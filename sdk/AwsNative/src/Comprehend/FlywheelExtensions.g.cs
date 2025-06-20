// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Comprehend;

public static partial class FlywheelExtensions
{

    extension(Flywheel)
    {
        public static Flywheel New(string @id, global::Pulumi.AwsNative.Comprehend.FlywheelArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Flywheel(@id, @args, @options);
        }

        public static Flywheel New(string @id, global::System.Action<global::Pulumi.AwsNative.Comprehend.FlywheelArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Comprehend.FlywheelArgs @args = new();
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

            return new Flywheel(@id, @args, @options);
        }

    }

}
