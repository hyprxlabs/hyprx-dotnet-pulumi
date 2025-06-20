// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Impact;

public static partial class WorkloadImpactExtensions
{

    extension(WorkloadImpact)
    {
        public static WorkloadImpact New(string @id, global::Pulumi.AzureNative.Impact.WorkloadImpactArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new WorkloadImpact(@id, @args, @options);
        }

        public static WorkloadImpact New(string @id, global::System.Action<global::Pulumi.AzureNative.Impact.WorkloadImpactArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Impact.WorkloadImpactArgs @args = new();
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

            return new WorkloadImpact(@id, @args, @options);
        }

    }

}
