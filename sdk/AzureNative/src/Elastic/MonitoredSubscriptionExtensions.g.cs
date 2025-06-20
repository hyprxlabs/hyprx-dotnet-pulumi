// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Elastic;

public static partial class MonitoredSubscriptionExtensions
{

    extension(MonitoredSubscription)
    {
        public static MonitoredSubscription New(string @id, global::Pulumi.AzureNative.Elastic.MonitoredSubscriptionArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new MonitoredSubscription(@id, @args, @options);
        }

        public static MonitoredSubscription New(string @id, global::System.Action<global::Pulumi.AzureNative.Elastic.MonitoredSubscriptionArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Elastic.MonitoredSubscriptionArgs @args = new();
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

            return new MonitoredSubscription(@id, @args, @options);
        }

    }

}
