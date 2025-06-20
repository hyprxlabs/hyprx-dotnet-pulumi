// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.CodeStarNotifications;

public static partial class NotificationRuleExtensions
{

    extension(NotificationRule)
    {
        public static NotificationRule New(string @id, global::Pulumi.AwsNative.CodeStarNotifications.NotificationRuleArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new NotificationRule(@id, @args, @options);
        }

        public static NotificationRule New(string @id, global::System.Action<global::Pulumi.AwsNative.CodeStarNotifications.NotificationRuleArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.CodeStarNotifications.NotificationRuleArgs @args = new();
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

            return new NotificationRule(@id, @args, @options);
        }

    }

}
