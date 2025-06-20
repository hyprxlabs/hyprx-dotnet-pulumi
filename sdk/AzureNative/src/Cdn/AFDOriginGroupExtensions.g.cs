// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Cdn;

public static partial class AFDOriginGroupExtensions
{

    extension(AFDOriginGroup)
    {
        public static AFDOriginGroup New(string @id, global::Pulumi.AzureNative.Cdn.AFDOriginGroupArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new AFDOriginGroup(@id, @args, @options);
        }

        public static AFDOriginGroup New(string @id, global::System.Action<global::Pulumi.AzureNative.Cdn.AFDOriginGroupArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Cdn.AFDOriginGroupArgs @args = new();
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

            return new AFDOriginGroup(@id, @args, @options);
        }

    }

}
