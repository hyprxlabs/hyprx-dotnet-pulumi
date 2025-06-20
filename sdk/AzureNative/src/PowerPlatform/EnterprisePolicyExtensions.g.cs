// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.PowerPlatform;

public static partial class EnterprisePolicyExtensions
{

    extension(EnterprisePolicy)
    {
        public static EnterprisePolicy New(string @id, global::Pulumi.AzureNative.PowerPlatform.EnterprisePolicyArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new EnterprisePolicy(@id, @args, @options);
        }

        public static EnterprisePolicy New(string @id, global::System.Action<global::Pulumi.AzureNative.PowerPlatform.EnterprisePolicyArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.PowerPlatform.EnterprisePolicyArgs @args = new();
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

            return new EnterprisePolicy(@id, @args, @options);
        }

    }

}
