// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.DataBrew.Inputs;

namespace Pulumi.AwsNative.DataBrew;

public static partial class RecipeActionArgsExtensions
{
    public static global::Pulumi.AwsNative.DataBrew.Inputs.RecipeActionArgs WithOperation(this global::Pulumi.AwsNative.DataBrew.Inputs.RecipeActionArgs @selfRef, global::System.String operation)
    {
        @selfRef.Operation = operation;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataBrew.Inputs.RecipeActionArgs WithParameters(this global::Pulumi.AwsNative.DataBrew.Inputs.RecipeActionArgs @selfRef, global::Pulumi.Union<global::Pulumi.AwsNative.DataBrew.Inputs.RecipeParametersArgs, global::System.Collections.Immutable.ImmutableDictionary<global::System.String, global::System.String>> parameters)
    {
        @selfRef.Parameters = parameters;
        return @selfRef;
    }

}
