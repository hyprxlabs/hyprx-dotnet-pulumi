// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class GuardrailContentPolicyConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.GuardrailContentPolicyConfigArgs WithFiltersConfig(this global::Pulumi.AwsNative.Bedrock.Inputs.GuardrailContentPolicyConfigArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Bedrock.Inputs.GuardrailContentFilterConfigArgs> filtersConfig)
    {
        @selfRef.FiltersConfig = filtersConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.GuardrailContentPolicyConfigArgs WithFiltersConfig(this global::Pulumi.AwsNative.Bedrock.Inputs.GuardrailContentPolicyConfigArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Bedrock.Inputs.GuardrailContentFilterConfigArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Bedrock.Inputs.GuardrailContentFilterConfigArgs>();
        @configure(@list);
        @selfRef.FiltersConfig = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.GuardrailContentPolicyConfigArgs WithFiltersConfig(this global::Pulumi.AwsNative.Bedrock.Inputs.GuardrailContentPolicyConfigArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Bedrock.Inputs.GuardrailContentFilterConfigArgs>> @create)
    {
        @selfRef.FiltersConfig = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
