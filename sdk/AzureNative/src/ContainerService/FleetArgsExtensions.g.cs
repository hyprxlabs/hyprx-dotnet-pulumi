// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ContainerService;

public static partial class FleetArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerService.FleetArgs WithFleetName(this global::Pulumi.AzureNative.ContainerService.FleetArgs @selfRef, global::System.String fleetName)
    {
        @selfRef.FleetName = fleetName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.FleetArgs WithHubProfile(this global::Pulumi.AzureNative.ContainerService.FleetArgs @selfRef, global::Pulumi.AzureNative.ContainerService.Inputs.FleetHubProfileArgs hubProfile)
    {
        @selfRef.HubProfile = hubProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.FleetArgs WithHubProfile(this global::Pulumi.AzureNative.ContainerService.FleetArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ContainerService.Inputs.FleetHubProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ContainerService.Inputs.FleetHubProfileArgs();
        @configure(@item);
        @selfRef.HubProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.FleetArgs WithIdentity(this global::Pulumi.AzureNative.ContainerService.FleetArgs @selfRef, global::Pulumi.AzureNative.ContainerService.Inputs.ManagedServiceIdentityArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.FleetArgs WithIdentity(this global::Pulumi.AzureNative.ContainerService.FleetArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ContainerService.Inputs.ManagedServiceIdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ContainerService.Inputs.ManagedServiceIdentityArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.FleetArgs WithLocation(this global::Pulumi.AzureNative.ContainerService.FleetArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.FleetArgs WithResourceGroupName(this global::Pulumi.AzureNative.ContainerService.FleetArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.FleetArgs WithTags(this global::Pulumi.AzureNative.ContainerService.FleetArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.FleetArgs WithTags(this global::Pulumi.AzureNative.ContainerService.FleetArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.FleetArgs WithTags(this global::Pulumi.AzureNative.ContainerService.FleetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
