// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ApiManagement;

public static partial class GraphQLApiResolverPolicyExtensions
{

    extension(GraphQLApiResolverPolicy)
    {
        public static GraphQLApiResolverPolicy New(string @id, global::Pulumi.AzureNative.ApiManagement.GraphQLApiResolverPolicyArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new GraphQLApiResolverPolicy(@id, @args, @options);
        }

        public static GraphQLApiResolverPolicy New(string @id, global::System.Action<global::Pulumi.AzureNative.ApiManagement.GraphQLApiResolverPolicyArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.ApiManagement.GraphQLApiResolverPolicyArgs @args = new();
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

            return new GraphQLApiResolverPolicy(@id, @args, @options);
        }

    }

}
