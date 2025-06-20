// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.FrontDoor;

public static partial class FrontDoorExtensions
{

    extension(FrontDoor)
    {
        public static FrontDoor New(string @id, global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new FrontDoor(@id, @args, @options);
        }

        public static FrontDoor New(string @id, global::System.Action<global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @args = new();
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

            return new FrontDoor(@id, @args, @options);
        }

    }

}
