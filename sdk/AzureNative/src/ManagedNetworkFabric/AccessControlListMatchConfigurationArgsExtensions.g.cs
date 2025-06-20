// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ManagedNetworkFabric.Inputs;

namespace Pulumi.AzureNative.ManagedNetworkFabric;

public static partial class AccessControlListMatchConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConfigurationArgs WithActions(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListActionArgs> actions)
    {
        @selfRef.Actions = actions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConfigurationArgs WithActions(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListActionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListActionArgs>();
        @configure(@list);
        @selfRef.Actions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConfigurationArgs WithActions(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListActionArgs>> @create)
    {
        @selfRef.Actions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConfigurationArgs WithIpAddressType(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ManagedNetworkFabric.IPAddressType> ipAddressType)
    {
        @selfRef.IpAddressType = ipAddressType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConfigurationArgs WithMatchConditions(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConditionArgs> matchConditions)
    {
        @selfRef.MatchConditions = matchConditions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConfigurationArgs WithMatchConditions(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConditionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConditionArgs>();
        @configure(@list);
        @selfRef.MatchConditions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConfigurationArgs WithMatchConditions(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConditionArgs>> @create)
    {
        @selfRef.MatchConditions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConfigurationArgs WithMatchConfigurationName(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConfigurationArgs @selfRef, global::System.String matchConfigurationName)
    {
        @selfRef.MatchConfigurationName = matchConfigurationName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConfigurationArgs WithSequenceNumber(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AccessControlListMatchConfigurationArgs @selfRef, global::System.Double sequenceNumber)
    {
        @selfRef.SequenceNumber = sequenceNumber;
        return @selfRef;
    }

}
