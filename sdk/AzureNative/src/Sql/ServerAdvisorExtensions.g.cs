// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Sql;

public static partial class ServerAdvisorExtensions
{

    extension(ServerAdvisor)
    {
        public static ServerAdvisor New(string @id, global::Pulumi.AzureNative.Sql.ServerAdvisorArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ServerAdvisor(@id, @args, @options);
        }

        public static ServerAdvisor New(string @id, global::System.Action<global::Pulumi.AzureNative.Sql.ServerAdvisorArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Sql.ServerAdvisorArgs @args = new();
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

            return new ServerAdvisor(@id, @args, @options);
        }

    }

}
