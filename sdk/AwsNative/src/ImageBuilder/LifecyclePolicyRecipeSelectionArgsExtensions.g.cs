// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ImageBuilder.Inputs;

namespace Pulumi.AwsNative.ImageBuilder;

public static partial class LifecyclePolicyRecipeSelectionArgsExtensions
{
    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.LifecyclePolicyRecipeSelectionArgs WithName(this global::Pulumi.AwsNative.ImageBuilder.Inputs.LifecyclePolicyRecipeSelectionArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.LifecyclePolicyRecipeSelectionArgs WithSemanticVersion(this global::Pulumi.AwsNative.ImageBuilder.Inputs.LifecyclePolicyRecipeSelectionArgs @selfRef, global::System.String semanticVersion)
    {
        @selfRef.SemanticVersion = semanticVersion;
        return @selfRef;
    }

}
