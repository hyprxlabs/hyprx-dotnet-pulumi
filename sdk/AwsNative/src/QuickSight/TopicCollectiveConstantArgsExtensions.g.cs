// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TopicCollectiveConstantArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TopicCollectiveConstantArgs WithValueList(this global::Pulumi.AwsNative.QuickSight.Inputs.TopicCollectiveConstantArgs @selfRef, global::System.Collections.Generic.List<global::System.String> valueList)
    {
        @selfRef.ValueList = valueList;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TopicCollectiveConstantArgs WithValueList(this global::Pulumi.AwsNative.QuickSight.Inputs.TopicCollectiveConstantArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ValueList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TopicCollectiveConstantArgs WithValueList(this global::Pulumi.AwsNative.QuickSight.Inputs.TopicCollectiveConstantArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ValueList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
