// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HealthcareApis.Inputs;

namespace Pulumi.AzureNative.HealthcareApis;

public static partial class SmartIdentityProviderApplicationArgsExtensions
{
    public static global::Pulumi.AzureNative.HealthcareApis.Inputs.SmartIdentityProviderApplicationArgs WithAllowedDataActions(this global::Pulumi.AzureNative.HealthcareApis.Inputs.SmartIdentityProviderApplicationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.HealthcareApis.SmartDataActions>> allowedDataActions)
    {
        @selfRef.AllowedDataActions = allowedDataActions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HealthcareApis.Inputs.SmartIdentityProviderApplicationArgs WithAllowedDataActions(this global::Pulumi.AzureNative.HealthcareApis.Inputs.SmartIdentityProviderApplicationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.HealthcareApis.SmartDataActions>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.HealthcareApis.SmartDataActions>>();
        @configure(@list);
        @selfRef.AllowedDataActions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HealthcareApis.Inputs.SmartIdentityProviderApplicationArgs WithAllowedDataActions(this global::Pulumi.AzureNative.HealthcareApis.Inputs.SmartIdentityProviderApplicationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.HealthcareApis.SmartDataActions>>> @create)
    {
        @selfRef.AllowedDataActions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HealthcareApis.Inputs.SmartIdentityProviderApplicationArgs WithAudience(this global::Pulumi.AzureNative.HealthcareApis.Inputs.SmartIdentityProviderApplicationArgs @selfRef, global::System.String audience)
    {
        @selfRef.Audience = audience;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HealthcareApis.Inputs.SmartIdentityProviderApplicationArgs WithClientId(this global::Pulumi.AzureNative.HealthcareApis.Inputs.SmartIdentityProviderApplicationArgs @selfRef, global::System.String clientId)
    {
        @selfRef.ClientId = clientId;
        return @selfRef;
    }

}
