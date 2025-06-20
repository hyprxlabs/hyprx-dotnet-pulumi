// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Msk;

public static partial class BatchScramSecretArgsExtensions
{
    public static global::Pulumi.AwsNative.Msk.BatchScramSecretArgs WithClusterArn(this global::Pulumi.AwsNative.Msk.BatchScramSecretArgs @selfRef, global::System.String clusterArn)
    {
        @selfRef.ClusterArn = clusterArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Msk.BatchScramSecretArgs WithSecretArnList(this global::Pulumi.AwsNative.Msk.BatchScramSecretArgs @selfRef, global::System.Collections.Generic.List<global::System.String> secretArnList)
    {
        @selfRef.SecretArnList = secretArnList;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Msk.BatchScramSecretArgs WithSecretArnList(this global::Pulumi.AwsNative.Msk.BatchScramSecretArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SecretArnList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Msk.BatchScramSecretArgs WithSecretArnList(this global::Pulumi.AwsNative.Msk.BatchScramSecretArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SecretArnList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
