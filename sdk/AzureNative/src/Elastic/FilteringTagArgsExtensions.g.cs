// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Elastic.Inputs;

namespace Pulumi.AzureNative.Elastic;

public static partial class FilteringTagArgsExtensions
{
    public static global::Pulumi.AzureNative.Elastic.Inputs.FilteringTagArgs WithAction(this global::Pulumi.AzureNative.Elastic.Inputs.FilteringTagArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Elastic.TagAction> action)
    {
        @selfRef.Action = action;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Elastic.Inputs.FilteringTagArgs WithName(this global::Pulumi.AzureNative.Elastic.Inputs.FilteringTagArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Elastic.Inputs.FilteringTagArgs WithValue(this global::Pulumi.AzureNative.Elastic.Inputs.FilteringTagArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
