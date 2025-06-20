// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DataProtection;

public static partial class BackupInstanceExtensions
{

    extension(BackupInstance)
    {
        public static BackupInstance New(string @id, global::Pulumi.AzureNative.DataProtection.BackupInstanceArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new BackupInstance(@id, @args, @options);
        }

        public static BackupInstance New(string @id, global::System.Action<global::Pulumi.AzureNative.DataProtection.BackupInstanceArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.DataProtection.BackupInstanceArgs @args = new();
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

            return new BackupInstance(@id, @args, @options);
        }

    }

}
