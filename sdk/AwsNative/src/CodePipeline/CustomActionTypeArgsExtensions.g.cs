// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.CodePipeline;

public static partial class CustomActionTypeArgsExtensions
{
    public static global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs WithCategory(this global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs @selfRef, global::System.String category)
    {
        @selfRef.Category = category;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs WithConfigurationProperties(this global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.CodePipeline.Inputs.CustomActionTypeConfigurationPropertiesArgs> configurationProperties)
    {
        @selfRef.ConfigurationProperties = configurationProperties;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs WithConfigurationProperties(this global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.CodePipeline.Inputs.CustomActionTypeConfigurationPropertiesArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.CodePipeline.Inputs.CustomActionTypeConfigurationPropertiesArgs>();
        @configure(@list);
        @selfRef.ConfigurationProperties = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs WithConfigurationProperties(this global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.CodePipeline.Inputs.CustomActionTypeConfigurationPropertiesArgs>> @create)
    {
        @selfRef.ConfigurationProperties = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs WithInputArtifactDetails(this global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs @selfRef, global::Pulumi.AwsNative.CodePipeline.Inputs.CustomActionTypeArtifactDetailsArgs inputArtifactDetails)
    {
        @selfRef.InputArtifactDetails = inputArtifactDetails;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs WithInputArtifactDetails(this global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CodePipeline.Inputs.CustomActionTypeArtifactDetailsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.CodePipeline.Inputs.CustomActionTypeArtifactDetailsArgs();
        @configure(@item);
        @selfRef.InputArtifactDetails = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs WithOutputArtifactDetails(this global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs @selfRef, global::Pulumi.AwsNative.CodePipeline.Inputs.CustomActionTypeArtifactDetailsArgs outputArtifactDetails)
    {
        @selfRef.OutputArtifactDetails = outputArtifactDetails;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs WithOutputArtifactDetails(this global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CodePipeline.Inputs.CustomActionTypeArtifactDetailsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.CodePipeline.Inputs.CustomActionTypeArtifactDetailsArgs();
        @configure(@item);
        @selfRef.OutputArtifactDetails = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs WithProvider(this global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs @selfRef, global::System.String provider)
    {
        @selfRef.Provider = provider;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs WithSettings(this global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs @selfRef, global::Pulumi.AwsNative.CodePipeline.Inputs.CustomActionTypeSettingsArgs settings)
    {
        @selfRef.Settings = settings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs WithSettings(this global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CodePipeline.Inputs.CustomActionTypeSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.CodePipeline.Inputs.CustomActionTypeSettingsArgs();
        @configure(@item);
        @selfRef.Settings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs WithTags(this global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs WithTags(this global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs WithTags(this global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs WithVersion(this global::Pulumi.AwsNative.CodePipeline.CustomActionTypeArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
