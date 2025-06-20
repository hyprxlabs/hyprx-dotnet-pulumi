// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardFreeFormLayoutElementArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs WithBackgroundStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementBackgroundStyleArgs backgroundStyle)
    {
        @selfRef.BackgroundStyle = backgroundStyle;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs WithBackgroundStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementBackgroundStyleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementBackgroundStyleArgs();
        @configure(@item);
        @selfRef.BackgroundStyle = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs WithBorderStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementBorderStyleArgs borderStyle)
    {
        @selfRef.BorderStyle = borderStyle;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs WithBorderStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementBorderStyleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementBorderStyleArgs();
        @configure(@item);
        @selfRef.BorderStyle = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs WithElementId(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs @selfRef, global::System.String elementId)
    {
        @selfRef.ElementId = elementId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs WithElementType(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs @selfRef, global::Pulumi.AwsNative.QuickSight.DashboardLayoutElementType elementType)
    {
        @selfRef.ElementType = elementType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs WithElementType(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.DashboardLayoutElementType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.DashboardLayoutElementType>();
        @configure(@item);
        @selfRef.ElementType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs WithHeight(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs @selfRef, global::System.String height)
    {
        @selfRef.Height = height;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs WithLoadingAnimation(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLoadingAnimationArgs loadingAnimation)
    {
        @selfRef.LoadingAnimation = loadingAnimation;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs WithLoadingAnimation(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLoadingAnimationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLoadingAnimationArgs();
        @configure(@item);
        @selfRef.LoadingAnimation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs WithRenderingRules(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSheetElementRenderingRuleArgs> renderingRules)
    {
        @selfRef.RenderingRules = renderingRules;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs WithRenderingRules(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSheetElementRenderingRuleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSheetElementRenderingRuleArgs>();
        @configure(@list);
        @selfRef.RenderingRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs WithRenderingRules(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSheetElementRenderingRuleArgs>> @create)
    {
        @selfRef.RenderingRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs WithSelectedBorderStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementBorderStyleArgs selectedBorderStyle)
    {
        @selfRef.SelectedBorderStyle = selectedBorderStyle;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs WithSelectedBorderStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementBorderStyleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementBorderStyleArgs();
        @configure(@item);
        @selfRef.SelectedBorderStyle = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs WithVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs @selfRef, global::Pulumi.AwsNative.QuickSight.DashboardVisibility visibility)
    {
        @selfRef.Visibility = visibility;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs WithVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.DashboardVisibility> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.DashboardVisibility>();
        @configure(@item);
        @selfRef.Visibility = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs WithWidth(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs @selfRef, global::System.String width)
    {
        @selfRef.Width = width;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs WithXAxisLocation(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs @selfRef, global::System.String xAxisLocation)
    {
        @selfRef.XAxisLocation = xAxisLocation;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs WithYAxisLocation(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormLayoutElementArgs @selfRef, global::System.String yAxisLocation)
    {
        @selfRef.YAxisLocation = yAxisLocation;
        return @selfRef;
    }

}
