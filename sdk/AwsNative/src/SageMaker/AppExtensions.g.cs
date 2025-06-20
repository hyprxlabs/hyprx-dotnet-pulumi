// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.SageMaker;

public static partial class AppExtensions
{

    extension(App)
    {
        public static App New(string @id, global::Pulumi.AwsNative.SageMaker.AppArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new App(@id, @args, @options);
        }

        public static App New(string @id, global::System.Action<global::Pulumi.AwsNative.SageMaker.AppArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.SageMaker.AppArgs @args = new();
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

            return new App(@id, @args, @options);
        }

    }

}
