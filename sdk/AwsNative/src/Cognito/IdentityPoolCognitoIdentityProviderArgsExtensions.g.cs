// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Cognito.Inputs;

namespace Pulumi.AwsNative.Cognito;

public static partial class IdentityPoolCognitoIdentityProviderArgsExtensions
{
    public static global::Pulumi.AwsNative.Cognito.Inputs.IdentityPoolCognitoIdentityProviderArgs WithClientId(this global::Pulumi.AwsNative.Cognito.Inputs.IdentityPoolCognitoIdentityProviderArgs @selfRef, global::System.String clientId)
    {
        @selfRef.ClientId = clientId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Cognito.Inputs.IdentityPoolCognitoIdentityProviderArgs WithProviderName(this global::Pulumi.AwsNative.Cognito.Inputs.IdentityPoolCognitoIdentityProviderArgs @selfRef, global::System.String providerName)
    {
        @selfRef.ProviderName = providerName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Cognito.Inputs.IdentityPoolCognitoIdentityProviderArgs WithServerSideTokenCheck(this global::Pulumi.AwsNative.Cognito.Inputs.IdentityPoolCognitoIdentityProviderArgs @selfRef, bool serverSideTokenCheck = true)
    {
        @selfRef.ServerSideTokenCheck = serverSideTokenCheck;
        return @selfRef;
    }

}
