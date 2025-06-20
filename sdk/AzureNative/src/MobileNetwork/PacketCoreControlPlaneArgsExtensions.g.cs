// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.MobileNetwork;

public static partial class PacketCoreControlPlaneArgsExtensions
{
    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithControlPlaneAccessInterface(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::Pulumi.AzureNative.MobileNetwork.Inputs.InterfacePropertiesArgs controlPlaneAccessInterface)
    {
        @selfRef.ControlPlaneAccessInterface = controlPlaneAccessInterface;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithControlPlaneAccessInterface(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MobileNetwork.Inputs.InterfacePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MobileNetwork.Inputs.InterfacePropertiesArgs();
        @configure(@item);
        @selfRef.ControlPlaneAccessInterface = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithControlPlaneAccessVirtualIpv4Addresses(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.Collections.Generic.List<global::System.String> controlPlaneAccessVirtualIpv4Addresses)
    {
        @selfRef.ControlPlaneAccessVirtualIpv4Addresses = controlPlaneAccessVirtualIpv4Addresses;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithControlPlaneAccessVirtualIpv4Addresses(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ControlPlaneAccessVirtualIpv4Addresses = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithControlPlaneAccessVirtualIpv4Addresses(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ControlPlaneAccessVirtualIpv4Addresses = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithCoreNetworkTechnology(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MobileNetwork.CoreNetworkType> coreNetworkTechnology)
    {
        @selfRef.CoreNetworkTechnology = coreNetworkTechnology;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithDiagnosticsUpload(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::Pulumi.AzureNative.MobileNetwork.Inputs.DiagnosticsUploadConfigurationArgs diagnosticsUpload)
    {
        @selfRef.DiagnosticsUpload = diagnosticsUpload;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithDiagnosticsUpload(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MobileNetwork.Inputs.DiagnosticsUploadConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MobileNetwork.Inputs.DiagnosticsUploadConfigurationArgs();
        @configure(@item);
        @selfRef.DiagnosticsUpload = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithEventHub(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::Pulumi.AzureNative.MobileNetwork.Inputs.EventHubConfigurationArgs eventHub)
    {
        @selfRef.EventHub = eventHub;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithEventHub(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MobileNetwork.Inputs.EventHubConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MobileNetwork.Inputs.EventHubConfigurationArgs();
        @configure(@item);
        @selfRef.EventHub = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithIdentity(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::Pulumi.AzureNative.MobileNetwork.Inputs.ManagedServiceIdentityArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithIdentity(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MobileNetwork.Inputs.ManagedServiceIdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MobileNetwork.Inputs.ManagedServiceIdentityArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithInstallation(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::Pulumi.AzureNative.MobileNetwork.Inputs.InstallationArgs installation)
    {
        @selfRef.Installation = installation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithInstallation(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MobileNetwork.Inputs.InstallationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MobileNetwork.Inputs.InstallationArgs();
        @configure(@item);
        @selfRef.Installation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithInteropSettings(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.Object interopSettings)
    {
        @selfRef.InteropSettings = interopSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithInteropSettings(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.InteropSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithLocalDiagnosticsAccess(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::Pulumi.AzureNative.MobileNetwork.Inputs.LocalDiagnosticsAccessConfigurationArgs localDiagnosticsAccess)
    {
        @selfRef.LocalDiagnosticsAccess = localDiagnosticsAccess;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithLocalDiagnosticsAccess(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MobileNetwork.Inputs.LocalDiagnosticsAccessConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MobileNetwork.Inputs.LocalDiagnosticsAccessConfigurationArgs();
        @configure(@item);
        @selfRef.LocalDiagnosticsAccess = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithLocation(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithPacketCoreControlPlaneName(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.String packetCoreControlPlaneName)
    {
        @selfRef.PacketCoreControlPlaneName = packetCoreControlPlaneName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithPlatform(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::Pulumi.AzureNative.MobileNetwork.Inputs.PlatformConfigurationArgs platform)
    {
        @selfRef.Platform = platform;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithPlatform(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MobileNetwork.Inputs.PlatformConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MobileNetwork.Inputs.PlatformConfigurationArgs();
        @configure(@item);
        @selfRef.Platform = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithResourceGroupName(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithSignaling(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::Pulumi.AzureNative.MobileNetwork.Inputs.SignalingConfigurationArgs signaling)
    {
        @selfRef.Signaling = signaling;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithSignaling(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MobileNetwork.Inputs.SignalingConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MobileNetwork.Inputs.SignalingConfigurationArgs();
        @configure(@item);
        @selfRef.Signaling = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithSites(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.MobileNetwork.Inputs.SiteResourceIdArgs> sites)
    {
        @selfRef.Sites = sites;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithSites(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.MobileNetwork.Inputs.SiteResourceIdArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.MobileNetwork.Inputs.SiteResourceIdArgs>();
        @configure(@list);
        @selfRef.Sites = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithSites(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.MobileNetwork.Inputs.SiteResourceIdArgs>> @create)
    {
        @selfRef.Sites = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithSku(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MobileNetwork.BillingSku> sku)
    {
        @selfRef.Sku = sku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithTags(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithTags(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithTags(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithUeMtu(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.Int32 ueMtu)
    {
        @selfRef.UeMtu = ueMtu;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithUserConsent(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::Pulumi.AzureNative.MobileNetwork.Inputs.UserConsentConfigurationArgs userConsent)
    {
        @selfRef.UserConsent = userConsent;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithUserConsent(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MobileNetwork.Inputs.UserConsentConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MobileNetwork.Inputs.UserConsentConfigurationArgs();
        @configure(@item);
        @selfRef.UserConsent = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs WithVersion(this global::Pulumi.AzureNative.MobileNetwork.PacketCoreControlPlaneArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
