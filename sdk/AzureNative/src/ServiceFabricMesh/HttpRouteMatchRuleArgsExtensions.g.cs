// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ServiceFabricMesh.Inputs;

namespace Pulumi.AzureNative.ServiceFabricMesh;

public static partial class HttpRouteMatchRuleArgsExtensions
{
    public static global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.HttpRouteMatchRuleArgs WithHeaders(this global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.HttpRouteMatchRuleArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.HttpRouteMatchHeaderArgs> headers)
    {
        @selfRef.Headers = headers;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.HttpRouteMatchRuleArgs WithHeaders(this global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.HttpRouteMatchRuleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.HttpRouteMatchHeaderArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.HttpRouteMatchHeaderArgs>();
        @configure(@list);
        @selfRef.Headers = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.HttpRouteMatchRuleArgs WithHeaders(this global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.HttpRouteMatchRuleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.HttpRouteMatchHeaderArgs>> @create)
    {
        @selfRef.Headers = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.HttpRouteMatchRuleArgs WithPath(this global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.HttpRouteMatchRuleArgs @selfRef, global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.HttpRouteMatchPathArgs path)
    {
        @selfRef.Path = path;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.HttpRouteMatchRuleArgs WithPath(this global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.HttpRouteMatchRuleArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.HttpRouteMatchPathArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.HttpRouteMatchPathArgs();
        @configure(@item);
        @selfRef.Path = @item;
        return @selfRef;
    }

}
