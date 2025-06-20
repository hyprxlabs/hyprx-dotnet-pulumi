// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DevCenter;

public static partial class CatalogExtensions
{

    extension(Catalog)
    {
        public static Catalog New(string @id, global::Pulumi.AzureNative.DevCenter.CatalogArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Catalog(@id, @args, @options);
        }

        public static Catalog New(string @id, global::System.Action<global::Pulumi.AzureNative.DevCenter.CatalogArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.DevCenter.CatalogArgs @args = new();
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

            return new Catalog(@id, @args, @options);
        }

    }

}
