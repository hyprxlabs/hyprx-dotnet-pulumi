// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class MonitoringArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MonitoringArgs WithState(this global::Pulumi.AzureNative.AwsConnector.Inputs.MonitoringArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.MonitoringStateEnumValueArgs state)
    {
        @selfRef.State = state;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MonitoringArgs WithState(this global::Pulumi.AzureNative.AwsConnector.Inputs.MonitoringArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.MonitoringStateEnumValueArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.MonitoringStateEnumValueArgs();
        @configure(@item);
        @selfRef.State = @item;
        return @selfRef;
    }

}
