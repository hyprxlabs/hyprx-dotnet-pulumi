// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class FirewallPolicySQLArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.FirewallPolicySQLArgs WithAllowSqlRedirect(this global::Pulumi.AzureNative.Network.Inputs.FirewallPolicySQLArgs @selfRef, bool allowSqlRedirect = true)
    {
        @selfRef.AllowSqlRedirect = allowSqlRedirect;
        return @selfRef;
    }

}
