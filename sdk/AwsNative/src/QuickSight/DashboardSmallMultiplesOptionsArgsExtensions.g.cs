// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardSmallMultiplesOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesOptionsArgs WithMaxVisibleColumns(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesOptionsArgs @selfRef, global::System.Double maxVisibleColumns)
    {
        @selfRef.MaxVisibleColumns = maxVisibleColumns;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesOptionsArgs WithMaxVisibleRows(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesOptionsArgs @selfRef, global::System.Double maxVisibleRows)
    {
        @selfRef.MaxVisibleRows = maxVisibleRows;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesOptionsArgs WithPanelConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPanelConfigurationArgs panelConfiguration)
    {
        @selfRef.PanelConfiguration = panelConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesOptionsArgs WithPanelConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPanelConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPanelConfigurationArgs();
        @configure(@item);
        @selfRef.PanelConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesOptionsArgs WithXAxis(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesAxisPropertiesArgs xAxis)
    {
        @selfRef.XAxis = xAxis;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesOptionsArgs WithXAxis(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesAxisPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesAxisPropertiesArgs();
        @configure(@item);
        @selfRef.XAxis = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesOptionsArgs WithYAxis(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesAxisPropertiesArgs yAxis)
    {
        @selfRef.YAxis = yAxis;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesOptionsArgs WithYAxis(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesAxisPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSmallMultiplesAxisPropertiesArgs();
        @configure(@item);
        @selfRef.YAxis = @item;
        return @selfRef;
    }

}
