// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Purview.Inputs;

namespace Pulumi.AzureNative.Purview;

public static partial class CredentialsArgsExtensions
{
    public static global::Pulumi.AzureNative.Purview.Inputs.CredentialsArgs WithIdentityId(this global::Pulumi.AzureNative.Purview.Inputs.CredentialsArgs @selfRef, global::System.String identityId)
    {
        @selfRef.IdentityId = identityId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Purview.Inputs.CredentialsArgs WithType(this global::Pulumi.AzureNative.Purview.Inputs.CredentialsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Purview.KafkaConfigurationIdentityType> type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
