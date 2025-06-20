// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoT.Inputs;

namespace Pulumi.AwsNative.IoT;

public static partial class JobTemplateAbortCriteriaArgsExtensions
{
    public static global::Pulumi.AwsNative.IoT.Inputs.JobTemplateAbortCriteriaArgs WithAction(this global::Pulumi.AwsNative.IoT.Inputs.JobTemplateAbortCriteriaArgs @selfRef, global::Pulumi.AwsNative.IoT.JobTemplateAction action)
    {
        @selfRef.Action = action;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.JobTemplateAbortCriteriaArgs WithAction(this global::Pulumi.AwsNative.IoT.Inputs.JobTemplateAbortCriteriaArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoT.JobTemplateAction> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.IoT.JobTemplateAction>();
        @configure(@item);
        @selfRef.Action = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.JobTemplateAbortCriteriaArgs WithFailureType(this global::Pulumi.AwsNative.IoT.Inputs.JobTemplateAbortCriteriaArgs @selfRef, global::Pulumi.AwsNative.IoT.JobTemplateFailureType failureType)
    {
        @selfRef.FailureType = failureType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.JobTemplateAbortCriteriaArgs WithFailureType(this global::Pulumi.AwsNative.IoT.Inputs.JobTemplateAbortCriteriaArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoT.JobTemplateFailureType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.IoT.JobTemplateFailureType>();
        @configure(@item);
        @selfRef.FailureType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.JobTemplateAbortCriteriaArgs WithMinNumberOfExecutedThings(this global::Pulumi.AwsNative.IoT.Inputs.JobTemplateAbortCriteriaArgs @selfRef, global::System.Int32 minNumberOfExecutedThings)
    {
        @selfRef.MinNumberOfExecutedThings = minNumberOfExecutedThings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.JobTemplateAbortCriteriaArgs WithThresholdPercentage(this global::Pulumi.AwsNative.IoT.Inputs.JobTemplateAbortCriteriaArgs @selfRef, global::System.Double thresholdPercentage)
    {
        @selfRef.ThresholdPercentage = thresholdPercentage;
        return @selfRef;
    }

}
