// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class VirtualNetworkGatewayArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithActiveActive(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, bool activeActive = true)
    {
        @selfRef.ActiveActive = activeActive;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithAdminState(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.AdminState> adminState)
    {
        @selfRef.AdminState = adminState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithAllowRemoteVnetTraffic(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, bool allowRemoteVnetTraffic = true)
    {
        @selfRef.AllowRemoteVnetTraffic = allowRemoteVnetTraffic;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithAllowVirtualWanTraffic(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, bool allowVirtualWanTraffic = true)
    {
        @selfRef.AllowVirtualWanTraffic = allowVirtualWanTraffic;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithAutoScaleConfiguration(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayAutoScaleConfigurationArgs autoScaleConfiguration)
    {
        @selfRef.AutoScaleConfiguration = autoScaleConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithAutoScaleConfiguration(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayAutoScaleConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayAutoScaleConfigurationArgs();
        @configure(@item);
        @selfRef.AutoScaleConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithBgpSettings(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.BgpSettingsArgs bgpSettings)
    {
        @selfRef.BgpSettings = bgpSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithBgpSettings(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.BgpSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.BgpSettingsArgs();
        @configure(@item);
        @selfRef.BgpSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithCustomRoutes(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.AddressSpaceArgs customRoutes)
    {
        @selfRef.CustomRoutes = customRoutes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithCustomRoutes(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.AddressSpaceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.AddressSpaceArgs();
        @configure(@item);
        @selfRef.CustomRoutes = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithDisableIPSecReplayProtection(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, bool disableIPSecReplayProtection = true)
    {
        @selfRef.DisableIPSecReplayProtection = disableIPSecReplayProtection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithEnableBgp(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, bool enableBgp = true)
    {
        @selfRef.EnableBgp = enableBgp;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithEnableBgpRouteTranslationForNat(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, bool enableBgpRouteTranslationForNat = true)
    {
        @selfRef.EnableBgpRouteTranslationForNat = enableBgpRouteTranslationForNat;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithEnableDnsForwarding(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, bool enableDnsForwarding = true)
    {
        @selfRef.EnableDnsForwarding = enableDnsForwarding;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithEnablePrivateIpAddress(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, bool enablePrivateIpAddress = true)
    {
        @selfRef.EnablePrivateIpAddress = enablePrivateIpAddress;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithExtendedLocation(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.ExtendedLocationArgs extendedLocation)
    {
        @selfRef.ExtendedLocation = extendedLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithExtendedLocation(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.ExtendedLocationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.ExtendedLocationArgs();
        @configure(@item);
        @selfRef.ExtendedLocation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithGatewayDefaultSite(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs gatewayDefaultSite)
    {
        @selfRef.GatewayDefaultSite = gatewayDefaultSite;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithGatewayDefaultSite(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.GatewayDefaultSite = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithGatewayType(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.VirtualNetworkGatewayType> gatewayType)
    {
        @selfRef.GatewayType = gatewayType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithId(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithIdentity(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.ManagedServiceIdentityArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithIdentity(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.ManagedServiceIdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.ManagedServiceIdentityArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithIpConfigurations(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayIPConfigurationArgs> ipConfigurations)
    {
        @selfRef.IpConfigurations = ipConfigurations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithIpConfigurations(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayIPConfigurationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayIPConfigurationArgs>();
        @configure(@list);
        @selfRef.IpConfigurations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithIpConfigurations(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayIPConfigurationArgs>> @create)
    {
        @selfRef.IpConfigurations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithLocation(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithNatRules(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayNatRuleArgs> natRules)
    {
        @selfRef.NatRules = natRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithNatRules(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayNatRuleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayNatRuleArgs>();
        @configure(@list);
        @selfRef.NatRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithNatRules(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayNatRuleArgs>> @create)
    {
        @selfRef.NatRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithResiliencyModel(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.ResiliencyModel> resiliencyModel)
    {
        @selfRef.ResiliencyModel = resiliencyModel;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithSku(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewaySkuArgs sku)
    {
        @selfRef.Sku = sku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithSku(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewaySkuArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewaySkuArgs();
        @configure(@item);
        @selfRef.Sku = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithTags(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithTags(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithTags(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithVNetExtendedLocationResourceId(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.String vNetExtendedLocationResourceId)
    {
        @selfRef.VNetExtendedLocationResourceId = vNetExtendedLocationResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithVirtualNetworkGatewayPolicyGroups(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupArgs> virtualNetworkGatewayPolicyGroups)
    {
        @selfRef.VirtualNetworkGatewayPolicyGroups = virtualNetworkGatewayPolicyGroups;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithVirtualNetworkGatewayPolicyGroups(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupArgs>();
        @configure(@list);
        @selfRef.VirtualNetworkGatewayPolicyGroups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithVirtualNetworkGatewayPolicyGroups(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupArgs>> @create)
    {
        @selfRef.VirtualNetworkGatewayPolicyGroups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithVpnClientConfiguration(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.VpnClientConfigurationArgs vpnClientConfiguration)
    {
        @selfRef.VpnClientConfiguration = vpnClientConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithVpnClientConfiguration(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.VpnClientConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.VpnClientConfigurationArgs();
        @configure(@item);
        @selfRef.VpnClientConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithVpnGatewayGeneration(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.VpnGatewayGeneration> vpnGatewayGeneration)
    {
        @selfRef.VpnGatewayGeneration = vpnGatewayGeneration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs WithVpnType(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.VpnType> vpnType)
    {
        @selfRef.VpnType = vpnType;
        return @selfRef;
    }

}
