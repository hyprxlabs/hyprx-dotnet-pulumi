// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.IoTWireless;

public static partial class TaskDefinitionExtensions
{

    extension(TaskDefinition)
    {
        public static TaskDefinition New(string @id, global::Pulumi.AwsNative.IoTWireless.TaskDefinitionArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new TaskDefinition(@id, @args, @options);
        }

        public static TaskDefinition New(string @id, global::System.Action<global::Pulumi.AwsNative.IoTWireless.TaskDefinitionArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.IoTWireless.TaskDefinitionArgs @args = new();
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

            return new TaskDefinition(@id, @args, @options);
        }

    }

}
