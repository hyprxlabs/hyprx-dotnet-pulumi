// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisWhatIfPointScenarioArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWhatIfPointScenarioArgs WithDate(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWhatIfPointScenarioArgs @selfRef, global::System.String date)
    {
        @selfRef.Date = date;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWhatIfPointScenarioArgs WithValue(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWhatIfPointScenarioArgs @selfRef, global::System.Double value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
