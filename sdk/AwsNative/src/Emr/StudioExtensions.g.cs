// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Emr;

public static partial class StudioExtensions
{

    extension(Studio)
    {
        public static Studio New(string @id, global::Pulumi.AwsNative.Emr.StudioArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Studio(@id, @args, @options);
        }

        public static Studio New(string @id, global::System.Action<global::Pulumi.AwsNative.Emr.StudioArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Emr.StudioArgs @args = new();
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

            return new Studio(@id, @args, @options);
        }

    }

}
