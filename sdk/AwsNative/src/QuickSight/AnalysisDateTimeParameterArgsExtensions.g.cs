// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisDateTimeParameterArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDateTimeParameterArgs WithName(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDateTimeParameterArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDateTimeParameterArgs WithValues(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDateTimeParameterArgs @selfRef, global::System.Collections.Generic.List<global::System.String> values)
    {
        @selfRef.Values = values;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDateTimeParameterArgs WithValues(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDateTimeParameterArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Values = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDateTimeParameterArgs WithValues(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDateTimeParameterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Values = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
