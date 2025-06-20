// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.OperationsManagement;

public static partial class ManagementAssociationExtensions
{

    extension(ManagementAssociation)
    {
        public static ManagementAssociation New(string @id, global::Pulumi.AzureNative.OperationsManagement.ManagementAssociationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ManagementAssociation(@id, @args, @options);
        }

        public static ManagementAssociation New(string @id, global::System.Action<global::Pulumi.AzureNative.OperationsManagement.ManagementAssociationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.OperationsManagement.ManagementAssociationArgs @args = new();
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

            return new ManagementAssociation(@id, @args, @options);
        }

    }

}
