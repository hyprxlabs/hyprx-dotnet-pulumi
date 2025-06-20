// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.FrontDoor;

public static partial class RulesEngineExtensions
{

    extension(RulesEngine)
    {
        public static RulesEngine New(string @id, global::Pulumi.AzureNative.FrontDoor.RulesEngineArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new RulesEngine(@id, @args, @options);
        }

        public static RulesEngine New(string @id, global::System.Action<global::Pulumi.AzureNative.FrontDoor.RulesEngineArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.FrontDoor.RulesEngineArgs @args = new();
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

            return new RulesEngine(@id, @args, @options);
        }

    }

}
