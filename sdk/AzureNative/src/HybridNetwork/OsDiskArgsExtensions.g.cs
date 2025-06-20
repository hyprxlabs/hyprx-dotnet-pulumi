// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HybridNetwork.Inputs;

namespace Pulumi.AzureNative.HybridNetwork;

public static partial class OsDiskArgsExtensions
{
    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.OsDiskArgs WithDiskSizeGB(this global::Pulumi.AzureNative.HybridNetwork.Inputs.OsDiskArgs @selfRef, global::System.Int32 diskSizeGB)
    {
        @selfRef.DiskSizeGB = diskSizeGB;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.OsDiskArgs WithName(this global::Pulumi.AzureNative.HybridNetwork.Inputs.OsDiskArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.OsDiskArgs WithOsType(this global::Pulumi.AzureNative.HybridNetwork.Inputs.OsDiskArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.HybridNetwork.OperatingSystemTypes> osType)
    {
        @selfRef.OsType = osType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.OsDiskArgs WithVhd(this global::Pulumi.AzureNative.HybridNetwork.Inputs.OsDiskArgs @selfRef, global::Pulumi.AzureNative.HybridNetwork.Inputs.VirtualHardDiskArgs vhd)
    {
        @selfRef.Vhd = vhd;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.OsDiskArgs WithVhd(this global::Pulumi.AzureNative.HybridNetwork.Inputs.OsDiskArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HybridNetwork.Inputs.VirtualHardDiskArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HybridNetwork.Inputs.VirtualHardDiskArgs();
        @configure(@item);
        @selfRef.Vhd = @item;
        return @selfRef;
    }

}
