// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.OpenSearchService.Inputs;

namespace Pulumi.AwsNative.OpenSearchService;

public static partial class DomainNodeOptionArgsExtensions
{
    public static global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainNodeOptionArgs WithNodeConfig(this global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainNodeOptionArgs @selfRef, global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainNodeConfigArgs nodeConfig)
    {
        @selfRef.NodeConfig = nodeConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainNodeOptionArgs WithNodeConfig(this global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainNodeOptionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainNodeConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainNodeConfigArgs();
        @configure(@item);
        @selfRef.NodeConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainNodeOptionArgs WithNodeType(this global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainNodeOptionArgs @selfRef, global::Pulumi.AwsNative.OpenSearchService.DomainNodeOptionNodeType nodeType)
    {
        @selfRef.NodeType = nodeType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainNodeOptionArgs WithNodeType(this global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainNodeOptionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.OpenSearchService.DomainNodeOptionNodeType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.OpenSearchService.DomainNodeOptionNodeType>();
        @configure(@item);
        @selfRef.NodeType = @item;
        return @selfRef;
    }

}
