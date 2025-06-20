// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class InferenceComponentAutoRollbackConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.InferenceComponentAutoRollbackConfigurationArgs WithAlarms(this global::Pulumi.AwsNative.SageMaker.Inputs.InferenceComponentAutoRollbackConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.Inputs.InferenceComponentAlarmArgs> alarms)
    {
        @selfRef.Alarms = alarms;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.InferenceComponentAutoRollbackConfigurationArgs WithAlarms(this global::Pulumi.AwsNative.SageMaker.Inputs.InferenceComponentAutoRollbackConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.Inputs.InferenceComponentAlarmArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.Inputs.InferenceComponentAlarmArgs>();
        @configure(@list);
        @selfRef.Alarms = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.InferenceComponentAutoRollbackConfigurationArgs WithAlarms(this global::Pulumi.AwsNative.SageMaker.Inputs.InferenceComponentAutoRollbackConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.SageMaker.Inputs.InferenceComponentAlarmArgs>> @create)
    {
        @selfRef.Alarms = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
