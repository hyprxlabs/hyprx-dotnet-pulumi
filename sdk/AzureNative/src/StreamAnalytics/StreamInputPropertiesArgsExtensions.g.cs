// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.StreamAnalytics.Inputs;

namespace Pulumi.AzureNative.StreamAnalytics;

public static partial class StreamInputPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.StreamAnalytics.Inputs.StreamInputPropertiesArgs WithCompression(this global::Pulumi.AzureNative.StreamAnalytics.Inputs.StreamInputPropertiesArgs @selfRef, global::Pulumi.AzureNative.StreamAnalytics.Inputs.CompressionArgs compression)
    {
        @selfRef.Compression = compression;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StreamAnalytics.Inputs.StreamInputPropertiesArgs WithCompression(this global::Pulumi.AzureNative.StreamAnalytics.Inputs.StreamInputPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.StreamAnalytics.Inputs.CompressionArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.StreamAnalytics.Inputs.CompressionArgs();
        @configure(@item);
        @selfRef.Compression = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StreamAnalytics.Inputs.StreamInputPropertiesArgs WithPartitionKey(this global::Pulumi.AzureNative.StreamAnalytics.Inputs.StreamInputPropertiesArgs @selfRef, global::System.String partitionKey)
    {
        @selfRef.PartitionKey = partitionKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StreamAnalytics.Inputs.StreamInputPropertiesArgs WithType(this global::Pulumi.AzureNative.StreamAnalytics.Inputs.StreamInputPropertiesArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
