// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardLayerCustomActionOperationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayerCustomActionOperationArgs WithFilterOperation(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayerCustomActionOperationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardCustomActionFilterOperationArgs filterOperation)
    {
        @selfRef.FilterOperation = filterOperation;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayerCustomActionOperationArgs WithFilterOperation(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayerCustomActionOperationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardCustomActionFilterOperationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardCustomActionFilterOperationArgs();
        @configure(@item);
        @selfRef.FilterOperation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayerCustomActionOperationArgs WithNavigationOperation(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayerCustomActionOperationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardCustomActionNavigationOperationArgs navigationOperation)
    {
        @selfRef.NavigationOperation = navigationOperation;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayerCustomActionOperationArgs WithNavigationOperation(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayerCustomActionOperationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardCustomActionNavigationOperationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardCustomActionNavigationOperationArgs();
        @configure(@item);
        @selfRef.NavigationOperation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayerCustomActionOperationArgs WithSetParametersOperation(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayerCustomActionOperationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardCustomActionSetParametersOperationArgs setParametersOperation)
    {
        @selfRef.SetParametersOperation = setParametersOperation;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayerCustomActionOperationArgs WithSetParametersOperation(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayerCustomActionOperationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardCustomActionSetParametersOperationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardCustomActionSetParametersOperationArgs();
        @configure(@item);
        @selfRef.SetParametersOperation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayerCustomActionOperationArgs WithUrlOperation(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayerCustomActionOperationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardCustomActionUrlOperationArgs urlOperation)
    {
        @selfRef.UrlOperation = urlOperation;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayerCustomActionOperationArgs WithUrlOperation(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayerCustomActionOperationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardCustomActionUrlOperationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardCustomActionUrlOperationArgs();
        @configure(@item);
        @selfRef.UrlOperation = @item;
        return @selfRef;
    }

}
