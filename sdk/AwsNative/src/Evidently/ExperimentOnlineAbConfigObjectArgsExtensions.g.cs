// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Evidently.Inputs;

namespace Pulumi.AwsNative.Evidently;

public static partial class ExperimentOnlineAbConfigObjectArgsExtensions
{
    public static global::Pulumi.AwsNative.Evidently.Inputs.ExperimentOnlineAbConfigObjectArgs WithControlTreatmentName(this global::Pulumi.AwsNative.Evidently.Inputs.ExperimentOnlineAbConfigObjectArgs @selfRef, global::System.String controlTreatmentName)
    {
        @selfRef.ControlTreatmentName = controlTreatmentName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Evidently.Inputs.ExperimentOnlineAbConfigObjectArgs WithTreatmentWeights(this global::Pulumi.AwsNative.Evidently.Inputs.ExperimentOnlineAbConfigObjectArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Evidently.Inputs.ExperimentTreatmentToWeightArgs> treatmentWeights)
    {
        @selfRef.TreatmentWeights = treatmentWeights;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Evidently.Inputs.ExperimentOnlineAbConfigObjectArgs WithTreatmentWeights(this global::Pulumi.AwsNative.Evidently.Inputs.ExperimentOnlineAbConfigObjectArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Evidently.Inputs.ExperimentTreatmentToWeightArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Evidently.Inputs.ExperimentTreatmentToWeightArgs>();
        @configure(@list);
        @selfRef.TreatmentWeights = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Evidently.Inputs.ExperimentOnlineAbConfigObjectArgs WithTreatmentWeights(this global::Pulumi.AwsNative.Evidently.Inputs.ExperimentOnlineAbConfigObjectArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Evidently.Inputs.ExperimentTreatmentToWeightArgs>> @create)
    {
        @selfRef.TreatmentWeights = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
