// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Network;

public static partial class ExpressRouteCircuitArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithAllowClassicOperations(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, bool allowClassicOperations = true)
    {
        @selfRef.AllowClassicOperations = allowClassicOperations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithAuthorizationKey(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.String authorizationKey)
    {
        @selfRef.AuthorizationKey = authorizationKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithAuthorizations(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ExpressRouteCircuitAuthorizationArgs> authorizations)
    {
        @selfRef.Authorizations = authorizations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithAuthorizations(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ExpressRouteCircuitAuthorizationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ExpressRouteCircuitAuthorizationArgs>();
        @configure(@list);
        @selfRef.Authorizations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithAuthorizations(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.ExpressRouteCircuitAuthorizationArgs>> @create)
    {
        @selfRef.Authorizations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithBandwidthInGbps(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.Double bandwidthInGbps)
    {
        @selfRef.BandwidthInGbps = bandwidthInGbps;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithCircuitName(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.String circuitName)
    {
        @selfRef.CircuitName = circuitName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithCircuitProvisioningState(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.String circuitProvisioningState)
    {
        @selfRef.CircuitProvisioningState = circuitProvisioningState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithEnableDirectPortRateLimit(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, bool enableDirectPortRateLimit = true)
    {
        @selfRef.EnableDirectPortRateLimit = enableDirectPortRateLimit;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithExpressRoutePort(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs expressRoutePort)
    {
        @selfRef.ExpressRoutePort = expressRoutePort;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithExpressRoutePort(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.ExpressRoutePort = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithGatewayManagerEtag(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.String gatewayManagerEtag)
    {
        @selfRef.GatewayManagerEtag = gatewayManagerEtag;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithGlobalReachEnabled(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, bool globalReachEnabled = true)
    {
        @selfRef.GlobalReachEnabled = globalReachEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithId(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithLocation(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithPeerings(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ExpressRouteCircuitPeeringArgs> peerings)
    {
        @selfRef.Peerings = peerings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithPeerings(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ExpressRouteCircuitPeeringArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ExpressRouteCircuitPeeringArgs>();
        @configure(@list);
        @selfRef.Peerings = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithPeerings(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.ExpressRouteCircuitPeeringArgs>> @create)
    {
        @selfRef.Peerings = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithResourceGroupName(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithServiceKey(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.String serviceKey)
    {
        @selfRef.ServiceKey = serviceKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithServiceProviderNotes(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.String serviceProviderNotes)
    {
        @selfRef.ServiceProviderNotes = serviceProviderNotes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithServiceProviderProperties(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.ExpressRouteCircuitServiceProviderPropertiesArgs serviceProviderProperties)
    {
        @selfRef.ServiceProviderProperties = serviceProviderProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithServiceProviderProperties(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.ExpressRouteCircuitServiceProviderPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.ExpressRouteCircuitServiceProviderPropertiesArgs();
        @configure(@item);
        @selfRef.ServiceProviderProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithServiceProviderProvisioningState(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.ServiceProviderProvisioningState> serviceProviderProvisioningState)
    {
        @selfRef.ServiceProviderProvisioningState = serviceProviderProvisioningState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithSku(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.ExpressRouteCircuitSkuArgs sku)
    {
        @selfRef.Sku = sku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithSku(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.ExpressRouteCircuitSkuArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.ExpressRouteCircuitSkuArgs();
        @configure(@item);
        @selfRef.Sku = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithTags(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithTags(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs WithTags(this global::Pulumi.AzureNative.Network.ExpressRouteCircuitArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
