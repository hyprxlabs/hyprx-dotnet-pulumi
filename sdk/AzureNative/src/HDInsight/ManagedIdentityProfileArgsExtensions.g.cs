// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HDInsight.Inputs;

namespace Pulumi.AzureNative.HDInsight;

public static partial class ManagedIdentityProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.HDInsight.Inputs.ManagedIdentityProfileArgs WithIdentityList(this global::Pulumi.AzureNative.HDInsight.Inputs.ManagedIdentityProfileArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.HDInsight.Inputs.ManagedIdentitySpecArgs> identityList)
    {
        @selfRef.IdentityList = identityList;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.Inputs.ManagedIdentityProfileArgs WithIdentityList(this global::Pulumi.AzureNative.HDInsight.Inputs.ManagedIdentityProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.HDInsight.Inputs.ManagedIdentitySpecArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.HDInsight.Inputs.ManagedIdentitySpecArgs>();
        @configure(@list);
        @selfRef.IdentityList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.Inputs.ManagedIdentityProfileArgs WithIdentityList(this global::Pulumi.AzureNative.HDInsight.Inputs.ManagedIdentityProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.HDInsight.Inputs.ManagedIdentitySpecArgs>> @create)
    {
        @selfRef.IdentityList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
