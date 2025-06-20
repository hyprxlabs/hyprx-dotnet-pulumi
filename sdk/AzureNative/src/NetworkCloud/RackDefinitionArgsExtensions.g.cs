// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.NetworkCloud.Inputs;

namespace Pulumi.AzureNative.NetworkCloud;

public static partial class RackDefinitionArgsExtensions
{
    public static global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs WithAvailabilityZone(this global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs @selfRef, global::System.String availabilityZone)
    {
        @selfRef.AvailabilityZone = availabilityZone;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs WithBareMetalMachineConfigurationData(this global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.NetworkCloud.Inputs.BareMetalMachineConfigurationDataArgs> bareMetalMachineConfigurationData)
    {
        @selfRef.BareMetalMachineConfigurationData = bareMetalMachineConfigurationData;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs WithBareMetalMachineConfigurationData(this global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.NetworkCloud.Inputs.BareMetalMachineConfigurationDataArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.NetworkCloud.Inputs.BareMetalMachineConfigurationDataArgs>();
        @configure(@list);
        @selfRef.BareMetalMachineConfigurationData = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs WithBareMetalMachineConfigurationData(this global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.NetworkCloud.Inputs.BareMetalMachineConfigurationDataArgs>> @create)
    {
        @selfRef.BareMetalMachineConfigurationData = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs WithNetworkRackId(this global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs @selfRef, global::System.String networkRackId)
    {
        @selfRef.NetworkRackId = networkRackId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs WithRackLocation(this global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs @selfRef, global::System.String rackLocation)
    {
        @selfRef.RackLocation = rackLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs WithRackSerialNumber(this global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs @selfRef, global::System.String rackSerialNumber)
    {
        @selfRef.RackSerialNumber = rackSerialNumber;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs WithRackSkuId(this global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs @selfRef, global::System.String rackSkuId)
    {
        @selfRef.RackSkuId = rackSkuId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs WithStorageApplianceConfigurationData(this global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.NetworkCloud.Inputs.StorageApplianceConfigurationDataArgs> storageApplianceConfigurationData)
    {
        @selfRef.StorageApplianceConfigurationData = storageApplianceConfigurationData;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs WithStorageApplianceConfigurationData(this global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.NetworkCloud.Inputs.StorageApplianceConfigurationDataArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.NetworkCloud.Inputs.StorageApplianceConfigurationDataArgs>();
        @configure(@list);
        @selfRef.StorageApplianceConfigurationData = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs WithStorageApplianceConfigurationData(this global::Pulumi.AzureNative.NetworkCloud.Inputs.RackDefinitionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.NetworkCloud.Inputs.StorageApplianceConfigurationDataArgs>> @create)
    {
        @selfRef.StorageApplianceConfigurationData = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
