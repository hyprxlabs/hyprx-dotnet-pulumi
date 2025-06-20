// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Batch;

public static partial class JobDefinitionExtensions
{

    extension(JobDefinition)
    {
        public static JobDefinition New(string @id, global::Pulumi.AwsNative.Batch.JobDefinitionArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new JobDefinition(@id, @args, @options);
        }

        public static JobDefinition New(string @id, global::System.Action<global::Pulumi.AwsNative.Batch.JobDefinitionArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Batch.JobDefinitionArgs @args = new();
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

            return new JobDefinition(@id, @args, @options);
        }

    }

}
