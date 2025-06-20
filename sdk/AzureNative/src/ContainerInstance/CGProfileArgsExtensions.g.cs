// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ContainerInstance;

public static partial class CGProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithConfidentialComputeProperties(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::Pulumi.AzureNative.ContainerInstance.Inputs.ConfidentialComputePropertiesArgs confidentialComputeProperties)
    {
        @selfRef.ConfidentialComputeProperties = confidentialComputeProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithConfidentialComputeProperties(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ContainerInstance.Inputs.ConfidentialComputePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ContainerInstance.Inputs.ConfidentialComputePropertiesArgs();
        @configure(@item);
        @selfRef.ConfidentialComputeProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithContainerGroupProfileName(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.String containerGroupProfileName)
    {
        @selfRef.ContainerGroupProfileName = containerGroupProfileName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithContainers(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerInstance.Inputs.ContainerArgs> containers)
    {
        @selfRef.Containers = containers;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithContainers(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerInstance.Inputs.ContainerArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerInstance.Inputs.ContainerArgs>();
        @configure(@list);
        @selfRef.Containers = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithContainers(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ContainerInstance.Inputs.ContainerArgs>> @create)
    {
        @selfRef.Containers = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithDiagnostics(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::Pulumi.AzureNative.ContainerInstance.Inputs.ContainerGroupDiagnosticsArgs diagnostics)
    {
        @selfRef.Diagnostics = diagnostics;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithDiagnostics(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ContainerInstance.Inputs.ContainerGroupDiagnosticsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ContainerInstance.Inputs.ContainerGroupDiagnosticsArgs();
        @configure(@item);
        @selfRef.Diagnostics = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithEncryptionProperties(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::Pulumi.AzureNative.ContainerInstance.Inputs.EncryptionPropertiesArgs encryptionProperties)
    {
        @selfRef.EncryptionProperties = encryptionProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithEncryptionProperties(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ContainerInstance.Inputs.EncryptionPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ContainerInstance.Inputs.EncryptionPropertiesArgs();
        @configure(@item);
        @selfRef.EncryptionProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithExtensions(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerInstance.Inputs.DeploymentExtensionSpecArgs> extensions)
    {
        @selfRef.Extensions = extensions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithExtensions(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerInstance.Inputs.DeploymentExtensionSpecArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerInstance.Inputs.DeploymentExtensionSpecArgs>();
        @configure(@list);
        @selfRef.Extensions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithExtensions(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ContainerInstance.Inputs.DeploymentExtensionSpecArgs>> @create)
    {
        @selfRef.Extensions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithImageRegistryCredentials(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerInstance.Inputs.ImageRegistryCredentialArgs> imageRegistryCredentials)
    {
        @selfRef.ImageRegistryCredentials = imageRegistryCredentials;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithImageRegistryCredentials(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerInstance.Inputs.ImageRegistryCredentialArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerInstance.Inputs.ImageRegistryCredentialArgs>();
        @configure(@list);
        @selfRef.ImageRegistryCredentials = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithImageRegistryCredentials(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ContainerInstance.Inputs.ImageRegistryCredentialArgs>> @create)
    {
        @selfRef.ImageRegistryCredentials = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithInitContainers(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerInstance.Inputs.InitContainerDefinitionArgs> initContainers)
    {
        @selfRef.InitContainers = initContainers;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithInitContainers(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerInstance.Inputs.InitContainerDefinitionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerInstance.Inputs.InitContainerDefinitionArgs>();
        @configure(@list);
        @selfRef.InitContainers = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithInitContainers(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ContainerInstance.Inputs.InitContainerDefinitionArgs>> @create)
    {
        @selfRef.InitContainers = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithIpAddress(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::Pulumi.AzureNative.ContainerInstance.Inputs.IpAddressArgs ipAddress)
    {
        @selfRef.IpAddress = ipAddress;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithIpAddress(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ContainerInstance.Inputs.IpAddressArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ContainerInstance.Inputs.IpAddressArgs();
        @configure(@item);
        @selfRef.IpAddress = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithLocation(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithOsType(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ContainerInstance.OperatingSystemTypes> osType)
    {
        @selfRef.OsType = osType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithPriority(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ContainerInstance.Priority> priority)
    {
        @selfRef.Priority = priority;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithRegisteredRevisions(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Collections.Generic.List<global::System.Double> registeredRevisions)
    {
        @selfRef.RegisteredRevisions = registeredRevisions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithRegisteredRevisions(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Double>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Double>();
        @configure(@list);
        @selfRef.RegisteredRevisions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithRegisteredRevisions(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Double>> @create)
    {
        @selfRef.RegisteredRevisions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithResourceGroupName(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithRestartPolicy(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ContainerInstance.ContainerGroupRestartPolicy> restartPolicy)
    {
        @selfRef.RestartPolicy = restartPolicy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithRevision(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Double revision)
    {
        @selfRef.Revision = revision;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithSecurityContext(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::Pulumi.AzureNative.ContainerInstance.Inputs.SecurityContextDefinitionArgs securityContext)
    {
        @selfRef.SecurityContext = securityContext;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithSecurityContext(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ContainerInstance.Inputs.SecurityContextDefinitionArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ContainerInstance.Inputs.SecurityContextDefinitionArgs();
        @configure(@item);
        @selfRef.SecurityContext = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithShutdownGracePeriod(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.String shutdownGracePeriod)
    {
        @selfRef.ShutdownGracePeriod = shutdownGracePeriod;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithSku(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ContainerInstance.ContainerGroupSku> sku)
    {
        @selfRef.Sku = sku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithTags(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithTags(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithTags(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithTimeToLive(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.String timeToLive)
    {
        @selfRef.TimeToLive = timeToLive;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithUseKrypton(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, bool useKrypton = true)
    {
        @selfRef.UseKrypton = useKrypton;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithVolumes(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerInstance.Inputs.VolumeArgs> volumes)
    {
        @selfRef.Volumes = volumes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithVolumes(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerInstance.Inputs.VolumeArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerInstance.Inputs.VolumeArgs>();
        @configure(@list);
        @selfRef.Volumes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithVolumes(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ContainerInstance.Inputs.VolumeArgs>> @create)
    {
        @selfRef.Volumes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithZones(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Collections.Generic.List<global::System.String> zones)
    {
        @selfRef.Zones = zones;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithZones(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Zones = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs WithZones(this global::Pulumi.AzureNative.ContainerInstance.CGProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Zones = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
