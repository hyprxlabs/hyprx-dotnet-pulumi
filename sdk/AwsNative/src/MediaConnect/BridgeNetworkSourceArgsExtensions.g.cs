// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.MediaConnect.Inputs;

namespace Pulumi.AwsNative.MediaConnect;

public static partial class BridgeNetworkSourceArgsExtensions
{
    public static global::Pulumi.AwsNative.MediaConnect.Inputs.BridgeNetworkSourceArgs WithMulticastIp(this global::Pulumi.AwsNative.MediaConnect.Inputs.BridgeNetworkSourceArgs @selfRef, global::System.String multicastIp)
    {
        @selfRef.MulticastIp = multicastIp;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.BridgeNetworkSourceArgs WithMulticastSourceSettings(this global::Pulumi.AwsNative.MediaConnect.Inputs.BridgeNetworkSourceArgs @selfRef, global::Pulumi.AwsNative.MediaConnect.Inputs.BridgeMulticastSourceSettingsArgs multicastSourceSettings)
    {
        @selfRef.MulticastSourceSettings = multicastSourceSettings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.BridgeNetworkSourceArgs WithMulticastSourceSettings(this global::Pulumi.AwsNative.MediaConnect.Inputs.BridgeNetworkSourceArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.MediaConnect.Inputs.BridgeMulticastSourceSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.MediaConnect.Inputs.BridgeMulticastSourceSettingsArgs();
        @configure(@item);
        @selfRef.MulticastSourceSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.BridgeNetworkSourceArgs WithName(this global::Pulumi.AwsNative.MediaConnect.Inputs.BridgeNetworkSourceArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.BridgeNetworkSourceArgs WithNetworkName(this global::Pulumi.AwsNative.MediaConnect.Inputs.BridgeNetworkSourceArgs @selfRef, global::System.String networkName)
    {
        @selfRef.NetworkName = networkName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.BridgeNetworkSourceArgs WithPort(this global::Pulumi.AwsNative.MediaConnect.Inputs.BridgeNetworkSourceArgs @selfRef, global::System.Int32 port)
    {
        @selfRef.Port = port;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.BridgeNetworkSourceArgs WithProtocol(this global::Pulumi.AwsNative.MediaConnect.Inputs.BridgeNetworkSourceArgs @selfRef, global::Pulumi.AwsNative.MediaConnect.BridgeProtocolEnum protocol)
    {
        @selfRef.Protocol = protocol;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.BridgeNetworkSourceArgs WithProtocol(this global::Pulumi.AwsNative.MediaConnect.Inputs.BridgeNetworkSourceArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.MediaConnect.BridgeProtocolEnum> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.MediaConnect.BridgeProtocolEnum>();
        @configure(@item);
        @selfRef.Protocol = @item;
        return @selfRef;
    }

}
