// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Fis;

public static partial class TargetAccountConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Fis.TargetAccountConfigurationArgs WithAccountId(this global::Pulumi.AwsNative.Fis.TargetAccountConfigurationArgs @selfRef, global::System.String accountId)
    {
        @selfRef.AccountId = accountId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fis.TargetAccountConfigurationArgs WithDescription(this global::Pulumi.AwsNative.Fis.TargetAccountConfigurationArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fis.TargetAccountConfigurationArgs WithExperimentTemplateId(this global::Pulumi.AwsNative.Fis.TargetAccountConfigurationArgs @selfRef, global::System.String experimentTemplateId)
    {
        @selfRef.ExperimentTemplateId = experimentTemplateId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fis.TargetAccountConfigurationArgs WithRoleArn(this global::Pulumi.AwsNative.Fis.TargetAccountConfigurationArgs @selfRef, global::System.String roleArn)
    {
        @selfRef.RoleArn = roleArn;
        return @selfRef;
    }

}
