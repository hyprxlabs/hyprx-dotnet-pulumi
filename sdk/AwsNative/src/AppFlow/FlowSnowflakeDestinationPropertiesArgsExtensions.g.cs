// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AppFlow.Inputs;

namespace Pulumi.AwsNative.AppFlow;

public static partial class FlowSnowflakeDestinationPropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSnowflakeDestinationPropertiesArgs WithBucketPrefix(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSnowflakeDestinationPropertiesArgs @selfRef, global::System.String bucketPrefix)
    {
        @selfRef.BucketPrefix = bucketPrefix;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSnowflakeDestinationPropertiesArgs WithErrorHandlingConfig(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSnowflakeDestinationPropertiesArgs @selfRef, global::Pulumi.AwsNative.AppFlow.Inputs.FlowErrorHandlingConfigArgs errorHandlingConfig)
    {
        @selfRef.ErrorHandlingConfig = errorHandlingConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSnowflakeDestinationPropertiesArgs WithErrorHandlingConfig(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSnowflakeDestinationPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.AppFlow.Inputs.FlowErrorHandlingConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.AppFlow.Inputs.FlowErrorHandlingConfigArgs();
        @configure(@item);
        @selfRef.ErrorHandlingConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSnowflakeDestinationPropertiesArgs WithIntermediateBucketName(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSnowflakeDestinationPropertiesArgs @selfRef, global::System.String intermediateBucketName)
    {
        @selfRef.IntermediateBucketName = intermediateBucketName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSnowflakeDestinationPropertiesArgs WithObject(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSnowflakeDestinationPropertiesArgs @selfRef, global::System.String @object)
    {
        @selfRef.Object = @object;
        return @selfRef;
    }

}
