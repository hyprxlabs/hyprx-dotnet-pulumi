// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.GlobalAccelerator;

public static partial class ListenerArgsExtensions
{
    public static global::Pulumi.AwsNative.GlobalAccelerator.ListenerArgs WithAcceleratorArn(this global::Pulumi.AwsNative.GlobalAccelerator.ListenerArgs @selfRef, global::System.String acceleratorArn)
    {
        @selfRef.AcceleratorArn = acceleratorArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GlobalAccelerator.ListenerArgs WithClientAffinity(this global::Pulumi.AwsNative.GlobalAccelerator.ListenerArgs @selfRef, global::Pulumi.AwsNative.GlobalAccelerator.ListenerClientAffinity clientAffinity)
    {
        @selfRef.ClientAffinity = clientAffinity;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GlobalAccelerator.ListenerArgs WithClientAffinity(this global::Pulumi.AwsNative.GlobalAccelerator.ListenerArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.GlobalAccelerator.ListenerClientAffinity> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.GlobalAccelerator.ListenerClientAffinity>();
        @configure(@item);
        @selfRef.ClientAffinity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GlobalAccelerator.ListenerArgs WithPortRanges(this global::Pulumi.AwsNative.GlobalAccelerator.ListenerArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.GlobalAccelerator.Inputs.ListenerPortRangeArgs> portRanges)
    {
        @selfRef.PortRanges = portRanges;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GlobalAccelerator.ListenerArgs WithPortRanges(this global::Pulumi.AwsNative.GlobalAccelerator.ListenerArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.GlobalAccelerator.Inputs.ListenerPortRangeArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.GlobalAccelerator.Inputs.ListenerPortRangeArgs>();
        @configure(@list);
        @selfRef.PortRanges = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GlobalAccelerator.ListenerArgs WithPortRanges(this global::Pulumi.AwsNative.GlobalAccelerator.ListenerArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.GlobalAccelerator.Inputs.ListenerPortRangeArgs>> @create)
    {
        @selfRef.PortRanges = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GlobalAccelerator.ListenerArgs WithProtocol(this global::Pulumi.AwsNative.GlobalAccelerator.ListenerArgs @selfRef, global::Pulumi.AwsNative.GlobalAccelerator.ListenerProtocol protocol)
    {
        @selfRef.Protocol = protocol;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GlobalAccelerator.ListenerArgs WithProtocol(this global::Pulumi.AwsNative.GlobalAccelerator.ListenerArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.GlobalAccelerator.ListenerProtocol> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.GlobalAccelerator.ListenerProtocol>();
        @configure(@item);
        @selfRef.Protocol = @item;
        return @selfRef;
    }

}
