// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.CodePipeline.Inputs;

namespace Pulumi.AwsNative.CodePipeline;

public static partial class CustomActionTypeSettingsArgsExtensions
{
    public static global::Pulumi.AwsNative.CodePipeline.Inputs.CustomActionTypeSettingsArgs WithEntityUrlTemplate(this global::Pulumi.AwsNative.CodePipeline.Inputs.CustomActionTypeSettingsArgs @selfRef, global::System.String entityUrlTemplate)
    {
        @selfRef.EntityUrlTemplate = entityUrlTemplate;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodePipeline.Inputs.CustomActionTypeSettingsArgs WithExecutionUrlTemplate(this global::Pulumi.AwsNative.CodePipeline.Inputs.CustomActionTypeSettingsArgs @selfRef, global::System.String executionUrlTemplate)
    {
        @selfRef.ExecutionUrlTemplate = executionUrlTemplate;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodePipeline.Inputs.CustomActionTypeSettingsArgs WithRevisionUrlTemplate(this global::Pulumi.AwsNative.CodePipeline.Inputs.CustomActionTypeSettingsArgs @selfRef, global::System.String revisionUrlTemplate)
    {
        @selfRef.RevisionUrlTemplate = revisionUrlTemplate;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodePipeline.Inputs.CustomActionTypeSettingsArgs WithThirdPartyConfigurationUrl(this global::Pulumi.AwsNative.CodePipeline.Inputs.CustomActionTypeSettingsArgs @selfRef, global::System.String thirdPartyConfigurationUrl)
    {
        @selfRef.ThirdPartyConfigurationUrl = thirdPartyConfigurationUrl;
        return @selfRef;
    }

}
