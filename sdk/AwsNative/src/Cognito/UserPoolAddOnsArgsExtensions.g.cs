// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Cognito.Inputs;

namespace Pulumi.AwsNative.Cognito;

public static partial class UserPoolAddOnsArgsExtensions
{
    public static global::Pulumi.AwsNative.Cognito.Inputs.UserPoolAddOnsArgs WithAdvancedSecurityAdditionalFlows(this global::Pulumi.AwsNative.Cognito.Inputs.UserPoolAddOnsArgs @selfRef, global::Pulumi.AwsNative.Cognito.Inputs.UserPoolAdvancedSecurityAdditionalFlowsArgs advancedSecurityAdditionalFlows)
    {
        @selfRef.AdvancedSecurityAdditionalFlows = advancedSecurityAdditionalFlows;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Cognito.Inputs.UserPoolAddOnsArgs WithAdvancedSecurityAdditionalFlows(this global::Pulumi.AwsNative.Cognito.Inputs.UserPoolAddOnsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Cognito.Inputs.UserPoolAdvancedSecurityAdditionalFlowsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Cognito.Inputs.UserPoolAdvancedSecurityAdditionalFlowsArgs();
        @configure(@item);
        @selfRef.AdvancedSecurityAdditionalFlows = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Cognito.Inputs.UserPoolAddOnsArgs WithAdvancedSecurityMode(this global::Pulumi.AwsNative.Cognito.Inputs.UserPoolAddOnsArgs @selfRef, global::System.String advancedSecurityMode)
    {
        @selfRef.AdvancedSecurityMode = advancedSecurityMode;
        return @selfRef;
    }

}
