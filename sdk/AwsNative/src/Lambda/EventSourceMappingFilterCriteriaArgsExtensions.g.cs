// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Lambda.Inputs;

namespace Pulumi.AwsNative.Lambda;

public static partial class EventSourceMappingFilterCriteriaArgsExtensions
{
    public static global::Pulumi.AwsNative.Lambda.Inputs.EventSourceMappingFilterCriteriaArgs WithFilters(this global::Pulumi.AwsNative.Lambda.Inputs.EventSourceMappingFilterCriteriaArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Lambda.Inputs.EventSourceMappingFilterArgs> filters)
    {
        @selfRef.Filters = filters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lambda.Inputs.EventSourceMappingFilterCriteriaArgs WithFilters(this global::Pulumi.AwsNative.Lambda.Inputs.EventSourceMappingFilterCriteriaArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Lambda.Inputs.EventSourceMappingFilterArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Lambda.Inputs.EventSourceMappingFilterArgs>();
        @configure(@list);
        @selfRef.Filters = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lambda.Inputs.EventSourceMappingFilterCriteriaArgs WithFilters(this global::Pulumi.AwsNative.Lambda.Inputs.EventSourceMappingFilterCriteriaArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Lambda.Inputs.EventSourceMappingFilterArgs>> @create)
    {
        @selfRef.Filters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
