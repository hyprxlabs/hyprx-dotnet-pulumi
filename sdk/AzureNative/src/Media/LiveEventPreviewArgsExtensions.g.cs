// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Media.Inputs;

namespace Pulumi.AzureNative.Media;

public static partial class LiveEventPreviewArgsExtensions
{
    public static global::Pulumi.AzureNative.Media.Inputs.LiveEventPreviewArgs WithAccessControl(this global::Pulumi.AzureNative.Media.Inputs.LiveEventPreviewArgs @selfRef, global::Pulumi.AzureNative.Media.Inputs.LiveEventPreviewAccessControlArgs accessControl)
    {
        @selfRef.AccessControl = accessControl;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.LiveEventPreviewArgs WithAccessControl(this global::Pulumi.AzureNative.Media.Inputs.LiveEventPreviewArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Media.Inputs.LiveEventPreviewAccessControlArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Media.Inputs.LiveEventPreviewAccessControlArgs();
        @configure(@item);
        @selfRef.AccessControl = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.LiveEventPreviewArgs WithAlternativeMediaId(this global::Pulumi.AzureNative.Media.Inputs.LiveEventPreviewArgs @selfRef, global::System.String alternativeMediaId)
    {
        @selfRef.AlternativeMediaId = alternativeMediaId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.LiveEventPreviewArgs WithEndpoints(this global::Pulumi.AzureNative.Media.Inputs.LiveEventPreviewArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Media.Inputs.LiveEventEndpointArgs> endpoints)
    {
        @selfRef.Endpoints = endpoints;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.LiveEventPreviewArgs WithEndpoints(this global::Pulumi.AzureNative.Media.Inputs.LiveEventPreviewArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Media.Inputs.LiveEventEndpointArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Media.Inputs.LiveEventEndpointArgs>();
        @configure(@list);
        @selfRef.Endpoints = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.LiveEventPreviewArgs WithEndpoints(this global::Pulumi.AzureNative.Media.Inputs.LiveEventPreviewArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Media.Inputs.LiveEventEndpointArgs>> @create)
    {
        @selfRef.Endpoints = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.LiveEventPreviewArgs WithPreviewLocator(this global::Pulumi.AzureNative.Media.Inputs.LiveEventPreviewArgs @selfRef, global::System.String previewLocator)
    {
        @selfRef.PreviewLocator = previewLocator;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.LiveEventPreviewArgs WithStreamingPolicyName(this global::Pulumi.AzureNative.Media.Inputs.LiveEventPreviewArgs @selfRef, global::System.String streamingPolicyName)
    {
        @selfRef.StreamingPolicyName = streamingPolicyName;
        return @selfRef;
    }

}
