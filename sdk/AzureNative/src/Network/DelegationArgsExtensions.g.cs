// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class DelegationArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.DelegationArgs WithActions(this global::Pulumi.AzureNative.Network.Inputs.DelegationArgs @selfRef, global::System.Collections.Generic.List<global::System.String> actions)
    {
        @selfRef.Actions = actions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.DelegationArgs WithActions(this global::Pulumi.AzureNative.Network.Inputs.DelegationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Actions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.DelegationArgs WithActions(this global::Pulumi.AzureNative.Network.Inputs.DelegationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Actions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.DelegationArgs WithEtag(this global::Pulumi.AzureNative.Network.Inputs.DelegationArgs @selfRef, global::System.String etag)
    {
        @selfRef.Etag = etag;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.DelegationArgs WithId(this global::Pulumi.AzureNative.Network.Inputs.DelegationArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.DelegationArgs WithName(this global::Pulumi.AzureNative.Network.Inputs.DelegationArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.DelegationArgs WithServiceName(this global::Pulumi.AzureNative.Network.Inputs.DelegationArgs @selfRef, global::System.String serviceName)
    {
        @selfRef.ServiceName = serviceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.DelegationArgs WithType(this global::Pulumi.AzureNative.Network.Inputs.DelegationArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
