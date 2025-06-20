// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Quota;

public static partial class GroupQuotaSubscriptionExtensions
{

    extension(GroupQuotaSubscription)
    {
        public static GroupQuotaSubscription New(string @id, global::Pulumi.AzureNative.Quota.GroupQuotaSubscriptionArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new GroupQuotaSubscription(@id, @args, @options);
        }

        public static GroupQuotaSubscription New(string @id, global::System.Action<global::Pulumi.AzureNative.Quota.GroupQuotaSubscriptionArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Quota.GroupQuotaSubscriptionArgs @args = new();
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

            return new GroupQuotaSubscription(@id, @args, @options);
        }

    }

}
