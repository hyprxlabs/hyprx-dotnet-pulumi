// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.CloudFront;

public static partial class DistributionTenantExtensions
{

    extension(DistributionTenant)
    {
        public static DistributionTenant New(string @id, global::Pulumi.AwsNative.CloudFront.DistributionTenantArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new DistributionTenant(@id, @args, @options);
        }

        public static DistributionTenant New(string @id, global::System.Action<global::Pulumi.AwsNative.CloudFront.DistributionTenantArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.CloudFront.DistributionTenantArgs @args = new();
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

            return new DistributionTenant(@id, @args, @options);
        }

    }

}
