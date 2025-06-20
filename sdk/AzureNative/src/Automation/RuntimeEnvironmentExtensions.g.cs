// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Automation;

public static partial class RuntimeEnvironmentExtensions
{

    extension(RuntimeEnvironment)
    {
        public static RuntimeEnvironment New(string @id, global::Pulumi.AzureNative.Automation.RuntimeEnvironmentArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new RuntimeEnvironment(@id, @args, @options);
        }

        public static RuntimeEnvironment New(string @id, global::System.Action<global::Pulumi.AzureNative.Automation.RuntimeEnvironmentArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Automation.RuntimeEnvironmentArgs @args = new();
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

            return new RuntimeEnvironment(@id, @args, @options);
        }

    }

}
