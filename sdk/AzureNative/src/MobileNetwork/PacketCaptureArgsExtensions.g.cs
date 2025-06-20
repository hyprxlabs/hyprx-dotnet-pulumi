// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.MobileNetwork;

public static partial class PacketCaptureArgsExtensions
{
    public static global::Pulumi.AzureNative.MobileNetwork.PacketCaptureArgs WithBytesToCapturePerPacket(this global::Pulumi.AzureNative.MobileNetwork.PacketCaptureArgs @selfRef, global::System.Double bytesToCapturePerPacket)
    {
        @selfRef.BytesToCapturePerPacket = bytesToCapturePerPacket;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCaptureArgs WithNetworkInterfaces(this global::Pulumi.AzureNative.MobileNetwork.PacketCaptureArgs @selfRef, global::System.Collections.Generic.List<global::System.String> networkInterfaces)
    {
        @selfRef.NetworkInterfaces = networkInterfaces;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCaptureArgs WithNetworkInterfaces(this global::Pulumi.AzureNative.MobileNetwork.PacketCaptureArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.NetworkInterfaces = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCaptureArgs WithNetworkInterfaces(this global::Pulumi.AzureNative.MobileNetwork.PacketCaptureArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.NetworkInterfaces = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCaptureArgs WithPacketCaptureName(this global::Pulumi.AzureNative.MobileNetwork.PacketCaptureArgs @selfRef, global::System.String packetCaptureName)
    {
        @selfRef.PacketCaptureName = packetCaptureName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCaptureArgs WithPacketCoreControlPlaneName(this global::Pulumi.AzureNative.MobileNetwork.PacketCaptureArgs @selfRef, global::System.String packetCoreControlPlaneName)
    {
        @selfRef.PacketCoreControlPlaneName = packetCoreControlPlaneName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCaptureArgs WithResourceGroupName(this global::Pulumi.AzureNative.MobileNetwork.PacketCaptureArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCaptureArgs WithTimeLimitInSeconds(this global::Pulumi.AzureNative.MobileNetwork.PacketCaptureArgs @selfRef, global::System.Int32 timeLimitInSeconds)
    {
        @selfRef.TimeLimitInSeconds = timeLimitInSeconds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.PacketCaptureArgs WithTotalBytesPerSession(this global::Pulumi.AzureNative.MobileNetwork.PacketCaptureArgs @selfRef, global::System.Double totalBytesPerSession)
    {
        @selfRef.TotalBytesPerSession = totalBytesPerSession;
        return @selfRef;
    }

}
