// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.RecoveryServices.Inputs;

namespace Pulumi.AzureNative.RecoveryServices;

public static partial class HyperVReplicaAzureEnableProtectionInputArgsExtensions
{
    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithDiskEncryptionSetId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.String diskEncryptionSetId)
    {
        @selfRef.DiskEncryptionSetId = diskEncryptionSetId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithDiskType(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.RecoveryServices.DiskAccountType> diskType)
    {
        @selfRef.DiskType = diskType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithDisksToInclude(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.Collections.Generic.List<global::System.String> disksToInclude)
    {
        @selfRef.DisksToInclude = disksToInclude;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithDisksToInclude(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.DisksToInclude = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithDisksToInclude(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.DisksToInclude = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithDisksToIncludeForManagedDisks(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureDiskInputDetailsArgs> disksToIncludeForManagedDisks)
    {
        @selfRef.DisksToIncludeForManagedDisks = disksToIncludeForManagedDisks;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithDisksToIncludeForManagedDisks(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureDiskInputDetailsArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureDiskInputDetailsArgs>();
        @configure(@list);
        @selfRef.DisksToIncludeForManagedDisks = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithDisksToIncludeForManagedDisks(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureDiskInputDetailsArgs>> @create)
    {
        @selfRef.DisksToIncludeForManagedDisks = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithEnableRdpOnTargetOption(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.String enableRdpOnTargetOption)
    {
        @selfRef.EnableRdpOnTargetOption = enableRdpOnTargetOption;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithHvHostVmId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.String hvHostVmId)
    {
        @selfRef.HvHostVmId = hvHostVmId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithInstanceType(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.String instanceType)
    {
        @selfRef.InstanceType = instanceType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithLicenseType(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.RecoveryServices.LicenseType> licenseType)
    {
        @selfRef.LicenseType = licenseType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithLinuxLicenseType(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.RecoveryServices.LinuxLicenseType> linuxLicenseType)
    {
        @selfRef.LinuxLicenseType = linuxLicenseType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithLogStorageAccountId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.String logStorageAccountId)
    {
        @selfRef.LogStorageAccountId = logStorageAccountId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithOsType(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.String osType)
    {
        @selfRef.OsType = osType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithSeedManagedDiskTags(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> seedManagedDiskTags)
    {
        @selfRef.SeedManagedDiskTags = seedManagedDiskTags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithSeedManagedDiskTags(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.SeedManagedDiskTags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithSeedManagedDiskTags(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.SeedManagedDiskTags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithSqlServerLicenseType(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.RecoveryServices.SqlServerLicenseType> sqlServerLicenseType)
    {
        @selfRef.SqlServerLicenseType = sqlServerLicenseType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithTargetAvailabilitySetId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.String targetAvailabilitySetId)
    {
        @selfRef.TargetAvailabilitySetId = targetAvailabilitySetId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithTargetAvailabilityZone(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.String targetAvailabilityZone)
    {
        @selfRef.TargetAvailabilityZone = targetAvailabilityZone;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithTargetAzureNetworkId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.String targetAzureNetworkId)
    {
        @selfRef.TargetAzureNetworkId = targetAzureNetworkId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithTargetAzureSubnetId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.String targetAzureSubnetId)
    {
        @selfRef.TargetAzureSubnetId = targetAzureSubnetId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithTargetAzureV1ResourceGroupId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.String targetAzureV1ResourceGroupId)
    {
        @selfRef.TargetAzureV1ResourceGroupId = targetAzureV1ResourceGroupId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithTargetAzureV2ResourceGroupId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.String targetAzureV2ResourceGroupId)
    {
        @selfRef.TargetAzureV2ResourceGroupId = targetAzureV2ResourceGroupId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithTargetAzureVmName(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.String targetAzureVmName)
    {
        @selfRef.TargetAzureVmName = targetAzureVmName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithTargetManagedDiskTags(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> targetManagedDiskTags)
    {
        @selfRef.TargetManagedDiskTags = targetManagedDiskTags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithTargetManagedDiskTags(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.TargetManagedDiskTags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithTargetManagedDiskTags(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.TargetManagedDiskTags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithTargetNicTags(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> targetNicTags)
    {
        @selfRef.TargetNicTags = targetNicTags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithTargetNicTags(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.TargetNicTags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithTargetNicTags(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.TargetNicTags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithTargetProximityPlacementGroupId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.String targetProximityPlacementGroupId)
    {
        @selfRef.TargetProximityPlacementGroupId = targetProximityPlacementGroupId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithTargetStorageAccountId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.String targetStorageAccountId)
    {
        @selfRef.TargetStorageAccountId = targetStorageAccountId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithTargetVmSecurityProfile(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::Pulumi.AzureNative.RecoveryServices.Inputs.SecurityProfilePropertiesArgs targetVmSecurityProfile)
    {
        @selfRef.TargetVmSecurityProfile = targetVmSecurityProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithTargetVmSecurityProfile(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.RecoveryServices.Inputs.SecurityProfilePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.RecoveryServices.Inputs.SecurityProfilePropertiesArgs();
        @configure(@item);
        @selfRef.TargetVmSecurityProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithTargetVmSize(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.String targetVmSize)
    {
        @selfRef.TargetVmSize = targetVmSize;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithTargetVmTags(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> targetVmTags)
    {
        @selfRef.TargetVmTags = targetVmTags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithTargetVmTags(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.TargetVmTags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithTargetVmTags(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.TargetVmTags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithUseManagedDisks(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.String useManagedDisks)
    {
        @selfRef.UseManagedDisks = useManagedDisks;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithUseManagedDisksForReplication(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.String useManagedDisksForReplication)
    {
        @selfRef.UseManagedDisksForReplication = useManagedDisksForReplication;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithUserSelectedOSName(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.String userSelectedOSName)
    {
        @selfRef.UserSelectedOSName = userSelectedOSName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithVhdId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.String vhdId)
    {
        @selfRef.VhdId = vhdId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs WithVmName(this global::Pulumi.AzureNative.RecoveryServices.Inputs.HyperVReplicaAzureEnableProtectionInputArgs @selfRef, global::System.String vmName)
    {
        @selfRef.VmName = vmName;
        return @selfRef;
    }

}
