// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Kusto;

public static partial class ClusterArgsExtensions
{
    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithAcceptedAudiences(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Kusto.Inputs.AcceptedAudiencesArgs> acceptedAudiences)
    {
        @selfRef.AcceptedAudiences = acceptedAudiences;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithAcceptedAudiences(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Kusto.Inputs.AcceptedAudiencesArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Kusto.Inputs.AcceptedAudiencesArgs>();
        @configure(@list);
        @selfRef.AcceptedAudiences = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithAcceptedAudiences(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Kusto.Inputs.AcceptedAudiencesArgs>> @create)
    {
        @selfRef.AcceptedAudiences = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithAllowedFqdnList(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Collections.Generic.List<global::System.String> allowedFqdnList)
    {
        @selfRef.AllowedFqdnList = allowedFqdnList;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithAllowedFqdnList(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AllowedFqdnList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithAllowedFqdnList(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AllowedFqdnList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithAllowedIpRangeList(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Collections.Generic.List<global::System.String> allowedIpRangeList)
    {
        @selfRef.AllowedIpRangeList = allowedIpRangeList;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithAllowedIpRangeList(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AllowedIpRangeList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithAllowedIpRangeList(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AllowedIpRangeList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithCalloutPolicies(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Kusto.Inputs.CalloutPolicyArgs> calloutPolicies)
    {
        @selfRef.CalloutPolicies = calloutPolicies;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithCalloutPolicies(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Kusto.Inputs.CalloutPolicyArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Kusto.Inputs.CalloutPolicyArgs>();
        @configure(@list);
        @selfRef.CalloutPolicies = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithCalloutPolicies(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Kusto.Inputs.CalloutPolicyArgs>> @create)
    {
        @selfRef.CalloutPolicies = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithClusterName(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.String clusterName)
    {
        @selfRef.ClusterName = clusterName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithEnableAutoStop(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, bool enableAutoStop = true)
    {
        @selfRef.EnableAutoStop = enableAutoStop;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithEnableDiskEncryption(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, bool enableDiskEncryption = true)
    {
        @selfRef.EnableDiskEncryption = enableDiskEncryption;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithEnableDoubleEncryption(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, bool enableDoubleEncryption = true)
    {
        @selfRef.EnableDoubleEncryption = enableDoubleEncryption;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithEnablePurge(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, bool enablePurge = true)
    {
        @selfRef.EnablePurge = enablePurge;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithEnableStreamingIngest(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, bool enableStreamingIngest = true)
    {
        @selfRef.EnableStreamingIngest = enableStreamingIngest;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithEngineType(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Kusto.EngineType> engineType)
    {
        @selfRef.EngineType = engineType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithIdentity(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::Pulumi.AzureNative.Kusto.Inputs.IdentityArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithIdentity(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Kusto.Inputs.IdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Kusto.Inputs.IdentityArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithKeyVaultProperties(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::Pulumi.AzureNative.Kusto.Inputs.KeyVaultPropertiesArgs keyVaultProperties)
    {
        @selfRef.KeyVaultProperties = keyVaultProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithKeyVaultProperties(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Kusto.Inputs.KeyVaultPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Kusto.Inputs.KeyVaultPropertiesArgs();
        @configure(@item);
        @selfRef.KeyVaultProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithLanguageExtensions(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::Pulumi.AzureNative.Kusto.Inputs.LanguageExtensionsListArgs languageExtensions)
    {
        @selfRef.LanguageExtensions = languageExtensions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithLanguageExtensions(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Kusto.Inputs.LanguageExtensionsListArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Kusto.Inputs.LanguageExtensionsListArgs();
        @configure(@item);
        @selfRef.LanguageExtensions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithLocation(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithOptimizedAutoscale(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::Pulumi.AzureNative.Kusto.Inputs.OptimizedAutoscaleArgs optimizedAutoscale)
    {
        @selfRef.OptimizedAutoscale = optimizedAutoscale;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithOptimizedAutoscale(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Kusto.Inputs.OptimizedAutoscaleArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Kusto.Inputs.OptimizedAutoscaleArgs();
        @configure(@item);
        @selfRef.OptimizedAutoscale = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithPublicIPType(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Kusto.PublicIPType> publicIPType)
    {
        @selfRef.PublicIPType = publicIPType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithPublicNetworkAccess(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Kusto.PublicNetworkAccess> publicNetworkAccess)
    {
        @selfRef.PublicNetworkAccess = publicNetworkAccess;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithResourceGroupName(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithRestrictOutboundNetworkAccess(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Kusto.ClusterNetworkAccessFlag> restrictOutboundNetworkAccess)
    {
        @selfRef.RestrictOutboundNetworkAccess = restrictOutboundNetworkAccess;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithSku(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::Pulumi.AzureNative.Kusto.Inputs.AzureSkuArgs sku)
    {
        @selfRef.Sku = sku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithSku(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Kusto.Inputs.AzureSkuArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Kusto.Inputs.AzureSkuArgs();
        @configure(@item);
        @selfRef.Sku = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithTags(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithTags(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithTags(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithTrustedExternalTenants(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Kusto.Inputs.TrustedExternalTenantArgs> trustedExternalTenants)
    {
        @selfRef.TrustedExternalTenants = trustedExternalTenants;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithTrustedExternalTenants(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Kusto.Inputs.TrustedExternalTenantArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Kusto.Inputs.TrustedExternalTenantArgs>();
        @configure(@list);
        @selfRef.TrustedExternalTenants = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithTrustedExternalTenants(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Kusto.Inputs.TrustedExternalTenantArgs>> @create)
    {
        @selfRef.TrustedExternalTenants = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithVirtualClusterGraduationProperties(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.String virtualClusterGraduationProperties)
    {
        @selfRef.VirtualClusterGraduationProperties = virtualClusterGraduationProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithVirtualNetworkConfiguration(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::Pulumi.AzureNative.Kusto.Inputs.VirtualNetworkConfigurationArgs virtualNetworkConfiguration)
    {
        @selfRef.VirtualNetworkConfiguration = virtualNetworkConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithVirtualNetworkConfiguration(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Kusto.Inputs.VirtualNetworkConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Kusto.Inputs.VirtualNetworkConfigurationArgs();
        @configure(@item);
        @selfRef.VirtualNetworkConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithZones(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Collections.Generic.List<global::System.String> zones)
    {
        @selfRef.Zones = zones;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithZones(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Zones = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.ClusterArgs WithZones(this global::Pulumi.AzureNative.Kusto.ClusterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Zones = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
