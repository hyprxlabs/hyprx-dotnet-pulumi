// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.NetApp.Inputs;

namespace Pulumi.AzureNative.NetApp;

public static partial class VolumeGroupMetaDataArgsExtensions
{
    public static global::Pulumi.AzureNative.NetApp.Inputs.VolumeGroupMetaDataArgs WithApplicationIdentifier(this global::Pulumi.AzureNative.NetApp.Inputs.VolumeGroupMetaDataArgs @selfRef, global::System.String applicationIdentifier)
    {
        @selfRef.ApplicationIdentifier = applicationIdentifier;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.Inputs.VolumeGroupMetaDataArgs WithApplicationType(this global::Pulumi.AzureNative.NetApp.Inputs.VolumeGroupMetaDataArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.NetApp.ApplicationType> applicationType)
    {
        @selfRef.ApplicationType = applicationType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.Inputs.VolumeGroupMetaDataArgs WithGlobalPlacementRules(this global::Pulumi.AzureNative.NetApp.Inputs.VolumeGroupMetaDataArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.NetApp.Inputs.PlacementKeyValuePairsArgs> globalPlacementRules)
    {
        @selfRef.GlobalPlacementRules = globalPlacementRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.Inputs.VolumeGroupMetaDataArgs WithGlobalPlacementRules(this global::Pulumi.AzureNative.NetApp.Inputs.VolumeGroupMetaDataArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.NetApp.Inputs.PlacementKeyValuePairsArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.NetApp.Inputs.PlacementKeyValuePairsArgs>();
        @configure(@list);
        @selfRef.GlobalPlacementRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.Inputs.VolumeGroupMetaDataArgs WithGlobalPlacementRules(this global::Pulumi.AzureNative.NetApp.Inputs.VolumeGroupMetaDataArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.NetApp.Inputs.PlacementKeyValuePairsArgs>> @create)
    {
        @selfRef.GlobalPlacementRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.Inputs.VolumeGroupMetaDataArgs WithGroupDescription(this global::Pulumi.AzureNative.NetApp.Inputs.VolumeGroupMetaDataArgs @selfRef, global::System.String groupDescription)
    {
        @selfRef.GroupDescription = groupDescription;
        return @selfRef;
    }

}
