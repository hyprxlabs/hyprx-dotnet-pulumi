// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.VpcLattice;

public static partial class AccessLogSubscriptionExtensions
{

    extension(AccessLogSubscription)
    {
        public static AccessLogSubscription New(string @id, global::Pulumi.AwsNative.VpcLattice.AccessLogSubscriptionArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new AccessLogSubscription(@id, @args, @options);
        }

        public static AccessLogSubscription New(string @id, global::System.Action<global::Pulumi.AwsNative.VpcLattice.AccessLogSubscriptionArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.VpcLattice.AccessLogSubscriptionArgs @args = new();
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

            return new AccessLogSubscription(@id, @args, @options);
        }

    }

}
