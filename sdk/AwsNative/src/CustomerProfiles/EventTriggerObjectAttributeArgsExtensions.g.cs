// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.CustomerProfiles.Inputs;

namespace Pulumi.AwsNative.CustomerProfiles;

public static partial class EventTriggerObjectAttributeArgsExtensions
{
    public static global::Pulumi.AwsNative.CustomerProfiles.Inputs.EventTriggerObjectAttributeArgs WithComparisonOperator(this global::Pulumi.AwsNative.CustomerProfiles.Inputs.EventTriggerObjectAttributeArgs @selfRef, global::Pulumi.AwsNative.CustomerProfiles.EventTriggerObjectAttributeComparisonOperator comparisonOperator)
    {
        @selfRef.ComparisonOperator = comparisonOperator;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CustomerProfiles.Inputs.EventTriggerObjectAttributeArgs WithComparisonOperator(this global::Pulumi.AwsNative.CustomerProfiles.Inputs.EventTriggerObjectAttributeArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CustomerProfiles.EventTriggerObjectAttributeComparisonOperator> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.CustomerProfiles.EventTriggerObjectAttributeComparisonOperator>();
        @configure(@item);
        @selfRef.ComparisonOperator = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CustomerProfiles.Inputs.EventTriggerObjectAttributeArgs WithFieldName(this global::Pulumi.AwsNative.CustomerProfiles.Inputs.EventTriggerObjectAttributeArgs @selfRef, global::System.String fieldName)
    {
        @selfRef.FieldName = fieldName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CustomerProfiles.Inputs.EventTriggerObjectAttributeArgs WithSource(this global::Pulumi.AwsNative.CustomerProfiles.Inputs.EventTriggerObjectAttributeArgs @selfRef, global::System.String source)
    {
        @selfRef.Source = source;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CustomerProfiles.Inputs.EventTriggerObjectAttributeArgs WithValues(this global::Pulumi.AwsNative.CustomerProfiles.Inputs.EventTriggerObjectAttributeArgs @selfRef, global::System.Collections.Generic.List<global::System.String> values)
    {
        @selfRef.Values = values;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CustomerProfiles.Inputs.EventTriggerObjectAttributeArgs WithValues(this global::Pulumi.AwsNative.CustomerProfiles.Inputs.EventTriggerObjectAttributeArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Values = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CustomerProfiles.Inputs.EventTriggerObjectAttributeArgs WithValues(this global::Pulumi.AwsNative.CustomerProfiles.Inputs.EventTriggerObjectAttributeArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Values = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
