// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.CognitiveServices;

public static partial class CommitmentPlanAssociationArgsExtensions
{
    public static global::Pulumi.AzureNative.CognitiveServices.CommitmentPlanAssociationArgs WithAccountId(this global::Pulumi.AzureNative.CognitiveServices.CommitmentPlanAssociationArgs @selfRef, global::System.String accountId)
    {
        @selfRef.AccountId = accountId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CognitiveServices.CommitmentPlanAssociationArgs WithCommitmentPlanAssociationName(this global::Pulumi.AzureNative.CognitiveServices.CommitmentPlanAssociationArgs @selfRef, global::System.String commitmentPlanAssociationName)
    {
        @selfRef.CommitmentPlanAssociationName = commitmentPlanAssociationName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CognitiveServices.CommitmentPlanAssociationArgs WithCommitmentPlanName(this global::Pulumi.AzureNative.CognitiveServices.CommitmentPlanAssociationArgs @selfRef, global::System.String commitmentPlanName)
    {
        @selfRef.CommitmentPlanName = commitmentPlanName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CognitiveServices.CommitmentPlanAssociationArgs WithResourceGroupName(this global::Pulumi.AzureNative.CognitiveServices.CommitmentPlanAssociationArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CognitiveServices.CommitmentPlanAssociationArgs WithTags(this global::Pulumi.AzureNative.CognitiveServices.CommitmentPlanAssociationArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CognitiveServices.CommitmentPlanAssociationArgs WithTags(this global::Pulumi.AzureNative.CognitiveServices.CommitmentPlanAssociationArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CognitiveServices.CommitmentPlanAssociationArgs WithTags(this global::Pulumi.AzureNative.CognitiveServices.CommitmentPlanAssociationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
