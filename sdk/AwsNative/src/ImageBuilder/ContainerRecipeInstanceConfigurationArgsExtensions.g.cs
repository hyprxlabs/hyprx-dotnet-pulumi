// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ImageBuilder.Inputs;

namespace Pulumi.AwsNative.ImageBuilder;

public static partial class ContainerRecipeInstanceConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.ContainerRecipeInstanceConfigurationArgs WithBlockDeviceMappings(this global::Pulumi.AwsNative.ImageBuilder.Inputs.ContainerRecipeInstanceConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.ImageBuilder.Inputs.ContainerRecipeInstanceBlockDeviceMappingArgs> blockDeviceMappings)
    {
        @selfRef.BlockDeviceMappings = blockDeviceMappings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.ContainerRecipeInstanceConfigurationArgs WithBlockDeviceMappings(this global::Pulumi.AwsNative.ImageBuilder.Inputs.ContainerRecipeInstanceConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.ImageBuilder.Inputs.ContainerRecipeInstanceBlockDeviceMappingArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.ImageBuilder.Inputs.ContainerRecipeInstanceBlockDeviceMappingArgs>();
        @configure(@list);
        @selfRef.BlockDeviceMappings = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.ContainerRecipeInstanceConfigurationArgs WithBlockDeviceMappings(this global::Pulumi.AwsNative.ImageBuilder.Inputs.ContainerRecipeInstanceConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.ImageBuilder.Inputs.ContainerRecipeInstanceBlockDeviceMappingArgs>> @create)
    {
        @selfRef.BlockDeviceMappings = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.ContainerRecipeInstanceConfigurationArgs WithImage(this global::Pulumi.AwsNative.ImageBuilder.Inputs.ContainerRecipeInstanceConfigurationArgs @selfRef, global::System.String image)
    {
        @selfRef.Image = image;
        return @selfRef;
    }

}
