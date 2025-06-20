// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DesktopVirtualization;

public static partial class ScalingPlanPooledScheduleExtensions
{

    extension(ScalingPlanPooledSchedule)
    {
        public static ScalingPlanPooledSchedule New(string @id, global::Pulumi.AzureNative.DesktopVirtualization.ScalingPlanPooledScheduleArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ScalingPlanPooledSchedule(@id, @args, @options);
        }

        public static ScalingPlanPooledSchedule New(string @id, global::System.Action<global::Pulumi.AzureNative.DesktopVirtualization.ScalingPlanPooledScheduleArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.DesktopVirtualization.ScalingPlanPooledScheduleArgs @args = new();
            global::Pulumi.CustomResourceOptions? @options = null;
            if (@configureArgs is not null)
            {
                @configureArgs(@args);
            }

            if (@configureOptions is not null)
            {
                @options = new();
                @configureOptions(@options);
            }

            return new ScalingPlanPooledSchedule(@id, @args, @options);
        }

    }

}
