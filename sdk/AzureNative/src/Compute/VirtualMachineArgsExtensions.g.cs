// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Compute;

public static partial class VirtualMachineArgsExtensions
{
    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithAdditionalCapabilities(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.AdditionalCapabilitiesArgs additionalCapabilities)
    {
        @selfRef.AdditionalCapabilities = additionalCapabilities;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithAdditionalCapabilities(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.AdditionalCapabilitiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.AdditionalCapabilitiesArgs();
        @configure(@item);
        @selfRef.AdditionalCapabilities = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithApplicationProfile(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.ApplicationProfileArgs applicationProfile)
    {
        @selfRef.ApplicationProfile = applicationProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithApplicationProfile(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.ApplicationProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.ApplicationProfileArgs();
        @configure(@item);
        @selfRef.ApplicationProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithAvailabilitySet(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs availabilitySet)
    {
        @selfRef.AvailabilitySet = availabilitySet;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithAvailabilitySet(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.AvailabilitySet = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithBillingProfile(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.BillingProfileArgs billingProfile)
    {
        @selfRef.BillingProfile = billingProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithBillingProfile(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.BillingProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.BillingProfileArgs();
        @configure(@item);
        @selfRef.BillingProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithCapacityReservation(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.CapacityReservationProfileArgs capacityReservation)
    {
        @selfRef.CapacityReservation = capacityReservation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithCapacityReservation(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.CapacityReservationProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.CapacityReservationProfileArgs();
        @configure(@item);
        @selfRef.CapacityReservation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithDiagnosticsProfile(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.DiagnosticsProfileArgs diagnosticsProfile)
    {
        @selfRef.DiagnosticsProfile = diagnosticsProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithDiagnosticsProfile(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.DiagnosticsProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.DiagnosticsProfileArgs();
        @configure(@item);
        @selfRef.DiagnosticsProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithEvictionPolicy(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Compute.VirtualMachineEvictionPolicyTypes> evictionPolicy)
    {
        @selfRef.EvictionPolicy = evictionPolicy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithExtendedLocation(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.ExtendedLocationArgs extendedLocation)
    {
        @selfRef.ExtendedLocation = extendedLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithExtendedLocation(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.ExtendedLocationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.ExtendedLocationArgs();
        @configure(@item);
        @selfRef.ExtendedLocation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithExtensionsTimeBudget(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.String extensionsTimeBudget)
    {
        @selfRef.ExtensionsTimeBudget = extensionsTimeBudget;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithHardwareProfile(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.HardwareProfileArgs hardwareProfile)
    {
        @selfRef.HardwareProfile = hardwareProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithHardwareProfile(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.HardwareProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.HardwareProfileArgs();
        @configure(@item);
        @selfRef.HardwareProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithHost(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs host)
    {
        @selfRef.Host = host;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithHost(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.Host = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithHostGroup(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs hostGroup)
    {
        @selfRef.HostGroup = hostGroup;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithHostGroup(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.HostGroup = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithIdentity(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineIdentityArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithIdentity(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineIdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineIdentityArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithLicenseType(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.String licenseType)
    {
        @selfRef.LicenseType = licenseType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithLocation(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithNetworkProfile(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.NetworkProfileArgs networkProfile)
    {
        @selfRef.NetworkProfile = networkProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithNetworkProfile(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.NetworkProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.NetworkProfileArgs();
        @configure(@item);
        @selfRef.NetworkProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithOsProfile(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.OSProfileArgs osProfile)
    {
        @selfRef.OsProfile = osProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithOsProfile(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.OSProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.OSProfileArgs();
        @configure(@item);
        @selfRef.OsProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithPlacement(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.PlacementArgs placement)
    {
        @selfRef.Placement = placement;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithPlacement(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.PlacementArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.PlacementArgs();
        @configure(@item);
        @selfRef.Placement = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithPlan(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.PlanArgs plan)
    {
        @selfRef.Plan = plan;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithPlan(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.PlanArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.PlanArgs();
        @configure(@item);
        @selfRef.Plan = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithPlatformFaultDomain(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Int32 platformFaultDomain)
    {
        @selfRef.PlatformFaultDomain = platformFaultDomain;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithPriority(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Compute.VirtualMachinePriorityTypes> priority)
    {
        @selfRef.Priority = priority;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithProximityPlacementGroup(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs proximityPlacementGroup)
    {
        @selfRef.ProximityPlacementGroup = proximityPlacementGroup;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithProximityPlacementGroup(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.ProximityPlacementGroup = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithResourceGroupName(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithScheduledEventsPolicy(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.ScheduledEventsPolicyArgs scheduledEventsPolicy)
    {
        @selfRef.ScheduledEventsPolicy = scheduledEventsPolicy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithScheduledEventsPolicy(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.ScheduledEventsPolicyArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.ScheduledEventsPolicyArgs();
        @configure(@item);
        @selfRef.ScheduledEventsPolicy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithScheduledEventsProfile(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.ScheduledEventsProfileArgs scheduledEventsProfile)
    {
        @selfRef.ScheduledEventsProfile = scheduledEventsProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithScheduledEventsProfile(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.ScheduledEventsProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.ScheduledEventsProfileArgs();
        @configure(@item);
        @selfRef.ScheduledEventsProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithSecurityProfile(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.SecurityProfileArgs securityProfile)
    {
        @selfRef.SecurityProfile = securityProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithSecurityProfile(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.SecurityProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.SecurityProfileArgs();
        @configure(@item);
        @selfRef.SecurityProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithStorageProfile(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.StorageProfileArgs storageProfile)
    {
        @selfRef.StorageProfile = storageProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithStorageProfile(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.StorageProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.StorageProfileArgs();
        @configure(@item);
        @selfRef.StorageProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithTags(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithTags(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithTags(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithUserData(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.String userData)
    {
        @selfRef.UserData = userData;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithVirtualMachineScaleSet(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs virtualMachineScaleSet)
    {
        @selfRef.VirtualMachineScaleSet = virtualMachineScaleSet;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithVirtualMachineScaleSet(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.VirtualMachineScaleSet = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithVmName(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.String vmName)
    {
        @selfRef.VmName = vmName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithZones(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Collections.Generic.List<global::System.String> zones)
    {
        @selfRef.Zones = zones;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithZones(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Zones = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.VirtualMachineArgs WithZones(this global::Pulumi.AzureNative.Compute.VirtualMachineArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Zones = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
