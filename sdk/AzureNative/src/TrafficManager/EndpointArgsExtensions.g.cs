// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.TrafficManager.Inputs;

namespace Pulumi.AzureNative.TrafficManager;

public static partial class EndpointArgsExtensions
{
    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithAlwaysServe(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.TrafficManager.AlwaysServe> alwaysServe)
    {
        @selfRef.AlwaysServe = alwaysServe;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithCustomHeaders(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointPropertiesCustomHeadersArgs> customHeaders)
    {
        @selfRef.CustomHeaders = customHeaders;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithCustomHeaders(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointPropertiesCustomHeadersArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointPropertiesCustomHeadersArgs>();
        @configure(@list);
        @selfRef.CustomHeaders = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithCustomHeaders(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointPropertiesCustomHeadersArgs>> @create)
    {
        @selfRef.CustomHeaders = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithEndpointLocation(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::System.String endpointLocation)
    {
        @selfRef.EndpointLocation = endpointLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithEndpointMonitorStatus(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.TrafficManager.EndpointMonitorStatus> endpointMonitorStatus)
    {
        @selfRef.EndpointMonitorStatus = endpointMonitorStatus;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithEndpointStatus(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.TrafficManager.EndpointStatus> endpointStatus)
    {
        @selfRef.EndpointStatus = endpointStatus;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithGeoMapping(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::System.Collections.Generic.List<global::System.String> geoMapping)
    {
        @selfRef.GeoMapping = geoMapping;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithGeoMapping(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.GeoMapping = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithGeoMapping(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.GeoMapping = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithId(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithMinChildEndpoints(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::System.Double minChildEndpoints)
    {
        @selfRef.MinChildEndpoints = minChildEndpoints;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithMinChildEndpointsIPv4(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::System.Double minChildEndpointsIPv4)
    {
        @selfRef.MinChildEndpointsIPv4 = minChildEndpointsIPv4;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithMinChildEndpointsIPv6(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::System.Double minChildEndpointsIPv6)
    {
        @selfRef.MinChildEndpointsIPv6 = minChildEndpointsIPv6;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithName(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithPriority(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::System.Double priority)
    {
        @selfRef.Priority = priority;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithSubnets(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointPropertiesSubnetsArgs> subnets)
    {
        @selfRef.Subnets = subnets;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithSubnets(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointPropertiesSubnetsArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointPropertiesSubnetsArgs>();
        @configure(@list);
        @selfRef.Subnets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithSubnets(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointPropertiesSubnetsArgs>> @create)
    {
        @selfRef.Subnets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithTarget(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::System.String target)
    {
        @selfRef.Target = target;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithTargetResourceId(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::System.String targetResourceId)
    {
        @selfRef.TargetResourceId = targetResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithType(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs WithWeight(this global::Pulumi.AzureNative.TrafficManager.Inputs.EndpointArgs @selfRef, global::System.Double weight)
    {
        @selfRef.Weight = weight;
        return @selfRef;
    }

}
