// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Cognito;

public static partial class LogDeliveryConfigurationExtensions
{

    extension(LogDeliveryConfiguration)
    {
        public static LogDeliveryConfiguration New(string @id, global::Pulumi.AwsNative.Cognito.LogDeliveryConfigurationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new LogDeliveryConfiguration(@id, @args, @options);
        }

        public static LogDeliveryConfiguration New(string @id, global::System.Action<global::Pulumi.AwsNative.Cognito.LogDeliveryConfigurationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Cognito.LogDeliveryConfigurationArgs @args = new();
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

            return new LogDeliveryConfiguration(@id, @args, @options);
        }

    }

}
