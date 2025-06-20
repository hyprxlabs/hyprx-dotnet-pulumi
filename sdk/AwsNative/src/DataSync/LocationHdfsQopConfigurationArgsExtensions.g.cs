// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.DataSync.Inputs;

namespace Pulumi.AwsNative.DataSync;

public static partial class LocationHdfsQopConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.DataSync.Inputs.LocationHdfsQopConfigurationArgs WithDataTransferProtection(this global::Pulumi.AwsNative.DataSync.Inputs.LocationHdfsQopConfigurationArgs @selfRef, global::Pulumi.AwsNative.DataSync.LocationHdfsQopConfigurationDataTransferProtection dataTransferProtection)
    {
        @selfRef.DataTransferProtection = dataTransferProtection;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.LocationHdfsQopConfigurationArgs WithDataTransferProtection(this global::Pulumi.AwsNative.DataSync.Inputs.LocationHdfsQopConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataSync.LocationHdfsQopConfigurationDataTransferProtection> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.DataSync.LocationHdfsQopConfigurationDataTransferProtection>();
        @configure(@item);
        @selfRef.DataTransferProtection = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.LocationHdfsQopConfigurationArgs WithRpcProtection(this global::Pulumi.AwsNative.DataSync.Inputs.LocationHdfsQopConfigurationArgs @selfRef, global::Pulumi.AwsNative.DataSync.LocationHdfsQopConfigurationRpcProtection rpcProtection)
    {
        @selfRef.RpcProtection = rpcProtection;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.LocationHdfsQopConfigurationArgs WithRpcProtection(this global::Pulumi.AwsNative.DataSync.Inputs.LocationHdfsQopConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataSync.LocationHdfsQopConfigurationRpcProtection> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.DataSync.LocationHdfsQopConfigurationRpcProtection>();
        @configure(@item);
        @selfRef.RpcProtection = @item;
        return @selfRef;
    }

}
