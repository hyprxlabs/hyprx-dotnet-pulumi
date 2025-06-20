// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Scheduler.Inputs;

namespace Pulumi.AzureNative.Scheduler;

public static partial class OAuthAuthenticationArgsExtensions
{
    public static global::Pulumi.AzureNative.Scheduler.Inputs.OAuthAuthenticationArgs WithAudience(this global::Pulumi.AzureNative.Scheduler.Inputs.OAuthAuthenticationArgs @selfRef, global::System.String audience)
    {
        @selfRef.Audience = audience;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Scheduler.Inputs.OAuthAuthenticationArgs WithClientId(this global::Pulumi.AzureNative.Scheduler.Inputs.OAuthAuthenticationArgs @selfRef, global::System.String clientId)
    {
        @selfRef.ClientId = clientId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Scheduler.Inputs.OAuthAuthenticationArgs WithSecret(this global::Pulumi.AzureNative.Scheduler.Inputs.OAuthAuthenticationArgs @selfRef, global::System.String secret)
    {
        @selfRef.Secret = secret;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Scheduler.Inputs.OAuthAuthenticationArgs WithTenant(this global::Pulumi.AzureNative.Scheduler.Inputs.OAuthAuthenticationArgs @selfRef, global::System.String tenant)
    {
        @selfRef.Tenant = tenant;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Scheduler.Inputs.OAuthAuthenticationArgs WithType(this global::Pulumi.AzureNative.Scheduler.Inputs.OAuthAuthenticationArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
