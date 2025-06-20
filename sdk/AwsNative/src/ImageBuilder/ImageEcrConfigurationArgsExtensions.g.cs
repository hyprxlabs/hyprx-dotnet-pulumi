// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ImageBuilder.Inputs;

namespace Pulumi.AwsNative.ImageBuilder;

public static partial class ImageEcrConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.ImageEcrConfigurationArgs WithContainerTags(this global::Pulumi.AwsNative.ImageBuilder.Inputs.ImageEcrConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::System.String> containerTags)
    {
        @selfRef.ContainerTags = containerTags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.ImageEcrConfigurationArgs WithContainerTags(this global::Pulumi.AwsNative.ImageBuilder.Inputs.ImageEcrConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ContainerTags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.ImageEcrConfigurationArgs WithContainerTags(this global::Pulumi.AwsNative.ImageBuilder.Inputs.ImageEcrConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ContainerTags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.ImageEcrConfigurationArgs WithRepositoryName(this global::Pulumi.AwsNative.ImageBuilder.Inputs.ImageEcrConfigurationArgs @selfRef, global::System.String repositoryName)
    {
        @selfRef.RepositoryName = repositoryName;
        return @selfRef;
    }

}
