// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardDateTimePickerControlDisplayOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDateTimePickerControlDisplayOptionsArgs WithDateIconVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDateTimePickerControlDisplayOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.DashboardVisibility dateIconVisibility)
    {
        @selfRef.DateIconVisibility = dateIconVisibility;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDateTimePickerControlDisplayOptionsArgs WithDateIconVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDateTimePickerControlDisplayOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.DashboardVisibility> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.DashboardVisibility>();
        @configure(@item);
        @selfRef.DateIconVisibility = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDateTimePickerControlDisplayOptionsArgs WithDateTimeFormat(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDateTimePickerControlDisplayOptionsArgs @selfRef, global::System.String dateTimeFormat)
    {
        @selfRef.DateTimeFormat = dateTimeFormat;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDateTimePickerControlDisplayOptionsArgs WithHelperTextVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDateTimePickerControlDisplayOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.DashboardVisibility helperTextVisibility)
    {
        @selfRef.HelperTextVisibility = helperTextVisibility;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDateTimePickerControlDisplayOptionsArgs WithHelperTextVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDateTimePickerControlDisplayOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.DashboardVisibility> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.DashboardVisibility>();
        @configure(@item);
        @selfRef.HelperTextVisibility = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDateTimePickerControlDisplayOptionsArgs WithInfoIconLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDateTimePickerControlDisplayOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSheetControlInfoIconLabelOptionsArgs infoIconLabelOptions)
    {
        @selfRef.InfoIconLabelOptions = infoIconLabelOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDateTimePickerControlDisplayOptionsArgs WithInfoIconLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDateTimePickerControlDisplayOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSheetControlInfoIconLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSheetControlInfoIconLabelOptionsArgs();
        @configure(@item);
        @selfRef.InfoIconLabelOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDateTimePickerControlDisplayOptionsArgs WithTitleOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDateTimePickerControlDisplayOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLabelOptionsArgs titleOptions)
    {
        @selfRef.TitleOptions = titleOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDateTimePickerControlDisplayOptionsArgs WithTitleOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDateTimePickerControlDisplayOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLabelOptionsArgs();
        @configure(@item);
        @selfRef.TitleOptions = @item;
        return @selfRef;
    }

}
