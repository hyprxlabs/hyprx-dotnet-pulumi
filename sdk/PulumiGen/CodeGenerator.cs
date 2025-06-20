using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace PulumiGen;

public class CodeGenerator
{
    private static readonly string[] CSharpKeywords =
    {
        "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked",
        "class", "const", "continue", "decimal", "default", "delegate", "do", "double", "else",
        "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float", "for",
        "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock",
        "long", "namespace", "new", "null", "object", "operator", "out", "override", "params",
        "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short",
        "sizeof", "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true",
        "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "virtual",
        "void", "volatile", "while", "global",
    };

    private static readonly HashSet<Type> PrimitiveTypes = new()
    {
        typeof(bool), typeof(byte), typeof(sbyte), typeof(char), typeof(decimal), typeof(double),
        typeof(float), typeof(int), typeof(uint), typeof(long), typeof(ulong), typeof(short),
        typeof(ushort), typeof(string), typeof(DateTime), typeof(DateTimeOffset), typeof(TimeSpan),
        typeof(Guid),
    };

    public async Task GenerateAsync(string shortName)
    {
        var projectRoot = Utils.GetProjectRoot();
        var map = new Dictionary<string, string>
        {
            { "Acme", "Pulumiverse.Acme" },
            { "AzureNative", "Pulumi.AzureNative" },
            { "AzureAd", "Pulumi.AzureAd" },
            { "AzureDevOps", "Pulumi.AzureDevOps" },
            { "Cloudflare", "Pulumi.Cloudflare" },
            { "Command", "Pulumi.Command" },
            { "DigitalOcean", "Pulumi.DigitalOcean" },
            { "Docker", "Pulumi.Docker" },
            { "Github", "Pulumi.Github" },
            { "Libvirt", "Pulumi.Libvirt" },
            { "ProxmoxVE", "Pulumi.ProxmoxVE" },
            { "Random", "Pulumi.Random" },
            { "Slack", "Pulumi.Slack" },
            { "TlsSelfSignedCert", "Pulumi.TlsSelfSignedCert" },
            { "Unfi", "Pulumiverse.Unfi" },
            { "Vault", "Pulumi.Vault" },
        };

        var assemblyName = $"Pulumi.{shortName}";

        if (map.TryGetValue(shortName, out var providerName))
        {
            assemblyName = providerName;
        }

        var targetProjectPath = Path.Combine(projectRoot, "sdk", shortName, "src");

        if (!Directory.Exists(targetProjectPath))
        {
            throw new DirectoryNotFoundException($"Target project directory not found: {targetProjectPath}");
        }

        // Load the Pulumi assembly
        var assembly = this.LoadPulumiAssembly(assemblyName);

        // Generate extension classes for CustomResource types
        await this.GenerateCustomResourceExtensions(assembly, targetProjectPath);

        // Generate extension classes for ResourceArgs types
        await this.GenerateResourceArgsExtensions(assembly, targetProjectPath);
    }

