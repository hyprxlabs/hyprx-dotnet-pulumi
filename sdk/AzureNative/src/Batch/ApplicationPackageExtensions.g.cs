// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Batch;

public static partial class ApplicationPackageExtensions
{

    extension(ApplicationPackage)
    {
        public static ApplicationPackage New(string @id, global::Pulumi.AzureNative.Batch.ApplicationPackageArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ApplicationPackage(@id, @args, @options);
        }

        public static ApplicationPackage New(string @id, global::System.Action<global::Pulumi.AzureNative.Batch.ApplicationPackageArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Batch.ApplicationPackageArgs @args = new();
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

            return new ApplicationPackage(@id, @args, @options);
        }

    }

}
