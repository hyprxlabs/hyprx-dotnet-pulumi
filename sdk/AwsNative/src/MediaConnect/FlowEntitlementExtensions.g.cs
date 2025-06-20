// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.MediaConnect;

public static partial class FlowEntitlementExtensions
{

    extension(FlowEntitlement)
    {
        public static FlowEntitlement New(string @id, global::Pulumi.AwsNative.MediaConnect.FlowEntitlementArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new FlowEntitlement(@id, @args, @options);
        }

        public static FlowEntitlement New(string @id, global::System.Action<global::Pulumi.AwsNative.MediaConnect.FlowEntitlementArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.MediaConnect.FlowEntitlementArgs @args = new();
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

            return new FlowEntitlement(@id, @args, @options);
        }

    }

}
