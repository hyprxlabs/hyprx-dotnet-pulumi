// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisSourceTemplateArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSourceTemplateArgs WithArn(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSourceTemplateArgs @selfRef, global::System.String arn)
    {
        @selfRef.Arn = arn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSourceTemplateArgs WithDataSetReferences(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSourceTemplateArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataSetReferenceArgs> dataSetReferences)
    {
        @selfRef.DataSetReferences = dataSetReferences;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSourceTemplateArgs WithDataSetReferences(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSourceTemplateArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataSetReferenceArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataSetReferenceArgs>();
        @configure(@list);
        @selfRef.DataSetReferences = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSourceTemplateArgs WithDataSetReferences(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSourceTemplateArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataSetReferenceArgs>> @create)
    {
        @selfRef.DataSetReferences = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
