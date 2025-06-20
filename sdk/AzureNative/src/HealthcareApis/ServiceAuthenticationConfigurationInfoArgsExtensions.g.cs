// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HealthcareApis.Inputs;

namespace Pulumi.AzureNative.HealthcareApis;

public static partial class ServiceAuthenticationConfigurationInfoArgsExtensions
{
    public static global::Pulumi.AzureNative.HealthcareApis.Inputs.ServiceAuthenticationConfigurationInfoArgs WithAudience(this global::Pulumi.AzureNative.HealthcareApis.Inputs.ServiceAuthenticationConfigurationInfoArgs @selfRef, global::System.String audience)
    {
        @selfRef.Audience = audience;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HealthcareApis.Inputs.ServiceAuthenticationConfigurationInfoArgs WithAuthority(this global::Pulumi.AzureNative.HealthcareApis.Inputs.ServiceAuthenticationConfigurationInfoArgs @selfRef, global::System.String authority)
    {
        @selfRef.Authority = authority;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HealthcareApis.Inputs.ServiceAuthenticationConfigurationInfoArgs WithSmartProxyEnabled(this global::Pulumi.AzureNative.HealthcareApis.Inputs.ServiceAuthenticationConfigurationInfoArgs @selfRef, bool smartProxyEnabled = true)
    {
        @selfRef.SmartProxyEnabled = smartProxyEnabled;
        return @selfRef;
    }

}
