// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoTEvents.Inputs;

namespace Pulumi.AwsNative.IoTEvents;

public static partial class DetectorModelOnInputArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelOnInputArgs WithEvents(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelOnInputArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelEventArgs> events)
    {
        @selfRef.Events = events;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelOnInputArgs WithEvents(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelOnInputArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelEventArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelEventArgs>();
        @configure(@list);
        @selfRef.Events = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelOnInputArgs WithEvents(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelOnInputArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelEventArgs>> @create)
    {
        @selfRef.Events = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelOnInputArgs WithTransitionEvents(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelOnInputArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelTransitionEventArgs> transitionEvents)
    {
        @selfRef.TransitionEvents = transitionEvents;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelOnInputArgs WithTransitionEvents(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelOnInputArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelTransitionEventArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelTransitionEventArgs>();
        @configure(@list);
        @selfRef.TransitionEvents = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelOnInputArgs WithTransitionEvents(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelOnInputArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelTransitionEventArgs>> @create)
    {
        @selfRef.TransitionEvents = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
