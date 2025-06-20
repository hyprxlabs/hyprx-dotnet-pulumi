// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.QuickSight;

public static partial class FolderExtensions
{

    extension(Folder)
    {
        public static Folder New(string @id, global::Pulumi.AwsNative.QuickSight.FolderArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Folder(@id, @args, @options);
        }

        public static Folder New(string @id, global::System.Action<global::Pulumi.AwsNative.QuickSight.FolderArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.QuickSight.FolderArgs @args = new();
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

            return new Folder(@id, @args, @options);
        }

    }

}
