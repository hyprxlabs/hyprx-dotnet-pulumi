// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AppSync.Inputs;

namespace Pulumi.AwsNative.AppSync;

public static partial class ApiCognitoConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.AppSync.Inputs.ApiCognitoConfigArgs WithAppIdClientRegex(this global::Pulumi.AwsNative.AppSync.Inputs.ApiCognitoConfigArgs @selfRef, global::System.String appIdClientRegex)
    {
        @selfRef.AppIdClientRegex = appIdClientRegex;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.Inputs.ApiCognitoConfigArgs WithAwsRegion(this global::Pulumi.AwsNative.AppSync.Inputs.ApiCognitoConfigArgs @selfRef, global::System.String awsRegion)
    {
        @selfRef.AwsRegion = awsRegion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.Inputs.ApiCognitoConfigArgs WithUserPoolId(this global::Pulumi.AwsNative.AppSync.Inputs.ApiCognitoConfigArgs @selfRef, global::System.String userPoolId)
    {
        @selfRef.UserPoolId = userPoolId;
        return @selfRef;
    }

}
