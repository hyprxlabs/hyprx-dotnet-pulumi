// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Emr;

public static partial class StudioSessionMappingExtensions
{

    extension(StudioSessionMapping)
    {
        public static StudioSessionMapping New(string @id, global::Pulumi.AwsNative.Emr.StudioSessionMappingArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new StudioSessionMapping(@id, @args, @options);
        }

        public static StudioSessionMapping New(string @id, global::System.Action<global::Pulumi.AwsNative.Emr.StudioSessionMappingArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Emr.StudioSessionMappingArgs @args = new();
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

            return new StudioSessionMapping(@id, @args, @options);
        }

    }

}
