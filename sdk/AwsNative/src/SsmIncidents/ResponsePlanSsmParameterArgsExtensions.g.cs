// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SsmIncidents.Inputs;

namespace Pulumi.AwsNative.SsmIncidents;

public static partial class ResponsePlanSsmParameterArgsExtensions
{
    public static global::Pulumi.AwsNative.SsmIncidents.Inputs.ResponsePlanSsmParameterArgs WithKey(this global::Pulumi.AwsNative.SsmIncidents.Inputs.ResponsePlanSsmParameterArgs @selfRef, global::System.String key)
    {
        @selfRef.Key = key;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmIncidents.Inputs.ResponsePlanSsmParameterArgs WithValues(this global::Pulumi.AwsNative.SsmIncidents.Inputs.ResponsePlanSsmParameterArgs @selfRef, global::System.Collections.Generic.List<global::System.String> values)
    {
        @selfRef.Values = values;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmIncidents.Inputs.ResponsePlanSsmParameterArgs WithValues(this global::Pulumi.AwsNative.SsmIncidents.Inputs.ResponsePlanSsmParameterArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Values = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmIncidents.Inputs.ResponsePlanSsmParameterArgs WithValues(this global::Pulumi.AwsNative.SsmIncidents.Inputs.ResponsePlanSsmParameterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Values = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
