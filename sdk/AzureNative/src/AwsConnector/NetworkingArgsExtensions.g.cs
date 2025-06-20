// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class NetworkingArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.NetworkingArgs WithMonthlyTransfer(this global::Pulumi.AzureNative.AwsConnector.Inputs.NetworkingArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.MonthlyTransferArgs monthlyTransfer)
    {
        @selfRef.MonthlyTransfer = monthlyTransfer;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.NetworkingArgs WithMonthlyTransfer(this global::Pulumi.AzureNative.AwsConnector.Inputs.NetworkingArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.MonthlyTransferArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.MonthlyTransferArgs();
        @configure(@item);
        @selfRef.MonthlyTransfer = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.NetworkingArgs WithPorts(this global::Pulumi.AzureNative.AwsConnector.Inputs.NetworkingArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.PortArgs> ports)
    {
        @selfRef.Ports = ports;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.NetworkingArgs WithPorts(this global::Pulumi.AzureNative.AwsConnector.Inputs.NetworkingArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.PortArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.PortArgs>();
        @configure(@list);
        @selfRef.Ports = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.NetworkingArgs WithPorts(this global::Pulumi.AzureNative.AwsConnector.Inputs.NetworkingArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.PortArgs>> @create)
    {
        @selfRef.Ports = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
