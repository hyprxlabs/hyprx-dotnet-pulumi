// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs;

namespace Pulumi.AzureNative.ConnectedVMwarevSphere;

public static partial class NetworkProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.NetworkProfileArgs WithNetworkInterfaces(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.NetworkProfileArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.NetworkInterfaceArgs> networkInterfaces)
    {
        @selfRef.NetworkInterfaces = networkInterfaces;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.NetworkProfileArgs WithNetworkInterfaces(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.NetworkProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.NetworkInterfaceArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.NetworkInterfaceArgs>();
        @configure(@list);
        @selfRef.NetworkInterfaces = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.NetworkProfileArgs WithNetworkInterfaces(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.NetworkProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.NetworkInterfaceArgs>> @create)
    {
        @selfRef.NetworkInterfaces = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
