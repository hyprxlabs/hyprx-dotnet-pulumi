// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class AwsRoute53ResourceRecordSetPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithAliasTarget(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.AliasTargetArgs aliasTarget)
    {
        @selfRef.AliasTarget = aliasTarget;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithAliasTarget(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.AliasTargetArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.AliasTargetArgs();
        @configure(@item);
        @selfRef.AliasTarget = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithCidrRoutingConfig(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.CidrRoutingConfigArgs cidrRoutingConfig)
    {
        @selfRef.CidrRoutingConfig = cidrRoutingConfig;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithCidrRoutingConfig(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.CidrRoutingConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.CidrRoutingConfigArgs();
        @configure(@item);
        @selfRef.CidrRoutingConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithFailover(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.ResourceRecordSetFailoverEnumValueArgs failover)
    {
        @selfRef.Failover = failover;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithFailover(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.ResourceRecordSetFailoverEnumValueArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.ResourceRecordSetFailoverEnumValueArgs();
        @configure(@item);
        @selfRef.Failover = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithGeoLocation(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.GeoLocationArgs geoLocation)
    {
        @selfRef.GeoLocation = geoLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithGeoLocation(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.GeoLocationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.GeoLocationArgs();
        @configure(@item);
        @selfRef.GeoLocation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithGeoProximityLocation(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.GeoProximityLocationArgs geoProximityLocation)
    {
        @selfRef.GeoProximityLocation = geoProximityLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithGeoProximityLocation(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.GeoProximityLocationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.GeoProximityLocationArgs();
        @configure(@item);
        @selfRef.GeoProximityLocation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithHealthCheckId(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::System.String healthCheckId)
    {
        @selfRef.HealthCheckId = healthCheckId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithMultiValueAnswer(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, bool multiValueAnswer = true)
    {
        @selfRef.MultiValueAnswer = multiValueAnswer;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithName(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithRegion(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.ResourceRecordSetRegionEnumValueArgs region)
    {
        @selfRef.Region = region;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithRegion(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.ResourceRecordSetRegionEnumValueArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.ResourceRecordSetRegionEnumValueArgs();
        @configure(@item);
        @selfRef.Region = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithResourceRecords(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.ResourceRecordArgs> resourceRecords)
    {
        @selfRef.ResourceRecords = resourceRecords;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithResourceRecords(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.ResourceRecordArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.ResourceRecordArgs>();
        @configure(@list);
        @selfRef.ResourceRecords = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithResourceRecords(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.ResourceRecordArgs>> @create)
    {
        @selfRef.ResourceRecords = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithSetIdentifier(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::System.String setIdentifier)
    {
        @selfRef.SetIdentifier = setIdentifier;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithTrafficPolicyInstanceId(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::System.String trafficPolicyInstanceId)
    {
        @selfRef.TrafficPolicyInstanceId = trafficPolicyInstanceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithTtl(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::System.Double ttl)
    {
        @selfRef.Ttl = ttl;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithType(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.RRTypeEnumValueArgs type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithType(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.RRTypeEnumValueArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.RRTypeEnumValueArgs();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs WithWeight(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRoute53ResourceRecordSetPropertiesArgs @selfRef, global::System.Double weight)
    {
        @selfRef.Weight = weight;
        return @selfRef;
    }

}
