// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardSectionLayoutConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSectionLayoutConfigurationArgs WithFreeFormLayout(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSectionLayoutConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormSectionLayoutConfigurationArgs freeFormLayout)
    {
        @selfRef.FreeFormLayout = freeFormLayout;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSectionLayoutConfigurationArgs WithFreeFormLayout(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSectionLayoutConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormSectionLayoutConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFreeFormSectionLayoutConfigurationArgs();
        @configure(@item);
        @selfRef.FreeFormLayout = @item;
        return @selfRef;
    }

}
