// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Scheduler.Inputs;

namespace Pulumi.AwsNative.Scheduler;

public static partial class ScheduleDeadLetterConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.Scheduler.Inputs.ScheduleDeadLetterConfigArgs WithArn(this global::Pulumi.AwsNative.Scheduler.Inputs.ScheduleDeadLetterConfigArgs @selfRef, global::System.String arn)
    {
        @selfRef.Arn = arn;
        return @selfRef;
    }

}
