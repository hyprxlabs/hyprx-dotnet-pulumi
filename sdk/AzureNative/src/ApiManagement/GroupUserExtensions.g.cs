// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ApiManagement;

public static partial class GroupUserExtensions
{

    extension(GroupUser)
    {
        public static GroupUser New(string @id, global::Pulumi.AzureNative.ApiManagement.GroupUserArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new GroupUser(@id, @args, @options);
        }

        public static GroupUser New(string @id, global::System.Action<global::Pulumi.AzureNative.ApiManagement.GroupUserArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.ApiManagement.GroupUserArgs @args = new();
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

            return new GroupUser(@id, @args, @options);
        }

    }

}
