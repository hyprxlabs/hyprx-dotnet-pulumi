// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardNumericFormatConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericFormatConfigurationArgs WithCurrencyDisplayFormatConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericFormatConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardCurrencyDisplayFormatConfigurationArgs currencyDisplayFormatConfiguration)
    {
        @selfRef.CurrencyDisplayFormatConfiguration = currencyDisplayFormatConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericFormatConfigurationArgs WithCurrencyDisplayFormatConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericFormatConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardCurrencyDisplayFormatConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardCurrencyDisplayFormatConfigurationArgs();
        @configure(@item);
        @selfRef.CurrencyDisplayFormatConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericFormatConfigurationArgs WithNumberDisplayFormatConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericFormatConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumberDisplayFormatConfigurationArgs numberDisplayFormatConfiguration)
    {
        @selfRef.NumberDisplayFormatConfiguration = numberDisplayFormatConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericFormatConfigurationArgs WithNumberDisplayFormatConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericFormatConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumberDisplayFormatConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumberDisplayFormatConfigurationArgs();
        @configure(@item);
        @selfRef.NumberDisplayFormatConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericFormatConfigurationArgs WithPercentageDisplayFormatConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericFormatConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPercentageDisplayFormatConfigurationArgs percentageDisplayFormatConfiguration)
    {
        @selfRef.PercentageDisplayFormatConfiguration = percentageDisplayFormatConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericFormatConfigurationArgs WithPercentageDisplayFormatConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericFormatConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPercentageDisplayFormatConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPercentageDisplayFormatConfigurationArgs();
        @configure(@item);
        @selfRef.PercentageDisplayFormatConfiguration = @item;
        return @selfRef;
    }

}
