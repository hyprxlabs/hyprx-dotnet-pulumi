// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ses;

public static partial class DedicatedIpPoolExtensions
{

    extension(DedicatedIpPool)
    {
        public static DedicatedIpPool New(string @id, global::Pulumi.AwsNative.Ses.DedicatedIpPoolArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new DedicatedIpPool(@id, @args, @options);
        }

        public static DedicatedIpPool New(string @id, global::System.Action<global::Pulumi.AwsNative.Ses.DedicatedIpPoolArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Ses.DedicatedIpPoolArgs @args = new();
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

            return new DedicatedIpPool(@id, @args, @options);
        }

    }

}
