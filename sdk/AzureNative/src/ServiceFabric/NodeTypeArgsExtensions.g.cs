// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ServiceFabric;

public static partial class NodeTypeArgsExtensions
{
    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithAdditionalDataDisks(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.VmssDataDiskArgs> additionalDataDisks)
    {
        @selfRef.AdditionalDataDisks = additionalDataDisks;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithAdditionalDataDisks(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.VmssDataDiskArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.VmssDataDiskArgs>();
        @configure(@list);
        @selfRef.AdditionalDataDisks = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithAdditionalDataDisks(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ServiceFabric.Inputs.VmssDataDiskArgs>> @create)
    {
        @selfRef.AdditionalDataDisks = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithAdditionalNetworkInterfaceConfigurations(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.AdditionalNetworkInterfaceConfigurationArgs> additionalNetworkInterfaceConfigurations)
    {
        @selfRef.AdditionalNetworkInterfaceConfigurations = additionalNetworkInterfaceConfigurations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithAdditionalNetworkInterfaceConfigurations(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.AdditionalNetworkInterfaceConfigurationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.AdditionalNetworkInterfaceConfigurationArgs>();
        @configure(@list);
        @selfRef.AdditionalNetworkInterfaceConfigurations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithAdditionalNetworkInterfaceConfigurations(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ServiceFabric.Inputs.AdditionalNetworkInterfaceConfigurationArgs>> @create)
    {
        @selfRef.AdditionalNetworkInterfaceConfigurations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithApplicationPorts(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::Pulumi.AzureNative.ServiceFabric.Inputs.EndpointRangeDescriptionArgs applicationPorts)
    {
        @selfRef.ApplicationPorts = applicationPorts;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithApplicationPorts(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ServiceFabric.Inputs.EndpointRangeDescriptionArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ServiceFabric.Inputs.EndpointRangeDescriptionArgs();
        @configure(@item);
        @selfRef.ApplicationPorts = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithCapacities(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> capacities)
    {
        @selfRef.Capacities = capacities;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithCapacities(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Capacities = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithCapacities(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Capacities = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithClusterName(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.String clusterName)
    {
        @selfRef.ClusterName = clusterName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithComputerNamePrefix(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.String computerNamePrefix)
    {
        @selfRef.ComputerNamePrefix = computerNamePrefix;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithDataDiskLetter(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.String dataDiskLetter)
    {
        @selfRef.DataDiskLetter = dataDiskLetter;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithDataDiskSizeGB(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Int32 dataDiskSizeGB)
    {
        @selfRef.DataDiskSizeGB = dataDiskSizeGB;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithDataDiskType(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ServiceFabric.DiskType> dataDiskType)
    {
        @selfRef.DataDiskType = dataDiskType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithDscpConfigurationId(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.String dscpConfigurationId)
    {
        @selfRef.DscpConfigurationId = dscpConfigurationId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithEnableAcceleratedNetworking(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, bool enableAcceleratedNetworking = true)
    {
        @selfRef.EnableAcceleratedNetworking = enableAcceleratedNetworking;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithEnableEncryptionAtHost(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, bool enableEncryptionAtHost = true)
    {
        @selfRef.EnableEncryptionAtHost = enableEncryptionAtHost;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithEnableNodePublicIP(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, bool enableNodePublicIP = true)
    {
        @selfRef.EnableNodePublicIP = enableNodePublicIP;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithEnableNodePublicIPv6(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, bool enableNodePublicIPv6 = true)
    {
        @selfRef.EnableNodePublicIPv6 = enableNodePublicIPv6;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithEnableOverProvisioning(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, bool enableOverProvisioning = true)
    {
        @selfRef.EnableOverProvisioning = enableOverProvisioning;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithEphemeralPorts(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::Pulumi.AzureNative.ServiceFabric.Inputs.EndpointRangeDescriptionArgs ephemeralPorts)
    {
        @selfRef.EphemeralPorts = ephemeralPorts;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithEphemeralPorts(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ServiceFabric.Inputs.EndpointRangeDescriptionArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ServiceFabric.Inputs.EndpointRangeDescriptionArgs();
        @configure(@item);
        @selfRef.EphemeralPorts = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithEvictionPolicy(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ServiceFabric.EvictionPolicyType> evictionPolicy)
    {
        @selfRef.EvictionPolicy = evictionPolicy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithFrontendConfigurations(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.FrontendConfigurationArgs> frontendConfigurations)
    {
        @selfRef.FrontendConfigurations = frontendConfigurations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithFrontendConfigurations(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.FrontendConfigurationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.FrontendConfigurationArgs>();
        @configure(@list);
        @selfRef.FrontendConfigurations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithFrontendConfigurations(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ServiceFabric.Inputs.FrontendConfigurationArgs>> @create)
    {
        @selfRef.FrontendConfigurations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithHostGroupId(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.String hostGroupId)
    {
        @selfRef.HostGroupId = hostGroupId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithIsPrimary(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, bool isPrimary = true)
    {
        @selfRef.IsPrimary = isPrimary;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithIsSpotVM(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, bool isSpotVM = true)
    {
        @selfRef.IsSpotVM = isSpotVM;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithIsStateless(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, bool isStateless = true)
    {
        @selfRef.IsStateless = isStateless;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithMultiplePlacementGroups(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, bool multiplePlacementGroups = true)
    {
        @selfRef.MultiplePlacementGroups = multiplePlacementGroups;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithNatConfigurations(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.NodeTypeNatConfigArgs> natConfigurations)
    {
        @selfRef.NatConfigurations = natConfigurations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithNatConfigurations(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.NodeTypeNatConfigArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.NodeTypeNatConfigArgs>();
        @configure(@list);
        @selfRef.NatConfigurations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithNatConfigurations(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ServiceFabric.Inputs.NodeTypeNatConfigArgs>> @create)
    {
        @selfRef.NatConfigurations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithNatGatewayId(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.String natGatewayId)
    {
        @selfRef.NatGatewayId = natGatewayId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithNetworkSecurityRules(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.NetworkSecurityRuleArgs> networkSecurityRules)
    {
        @selfRef.NetworkSecurityRules = networkSecurityRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithNetworkSecurityRules(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.NetworkSecurityRuleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.NetworkSecurityRuleArgs>();
        @configure(@list);
        @selfRef.NetworkSecurityRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithNetworkSecurityRules(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ServiceFabric.Inputs.NetworkSecurityRuleArgs>> @create)
    {
        @selfRef.NetworkSecurityRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithNodeTypeName(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.String nodeTypeName)
    {
        @selfRef.NodeTypeName = nodeTypeName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithPlacementProperties(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> placementProperties)
    {
        @selfRef.PlacementProperties = placementProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithPlacementProperties(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.PlacementProperties = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithPlacementProperties(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.PlacementProperties = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithResourceGroupName(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithSecureBootEnabled(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, bool secureBootEnabled = true)
    {
        @selfRef.SecureBootEnabled = secureBootEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithSecurityType(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ServiceFabric.SecurityType> securityType)
    {
        @selfRef.SecurityType = securityType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithServiceArtifactReferenceId(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.String serviceArtifactReferenceId)
    {
        @selfRef.ServiceArtifactReferenceId = serviceArtifactReferenceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithSku(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::Pulumi.AzureNative.ServiceFabric.Inputs.NodeTypeSkuArgs sku)
    {
        @selfRef.Sku = sku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithSku(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ServiceFabric.Inputs.NodeTypeSkuArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ServiceFabric.Inputs.NodeTypeSkuArgs();
        @configure(@item);
        @selfRef.Sku = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithSpotRestoreTimeout(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.String spotRestoreTimeout)
    {
        @selfRef.SpotRestoreTimeout = spotRestoreTimeout;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithSubnetId(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.String subnetId)
    {
        @selfRef.SubnetId = subnetId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithTags(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithTags(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithTags(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithUseDefaultPublicLoadBalancer(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, bool useDefaultPublicLoadBalancer = true)
    {
        @selfRef.UseDefaultPublicLoadBalancer = useDefaultPublicLoadBalancer;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithUseEphemeralOSDisk(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, bool useEphemeralOSDisk = true)
    {
        @selfRef.UseEphemeralOSDisk = useEphemeralOSDisk;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithUseTempDataDisk(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, bool useTempDataDisk = true)
    {
        @selfRef.UseTempDataDisk = useTempDataDisk;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithVmExtensions(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.VMSSExtensionArgs> vmExtensions)
    {
        @selfRef.VmExtensions = vmExtensions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithVmExtensions(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.VMSSExtensionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.VMSSExtensionArgs>();
        @configure(@list);
        @selfRef.VmExtensions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithVmExtensions(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ServiceFabric.Inputs.VMSSExtensionArgs>> @create)
    {
        @selfRef.VmExtensions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithVmImageOffer(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.String vmImageOffer)
    {
        @selfRef.VmImageOffer = vmImageOffer;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithVmImagePlan(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::Pulumi.AzureNative.ServiceFabric.Inputs.VmImagePlanArgs vmImagePlan)
    {
        @selfRef.VmImagePlan = vmImagePlan;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithVmImagePlan(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ServiceFabric.Inputs.VmImagePlanArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ServiceFabric.Inputs.VmImagePlanArgs();
        @configure(@item);
        @selfRef.VmImagePlan = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithVmImagePublisher(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.String vmImagePublisher)
    {
        @selfRef.VmImagePublisher = vmImagePublisher;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithVmImageResourceId(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.String vmImageResourceId)
    {
        @selfRef.VmImageResourceId = vmImageResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithVmImageSku(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.String vmImageSku)
    {
        @selfRef.VmImageSku = vmImageSku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithVmImageVersion(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.String vmImageVersion)
    {
        @selfRef.VmImageVersion = vmImageVersion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithVmInstanceCount(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Int32 vmInstanceCount)
    {
        @selfRef.VmInstanceCount = vmInstanceCount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithVmManagedIdentity(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::Pulumi.AzureNative.ServiceFabric.Inputs.VmManagedIdentityArgs vmManagedIdentity)
    {
        @selfRef.VmManagedIdentity = vmManagedIdentity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithVmManagedIdentity(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ServiceFabric.Inputs.VmManagedIdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ServiceFabric.Inputs.VmManagedIdentityArgs();
        @configure(@item);
        @selfRef.VmManagedIdentity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithVmSecrets(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.VaultSecretGroupArgs> vmSecrets)
    {
        @selfRef.VmSecrets = vmSecrets;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithVmSecrets(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.VaultSecretGroupArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.VaultSecretGroupArgs>();
        @configure(@list);
        @selfRef.VmSecrets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithVmSecrets(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ServiceFabric.Inputs.VaultSecretGroupArgs>> @create)
    {
        @selfRef.VmSecrets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithVmSetupActions(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ServiceFabric.VmSetupAction>> vmSetupActions)
    {
        @selfRef.VmSetupActions = vmSetupActions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithVmSetupActions(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ServiceFabric.VmSetupAction>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ServiceFabric.VmSetupAction>>();
        @configure(@list);
        @selfRef.VmSetupActions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithVmSetupActions(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ServiceFabric.VmSetupAction>>> @create)
    {
        @selfRef.VmSetupActions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithVmSharedGalleryImageId(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.String vmSharedGalleryImageId)
    {
        @selfRef.VmSharedGalleryImageId = vmSharedGalleryImageId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithVmSize(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.String vmSize)
    {
        @selfRef.VmSize = vmSize;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithZones(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Collections.Generic.List<global::System.String> zones)
    {
        @selfRef.Zones = zones;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithZones(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Zones = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs WithZones(this global::Pulumi.AzureNative.ServiceFabric.NodeTypeArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Zones = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
