// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardLayoutArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayoutArgs WithConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayoutArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayoutConfigurationArgs configuration)
    {
        @selfRef.Configuration = configuration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayoutArgs WithConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayoutArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayoutConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLayoutConfigurationArgs();
        @configure(@item);
        @selfRef.Configuration = @item;
        return @selfRef;
    }

}
