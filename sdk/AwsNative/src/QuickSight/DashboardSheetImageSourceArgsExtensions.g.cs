// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardSheetImageSourceArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSheetImageSourceArgs WithSheetImageStaticFileSource(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSheetImageSourceArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSheetImageStaticFileSourceArgs sheetImageStaticFileSource)
    {
        @selfRef.SheetImageStaticFileSource = sheetImageStaticFileSource;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSheetImageSourceArgs WithSheetImageStaticFileSource(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSheetImageSourceArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSheetImageStaticFileSourceArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSheetImageStaticFileSourceArgs();
        @configure(@item);
        @selfRef.SheetImageStaticFileSource = @item;
        return @selfRef;
    }

}
