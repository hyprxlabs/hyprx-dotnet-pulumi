// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DeviceRegistry.Inputs;

namespace Pulumi.AzureNative.DeviceRegistry;

public static partial class TopicArgsExtensions
{
    public static global::Pulumi.AzureNative.DeviceRegistry.Inputs.TopicArgs WithPath(this global::Pulumi.AzureNative.DeviceRegistry.Inputs.TopicArgs @selfRef, global::System.String path)
    {
        @selfRef.Path = path;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceRegistry.Inputs.TopicArgs WithRetain(this global::Pulumi.AzureNative.DeviceRegistry.Inputs.TopicArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DeviceRegistry.TopicRetainType> retain)
    {
        @selfRef.Retain = retain;
        return @selfRef;
    }

}
