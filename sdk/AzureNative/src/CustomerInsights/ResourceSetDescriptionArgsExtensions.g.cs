// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.CustomerInsights.Inputs;

namespace Pulumi.AzureNative.CustomerInsights;

public static partial class ResourceSetDescriptionArgsExtensions
{
    public static global::Pulumi.AzureNative.CustomerInsights.Inputs.ResourceSetDescriptionArgs WithElements(this global::Pulumi.AzureNative.CustomerInsights.Inputs.ResourceSetDescriptionArgs @selfRef, global::System.Collections.Generic.List<global::System.String> elements)
    {
        @selfRef.Elements = elements;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.Inputs.ResourceSetDescriptionArgs WithElements(this global::Pulumi.AzureNative.CustomerInsights.Inputs.ResourceSetDescriptionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Elements = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.Inputs.ResourceSetDescriptionArgs WithElements(this global::Pulumi.AzureNative.CustomerInsights.Inputs.ResourceSetDescriptionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Elements = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.Inputs.ResourceSetDescriptionArgs WithExceptions(this global::Pulumi.AzureNative.CustomerInsights.Inputs.ResourceSetDescriptionArgs @selfRef, global::System.Collections.Generic.List<global::System.String> exceptions)
    {
        @selfRef.Exceptions = exceptions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.Inputs.ResourceSetDescriptionArgs WithExceptions(this global::Pulumi.AzureNative.CustomerInsights.Inputs.ResourceSetDescriptionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Exceptions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.Inputs.ResourceSetDescriptionArgs WithExceptions(this global::Pulumi.AzureNative.CustomerInsights.Inputs.ResourceSetDescriptionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Exceptions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
