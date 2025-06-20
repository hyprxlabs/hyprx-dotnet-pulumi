// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisSmallMultiplesOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesOptionsArgs WithMaxVisibleColumns(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesOptionsArgs @selfRef, global::System.Double maxVisibleColumns)
    {
        @selfRef.MaxVisibleColumns = maxVisibleColumns;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesOptionsArgs WithMaxVisibleRows(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesOptionsArgs @selfRef, global::System.Double maxVisibleRows)
    {
        @selfRef.MaxVisibleRows = maxVisibleRows;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesOptionsArgs WithPanelConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPanelConfigurationArgs panelConfiguration)
    {
        @selfRef.PanelConfiguration = panelConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesOptionsArgs WithPanelConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPanelConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPanelConfigurationArgs();
        @configure(@item);
        @selfRef.PanelConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesOptionsArgs WithXAxis(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesAxisPropertiesArgs xAxis)
    {
        @selfRef.XAxis = xAxis;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesOptionsArgs WithXAxis(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesAxisPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesAxisPropertiesArgs();
        @configure(@item);
        @selfRef.XAxis = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesOptionsArgs WithYAxis(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesAxisPropertiesArgs yAxis)
    {
        @selfRef.YAxis = yAxis;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesOptionsArgs WithYAxis(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesAxisPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSmallMultiplesAxisPropertiesArgs();
        @configure(@item);
        @selfRef.YAxis = @item;
        return @selfRef;
    }

}
