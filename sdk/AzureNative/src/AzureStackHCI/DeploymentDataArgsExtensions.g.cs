// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AzureStackHCI.Inputs;

namespace Pulumi.AzureNative.AzureStackHCI;

public static partial class DeploymentDataArgsExtensions
{
    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithAdouPath(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::System.String adouPath)
    {
        @selfRef.AdouPath = adouPath;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithCluster(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentClusterArgs cluster)
    {
        @selfRef.Cluster = cluster;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithCluster(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentClusterArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentClusterArgs();
        @configure(@item);
        @selfRef.Cluster = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithDomainFqdn(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::System.String domainFqdn)
    {
        @selfRef.DomainFqdn = domainFqdn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithHostNetwork(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::Pulumi.AzureNative.AzureStackHCI.Inputs.HostNetworkArgs hostNetwork)
    {
        @selfRef.HostNetwork = hostNetwork;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithHostNetwork(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureStackHCI.Inputs.HostNetworkArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureStackHCI.Inputs.HostNetworkArgs();
        @configure(@item);
        @selfRef.HostNetwork = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithInfrastructureNetwork(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AzureStackHCI.Inputs.InfrastructureNetworkArgs> infrastructureNetwork)
    {
        @selfRef.InfrastructureNetwork = infrastructureNetwork;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithInfrastructureNetwork(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AzureStackHCI.Inputs.InfrastructureNetworkArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AzureStackHCI.Inputs.InfrastructureNetworkArgs>();
        @configure(@list);
        @selfRef.InfrastructureNetwork = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithInfrastructureNetwork(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AzureStackHCI.Inputs.InfrastructureNetworkArgs>> @create)
    {
        @selfRef.InfrastructureNetwork = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithNamingPrefix(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::System.String namingPrefix)
    {
        @selfRef.NamingPrefix = namingPrefix;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithObservability(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::Pulumi.AzureNative.AzureStackHCI.Inputs.ObservabilityArgs observability)
    {
        @selfRef.Observability = observability;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithObservability(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureStackHCI.Inputs.ObservabilityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureStackHCI.Inputs.ObservabilityArgs();
        @configure(@item);
        @selfRef.Observability = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithOptionalServices(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::Pulumi.AzureNative.AzureStackHCI.Inputs.OptionalServicesArgs optionalServices)
    {
        @selfRef.OptionalServices = optionalServices;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithOptionalServices(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureStackHCI.Inputs.OptionalServicesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureStackHCI.Inputs.OptionalServicesArgs();
        @configure(@item);
        @selfRef.OptionalServices = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithPhysicalNodes(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AzureStackHCI.Inputs.PhysicalNodesArgs> physicalNodes)
    {
        @selfRef.PhysicalNodes = physicalNodes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithPhysicalNodes(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AzureStackHCI.Inputs.PhysicalNodesArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AzureStackHCI.Inputs.PhysicalNodesArgs>();
        @configure(@list);
        @selfRef.PhysicalNodes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithPhysicalNodes(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AzureStackHCI.Inputs.PhysicalNodesArgs>> @create)
    {
        @selfRef.PhysicalNodes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithSdnIntegration(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::Pulumi.AzureNative.AzureStackHCI.Inputs.SdnIntegrationArgs sdnIntegration)
    {
        @selfRef.SdnIntegration = sdnIntegration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithSdnIntegration(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureStackHCI.Inputs.SdnIntegrationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureStackHCI.Inputs.SdnIntegrationArgs();
        @configure(@item);
        @selfRef.SdnIntegration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithSecrets(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AzureStackHCI.Inputs.EceDeploymentSecretsArgs> secrets)
    {
        @selfRef.Secrets = secrets;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithSecrets(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AzureStackHCI.Inputs.EceDeploymentSecretsArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AzureStackHCI.Inputs.EceDeploymentSecretsArgs>();
        @configure(@list);
        @selfRef.Secrets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithSecrets(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AzureStackHCI.Inputs.EceDeploymentSecretsArgs>> @create)
    {
        @selfRef.Secrets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithSecretsLocation(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::System.String secretsLocation)
    {
        @selfRef.SecretsLocation = secretsLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithSecuritySettings(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs securitySettings)
    {
        @selfRef.SecuritySettings = securitySettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithSecuritySettings(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentSecuritySettingsArgs();
        @configure(@item);
        @selfRef.SecuritySettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithStorage(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::Pulumi.AzureNative.AzureStackHCI.Inputs.StorageArgs storage)
    {
        @selfRef.Storage = storage;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs WithStorage(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.DeploymentDataArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureStackHCI.Inputs.StorageArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureStackHCI.Inputs.StorageArgs();
        @configure(@item);
        @selfRef.Storage = @item;
        return @selfRef;
    }

}
