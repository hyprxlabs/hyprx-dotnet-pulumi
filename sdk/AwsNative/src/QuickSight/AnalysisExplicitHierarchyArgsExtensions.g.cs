// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisExplicitHierarchyArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisExplicitHierarchyArgs WithColumns(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisExplicitHierarchyArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColumnIdentifierArgs> columns)
    {
        @selfRef.Columns = columns;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisExplicitHierarchyArgs WithColumns(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisExplicitHierarchyArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColumnIdentifierArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColumnIdentifierArgs>();
        @configure(@list);
        @selfRef.Columns = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisExplicitHierarchyArgs WithColumns(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisExplicitHierarchyArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColumnIdentifierArgs>> @create)
    {
        @selfRef.Columns = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisExplicitHierarchyArgs WithDrillDownFilters(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisExplicitHierarchyArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDrillDownFilterArgs> drillDownFilters)
    {
        @selfRef.DrillDownFilters = drillDownFilters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisExplicitHierarchyArgs WithDrillDownFilters(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisExplicitHierarchyArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDrillDownFilterArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDrillDownFilterArgs>();
        @configure(@list);
        @selfRef.DrillDownFilters = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisExplicitHierarchyArgs WithDrillDownFilters(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisExplicitHierarchyArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDrillDownFilterArgs>> @create)
    {
        @selfRef.DrillDownFilters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisExplicitHierarchyArgs WithHierarchyId(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisExplicitHierarchyArgs @selfRef, global::System.String hierarchyId)
    {
        @selfRef.HierarchyId = hierarchyId;
        return @selfRef;
    }

}
