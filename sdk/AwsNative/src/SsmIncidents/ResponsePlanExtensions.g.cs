// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.SsmIncidents;

public static partial class ResponsePlanExtensions
{

    extension(ResponsePlan)
    {
        public static ResponsePlan New(string @id, global::Pulumi.AwsNative.SsmIncidents.ResponsePlanArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ResponsePlan(@id, @args, @options);
        }

        public static ResponsePlan New(string @id, global::System.Action<global::Pulumi.AwsNative.SsmIncidents.ResponsePlanArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.SsmIncidents.ResponsePlanArgs @args = new();
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

            return new ResponsePlan(@id, @args, @options);
        }

    }

}
