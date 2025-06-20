// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.ElasticLoadBalancingV2;

public static partial class TrustStoreExtensions
{

    extension(TrustStore)
    {
        public static TrustStore New(string @id, global::Pulumi.AwsNative.ElasticLoadBalancingV2.TrustStoreArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new TrustStore(@id, @args, @options);
        }

        public static TrustStore New(string @id, global::System.Action<global::Pulumi.AwsNative.ElasticLoadBalancingV2.TrustStoreArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.ElasticLoadBalancingV2.TrustStoreArgs @args = new();
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

            return new TrustStore(@id, @args, @options);
        }

    }

}
