// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisDataSetIdentifierDeclarationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataSetIdentifierDeclarationArgs WithDataSetArn(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataSetIdentifierDeclarationArgs @selfRef, global::System.String dataSetArn)
    {
        @selfRef.DataSetArn = dataSetArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataSetIdentifierDeclarationArgs WithIdentifier(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataSetIdentifierDeclarationArgs @selfRef, global::System.String identifier)
    {
        @selfRef.Identifier = identifier;
        return @selfRef;
    }

}
