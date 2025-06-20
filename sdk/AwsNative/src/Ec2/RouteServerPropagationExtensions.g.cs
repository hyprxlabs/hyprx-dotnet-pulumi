// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ec2;

public static partial class RouteServerPropagationExtensions
{

    extension(RouteServerPropagation)
    {
        public static RouteServerPropagation New(string @id, global::Pulumi.AwsNative.Ec2.RouteServerPropagationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new RouteServerPropagation(@id, @args, @options);
        }

        public static RouteServerPropagation New(string @id, global::System.Action<global::Pulumi.AwsNative.Ec2.RouteServerPropagationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Ec2.RouteServerPropagationArgs @args = new();
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

            return new RouteServerPropagation(@id, @args, @options);
        }

    }

}
