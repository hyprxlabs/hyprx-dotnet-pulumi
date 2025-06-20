// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ApiManagement;

public static partial class WorkspaceApiSchemaExtensions
{

    extension(WorkspaceApiSchema)
    {
        public static WorkspaceApiSchema New(string @id, global::Pulumi.AzureNative.ApiManagement.WorkspaceApiSchemaArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new WorkspaceApiSchema(@id, @args, @options);
        }

        public static WorkspaceApiSchema New(string @id, global::System.Action<global::Pulumi.AzureNative.ApiManagement.WorkspaceApiSchemaArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.ApiManagement.WorkspaceApiSchemaArgs @args = new();
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

            return new WorkspaceApiSchema(@id, @args, @options);
        }

    }

}
