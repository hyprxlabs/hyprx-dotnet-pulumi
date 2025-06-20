// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ServiceFabric;

public static partial class ManagedClusterApplicationArgsExtensions
{
    public static global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs WithApplicationName(this global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs @selfRef, global::System.String applicationName)
    {
        @selfRef.ApplicationName = applicationName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs WithClusterName(this global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs @selfRef, global::System.String clusterName)
    {
        @selfRef.ClusterName = clusterName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs WithIdentity(this global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs @selfRef, global::Pulumi.AzureNative.ServiceFabric.Inputs.ManagedIdentityArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs WithIdentity(this global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ServiceFabric.Inputs.ManagedIdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ServiceFabric.Inputs.ManagedIdentityArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs WithLocation(this global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs WithManagedIdentities(this global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.ApplicationUserAssignedIdentityArgs> managedIdentities)
    {
        @selfRef.ManagedIdentities = managedIdentities;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs WithManagedIdentities(this global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.ApplicationUserAssignedIdentityArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.ApplicationUserAssignedIdentityArgs>();
        @configure(@list);
        @selfRef.ManagedIdentities = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs WithManagedIdentities(this global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ServiceFabric.Inputs.ApplicationUserAssignedIdentityArgs>> @create)
    {
        @selfRef.ManagedIdentities = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs WithParameters(this global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> parameters)
    {
        @selfRef.Parameters = parameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs WithParameters(this global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Parameters = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs WithParameters(this global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Parameters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs WithResourceGroupName(this global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs WithTags(this global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs WithTags(this global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs WithTags(this global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs WithUpgradePolicy(this global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs @selfRef, global::Pulumi.AzureNative.ServiceFabric.Inputs.ApplicationUpgradePolicyArgs upgradePolicy)
    {
        @selfRef.UpgradePolicy = upgradePolicy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs WithUpgradePolicy(this global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ServiceFabric.Inputs.ApplicationUpgradePolicyArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ServiceFabric.Inputs.ApplicationUpgradePolicyArgs();
        @configure(@item);
        @selfRef.UpgradePolicy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs WithVersion(this global::Pulumi.AzureNative.ServiceFabric.ManagedClusterApplicationArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
