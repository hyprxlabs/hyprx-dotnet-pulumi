// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ExtendedLocation;

public static partial class CustomLocationArgsExtensions
{
    public static global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs WithAuthentication(this global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs @selfRef, global::Pulumi.AzureNative.ExtendedLocation.Inputs.CustomLocationPropertiesAuthenticationArgs authentication)
    {
        @selfRef.Authentication = authentication;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs WithAuthentication(this global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ExtendedLocation.Inputs.CustomLocationPropertiesAuthenticationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ExtendedLocation.Inputs.CustomLocationPropertiesAuthenticationArgs();
        @configure(@item);
        @selfRef.Authentication = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs WithClusterExtensionIds(this global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs @selfRef, global::System.Collections.Generic.List<global::System.String> clusterExtensionIds)
    {
        @selfRef.ClusterExtensionIds = clusterExtensionIds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs WithClusterExtensionIds(this global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ClusterExtensionIds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs WithClusterExtensionIds(this global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ClusterExtensionIds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs WithDisplayName(this global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs @selfRef, global::System.String displayName)
    {
        @selfRef.DisplayName = displayName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs WithHostResourceId(this global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs @selfRef, global::System.String hostResourceId)
    {
        @selfRef.HostResourceId = hostResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs WithHostType(this global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ExtendedLocation.HostType> hostType)
    {
        @selfRef.HostType = hostType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs WithIdentity(this global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs @selfRef, global::Pulumi.AzureNative.ExtendedLocation.Inputs.IdentityArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs WithIdentity(this global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ExtendedLocation.Inputs.IdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ExtendedLocation.Inputs.IdentityArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs WithLocation(this global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs WithNamespace(this global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs @selfRef, global::System.String @namespace)
    {
        @selfRef.Namespace = @namespace;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs WithProvisioningState(this global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs @selfRef, global::System.String provisioningState)
    {
        @selfRef.ProvisioningState = provisioningState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs WithResourceGroupName(this global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs WithResourceName(this global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs @selfRef, global::System.String resourceName)
    {
        @selfRef.ResourceName = resourceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs WithTags(this global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs WithTags(this global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs WithTags(this global::Pulumi.AzureNative.ExtendedLocation.CustomLocationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
