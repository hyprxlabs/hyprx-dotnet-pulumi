// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class EndpointAutoRollbackConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.EndpointAutoRollbackConfigArgs WithAlarms(this global::Pulumi.AwsNative.SageMaker.Inputs.EndpointAutoRollbackConfigArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.Inputs.EndpointAlarmArgs> alarms)
    {
        @selfRef.Alarms = alarms;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.EndpointAutoRollbackConfigArgs WithAlarms(this global::Pulumi.AwsNative.SageMaker.Inputs.EndpointAutoRollbackConfigArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.Inputs.EndpointAlarmArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.Inputs.EndpointAlarmArgs>();
        @configure(@list);
        @selfRef.Alarms = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.EndpointAutoRollbackConfigArgs WithAlarms(this global::Pulumi.AwsNative.SageMaker.Inputs.EndpointAutoRollbackConfigArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.SageMaker.Inputs.EndpointAlarmArgs>> @create)
    {
        @selfRef.Alarms = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
