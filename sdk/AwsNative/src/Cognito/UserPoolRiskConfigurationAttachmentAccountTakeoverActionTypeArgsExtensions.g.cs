// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Cognito.Inputs;

namespace Pulumi.AwsNative.Cognito;

public static partial class UserPoolRiskConfigurationAttachmentAccountTakeoverActionTypeArgsExtensions
{
    public static global::Pulumi.AwsNative.Cognito.Inputs.UserPoolRiskConfigurationAttachmentAccountTakeoverActionTypeArgs WithEventAction(this global::Pulumi.AwsNative.Cognito.Inputs.UserPoolRiskConfigurationAttachmentAccountTakeoverActionTypeArgs @selfRef, global::System.String eventAction)
    {
        @selfRef.EventAction = eventAction;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Cognito.Inputs.UserPoolRiskConfigurationAttachmentAccountTakeoverActionTypeArgs WithNotify(this global::Pulumi.AwsNative.Cognito.Inputs.UserPoolRiskConfigurationAttachmentAccountTakeoverActionTypeArgs @selfRef, bool notify = true)
    {
        @selfRef.Notify = notify;
        return @selfRef;
    }

}
