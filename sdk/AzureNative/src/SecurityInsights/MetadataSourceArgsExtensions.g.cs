// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.SecurityInsights.Inputs;

namespace Pulumi.AzureNative.SecurityInsights;

public static partial class MetadataSourceArgsExtensions
{
    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.MetadataSourceArgs WithKind(this global::Pulumi.AzureNative.SecurityInsights.Inputs.MetadataSourceArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.SecurityInsights.SourceKind> kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.MetadataSourceArgs WithName(this global::Pulumi.AzureNative.SecurityInsights.Inputs.MetadataSourceArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.MetadataSourceArgs WithSourceId(this global::Pulumi.AzureNative.SecurityInsights.Inputs.MetadataSourceArgs @selfRef, global::System.String sourceId)
    {
        @selfRef.SourceId = sourceId;
        return @selfRef;
    }

}
