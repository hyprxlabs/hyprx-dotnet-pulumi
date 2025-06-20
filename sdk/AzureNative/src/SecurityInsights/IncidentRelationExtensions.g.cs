// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.SecurityInsights;

public static partial class IncidentRelationExtensions
{

    extension(IncidentRelation)
    {
        public static IncidentRelation New(string @id, global::Pulumi.AzureNative.SecurityInsights.IncidentRelationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new IncidentRelation(@id, @args, @options);
        }

        public static IncidentRelation New(string @id, global::System.Action<global::Pulumi.AzureNative.SecurityInsights.IncidentRelationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.SecurityInsights.IncidentRelationArgs @args = new();
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

            return new IncidentRelation(@id, @args, @options);
        }

    }

}
