// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class DataAutomationProjectModalityRoutingConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectModalityRoutingConfigurationArgs WithJpeg(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectModalityRoutingConfigurationArgs @selfRef, global::Pulumi.AwsNative.Bedrock.DataAutomationProjectDesiredModality jpeg)
    {
        @selfRef.Jpeg = jpeg;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectModalityRoutingConfigurationArgs WithJpeg(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectModalityRoutingConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.DataAutomationProjectDesiredModality> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Bedrock.DataAutomationProjectDesiredModality>();
        @configure(@item);
        @selfRef.Jpeg = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectModalityRoutingConfigurationArgs WithMov(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectModalityRoutingConfigurationArgs @selfRef, global::Pulumi.AwsNative.Bedrock.DataAutomationProjectDesiredModality mov)
    {
        @selfRef.Mov = mov;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectModalityRoutingConfigurationArgs WithMov(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectModalityRoutingConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.DataAutomationProjectDesiredModality> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Bedrock.DataAutomationProjectDesiredModality>();
        @configure(@item);
        @selfRef.Mov = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectModalityRoutingConfigurationArgs WithMp4(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectModalityRoutingConfigurationArgs @selfRef, global::Pulumi.AwsNative.Bedrock.DataAutomationProjectDesiredModality mp4)
    {
        @selfRef.Mp4 = mp4;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectModalityRoutingConfigurationArgs WithMp4(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectModalityRoutingConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.DataAutomationProjectDesiredModality> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Bedrock.DataAutomationProjectDesiredModality>();
        @configure(@item);
        @selfRef.Mp4 = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectModalityRoutingConfigurationArgs WithPng(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectModalityRoutingConfigurationArgs @selfRef, global::Pulumi.AwsNative.Bedrock.DataAutomationProjectDesiredModality png)
    {
        @selfRef.Png = png;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectModalityRoutingConfigurationArgs WithPng(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectModalityRoutingConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.DataAutomationProjectDesiredModality> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Bedrock.DataAutomationProjectDesiredModality>();
        @configure(@item);
        @selfRef.Png = @item;
        return @selfRef;
    }

}
