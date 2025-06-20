// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Confluent.Inputs;

namespace Pulumi.AzureNative.Confluent;

public static partial class SCClusterSpecEntityArgsExtensions
{
    public static global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs WithApiEndpoint(this global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs @selfRef, global::System.String apiEndpoint)
    {
        @selfRef.ApiEndpoint = apiEndpoint;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs WithAvailability(this global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs @selfRef, global::System.String availability)
    {
        @selfRef.Availability = availability;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs WithByok(this global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs @selfRef, global::Pulumi.AzureNative.Confluent.Inputs.SCClusterByokEntityArgs byok)
    {
        @selfRef.Byok = byok;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs WithByok(this global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Confluent.Inputs.SCClusterByokEntityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Confluent.Inputs.SCClusterByokEntityArgs();
        @configure(@item);
        @selfRef.Byok = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs WithCloud(this global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs @selfRef, global::System.String cloud)
    {
        @selfRef.Cloud = cloud;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs WithConfig(this global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs @selfRef, global::Pulumi.AzureNative.Confluent.Inputs.ClusterConfigEntityArgs config)
    {
        @selfRef.Config = config;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs WithConfig(this global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Confluent.Inputs.ClusterConfigEntityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Confluent.Inputs.ClusterConfigEntityArgs();
        @configure(@item);
        @selfRef.Config = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs WithEnvironment(this global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs @selfRef, global::Pulumi.AzureNative.Confluent.Inputs.SCClusterNetworkEnvironmentEntityArgs environment)
    {
        @selfRef.Environment = environment;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs WithEnvironment(this global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Confluent.Inputs.SCClusterNetworkEnvironmentEntityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Confluent.Inputs.SCClusterNetworkEnvironmentEntityArgs();
        @configure(@item);
        @selfRef.Environment = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs WithHttpEndpoint(this global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs @selfRef, global::System.String httpEndpoint)
    {
        @selfRef.HttpEndpoint = httpEndpoint;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs WithKafkaBootstrapEndpoint(this global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs @selfRef, global::System.String kafkaBootstrapEndpoint)
    {
        @selfRef.KafkaBootstrapEndpoint = kafkaBootstrapEndpoint;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs WithName(this global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs WithNetwork(this global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs @selfRef, global::Pulumi.AzureNative.Confluent.Inputs.SCClusterNetworkEnvironmentEntityArgs network)
    {
        @selfRef.Network = network;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs WithNetwork(this global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Confluent.Inputs.SCClusterNetworkEnvironmentEntityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Confluent.Inputs.SCClusterNetworkEnvironmentEntityArgs();
        @configure(@item);
        @selfRef.Network = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs WithPackage(this global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Confluent.Package> package)
    {
        @selfRef.Package = package;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs WithRegion(this global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs @selfRef, global::System.String region)
    {
        @selfRef.Region = region;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs WithZone(this global::Pulumi.AzureNative.Confluent.Inputs.SCClusterSpecEntityArgs @selfRef, global::System.String zone)
    {
        @selfRef.Zone = zone;
        return @selfRef;
    }

}
