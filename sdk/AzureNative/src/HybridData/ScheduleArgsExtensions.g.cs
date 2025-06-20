// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HybridData.Inputs;

namespace Pulumi.AzureNative.HybridData;

public static partial class ScheduleArgsExtensions
{
    public static global::Pulumi.AzureNative.HybridData.Inputs.ScheduleArgs WithName(this global::Pulumi.AzureNative.HybridData.Inputs.ScheduleArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridData.Inputs.ScheduleArgs WithPolicyList(this global::Pulumi.AzureNative.HybridData.Inputs.ScheduleArgs @selfRef, global::System.Collections.Generic.List<global::System.String> policyList)
    {
        @selfRef.PolicyList = policyList;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridData.Inputs.ScheduleArgs WithPolicyList(this global::Pulumi.AzureNative.HybridData.Inputs.ScheduleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.PolicyList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridData.Inputs.ScheduleArgs WithPolicyList(this global::Pulumi.AzureNative.HybridData.Inputs.ScheduleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.PolicyList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
