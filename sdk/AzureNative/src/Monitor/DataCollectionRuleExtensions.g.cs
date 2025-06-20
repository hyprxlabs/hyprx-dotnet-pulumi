// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Monitor;

public static partial class DataCollectionRuleExtensions
{

    extension(DataCollectionRule)
    {
        public static DataCollectionRule New(string @id, global::Pulumi.AzureNative.Monitor.DataCollectionRuleArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new DataCollectionRule(@id, @args, @options);
        }

        public static DataCollectionRule New(string @id, global::System.Action<global::Pulumi.AzureNative.Monitor.DataCollectionRuleArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Monitor.DataCollectionRuleArgs @args = new();
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

            return new DataCollectionRule(@id, @args, @options);
        }

    }

}
