// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class FlowNodeConfiguration9PropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.FlowNodeConfiguration9PropertiesArgs WithIterator(this global::Pulumi.AwsNative.Bedrock.Inputs.FlowNodeConfiguration9PropertiesArgs @selfRef, global::Pulumi.AwsNative.Bedrock.Inputs.FlowIteratorFlowNodeConfigurationArgs iterator)
    {
        @selfRef.Iterator = iterator;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.FlowNodeConfiguration9PropertiesArgs WithIterator(this global::Pulumi.AwsNative.Bedrock.Inputs.FlowNodeConfiguration9PropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.Inputs.FlowIteratorFlowNodeConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Bedrock.Inputs.FlowIteratorFlowNodeConfigurationArgs();
        @configure(@item);
        @selfRef.Iterator = @item;
        return @selfRef;
    }

}
