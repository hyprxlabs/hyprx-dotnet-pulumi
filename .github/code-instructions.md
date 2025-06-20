# Code Instructions

## FluentBuilder

Fluent builder is located in the ./sdk/FluentBuilder/src directory relative
to the root project folder where the .git folder resides.

FluentBuilder must generate an internal attribute called FluentPulumiTypeAttribute
inside the project that includes the Hyprx.Pulumi.FluentBuilder project or package
reference.

The source code generator must take the type passed to the attribute, look at all the
public properties and generate fluent builder methods on the class that the attribute
is applied to.

```cs

public class StorageAccountArgs : PulumiResourceArgs
{
    /// <summary>
    /// Allow or disallow public access to all blobs or containers in the storage account. The default interpretation is false for this property.
    /// </summary>
    [Input("allowBlobPublicAccess")]
    public Input<bool>? AllowBlobPublicAccess { get; set; }

    /// <summary>
    /// User domain assigned to the storage account. Name is the CNAME source. Only one custom domain is supported per storage account at this time. To clear the existing custom domain, use an empty string for the custom domain name property.
    /// </summary>
    [Input("customDomain")]
    public Input<Inputs.CustomDomainArgs>? CustomDomain { get; set; }

    /// <summary>
    /// A boolean flag which indicates whether the default authentication is OAuth or not. The default interpretation is false for this property.
    /// </summary>
    [Input("defaultToOAuthAuthentication")]
    public Input<bool>? DefaultToOAuthAuthentication { get; set; }

    /// <summary>
    /// Allows you to specify the type of endpoint. Set this to AzureDNSZone to create a large number of accounts in a single subscription, which creates accounts in an Azure DNS Zone and the endpoint URL will have an alphanumeric DNS Zone identifier.
    /// </summary>
    [Input("dnsEndpointType")]
    public InputUnion<string, Pulumi.AzureNative.Storage.DnsEndpointType>? DnsEndpointType { get; set; }

    /// <summary>
    /// Gets or sets a list of key value pairs that describe the resource. These tags can be used for viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key with a length no greater than 128 characters and a value with a length no greater than 256 characters.
    /// </summary>
    public InputMap<string> Tags
    {
        get => _tags ?? (_tags = new InputMap<string>());
        set => _tags = value;
    }
}

[FluentPulumiType(typeof(StorageAccountArgs))]
public static partial class StorageAccountArgsExtensions
{
}

```

When generating extension methods, the methods should start with "With", followed by the property names.

When create the parameter for the "this Type arg" in the extension method, parameter name should be thisRef.

```cs

public static StorageAccountArgs WithAllowPublicAccess(this StorageAccountArgs thisRef, bool allow = true)
{
    thisRef.AllowPublicAccess = allow;
    return thisRef;
}

```

The source code generator must take any properties that are converted into argument names and ensure that
they do not conflict with the C# keywords.  If they are a c# keyword like namespace, event, object, etc, then
the argument name must prefix the variable with the '@' symbol. For example:

```cs
public static StorageAccountArgs WithUseEvent(this StorageAccountArgs thisRef, string @event)
{
    thisRef.Event = @event;
    return thisRef;
}

```

For properties that use `InputList<T>`, `InputMap<T>`, or `InputMap<T, V>`, the extension methods must
use there normal generic types and must have an overload that accepts a `Action<T>` such as `Action<List<string>>`

```cs
public static StorageAccountArgs WithList(this StorageAccountArgs thisRef, List<string> values)
{
    // thisRef.List is type of InputList<string>.
    thisRef.List = values;
    return thisRef;
}

public static StorageAccountArgs WithList(this StorageAccountArgs thisRef, Action<List<string>> configure)
{
    var instance = new List<string>();
    configure(instance);
    thisRef.List = instance;
    return thisRef;
}

public static StorageAccountArgs WithMap(this StorageAccountArgs thisRef, Dictionary<string, string> values)
{
    // thisRef.Map is type of InputMap<string>.
    thisRef.Map = values;
    return thisRef;
}

public static StorageAccountArgs WithMap(this StorageAccountArgs thisRef, Action<Dictionary<string, string>> configure)
{
    // thisRef.Map is type of InputMap<string>.
    var instance = new Dictionary<string, string>();
    configure(instance);
    thisRef.Map = instance
    return thisRef;
}


public static StorageAccountArgs WithMap(this StorageAccountArgs thisRef, Action<Dictionary<string, object>> configure)
{
    // thisRef.Map is type of InputMap<string, object>.
    var instance = new Dictionary<string, object>();
    configure(instance);
    thisRef.Map = instance
    return thisRef;
}

```

When a property is type of `Input<T>` it must handle multiple cases.

If the type is `Input<bool>` then it must generate a method where the method has a parameter with the default value
of true.

```cs
public static StorageAccountArgs WithAllowPublicAccess(this StorageAccountArgs thisRef, bool allow = true)
{
    thisRef.AllowPublicAccess = allow;
    return thisRef;
}
```

If the type parameter for `Input<T>` is a complex type (not a primitive like string, int, byte, etc), then it must have two overloads by
default.

If the complex type has 3 properties or less, then it should create a third overload where it takes each property type as an argument

```cs

public class ComplexType
{
    public string Name { get; set; }

    public int Age { get; set; }

    public long Weight { get; set;}
}

public static StorageAccountArgs WithAllowPublicAccess(this StorageAccountArgs thisRef, ComplexType complex)
{
    thisRef.Complex = complex;
    return thisRef;
}


public static StorageAccountArgs WithAllowPublicAccess(this StorageAccountArgs thisRef, Action<ComplexType> configure)
{
    var instance = new ComplextType();
    configure(instance)
    thisRef.Complex = instance;
    return thisRef;
}


public static StorageAccountArgs WithAllowPublicAccess(this StorageAccountArgs thisRef, string name, int age, long weight)
{
    thisRef.Complex = new()
    {
        Name = name,
        Age = age,
        Weight = weight,
    }

    return this;
}

```
