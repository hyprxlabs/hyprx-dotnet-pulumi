// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Route53Resolver;

public static partial class OutpostResolverExtensions
{

    extension(OutpostResolver)
    {
        public static OutpostResolver New(string @id, global::Pulumi.AwsNative.Route53Resolver.OutpostResolverArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new OutpostResolver(@id, @args, @options);
        }

        public static OutpostResolver New(string @id, global::System.Action<global::Pulumi.AwsNative.Route53Resolver.OutpostResolverArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Route53Resolver.OutpostResolverArgs @args = new();
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

            return new OutpostResolver(@id, @args, @options);
        }

    }

}
