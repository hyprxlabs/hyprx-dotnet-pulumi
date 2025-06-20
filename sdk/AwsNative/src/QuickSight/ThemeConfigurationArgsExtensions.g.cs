// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class ThemeConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.ThemeConfigurationArgs WithDataColorPalette(this global::Pulumi.AwsNative.QuickSight.Inputs.ThemeConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.ThemeDataColorPaletteArgs dataColorPalette)
    {
        @selfRef.DataColorPalette = dataColorPalette;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.ThemeConfigurationArgs WithDataColorPalette(this global::Pulumi.AwsNative.QuickSight.Inputs.ThemeConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.ThemeDataColorPaletteArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.ThemeDataColorPaletteArgs();
        @configure(@item);
        @selfRef.DataColorPalette = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.ThemeConfigurationArgs WithSheet(this global::Pulumi.AwsNative.QuickSight.Inputs.ThemeConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.ThemeSheetStyleArgs sheet)
    {
        @selfRef.Sheet = sheet;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.ThemeConfigurationArgs WithSheet(this global::Pulumi.AwsNative.QuickSight.Inputs.ThemeConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.ThemeSheetStyleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.ThemeSheetStyleArgs();
        @configure(@item);
        @selfRef.Sheet = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.ThemeConfigurationArgs WithTypography(this global::Pulumi.AwsNative.QuickSight.Inputs.ThemeConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.ThemeTypographyArgs typography)
    {
        @selfRef.Typography = typography;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.ThemeConfigurationArgs WithTypography(this global::Pulumi.AwsNative.QuickSight.Inputs.ThemeConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.ThemeTypographyArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.ThemeTypographyArgs();
        @configure(@item);
        @selfRef.Typography = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.ThemeConfigurationArgs WithUiColorPalette(this global::Pulumi.AwsNative.QuickSight.Inputs.ThemeConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.ThemeUiColorPaletteArgs uiColorPalette)
    {
        @selfRef.UiColorPalette = uiColorPalette;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.ThemeConfigurationArgs WithUiColorPalette(this global::Pulumi.AwsNative.QuickSight.Inputs.ThemeConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.ThemeUiColorPaletteArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.ThemeUiColorPaletteArgs();
        @configure(@item);
        @selfRef.UiColorPalette = @item;
        return @selfRef;
    }

}
