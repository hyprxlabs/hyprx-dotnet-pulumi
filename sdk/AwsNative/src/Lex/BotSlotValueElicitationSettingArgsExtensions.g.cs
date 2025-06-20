// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Lex.Inputs;

namespace Pulumi.AwsNative.Lex;

public static partial class BotSlotValueElicitationSettingArgsExtensions
{
    public static global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs WithDefaultValueSpecification(this global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs @selfRef, global::Pulumi.AwsNative.Lex.Inputs.BotSlotDefaultValueSpecificationArgs defaultValueSpecification)
    {
        @selfRef.DefaultValueSpecification = defaultValueSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs WithDefaultValueSpecification(this global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Lex.Inputs.BotSlotDefaultValueSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Lex.Inputs.BotSlotDefaultValueSpecificationArgs();
        @configure(@item);
        @selfRef.DefaultValueSpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs WithPromptSpecification(this global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs @selfRef, global::Pulumi.AwsNative.Lex.Inputs.BotPromptSpecificationArgs promptSpecification)
    {
        @selfRef.PromptSpecification = promptSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs WithPromptSpecification(this global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Lex.Inputs.BotPromptSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Lex.Inputs.BotPromptSpecificationArgs();
        @configure(@item);
        @selfRef.PromptSpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs WithSampleUtterances(this global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Lex.Inputs.BotSampleUtteranceArgs> sampleUtterances)
    {
        @selfRef.SampleUtterances = sampleUtterances;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs WithSampleUtterances(this global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Lex.Inputs.BotSampleUtteranceArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Lex.Inputs.BotSampleUtteranceArgs>();
        @configure(@list);
        @selfRef.SampleUtterances = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs WithSampleUtterances(this global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Lex.Inputs.BotSampleUtteranceArgs>> @create)
    {
        @selfRef.SampleUtterances = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs WithSlotCaptureSetting(this global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs @selfRef, global::Pulumi.AwsNative.Lex.Inputs.BotSlotCaptureSettingArgs slotCaptureSetting)
    {
        @selfRef.SlotCaptureSetting = slotCaptureSetting;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs WithSlotCaptureSetting(this global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Lex.Inputs.BotSlotCaptureSettingArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Lex.Inputs.BotSlotCaptureSettingArgs();
        @configure(@item);
        @selfRef.SlotCaptureSetting = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs WithSlotConstraint(this global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs @selfRef, global::Pulumi.AwsNative.Lex.BotSlotConstraint slotConstraint)
    {
        @selfRef.SlotConstraint = slotConstraint;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs WithSlotConstraint(this global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Lex.BotSlotConstraint> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Lex.BotSlotConstraint>();
        @configure(@item);
        @selfRef.SlotConstraint = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs WithWaitAndContinueSpecification(this global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs @selfRef, global::Pulumi.AwsNative.Lex.Inputs.BotWaitAndContinueSpecificationArgs waitAndContinueSpecification)
    {
        @selfRef.WaitAndContinueSpecification = waitAndContinueSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs WithWaitAndContinueSpecification(this global::Pulumi.AwsNative.Lex.Inputs.BotSlotValueElicitationSettingArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Lex.Inputs.BotWaitAndContinueSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Lex.Inputs.BotWaitAndContinueSpecificationArgs();
        @configure(@item);
        @selfRef.WaitAndContinueSpecification = @item;
        return @selfRef;
    }

}
