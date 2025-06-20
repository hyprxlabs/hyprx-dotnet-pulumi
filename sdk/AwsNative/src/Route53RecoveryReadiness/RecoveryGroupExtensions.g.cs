// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Route53RecoveryReadiness;

public static partial class RecoveryGroupExtensions
{

    extension(RecoveryGroup)
    {
        public static RecoveryGroup New(string @id, global::Pulumi.AwsNative.Route53RecoveryReadiness.RecoveryGroupArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new RecoveryGroup(@id, @args, @options);
        }

        public static RecoveryGroup New(string @id, global::System.Action<global::Pulumi.AwsNative.Route53RecoveryReadiness.RecoveryGroupArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Route53RecoveryReadiness.RecoveryGroupArgs @args = new();
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

            return new RecoveryGroup(@id, @args, @options);
        }

    }

}
