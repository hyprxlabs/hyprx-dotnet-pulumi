// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SecurityHub.Inputs;

namespace Pulumi.AwsNative.SecurityHub;

public static partial class AutomationRuleRelatedFindingArgsExtensions
{
    public static global::Pulumi.AwsNative.SecurityHub.Inputs.AutomationRuleRelatedFindingArgs WithId(this global::Pulumi.AwsNative.SecurityHub.Inputs.AutomationRuleRelatedFindingArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SecurityHub.Inputs.AutomationRuleRelatedFindingArgs WithProductArn(this global::Pulumi.AwsNative.SecurityHub.Inputs.AutomationRuleRelatedFindingArgs @selfRef, global::System.String productArn)
    {
        @selfRef.ProductArn = productArn;
        return @selfRef;
    }

}
