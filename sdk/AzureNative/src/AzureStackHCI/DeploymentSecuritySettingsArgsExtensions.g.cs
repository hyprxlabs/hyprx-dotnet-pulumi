// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AzureStackHCI.Inputs;

namespace Pulumi.AzureNative.AzureStackHCI;

public static partial class DeploymentSecuritySettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs WithBitlockerBootVolume(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs @selfRef, bool bitlockerBootVolume = true)
    {
        @selfRef.BitlockerBootVolume = bitlockerBootVolume;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs WithBitlockerDataVolumes(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs @selfRef, bool bitlockerDataVolumes = true)
    {
        @selfRef.BitlockerDataVolumes = bitlockerDataVolumes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs WithCredentialGuardEnforced(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs @selfRef, bool credentialGuardEnforced = true)
    {
        @selfRef.CredentialGuardEnforced = credentialGuardEnforced;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs WithDriftControlEnforced(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs @selfRef, bool driftControlEnforced = true)
    {
        @selfRef.DriftControlEnforced = driftControlEnforced;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs WithDrtmProtection(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs @selfRef, bool drtmProtection = true)
    {
        @selfRef.DrtmProtection = drtmProtection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs WithHvciProtection(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs @selfRef, bool hvciProtection = true)
    {
        @selfRef.HvciProtection = hvciProtection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs WithSideChannelMitigationEnforced(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs @selfRef, bool sideChannelMitigationEnforced = true)
    {
        @selfRef.SideChannelMitigationEnforced = sideChannelMitigationEnforced;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs WithSmbClusterEncryption(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs @selfRef, bool smbClusterEncryption = true)
    {
        @selfRef.SmbClusterEncryption = smbClusterEncryption;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs WithSmbSigningEnforced(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs @selfRef, bool smbSigningEnforced = true)
    {
        @selfRef.SmbSigningEnforced = smbSigningEnforced;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs WithWdacEnforced(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs @selfRef, bool wdacEnforced = true)
    {
        @selfRef.WdacEnforced = wdacEnforced;
        return @selfRef;
    }

}
