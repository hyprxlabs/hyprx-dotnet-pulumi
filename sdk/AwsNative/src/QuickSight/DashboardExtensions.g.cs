// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardExtensions
{

    extension(Dashboard)
    {
        public static Dashboard New(string @id, global::Pulumi.AwsNative.QuickSight.DashboardArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Dashboard(@id, @args, @options);
        }

        public static Dashboard New(string @id, global::System.Action<global::Pulumi.AwsNative.QuickSight.DashboardArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.QuickSight.DashboardArgs @args = new();
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

            return new Dashboard(@id, @args, @options);
        }

    }

}
