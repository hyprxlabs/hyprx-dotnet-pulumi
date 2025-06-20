// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Configuration;

public static partial class AggregationAuthorizationExtensions
{

    extension(AggregationAuthorization)
    {
        public static AggregationAuthorization New(string @id, global::Pulumi.AwsNative.Configuration.AggregationAuthorizationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new AggregationAuthorization(@id, @args, @options);
        }

        public static AggregationAuthorization New(string @id, global::System.Action<global::Pulumi.AwsNative.Configuration.AggregationAuthorizationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Configuration.AggregationAuthorizationArgs @args = new();
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

            return new AggregationAuthorization(@id, @args, @options);
        }

    }

}
