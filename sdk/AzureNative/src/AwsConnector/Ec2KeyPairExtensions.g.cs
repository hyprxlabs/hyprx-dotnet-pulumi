// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AwsConnector;

public static partial class Ec2KeyPairExtensions
{

    extension(Ec2KeyPair)
    {
        public static Ec2KeyPair New(string @id, global::Pulumi.AzureNative.AwsConnector.Ec2KeyPairArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Ec2KeyPair(@id, @args, @options);
        }

        public static Ec2KeyPair New(string @id, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Ec2KeyPairArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.AwsConnector.Ec2KeyPairArgs @args = new();
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

            return new Ec2KeyPair(@id, @args, @options);
        }

    }

}
