// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.App.Inputs;

namespace Pulumi.AzureNative.App;

public static partial class JavaComponentPropertiesScaleArgsExtensions
{
    public static global::Pulumi.AzureNative.App.Inputs.JavaComponentPropertiesScaleArgs WithMaxReplicas(this global::Pulumi.AzureNative.App.Inputs.JavaComponentPropertiesScaleArgs @selfRef, global::System.Int32 maxReplicas)
    {
        @selfRef.MaxReplicas = maxReplicas;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.JavaComponentPropertiesScaleArgs WithMinReplicas(this global::Pulumi.AzureNative.App.Inputs.JavaComponentPropertiesScaleArgs @selfRef, global::System.Int32 minReplicas)
    {
        @selfRef.MinReplicas = minReplicas;
        return @selfRef;
    }

}
