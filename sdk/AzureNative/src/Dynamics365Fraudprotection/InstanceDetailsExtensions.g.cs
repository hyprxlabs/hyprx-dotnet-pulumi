// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Dynamics365Fraudprotection;

public static partial class InstanceDetailsExtensions
{

    extension(InstanceDetails)
    {
        public static InstanceDetails New(string @id, global::Pulumi.AzureNative.Dynamics365Fraudprotection.InstanceDetailsArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new InstanceDetails(@id, @args, @options);
        }

        public static InstanceDetails New(string @id, global::System.Action<global::Pulumi.AzureNative.Dynamics365Fraudprotection.InstanceDetailsArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Dynamics365Fraudprotection.InstanceDetailsArgs @args = new();
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

            return new InstanceDetails(@id, @args, @options);
        }

    }

}
