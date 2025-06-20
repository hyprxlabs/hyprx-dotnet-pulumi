// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardNumericSeparatorConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericSeparatorConfigurationArgs WithDecimalSeparator(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericSeparatorConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.DashboardNumericSeparatorSymbol decimalSeparator)
    {
        @selfRef.DecimalSeparator = decimalSeparator;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericSeparatorConfigurationArgs WithDecimalSeparator(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericSeparatorConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.DashboardNumericSeparatorSymbol> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.DashboardNumericSeparatorSymbol>();
        @configure(@item);
        @selfRef.DecimalSeparator = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericSeparatorConfigurationArgs WithThousandsSeparator(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericSeparatorConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardThousandSeparatorOptionsArgs thousandsSeparator)
    {
        @selfRef.ThousandsSeparator = thousandsSeparator;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericSeparatorConfigurationArgs WithThousandsSeparator(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericSeparatorConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardThousandSeparatorOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardThousandSeparatorOptionsArgs();
        @configure(@item);
        @selfRef.ThousandsSeparator = @item;
        return @selfRef;
    }

}
