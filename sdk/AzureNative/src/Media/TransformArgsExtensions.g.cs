// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Media;

public static partial class TransformArgsExtensions
{
    public static global::Pulumi.AzureNative.Media.TransformArgs WithAccountName(this global::Pulumi.AzureNative.Media.TransformArgs @selfRef, global::System.String accountName)
    {
        @selfRef.AccountName = accountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.TransformArgs WithDescription(this global::Pulumi.AzureNative.Media.TransformArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.TransformArgs WithOutputs(this global::Pulumi.AzureNative.Media.TransformArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Media.Inputs.TransformOutputArgs> outputs)
    {
        @selfRef.Outputs = outputs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.TransformArgs WithOutputs(this global::Pulumi.AzureNative.Media.TransformArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Media.Inputs.TransformOutputArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Media.Inputs.TransformOutputArgs>();
        @configure(@list);
        @selfRef.Outputs = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.TransformArgs WithOutputs(this global::Pulumi.AzureNative.Media.TransformArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Media.Inputs.TransformOutputArgs>> @create)
    {
        @selfRef.Outputs = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.TransformArgs WithResourceGroupName(this global::Pulumi.AzureNative.Media.TransformArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.TransformArgs WithTransformName(this global::Pulumi.AzureNative.Media.TransformArgs @selfRef, global::System.String transformName)
    {
        @selfRef.TransformName = transformName;
        return @selfRef;
    }

}
