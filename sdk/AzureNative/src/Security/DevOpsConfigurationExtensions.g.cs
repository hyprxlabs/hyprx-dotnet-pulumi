// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Security;

public static partial class DevOpsConfigurationExtensions
{

    extension(DevOpsConfiguration)
    {
        public static DevOpsConfiguration New(string @id, global::Pulumi.AzureNative.Security.DevOpsConfigurationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new DevOpsConfiguration(@id, @args, @options);
        }

        public static DevOpsConfiguration New(string @id, global::System.Action<global::Pulumi.AzureNative.Security.DevOpsConfigurationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Security.DevOpsConfigurationArgs @args = new();
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

            return new DevOpsConfiguration(@id, @args, @options);
        }

    }

}
