// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DatabaseFleetManager;

public static partial class FleetTierExtensions
{

    extension(FleetTier)
    {
        public static FleetTier New(string @id, global::Pulumi.AzureNative.DatabaseFleetManager.FleetTierArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new FleetTier(@id, @args, @options);
        }

        public static FleetTier New(string @id, global::System.Action<global::Pulumi.AzureNative.DatabaseFleetManager.FleetTierArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.DatabaseFleetManager.FleetTierArgs @args = new();
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

            return new FleetTier(@id, @args, @options);
        }

    }

}
