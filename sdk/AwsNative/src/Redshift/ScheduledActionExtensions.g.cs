// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Redshift;

public static partial class ScheduledActionExtensions
{

    extension(ScheduledAction)
    {
        public static ScheduledAction New(string @id, global::Pulumi.AwsNative.Redshift.ScheduledActionArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ScheduledAction(@id, @args, @options);
        }

        public static ScheduledAction New(string @id, global::System.Action<global::Pulumi.AwsNative.Redshift.ScheduledActionArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Redshift.ScheduledActionArgs @args = new();
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

            return new ScheduledAction(@id, @args, @options);
        }

    }

}
