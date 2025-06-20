// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ApiManagement;

public static partial class DiagnosticExtensions
{

    extension(Diagnostic)
    {
        public static Diagnostic New(string @id, global::Pulumi.AzureNative.ApiManagement.DiagnosticArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Diagnostic(@id, @args, @options);
        }

        public static Diagnostic New(string @id, global::System.Action<global::Pulumi.AzureNative.ApiManagement.DiagnosticArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.ApiManagement.DiagnosticArgs @args = new();
            global::Pulumi.CustomResourceOptions? @options = null;
            if (@configureArgs is not null)
            {
                @configureArgs(@args);
            }

            if (@configureOptions is not null)
            {
                @options = new();
                @configureOptions(@options);
            }

            return new Diagnostic(@id, @args, @options);
        }

    }

}
