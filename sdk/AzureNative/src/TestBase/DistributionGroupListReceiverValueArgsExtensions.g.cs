// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.TestBase.Inputs;

namespace Pulumi.AzureNative.TestBase;

public static partial class DistributionGroupListReceiverValueArgsExtensions
{
    public static global::Pulumi.AzureNative.TestBase.Inputs.DistributionGroupListReceiverValueArgs WithDistributionGroups(this global::Pulumi.AzureNative.TestBase.Inputs.DistributionGroupListReceiverValueArgs @selfRef, global::System.Collections.Generic.List<global::System.String> distributionGroups)
    {
        @selfRef.DistributionGroups = distributionGroups;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.Inputs.DistributionGroupListReceiverValueArgs WithDistributionGroups(this global::Pulumi.AzureNative.TestBase.Inputs.DistributionGroupListReceiverValueArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.DistributionGroups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.Inputs.DistributionGroupListReceiverValueArgs WithDistributionGroups(this global::Pulumi.AzureNative.TestBase.Inputs.DistributionGroupListReceiverValueArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.DistributionGroups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
