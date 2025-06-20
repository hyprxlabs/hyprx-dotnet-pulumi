// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Lightsail.Inputs;

namespace Pulumi.AwsNative.Lightsail;

public static partial class InstanceNetworkingArgsExtensions
{
    public static global::Pulumi.AwsNative.Lightsail.Inputs.InstanceNetworkingArgs WithMonthlyTransfer(this global::Pulumi.AwsNative.Lightsail.Inputs.InstanceNetworkingArgs @selfRef, global::Pulumi.AwsNative.Lightsail.Inputs.InstanceMonthlyTransferArgs monthlyTransfer)
    {
        @selfRef.MonthlyTransfer = monthlyTransfer;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.Inputs.InstanceNetworkingArgs WithMonthlyTransfer(this global::Pulumi.AwsNative.Lightsail.Inputs.InstanceNetworkingArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Lightsail.Inputs.InstanceMonthlyTransferArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Lightsail.Inputs.InstanceMonthlyTransferArgs();
        @configure(@item);
        @selfRef.MonthlyTransfer = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.Inputs.InstanceNetworkingArgs WithPorts(this global::Pulumi.AwsNative.Lightsail.Inputs.InstanceNetworkingArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Lightsail.Inputs.InstancePortArgs> ports)
    {
        @selfRef.Ports = ports;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.Inputs.InstanceNetworkingArgs WithPorts(this global::Pulumi.AwsNative.Lightsail.Inputs.InstanceNetworkingArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Lightsail.Inputs.InstancePortArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Lightsail.Inputs.InstancePortArgs>();
        @configure(@list);
        @selfRef.Ports = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.Inputs.InstanceNetworkingArgs WithPorts(this global::Pulumi.AwsNative.Lightsail.Inputs.InstanceNetworkingArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Lightsail.Inputs.InstancePortArgs>> @create)
    {
        @selfRef.Ports = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
