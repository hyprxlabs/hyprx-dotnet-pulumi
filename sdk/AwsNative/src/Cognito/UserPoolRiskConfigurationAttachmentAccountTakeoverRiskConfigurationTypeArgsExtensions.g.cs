// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Cognito.Inputs;

namespace Pulumi.AwsNative.Cognito;

public static partial class UserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeArgsExtensions
{
    public static global::Pulumi.AwsNative.Cognito.Inputs.UserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeArgs WithActions(this global::Pulumi.AwsNative.Cognito.Inputs.UserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeArgs @selfRef, global::Pulumi.AwsNative.Cognito.Inputs.UserPoolRiskConfigurationAttachmentAccountTakeoverActionsTypeArgs actions)
    {
        @selfRef.Actions = actions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Cognito.Inputs.UserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeArgs WithActions(this global::Pulumi.AwsNative.Cognito.Inputs.UserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Cognito.Inputs.UserPoolRiskConfigurationAttachmentAccountTakeoverActionsTypeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Cognito.Inputs.UserPoolRiskConfigurationAttachmentAccountTakeoverActionsTypeArgs();
        @configure(@item);
        @selfRef.Actions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Cognito.Inputs.UserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeArgs WithNotifyConfiguration(this global::Pulumi.AwsNative.Cognito.Inputs.UserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeArgs @selfRef, global::Pulumi.AwsNative.Cognito.Inputs.UserPoolRiskConfigurationAttachmentNotifyConfigurationTypeArgs notifyConfiguration)
    {
        @selfRef.NotifyConfiguration = notifyConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Cognito.Inputs.UserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeArgs WithNotifyConfiguration(this global::Pulumi.AwsNative.Cognito.Inputs.UserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Cognito.Inputs.UserPoolRiskConfigurationAttachmentNotifyConfigurationTypeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Cognito.Inputs.UserPoolRiskConfigurationAttachmentNotifyConfigurationTypeArgs();
        @configure(@item);
        @selfRef.NotifyConfiguration = @item;
        return @selfRef;
    }

}
