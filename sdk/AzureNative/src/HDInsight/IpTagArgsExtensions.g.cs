// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HDInsight.Inputs;

namespace Pulumi.AzureNative.HDInsight;

public static partial class IpTagArgsExtensions
{
    public static global::Pulumi.AzureNative.HDInsight.Inputs.IpTagArgs WithIpTagType(this global::Pulumi.AzureNative.HDInsight.Inputs.IpTagArgs @selfRef, global::System.String ipTagType)
    {
        @selfRef.IpTagType = ipTagType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.Inputs.IpTagArgs WithTag(this global::Pulumi.AzureNative.HDInsight.Inputs.IpTagArgs @selfRef, global::System.String tag)
    {
        @selfRef.Tag = tag;
        return @selfRef;
    }

}
