// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.FraudDetector;

public static partial class LabelExtensions
{

    extension(Label)
    {
        public static Label New(string @id, global::Pulumi.AwsNative.FraudDetector.LabelArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Label(@id, @args, @options);
        }

        public static Label New(string @id, global::System.Action<global::Pulumi.AwsNative.FraudDetector.LabelArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.FraudDetector.LabelArgs @args = new();
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

            return new Label(@id, @args, @options);
        }

    }

}
