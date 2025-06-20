// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoTEvents.Inputs;

namespace Pulumi.AwsNative.IoTEvents;

public static partial class DetectorModelStateArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelStateArgs WithOnEnter(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelStateArgs @selfRef, global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelOnEnterArgs onEnter)
    {
        @selfRef.OnEnter = onEnter;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelStateArgs WithOnEnter(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelStateArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelOnEnterArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelOnEnterArgs();
        @configure(@item);
        @selfRef.OnEnter = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelStateArgs WithOnExit(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelStateArgs @selfRef, global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelOnExitArgs onExit)
    {
        @selfRef.OnExit = onExit;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelStateArgs WithOnExit(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelStateArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelOnExitArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelOnExitArgs();
        @configure(@item);
        @selfRef.OnExit = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelStateArgs WithOnInput(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelStateArgs @selfRef, global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelOnInputArgs onInput)
    {
        @selfRef.OnInput = onInput;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelStateArgs WithOnInput(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelStateArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelOnInputArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelOnInputArgs();
        @configure(@item);
        @selfRef.OnInput = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelStateArgs WithStateName(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelStateArgs @selfRef, global::System.String stateName)
    {
        @selfRef.StateName = stateName;
        return @selfRef;
    }

}
