// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisSheetArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSheetArgs WithName(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSheetArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSheetArgs WithSheetId(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSheetArgs @selfRef, global::System.String sheetId)
    {
        @selfRef.SheetId = sheetId;
        return @selfRef;
    }

}
