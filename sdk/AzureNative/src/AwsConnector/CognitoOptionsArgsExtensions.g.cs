// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class CognitoOptionsArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.CognitoOptionsArgs WithEnabled(this global::Pulumi.AzureNative.AwsConnector.Inputs.CognitoOptionsArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.CognitoOptionsArgs WithIdentityPoolId(this global::Pulumi.AzureNative.AwsConnector.Inputs.CognitoOptionsArgs @selfRef, global::System.String identityPoolId)
    {
        @selfRef.IdentityPoolId = identityPoolId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.CognitoOptionsArgs WithRoleArn(this global::Pulumi.AzureNative.AwsConnector.Inputs.CognitoOptionsArgs @selfRef, global::System.String roleArn)
    {
        @selfRef.RoleArn = roleArn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.CognitoOptionsArgs WithUserPoolId(this global::Pulumi.AzureNative.AwsConnector.Inputs.CognitoOptionsArgs @selfRef, global::System.String userPoolId)
    {
        @selfRef.UserPoolId = userPoolId;
        return @selfRef;
    }

}
