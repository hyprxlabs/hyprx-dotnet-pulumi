// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class DataAutomationProjectOverrideConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectOverrideConfigurationArgs WithAudio(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectOverrideConfigurationArgs @selfRef, global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectAudioOverrideConfigurationArgs audio)
    {
        @selfRef.Audio = audio;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectOverrideConfigurationArgs WithAudio(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectOverrideConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectAudioOverrideConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectAudioOverrideConfigurationArgs();
        @configure(@item);
        @selfRef.Audio = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectOverrideConfigurationArgs WithDocument(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectOverrideConfigurationArgs @selfRef, global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentOverrideConfigurationArgs document)
    {
        @selfRef.Document = document;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectOverrideConfigurationArgs WithDocument(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectOverrideConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentOverrideConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentOverrideConfigurationArgs();
        @configure(@item);
        @selfRef.Document = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectOverrideConfigurationArgs WithImage(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectOverrideConfigurationArgs @selfRef, global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectImageOverrideConfigurationArgs image)
    {
        @selfRef.Image = image;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectOverrideConfigurationArgs WithImage(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectOverrideConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectImageOverrideConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectImageOverrideConfigurationArgs();
        @configure(@item);
        @selfRef.Image = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectOverrideConfigurationArgs WithModalityRouting(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectOverrideConfigurationArgs @selfRef, global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectModalityRoutingConfigurationArgs modalityRouting)
    {
        @selfRef.ModalityRouting = modalityRouting;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectOverrideConfigurationArgs WithModalityRouting(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectOverrideConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectModalityRoutingConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectModalityRoutingConfigurationArgs();
        @configure(@item);
        @selfRef.ModalityRouting = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectOverrideConfigurationArgs WithVideo(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectOverrideConfigurationArgs @selfRef, global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectVideoOverrideConfigurationArgs video)
    {
        @selfRef.Video = video;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectOverrideConfigurationArgs WithVideo(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectOverrideConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectVideoOverrideConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectVideoOverrideConfigurationArgs();
        @configure(@item);
        @selfRef.Video = @item;
        return @selfRef;
    }

}
