// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class ComputeArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs WithComputeName(this global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs @selfRef, global::System.String computeName)
    {
        @selfRef.ComputeName = computeName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs WithIdentity(this global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs @selfRef, global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedServiceIdentityArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs WithIdentity(this global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedServiceIdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedServiceIdentityArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs WithLocation(this global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs WithResourceGroupName(this global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs WithSku(this global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs @selfRef, global::Pulumi.AzureNative.MachineLearningServices.Inputs.SkuArgs sku)
    {
        @selfRef.Sku = sku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs WithSku(this global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.Inputs.SkuArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MachineLearningServices.Inputs.SkuArgs();
        @configure(@item);
        @selfRef.Sku = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs WithTags(this global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs WithTags(this global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs WithTags(this global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs WithWorkspaceName(this global::Pulumi.AzureNative.MachineLearningServices.ComputeArgs @selfRef, global::System.String workspaceName)
    {
        @selfRef.WorkspaceName = workspaceName;
        return @selfRef;
    }

}
