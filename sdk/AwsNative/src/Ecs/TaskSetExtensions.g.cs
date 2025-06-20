// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ecs;

public static partial class TaskSetExtensions
{

    extension(TaskSet)
    {
        public static TaskSet New(string @id, global::Pulumi.AwsNative.Ecs.TaskSetArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new TaskSet(@id, @args, @options);
        }

        public static TaskSet New(string @id, global::System.Action<global::Pulumi.AwsNative.Ecs.TaskSetArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Ecs.TaskSetArgs @args = new();
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

            return new TaskSet(@id, @args, @options);
        }

    }

}
