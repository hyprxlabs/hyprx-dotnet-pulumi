// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Iam;

public static partial class ManagedPolicyExtensions
{

    extension(ManagedPolicy)
    {
        public static ManagedPolicy New(string @id, global::Pulumi.AwsNative.Iam.ManagedPolicyArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ManagedPolicy(@id, @args, @options);
        }

        public static ManagedPolicy New(string @id, global::System.Action<global::Pulumi.AwsNative.Iam.ManagedPolicyArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Iam.ManagedPolicyArgs @args = new();
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

            return new ManagedPolicy(@id, @args, @options);
        }

    }

}
