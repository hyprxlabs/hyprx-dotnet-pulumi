// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class FlowRetrievalFlowNodeServiceConfigurationPropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.FlowRetrievalFlowNodeServiceConfigurationPropertiesArgs WithS3(this global::Pulumi.AwsNative.Bedrock.Inputs.FlowRetrievalFlowNodeServiceConfigurationPropertiesArgs @selfRef, global::Pulumi.AwsNative.Bedrock.Inputs.FlowRetrievalFlowNodeS3ConfigurationArgs s3)
    {
        @selfRef.S3 = s3;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.FlowRetrievalFlowNodeServiceConfigurationPropertiesArgs WithS3(this global::Pulumi.AwsNative.Bedrock.Inputs.FlowRetrievalFlowNodeServiceConfigurationPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.Inputs.FlowRetrievalFlowNodeS3ConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Bedrock.Inputs.FlowRetrievalFlowNodeS3ConfigurationArgs();
        @configure(@item);
        @selfRef.S3 = @item;
        return @selfRef;
    }

}
