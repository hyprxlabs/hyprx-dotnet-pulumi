// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.CloudTrail.Inputs;

namespace Pulumi.AwsNative.CloudTrail;

public static partial class TrailAdvancedEventSelectorArgsExtensions
{
    public static global::Pulumi.AwsNative.CloudTrail.Inputs.TrailAdvancedEventSelectorArgs WithFieldSelectors(this global::Pulumi.AwsNative.CloudTrail.Inputs.TrailAdvancedEventSelectorArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.CloudTrail.Inputs.TrailAdvancedFieldSelectorArgs> fieldSelectors)
    {
        @selfRef.FieldSelectors = fieldSelectors;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudTrail.Inputs.TrailAdvancedEventSelectorArgs WithFieldSelectors(this global::Pulumi.AwsNative.CloudTrail.Inputs.TrailAdvancedEventSelectorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.CloudTrail.Inputs.TrailAdvancedFieldSelectorArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.CloudTrail.Inputs.TrailAdvancedFieldSelectorArgs>();
        @configure(@list);
        @selfRef.FieldSelectors = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudTrail.Inputs.TrailAdvancedEventSelectorArgs WithFieldSelectors(this global::Pulumi.AwsNative.CloudTrail.Inputs.TrailAdvancedEventSelectorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.CloudTrail.Inputs.TrailAdvancedFieldSelectorArgs>> @create)
    {
        @selfRef.FieldSelectors = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudTrail.Inputs.TrailAdvancedEventSelectorArgs WithName(this global::Pulumi.AwsNative.CloudTrail.Inputs.TrailAdvancedEventSelectorArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

}
