// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Billing;

public static partial class BillingProfileExtensions
{

    extension(BillingProfile)
    {
        public static BillingProfile New(string @id, global::Pulumi.AzureNative.Billing.BillingProfileArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new BillingProfile(@id, @args, @options);
        }

        public static BillingProfile New(string @id, global::System.Action<global::Pulumi.AzureNative.Billing.BillingProfileArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Billing.BillingProfileArgs @args = new();
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

            return new BillingProfile(@id, @args, @options);
        }

    }

}
