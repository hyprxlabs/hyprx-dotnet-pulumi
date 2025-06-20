// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class ScaleSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ScaleSettingsArgs WithMaxNodeCount(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ScaleSettingsArgs @selfRef, global::System.Int32 maxNodeCount)
    {
        @selfRef.MaxNodeCount = maxNodeCount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ScaleSettingsArgs WithMinNodeCount(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ScaleSettingsArgs @selfRef, global::System.Int32 minNodeCount)
    {
        @selfRef.MinNodeCount = minNodeCount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ScaleSettingsArgs WithNodeIdleTimeBeforeScaleDown(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ScaleSettingsArgs @selfRef, global::System.String nodeIdleTimeBeforeScaleDown)
    {
        @selfRef.NodeIdleTimeBeforeScaleDown = nodeIdleTimeBeforeScaleDown;
        return @selfRef;
    }

}
