// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class ImageArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ImageArgs WithReference(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ImageArgs @selfRef, global::System.String reference)
    {
        @selfRef.Reference = reference;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ImageArgs WithType(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ImageArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.ImageType> type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
