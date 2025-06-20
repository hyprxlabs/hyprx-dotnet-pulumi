// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Security;

public static partial class AdvancedThreatProtectionExtensions
{

    extension(AdvancedThreatProtection)
    {
        public static AdvancedThreatProtection New(string @id, global::Pulumi.AzureNative.Security.AdvancedThreatProtectionArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new AdvancedThreatProtection(@id, @args, @options);
        }

        public static AdvancedThreatProtection New(string @id, global::System.Action<global::Pulumi.AzureNative.Security.AdvancedThreatProtectionArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Security.AdvancedThreatProtectionArgs @args = new();
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

            return new AdvancedThreatProtection(@id, @args, @options);
        }

    }

}
