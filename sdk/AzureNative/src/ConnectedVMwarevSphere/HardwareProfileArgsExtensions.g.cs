// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs;

namespace Pulumi.AzureNative.ConnectedVMwarevSphere;

public static partial class HardwareProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.HardwareProfileArgs WithMemorySizeMB(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.HardwareProfileArgs @selfRef, global::System.Int32 memorySizeMB)
    {
        @selfRef.MemorySizeMB = memorySizeMB;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.HardwareProfileArgs WithNumCPUs(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.HardwareProfileArgs @selfRef, global::System.Int32 numCPUs)
    {
        @selfRef.NumCPUs = numCPUs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.HardwareProfileArgs WithNumCoresPerSocket(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.HardwareProfileArgs @selfRef, global::System.Int32 numCoresPerSocket)
    {
        @selfRef.NumCoresPerSocket = numCoresPerSocket;
        return @selfRef;
    }

}
