// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AwsConnector;

public static partial class WafWebAclSummaryExtensions
{

    extension(WafWebAclSummary)
    {
        public static WafWebAclSummary New(string @id, global::Pulumi.AzureNative.AwsConnector.WafWebAclSummaryArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new WafWebAclSummary(@id, @args, @options);
        }

        public static WafWebAclSummary New(string @id, global::System.Action<global::Pulumi.AzureNative.AwsConnector.WafWebAclSummaryArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.AwsConnector.WafWebAclSummaryArgs @args = new();
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

            return new WafWebAclSummary(@id, @args, @options);
        }

    }

}
