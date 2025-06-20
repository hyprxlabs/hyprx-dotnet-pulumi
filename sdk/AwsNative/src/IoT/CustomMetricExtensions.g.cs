// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.IoT;

public static partial class CustomMetricExtensions
{

    extension(CustomMetric)
    {
        public static CustomMetric New(string @id, global::Pulumi.AwsNative.IoT.CustomMetricArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new CustomMetric(@id, @args, @options);
        }

        public static CustomMetric New(string @id, global::System.Action<global::Pulumi.AwsNative.IoT.CustomMetricArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.IoT.CustomMetricArgs @args = new();
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

            return new CustomMetric(@id, @args, @options);
        }

    }

}
