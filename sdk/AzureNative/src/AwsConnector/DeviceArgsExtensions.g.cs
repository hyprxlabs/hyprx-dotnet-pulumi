// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class DeviceArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DeviceArgs WithContainerPath(this global::Pulumi.AzureNative.AwsConnector.Inputs.DeviceArgs @selfRef, global::System.String containerPath)
    {
        @selfRef.ContainerPath = containerPath;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DeviceArgs WithHostPath(this global::Pulumi.AzureNative.AwsConnector.Inputs.DeviceArgs @selfRef, global::System.String hostPath)
    {
        @selfRef.HostPath = hostPath;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DeviceArgs WithPermissions(this global::Pulumi.AzureNative.AwsConnector.Inputs.DeviceArgs @selfRef, global::System.Collections.Generic.List<global::System.String> permissions)
    {
        @selfRef.Permissions = permissions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DeviceArgs WithPermissions(this global::Pulumi.AzureNative.AwsConnector.Inputs.DeviceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Permissions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DeviceArgs WithPermissions(this global::Pulumi.AzureNative.AwsConnector.Inputs.DeviceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Permissions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
