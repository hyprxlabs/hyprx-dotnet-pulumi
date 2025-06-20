// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Migrate.Inputs;

namespace Pulumi.AzureNative.Migrate;

public static partial class AvailabilitySetResourceSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.Migrate.Inputs.AvailabilitySetResourceSettingsArgs WithFaultDomain(this global::Pulumi.AzureNative.Migrate.Inputs.AvailabilitySetResourceSettingsArgs @selfRef, global::System.Int32 faultDomain)
    {
        @selfRef.FaultDomain = faultDomain;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.AvailabilitySetResourceSettingsArgs WithResourceType(this global::Pulumi.AzureNative.Migrate.Inputs.AvailabilitySetResourceSettingsArgs @selfRef, global::System.String resourceType)
    {
        @selfRef.ResourceType = resourceType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.AvailabilitySetResourceSettingsArgs WithTags(this global::Pulumi.AzureNative.Migrate.Inputs.AvailabilitySetResourceSettingsArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.AvailabilitySetResourceSettingsArgs WithTags(this global::Pulumi.AzureNative.Migrate.Inputs.AvailabilitySetResourceSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.AvailabilitySetResourceSettingsArgs WithTags(this global::Pulumi.AzureNative.Migrate.Inputs.AvailabilitySetResourceSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.AvailabilitySetResourceSettingsArgs WithTargetResourceGroupName(this global::Pulumi.AzureNative.Migrate.Inputs.AvailabilitySetResourceSettingsArgs @selfRef, global::System.String targetResourceGroupName)
    {
        @selfRef.TargetResourceGroupName = targetResourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.AvailabilitySetResourceSettingsArgs WithTargetResourceName(this global::Pulumi.AzureNative.Migrate.Inputs.AvailabilitySetResourceSettingsArgs @selfRef, global::System.String targetResourceName)
    {
        @selfRef.TargetResourceName = targetResourceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.AvailabilitySetResourceSettingsArgs WithUpdateDomain(this global::Pulumi.AzureNative.Migrate.Inputs.AvailabilitySetResourceSettingsArgs @selfRef, global::System.Int32 updateDomain)
    {
        @selfRef.UpdateDomain = updateDomain;
        return @selfRef;
    }

}
