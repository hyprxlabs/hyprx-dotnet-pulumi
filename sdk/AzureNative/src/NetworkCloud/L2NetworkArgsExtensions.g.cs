// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.NetworkCloud;

public static partial class L2NetworkArgsExtensions
{
    public static global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs WithExtendedLocation(this global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs @selfRef, global::Pulumi.AzureNative.NetworkCloud.Inputs.ExtendedLocationArgs extendedLocation)
    {
        @selfRef.ExtendedLocation = extendedLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs WithExtendedLocation(this global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.NetworkCloud.Inputs.ExtendedLocationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.NetworkCloud.Inputs.ExtendedLocationArgs();
        @configure(@item);
        @selfRef.ExtendedLocation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs WithHybridAksPluginType(this global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.NetworkCloud.HybridAksPluginType> hybridAksPluginType)
    {
        @selfRef.HybridAksPluginType = hybridAksPluginType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs WithInterfaceName(this global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs @selfRef, global::System.String interfaceName)
    {
        @selfRef.InterfaceName = interfaceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs WithL2IsolationDomainId(this global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs @selfRef, global::System.String l2IsolationDomainId)
    {
        @selfRef.L2IsolationDomainId = l2IsolationDomainId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs WithL2NetworkName(this global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs @selfRef, global::System.String l2NetworkName)
    {
        @selfRef.L2NetworkName = l2NetworkName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs WithLocation(this global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs WithResourceGroupName(this global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs WithTags(this global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs WithTags(this global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs WithTags(this global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
