// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ServiceNetworking;

public static partial class TrafficControllerInterfaceExtensions
{

    extension(TrafficControllerInterface)
    {
        public static TrafficControllerInterface New(string @id, global::Pulumi.AzureNative.ServiceNetworking.TrafficControllerInterfaceArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new TrafficControllerInterface(@id, @args, @options);
        }

        public static TrafficControllerInterface New(string @id, global::System.Action<global::Pulumi.AzureNative.ServiceNetworking.TrafficControllerInterfaceArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.ServiceNetworking.TrafficControllerInterfaceArgs @args = new();
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

            return new TrafficControllerInterface(@id, @args, @options);
        }

    }

}
