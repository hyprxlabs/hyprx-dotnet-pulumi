// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataReplication.Inputs;

namespace Pulumi.AzureNative.DataReplication;

public static partial class VMwareToAzStackHCINicInputArgsExtensions
{
    public static global::Pulumi.AzureNative.DataReplication.Inputs.VMwareToAzStackHCINicInputArgs WithLabel(this global::Pulumi.AzureNative.DataReplication.Inputs.VMwareToAzStackHCINicInputArgs @selfRef, global::System.String label)
    {
        @selfRef.Label = label;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataReplication.Inputs.VMwareToAzStackHCINicInputArgs WithNicId(this global::Pulumi.AzureNative.DataReplication.Inputs.VMwareToAzStackHCINicInputArgs @selfRef, global::System.String nicId)
    {
        @selfRef.NicId = nicId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataReplication.Inputs.VMwareToAzStackHCINicInputArgs WithSelectionTypeForFailover(this global::Pulumi.AzureNative.DataReplication.Inputs.VMwareToAzStackHCINicInputArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DataReplication.VMNicSelection> selectionTypeForFailover)
    {
        @selfRef.SelectionTypeForFailover = selectionTypeForFailover;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataReplication.Inputs.VMwareToAzStackHCINicInputArgs WithTargetNetworkId(this global::Pulumi.AzureNative.DataReplication.Inputs.VMwareToAzStackHCINicInputArgs @selfRef, global::System.String targetNetworkId)
    {
        @selfRef.TargetNetworkId = targetNetworkId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataReplication.Inputs.VMwareToAzStackHCINicInputArgs WithTestNetworkId(this global::Pulumi.AzureNative.DataReplication.Inputs.VMwareToAzStackHCINicInputArgs @selfRef, global::System.String testNetworkId)
    {
        @selfRef.TestNetworkId = testNetworkId;
        return @selfRef;
    }

}
