// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Cognito.Inputs;

namespace Pulumi.AwsNative.Cognito;

public static partial class LogDeliveryConfigurationFirehoseConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Cognito.Inputs.LogDeliveryConfigurationFirehoseConfigurationArgs WithStreamArn(this global::Pulumi.AwsNative.Cognito.Inputs.LogDeliveryConfigurationFirehoseConfigurationArgs @selfRef, global::System.String streamArn)
    {
        @selfRef.StreamArn = streamArn;
        return @selfRef;
    }

}
