// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Kusto;

public static partial class ScriptExtensions
{

    extension(Script)
    {
        public static Script New(string @id, global::Pulumi.AzureNative.Kusto.ScriptArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Script(@id, @args, @options);
        }

        public static Script New(string @id, global::System.Action<global::Pulumi.AzureNative.Kusto.ScriptArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Kusto.ScriptArgs @args = new();
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

            return new Script(@id, @args, @options);
        }

    }

}
