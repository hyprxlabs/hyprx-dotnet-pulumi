// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.CostManagement;

public static partial class ScheduledActionByScopeExtensions
{

    extension(ScheduledActionByScope)
    {
        public static ScheduledActionByScope New(string @id, global::Pulumi.AzureNative.CostManagement.ScheduledActionByScopeArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ScheduledActionByScope(@id, @args, @options);
        }

        public static ScheduledActionByScope New(string @id, global::System.Action<global::Pulumi.AzureNative.CostManagement.ScheduledActionByScopeArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.CostManagement.ScheduledActionByScopeArgs @args = new();
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

            return new ScheduledActionByScope(@id, @args, @options);
        }

    }

}
