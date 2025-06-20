// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class ServiceEndpointPolicyDefinitionArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.ServiceEndpointPolicyDefinitionArgs WithDescription(this global::Pulumi.AzureNative.Network.Inputs.ServiceEndpointPolicyDefinitionArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ServiceEndpointPolicyDefinitionArgs WithEtag(this global::Pulumi.AzureNative.Network.Inputs.ServiceEndpointPolicyDefinitionArgs @selfRef, global::System.String etag)
    {
        @selfRef.Etag = etag;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ServiceEndpointPolicyDefinitionArgs WithId(this global::Pulumi.AzureNative.Network.Inputs.ServiceEndpointPolicyDefinitionArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ServiceEndpointPolicyDefinitionArgs WithName(this global::Pulumi.AzureNative.Network.Inputs.ServiceEndpointPolicyDefinitionArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ServiceEndpointPolicyDefinitionArgs WithService(this global::Pulumi.AzureNative.Network.Inputs.ServiceEndpointPolicyDefinitionArgs @selfRef, global::System.String service)
    {
        @selfRef.Service = service;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ServiceEndpointPolicyDefinitionArgs WithServiceResources(this global::Pulumi.AzureNative.Network.Inputs.ServiceEndpointPolicyDefinitionArgs @selfRef, global::System.Collections.Generic.List<global::System.String> serviceResources)
    {
        @selfRef.ServiceResources = serviceResources;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ServiceEndpointPolicyDefinitionArgs WithServiceResources(this global::Pulumi.AzureNative.Network.Inputs.ServiceEndpointPolicyDefinitionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ServiceResources = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ServiceEndpointPolicyDefinitionArgs WithServiceResources(this global::Pulumi.AzureNative.Network.Inputs.ServiceEndpointPolicyDefinitionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ServiceResources = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ServiceEndpointPolicyDefinitionArgs WithType(this global::Pulumi.AzureNative.Network.Inputs.ServiceEndpointPolicyDefinitionArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
