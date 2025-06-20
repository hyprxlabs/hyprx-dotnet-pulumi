// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Detective;

public static partial class GraphExtensions
{

    extension(Graph)
    {
        public static Graph New(string @id, global::Pulumi.AwsNative.Detective.GraphArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Graph(@id, @args, @options);
        }

        public static Graph New(string @id, global::System.Action<global::Pulumi.AwsNative.Detective.GraphArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Detective.GraphArgs @args = new();
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

            return new Graph(@id, @args, @options);
        }

    }

}
