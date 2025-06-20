// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DevTestLab.Inputs;

namespace Pulumi.AzureNative.DevTestLab;

public static partial class LabVirtualMachineCreationParameterArgsExtensions
{
    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithAllowClaim(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, bool allowClaim = true)
    {
        @selfRef.AllowClaim = allowClaim;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithArtifacts(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DevTestLab.Inputs.ArtifactInstallPropertiesArgs> artifacts)
    {
        @selfRef.Artifacts = artifacts;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithArtifacts(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DevTestLab.Inputs.ArtifactInstallPropertiesArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DevTestLab.Inputs.ArtifactInstallPropertiesArgs>();
        @configure(@list);
        @selfRef.Artifacts = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithArtifacts(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DevTestLab.Inputs.ArtifactInstallPropertiesArgs>> @create)
    {
        @selfRef.Artifacts = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithBulkCreationParameters(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::Pulumi.AzureNative.DevTestLab.Inputs.BulkCreationParametersArgs bulkCreationParameters)
    {
        @selfRef.BulkCreationParameters = bulkCreationParameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithBulkCreationParameters(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DevTestLab.Inputs.BulkCreationParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DevTestLab.Inputs.BulkCreationParametersArgs();
        @configure(@item);
        @selfRef.BulkCreationParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithCreatedDate(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.String createdDate)
    {
        @selfRef.CreatedDate = createdDate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithCustomImageId(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.String customImageId)
    {
        @selfRef.CustomImageId = customImageId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithDataDiskParameters(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DevTestLab.Inputs.DataDiskPropertiesArgs> dataDiskParameters)
    {
        @selfRef.DataDiskParameters = dataDiskParameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithDataDiskParameters(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DevTestLab.Inputs.DataDiskPropertiesArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DevTestLab.Inputs.DataDiskPropertiesArgs>();
        @configure(@list);
        @selfRef.DataDiskParameters = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithDataDiskParameters(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DevTestLab.Inputs.DataDiskPropertiesArgs>> @create)
    {
        @selfRef.DataDiskParameters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithDisallowPublicIpAddress(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, bool disallowPublicIpAddress = true)
    {
        @selfRef.DisallowPublicIpAddress = disallowPublicIpAddress;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithEnvironmentId(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.String environmentId)
    {
        @selfRef.EnvironmentId = environmentId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithExpirationDate(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.String expirationDate)
    {
        @selfRef.ExpirationDate = expirationDate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithGalleryImageReference(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::Pulumi.AzureNative.DevTestLab.Inputs.GalleryImageReferenceArgs galleryImageReference)
    {
        @selfRef.GalleryImageReference = galleryImageReference;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithGalleryImageReference(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DevTestLab.Inputs.GalleryImageReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DevTestLab.Inputs.GalleryImageReferenceArgs();
        @configure(@item);
        @selfRef.GalleryImageReference = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithIsAuthenticationWithSshKey(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, bool isAuthenticationWithSshKey = true)
    {
        @selfRef.IsAuthenticationWithSshKey = isAuthenticationWithSshKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithLabSubnetName(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.String labSubnetName)
    {
        @selfRef.LabSubnetName = labSubnetName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithLabVirtualNetworkId(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.String labVirtualNetworkId)
    {
        @selfRef.LabVirtualNetworkId = labVirtualNetworkId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithLocation(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithName(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithNetworkInterface(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::Pulumi.AzureNative.DevTestLab.Inputs.NetworkInterfacePropertiesArgs networkInterface)
    {
        @selfRef.NetworkInterface = networkInterface;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithNetworkInterface(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DevTestLab.Inputs.NetworkInterfacePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DevTestLab.Inputs.NetworkInterfacePropertiesArgs();
        @configure(@item);
        @selfRef.NetworkInterface = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithNotes(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.String notes)
    {
        @selfRef.Notes = notes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithOwnerObjectId(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.String ownerObjectId)
    {
        @selfRef.OwnerObjectId = ownerObjectId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithOwnerUserPrincipalName(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.String ownerUserPrincipalName)
    {
        @selfRef.OwnerUserPrincipalName = ownerUserPrincipalName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithPassword(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.String password)
    {
        @selfRef.Password = password;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithPlanId(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.String planId)
    {
        @selfRef.PlanId = planId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithScheduleParameters(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DevTestLab.Inputs.ScheduleCreationParameterArgs> scheduleParameters)
    {
        @selfRef.ScheduleParameters = scheduleParameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithScheduleParameters(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DevTestLab.Inputs.ScheduleCreationParameterArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DevTestLab.Inputs.ScheduleCreationParameterArgs>();
        @configure(@list);
        @selfRef.ScheduleParameters = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithScheduleParameters(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DevTestLab.Inputs.ScheduleCreationParameterArgs>> @create)
    {
        @selfRef.ScheduleParameters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithSize(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.String size)
    {
        @selfRef.Size = size;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithSshKey(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.String sshKey)
    {
        @selfRef.SshKey = sshKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithStorageType(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.String storageType)
    {
        @selfRef.StorageType = storageType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithTags(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithTags(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithTags(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs WithUserName(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabVirtualMachineCreationParameterArgs @selfRef, global::System.String userName)
    {
        @selfRef.UserName = userName;
        return @selfRef;
    }

}
