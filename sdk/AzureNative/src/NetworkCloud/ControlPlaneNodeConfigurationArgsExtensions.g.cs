// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.NetworkCloud.Inputs;

namespace Pulumi.AzureNative.NetworkCloud;

public static partial class ControlPlaneNodeConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.NetworkCloud.Inputs.ControlPlaneNodeConfigurationArgs WithAdministratorConfiguration(this global::Pulumi.AzureNative.NetworkCloud.Inputs.ControlPlaneNodeConfigurationArgs @selfRef, global::Pulumi.AzureNative.NetworkCloud.Inputs.AdministratorConfigurationArgs administratorConfiguration)
    {
        @selfRef.AdministratorConfiguration = administratorConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.Inputs.ControlPlaneNodeConfigurationArgs WithAdministratorConfiguration(this global::Pulumi.AzureNative.NetworkCloud.Inputs.ControlPlaneNodeConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.NetworkCloud.Inputs.AdministratorConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.NetworkCloud.Inputs.AdministratorConfigurationArgs();
        @configure(@item);
        @selfRef.AdministratorConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.Inputs.ControlPlaneNodeConfigurationArgs WithAvailabilityZones(this global::Pulumi.AzureNative.NetworkCloud.Inputs.ControlPlaneNodeConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::System.String> availabilityZones)
    {
        @selfRef.AvailabilityZones = availabilityZones;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.Inputs.ControlPlaneNodeConfigurationArgs WithAvailabilityZones(this global::Pulumi.AzureNative.NetworkCloud.Inputs.ControlPlaneNodeConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AvailabilityZones = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.Inputs.ControlPlaneNodeConfigurationArgs WithAvailabilityZones(this global::Pulumi.AzureNative.NetworkCloud.Inputs.ControlPlaneNodeConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AvailabilityZones = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.Inputs.ControlPlaneNodeConfigurationArgs WithCount(this global::Pulumi.AzureNative.NetworkCloud.Inputs.ControlPlaneNodeConfigurationArgs @selfRef, global::System.Double count)
    {
        @selfRef.Count = count;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.Inputs.ControlPlaneNodeConfigurationArgs WithVmSkuName(this global::Pulumi.AzureNative.NetworkCloud.Inputs.ControlPlaneNodeConfigurationArgs @selfRef, global::System.String vmSkuName)
    {
        @selfRef.VmSkuName = vmSkuName;
        return @selfRef;
    }

}
