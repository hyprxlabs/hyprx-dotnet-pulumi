// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DevCenter;

public static partial class ProjectArgsExtensions
{
    public static global::Pulumi.AzureNative.DevCenter.ProjectArgs WithCatalogSettings(this global::Pulumi.AzureNative.DevCenter.ProjectArgs @selfRef, global::Pulumi.AzureNative.DevCenter.Inputs.ProjectCatalogSettingsArgs catalogSettings)
    {
        @selfRef.CatalogSettings = catalogSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevCenter.ProjectArgs WithCatalogSettings(this global::Pulumi.AzureNative.DevCenter.ProjectArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DevCenter.Inputs.ProjectCatalogSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DevCenter.Inputs.ProjectCatalogSettingsArgs();
        @configure(@item);
        @selfRef.CatalogSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevCenter.ProjectArgs WithDescription(this global::Pulumi.AzureNative.DevCenter.ProjectArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevCenter.ProjectArgs WithDevCenterId(this global::Pulumi.AzureNative.DevCenter.ProjectArgs @selfRef, global::System.String devCenterId)
    {
        @selfRef.DevCenterId = devCenterId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevCenter.ProjectArgs WithDisplayName(this global::Pulumi.AzureNative.DevCenter.ProjectArgs @selfRef, global::System.String displayName)
    {
        @selfRef.DisplayName = displayName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevCenter.ProjectArgs WithIdentity(this global::Pulumi.AzureNative.DevCenter.ProjectArgs @selfRef, global::Pulumi.AzureNative.DevCenter.Inputs.ManagedServiceIdentityArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevCenter.ProjectArgs WithIdentity(this global::Pulumi.AzureNative.DevCenter.ProjectArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DevCenter.Inputs.ManagedServiceIdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DevCenter.Inputs.ManagedServiceIdentityArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevCenter.ProjectArgs WithLocation(this global::Pulumi.AzureNative.DevCenter.ProjectArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevCenter.ProjectArgs WithMaxDevBoxesPerUser(this global::Pulumi.AzureNative.DevCenter.ProjectArgs @selfRef, global::System.Int32 maxDevBoxesPerUser)
    {
        @selfRef.MaxDevBoxesPerUser = maxDevBoxesPerUser;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevCenter.ProjectArgs WithProjectName(this global::Pulumi.AzureNative.DevCenter.ProjectArgs @selfRef, global::System.String projectName)
    {
        @selfRef.ProjectName = projectName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevCenter.ProjectArgs WithResourceGroupName(this global::Pulumi.AzureNative.DevCenter.ProjectArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevCenter.ProjectArgs WithTags(this global::Pulumi.AzureNative.DevCenter.ProjectArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevCenter.ProjectArgs WithTags(this global::Pulumi.AzureNative.DevCenter.ProjectArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevCenter.ProjectArgs WithTags(this global::Pulumi.AzureNative.DevCenter.ProjectArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