    private Assembly LoadPulumiAssembly(string assemblyName)
    {
        try
        {
            // First try to load from current directory
            var localPath = $"{assemblyName}.dll";
            if (File.Exists(localPath))
            {
                return Assembly.LoadFrom(localPath);
            }

            // Try to find in NuGet packages
            var nugetPackagesPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".nuget", "packages");
            var packageName = assemblyName.ToLowerInvariant();
            var packageDir = Path.Combine(nugetPackagesPath, packageName);

            if (Directory.Exists(packageDir))
            {
                // Get the latest version directory
                var versionDirs = Directory.GetDirectories(packageDir)
                    .Select(d => new DirectoryInfo(d))
                    .OrderByDescending(d => d.Name)
                    .ToList();

                foreach (var versionDir in versionDirs)
                {
                    // Look for the assembly in lib/net6.0 or lib/netstandard2.0
                    var possiblePaths = new[]
                    {
                        Path.Combine(versionDir.FullName, "lib", "net6.0", $"{assemblyName}.dll"),
                        Path.Combine(versionDir.FullName, "lib", "netstandard2.0", $"{assemblyName}.dll"),
                        Path.Combine(versionDir.FullName, "lib", "net5.0", $"{assemblyName}.dll"),
                        Path.Combine(versionDir.FullName, "lib", "netcoreapp3.1", $"{assemblyName}.dll"),
                    };

                    foreach (var path in possiblePaths)
                    {
                        if (File.Exists(path))
                        {
                            global::System.Console.WriteLine($"Loading assembly from: {path}");
                            return Assembly.LoadFrom(path);
                        }
                    }
                }
            }

            // Fall back to LoadWithPartialName which searches the GAC and other locations
            return Assembly.Load(assemblyName);
        }
        catch (Exception ex)
        {
            throw new FileNotFoundException($"Could not load assembly '{assemblyName}'. Make sure the Pulumi package is installed. Details: {ex.Message}", ex);
        }
    }

    private async Task GenerateCustomResourceExtensions(Assembly assembly, string targetProjectPath)
    {
        var customResourceType = typeof(global::Pulumi.CustomResource);
        var types = assembly.GetTypes()
            .Where(t => t.IsPublic && !t.IsAbstract && !t.IsStatic() &&
                       customResourceType.IsAssignableFrom(t))
            .ToList();

        foreach (var type in types)
        {
            await this.GenerateCustomResourceExtensionClass(type, targetProjectPath);
        }
    }

    private async Task GenerateResourceArgsExtensions(Assembly assembly, string targetProjectPath)
    {
        var resourceArgsType = typeof(global::Pulumi.ResourceArgs);
        var types = assembly.GetTypes()
            .Where(t => t.IsPublic && !t.IsAbstract && !t.IsStatic() &&
                       resourceArgsType.IsAssignableFrom(t))
            .ToList();

        foreach (var type in types)
        {
            await this.GenerateResourceArgsExtensionClass(type, targetProjectPath);
        }
    }

    private Task GenerateCustomResourceExtensionClass(Type type, string targetProjectPath)
    {
        var className = $"{type.Name}Extensions";
        var namespaceName = type.Namespace ?? string.Empty;
        var subFolder = this.GetSubFolderFromNamespace(namespaceName);
        var outputDir = Path.Combine(targetProjectPath, subFolder);
        var outputFile = Path.Combine(outputDir, $"{className}.g.cs");

        Directory.CreateDirectory(outputDir);

        var code = this.GenerateCustomResourceExtensionCode(type, namespaceName, className);
        return File.WriteAllTextAsync(outputFile, code);
    }

    private Task GenerateResourceArgsExtensionClass(Type type, string targetProjectPath)
    {
        var className = $"{type.Name}Extensions";
        var namespaceName = this.GetArgsNamespace(type);
        var subFolder = this.GetSubFolderFromNamespace(namespaceName);
        var outputDir = Path.Combine(targetProjectPath, subFolder);
        var outputFile = Path.Combine(outputDir, $"{className}.g.cs");

        Directory.CreateDirectory(outputDir);

        var code = this.GenerateResourceArgsExtensionCode(type, namespaceName, className);
        return File.WriteAllTextAsync(outputFile, code);
    }

    private string GenerateCustomResourceExtensionCode(Type type, string namespaceName, string className)
    {
        var sb = new StringBuilder();
        sb.AppendLine("// <auto-generated/>");
        sb.AppendLine("// Do not edit any code this file. Create or edit the partial class instead in a different file.");
        sb.AppendLine();
        sb.AppendLine("#nullable enable");
        sb.AppendLine();
        if (!namespaceName.StartsWith("Pulumi."))
        {
            sb.AppendLine($"using Pulumi;");
            sb.AppendLine();
        }

        if (type.Namespace != namespaceName)
        {
            sb.AppendLine($"using {type.Namespace};");
            sb.AppendLine();
        }

        sb.AppendLine($"namespace {namespaceName};");
        sb.AppendLine();
        sb.AppendLine($"public static partial class {className}");
        sb.AppendLine("{");
        sb.AppendLine();

        // Generate extension members
        sb.AppendLine($"    extension({type.Name})");
        sb.AppendLine("    {");

        // Generate New methods
        var constructors = type.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
        var primaryConstructor = constructors.FirstOrDefault(c => c.GetParameters().Length >= 2);

        if (primaryConstructor != null)
        {
            var parameters = primaryConstructor.GetParameters();
            var idParam = parameters.FirstOrDefault(p => p.ParameterType == typeof(string));
            var argsParam = parameters.FirstOrDefault(p => p.ParameterType.Name.EndsWith("Args"));
            var optionsParam = parameters.FirstOrDefault(p => p.ParameterType == typeof(global::Pulumi.CustomResourceOptions));

            // Must have at least an id parameter
            if (idParam != null)
            {
                var argsTypeName = argsParam != null ? this.GetFullTypeName(argsParam.ParameterType) : null;
                var optionsTypeName = this.GetFullTypeName(typeof(global::Pulumi.CustomResourceOptions));

                if (argsParam != null)
                {
                    // Case: Resource with Args parameter
                    // Args are always required (non-nullable), options are optional
                    var optionsIsOptional = optionsParam?.HasDefaultValue ?? true || this.IsNullableType(optionsParam?.ParameterType);
                    var optionsNullability = optionsIsOptional ? "?" : string.Empty;
                    var optionsDefault = optionsIsOptional ? " = null" : string.Empty;

                    // First overload - args is required, options is optional
                    sb.AppendLine($"        public static {type.Name} New(string @id, {argsTypeName} @args, {optionsTypeName}{optionsNullability} @options{optionsDefault})");
                    sb.AppendLine("        {");
                    sb.AppendLine($"            return new {type.Name}(@id, @args, @options);");
                    sb.AppendLine("        }");
                    sb.AppendLine();

                    // Second overload with Action configurators - configureArgs is optional but args is always created
                    sb.AppendLine($"        public static {type.Name} New(string @id, global::System.Action<{argsTypeName}>? @configureArgs = null, global::System.Action<{optionsTypeName}>? @configureOptions = null)");
                    sb.AppendLine("        {");
                    sb.AppendLine($"            {argsTypeName} @args = new();");
                    sb.AppendLine($"            {optionsTypeName}? @options = null;");
                    sb.AppendLine("            if (@configureArgs is not null)");
                    sb.AppendLine("            {");
                    sb.AppendLine("                @configureArgs(@args);");
                    sb.AppendLine("            }");
                    sb.AppendLine();
                    sb.AppendLine("            if (@configureOptions is not null)");
                    sb.AppendLine("            {");
                    sb.AppendLine("                @options = new();");
                    sb.AppendLine("                @configureOptions(@options);");
                    sb.AppendLine("            }");
                    sb.AppendLine();
                    sb.AppendLine($"            return new {type.Name}(@id, @args, @options);");
                    sb.AppendLine("        }");
                    sb.AppendLine();
                }
                else
                {
                    // Case: Resource without Args parameter (just id and options)
                    var optionsIsOptional = optionsParam?.HasDefaultValue ?? true || this.IsNullableType(optionsParam?.ParameterType);
                    var optionsNullability = optionsIsOptional ? "?" : string.Empty;
                    var optionsDefault = optionsIsOptional ? " = null" : string.Empty;

                    sb.AppendLine($"        public static {type.Name} New(string @id, {optionsTypeName}{optionsNullability} @options{optionsDefault})");
                    sb.AppendLine("        {");
                    if (optionsParam != null)
                    {
                        sb.AppendLine($"            return new {type.Name}(@id, @options);");
                    }
                    else
                    {
                        sb.AppendLine($"            return new {type.Name}(@id);");
                    }

                    sb.AppendLine("        }");
                    sb.AppendLine();

                    // Only add Action<CustomResourceOptions> overload if options exist
                    if (optionsParam != null)
                    {
                        sb.AppendLine($"        public static {type.Name} New(string @id, global::System.Action<{optionsTypeName}>? @configureOptions = null)");
                        sb.AppendLine("        {");
                        sb.AppendLine($"            {optionsTypeName}? @options = null;");
                        sb.AppendLine("            if (@configureOptions is not null)");
                        sb.AppendLine("            {");
                        sb.AppendLine("                @options = new();");
                        sb.AppendLine("                @configureOptions(@options);");
                        sb.AppendLine("            }");
                        sb.AppendLine();
                        sb.AppendLine($"            return new {type.Name}(@id, @options);");
                        sb.AppendLine("        }");
                    }
                }
            }
        }

        sb.AppendLine("    }");
        sb.AppendLine();
        sb.AppendLine("}");

        return sb.ToString();
    }

    private string GenerateResourceArgsExtensionCode(Type type, string namespaceName, string className)
    {
        var sb = new StringBuilder();
        sb.AppendLine("// <auto-generated/>");
        sb.AppendLine("// Do not edit any code this file. Create or edit the partial class instead in a different file.");
        sb.AppendLine();
        sb.AppendLine("#nullable enable");
        sb.AppendLine();
        if (!namespaceName.StartsWith("Pulumi."))
        {
            sb.AppendLine($"using Pulumi;");
            sb.AppendLine();
        }
        if (type.Namespace != namespaceName)
        {
            sb.AppendLine($"using {type.Namespace};");
            sb.AppendLine();
        }

        sb.AppendLine($"namespace {namespaceName};");
        sb.AppendLine();
        sb.AppendLine($"public static partial class {className}");
        sb.AppendLine("{");

        // Generate fluent methods for public properties
        var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(p => p.CanWrite && !p.GetMethod?.IsStatic == true)
            .ToList();

        foreach (var property in properties)
        {
            this.GeneratePropertyExtensions(sb, type, property);
        }

        sb.AppendLine("}");

        return sb.ToString();
    }

    private void GeneratePropertyExtensions(StringBuilder sb, Type ownerType, PropertyInfo property)
    {
        var propertyName = this.EscapeKeyword(this.ToCamelCase(property.Name));
        var methodName = $"With{property.Name}";
        var ownerTypeName = $"global::{ownerType.FullName}";
        var propertyType = property.PropertyType;

        // Handle InputUnion<T1, T2>
        if (this.IsInputUnionType(propertyType))
        {
            var unionTypes = propertyType.GetGenericArguments();
            var unionTypeName = $"global::Pulumi.Union<{string.Join(", ", unionTypes.Select(this.GetFullTypeName))}>";

            sb.AppendLine($"    public static {ownerTypeName} {methodName}(this {ownerTypeName} @selfRef, {unionTypeName} {propertyName})");
            sb.AppendLine("    {");
            sb.AppendLine($"        @selfRef.{property.Name} = {propertyName};");
            sb.AppendLine("        return @selfRef;");
            sb.AppendLine("    }");
            sb.AppendLine();
        }

        // Handle InputList<T>
        else if (this.IsInputListType(propertyType))
        {
            var elementType = propertyType.GetGenericArguments()[0];
            var listTypeName = $"global::System.Collections.Generic.List<{this.GetFullTypeName(elementType)}>";
            var iListTypeName = $"global::System.Collections.Generic.IEnumerable<{this.GetFullTypeName(elementType)}>";

            // List<T> overload
            sb.AppendLine($"    public static {ownerTypeName} {methodName}(this {ownerTypeName} @selfRef, {listTypeName} {propertyName})");
            sb.AppendLine("    {");
            sb.AppendLine($"        @selfRef.{property.Name} = {propertyName};");
            sb.AppendLine("        return @selfRef;");
            sb.AppendLine("    }");
            sb.AppendLine();

            // Action<List<T>> overload
            sb.AppendLine($"    public static {ownerTypeName} {methodName}(this {ownerTypeName} @selfRef, global::System.Action<{listTypeName}> @configure)");
            sb.AppendLine("    {");
            sb.AppendLine($"        var @list = new {listTypeName}();");
            sb.AppendLine("        @configure(@list);");
            sb.AppendLine($"        @selfRef.{property.Name} = @list;");
            sb.AppendLine("        return @selfRef;");
            sb.AppendLine("    }");
            sb.AppendLine();

            // Func<IList<T>> overload
            sb.AppendLine($"    public static {ownerTypeName} {methodName}(this {ownerTypeName} @selfRef, global::System.Func<{iListTypeName}> @create)");
            sb.AppendLine("    {");
            sb.AppendLine($"        @selfRef.{property.Name} = global::Pulumi.Output.Create(@create());");
            sb.AppendLine("        return @selfRef;");
            sb.AppendLine("    }");
            sb.AppendLine();
        }

        // Handle InputMap<T>
        else if (this.IsInputMapType(propertyType))
        {
            var valueType = propertyType.GetGenericArguments()[0];
            var dictTypeName = $"global::System.Collections.Generic.Dictionary<string, {this.GetFullTypeName(valueType)}>";
            var iDictTypeName = $"global::System.Collections.Generic.IDictionary<string, {this.GetFullTypeName(valueType)}>";

            // Dictionary<string, T> overload
            sb.AppendLine($"    public static {ownerTypeName} {methodName}(this {ownerTypeName} @selfRef, {dictTypeName} {propertyName})");
            sb.AppendLine("    {");
            sb.AppendLine($"        @selfRef.{property.Name} = {propertyName};");
            sb.AppendLine("        return @selfRef;");
            sb.AppendLine("    }");
            sb.AppendLine();

            // Action<Dictionary<string, T>> overload
            sb.AppendLine($"    public static {ownerTypeName} {methodName}(this {ownerTypeName} @selfRef, global::System.Action<{dictTypeName}> @configure)");
            sb.AppendLine("    {");
            sb.AppendLine($"        var @dict = new {dictTypeName}();");
            sb.AppendLine("        @configure(@dict);");
            sb.AppendLine($"        @selfRef.{property.Name} = @dict;");
            sb.AppendLine("        return @selfRef;");
            sb.AppendLine("    }");
            sb.AppendLine();

            // Func<IDictionary<string, T>> overload
            sb.AppendLine($"    public static {ownerTypeName} {methodName}(this {ownerTypeName} @selfRef, global::System.Func<{iDictTypeName}> @create)");
            sb.AppendLine("    {");
            sb.AppendLine($"        @selfRef.{property.Name} = global::Pulumi.Output.Create(@create());");
            sb.AppendLine("        return @selfRef;");
            sb.AppendLine("    }");
            sb.AppendLine();
        }

        // Handle Input<T>
        else if (this.IsInputType(propertyType))
        {
            var innerType = propertyType.GetGenericArguments()[0];

            if (this.IsPrimitiveType(innerType))
            {
                // For boolean, add default value of true
                if (innerType == typeof(bool))
                {
                    sb.AppendLine($"    public static {ownerTypeName} {methodName}(this {ownerTypeName} @selfRef, bool {propertyName} = true)");
                }
                else
                {
                    sb.AppendLine($"    public static {ownerTypeName} {methodName}(this {ownerTypeName} @selfRef, {this.GetFullTypeName(innerType)} {propertyName})");
                }

                sb.AppendLine("    {");
                sb.AppendLine($"        @selfRef.{property.Name} = {propertyName};");
                sb.AppendLine("        return @selfRef;");
                sb.AppendLine("    }");
                sb.AppendLine();
            }
            else
            {
                // Complex type - generate T overload
                sb.AppendLine($"    public static {ownerTypeName} {methodName}(this {ownerTypeName} @selfRef, {this.GetFullTypeName(innerType)} {propertyName})");
                sb.AppendLine("    {");
                sb.AppendLine($"        @selfRef.{property.Name} = {propertyName};");
                sb.AppendLine("        return @selfRef;");
                sb.AppendLine("    }");
                sb.AppendLine();

                // Action<T> overload
                sb.AppendLine($"    public static {ownerTypeName} {methodName}(this {ownerTypeName} @selfRef, global::System.Action<{this.GetFullTypeName(innerType)}> @configure)");
                sb.AppendLine("    {");
                if (this.CanCreateWithDefaultConstructor(innerType))
                {
                    sb.AppendLine($"        var @item = new {this.GetFullTypeName(innerType)}();");
                }
                else
                {
                    sb.AppendLine($"        var @item = global::System.Activator.CreateInstance<{this.GetFullTypeName(innerType)}>();");
                }

                sb.AppendLine("        @configure(@item);");
                sb.AppendLine($"        @selfRef.{property.Name} = @item;");
                sb.AppendLine("        return @selfRef;");
                sb.AppendLine("    }");
                sb.AppendLine();
            }
        }
    }

    private string GetSubFolderFromNamespace(string namespaceName)
    {
        var parts = namespaceName.Split('.');
        if (parts.Length > 2)
        {
            return string.Join(Path.DirectorySeparatorChar.ToString(), parts.Skip(2));
        }

        return string.Empty;
    }

    private string GetArgsNamespace(Type type)
    {
        var namespaceName = type.Namespace ?? string.Empty;
        if (namespaceName.Contains(".Inputs"))
        {
            return namespaceName.Replace(".Inputs", string.Empty);
        }

        return namespaceName;
    }

    private string GetFullTypeName(Type type)
    {
        if (type.IsGenericType)
        {
            var name = type.Name.Substring(0, type.Name.IndexOf('`'));
            var args = string.Join(", ", type.GetGenericArguments().Select(this.GetFullTypeName));
            return $"global::{type.Namespace}.{name}<{args}>";
        }

        return $"global::{type.FullName}";
    }

    private bool IsInputUnionType(Type type)
    {
        return type.IsGenericType && type.Name.StartsWith("InputUnion");
    }

    private bool IsInputListType(Type type)
    {
        return type.IsGenericType && type.Name.StartsWith("InputList");
    }

    private bool IsInputMapType(Type type)
    {
        return type.IsGenericType && type.Name.StartsWith("InputMap");
    }

    private bool IsInputType(Type type)
    {
        return type.IsGenericType && type.Name.StartsWith("Input") &&
               !this.IsInputUnionType(type) && !this.IsInputListType(type) && !this.IsInputMapType(type);
    }

    private bool IsPrimitiveType(Type type)
    {
        return type.IsPrimitive || PrimitiveTypes.Contains(type) || type.IsEnum ||
               (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>) &&
                this.IsPrimitiveType(type.GetGenericArguments()[0]));
    }

    private bool CanCreateWithDefaultConstructor(Type type)
    {
        return !type.IsAbstract && !type.IsInterface &&
               type.GetConstructor(Type.EmptyTypes) != null;
    }

    private bool IsNullableType(Type? type)
    {
        if (type == null)
        {
            return true;
        }

        return !type.IsValueType || (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>));
    }

    private string EscapeKeyword(string identifier)
    {
        return CSharpKeywords.Contains(identifier) ? $"@{identifier}" : identifier;
    }

    private string ToCamelCase(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        return char.ToLowerInvariant(input[0]) + input.Substring(1);
    }
}

public static class TypeExtensions
{
    public static bool IsStatic(this Type type)
    {
        return type.IsAbstract && type.IsSealed;
    }
}