// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Kms;

public static partial class ReplicaKeyArgsExtensions
{
    public static global::Pulumi.AwsNative.Kms.ReplicaKeyArgs WithDescription(this global::Pulumi.AwsNative.Kms.ReplicaKeyArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kms.ReplicaKeyArgs WithEnabled(this global::Pulumi.AwsNative.Kms.ReplicaKeyArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kms.ReplicaKeyArgs WithKeyPolicy(this global::Pulumi.AwsNative.Kms.ReplicaKeyArgs @selfRef, global::System.Object keyPolicy)
    {
        @selfRef.KeyPolicy = keyPolicy;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kms.ReplicaKeyArgs WithKeyPolicy(this global::Pulumi.AwsNative.Kms.ReplicaKeyArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.KeyPolicy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kms.ReplicaKeyArgs WithPendingWindowInDays(this global::Pulumi.AwsNative.Kms.ReplicaKeyArgs @selfRef, global::System.Int32 pendingWindowInDays)
    {
        @selfRef.PendingWindowInDays = pendingWindowInDays;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kms.ReplicaKeyArgs WithPrimaryKeyArn(this global::Pulumi.AwsNative.Kms.ReplicaKeyArgs @selfRef, global::System.String primaryKeyArn)
    {
        @selfRef.PrimaryKeyArn = primaryKeyArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kms.ReplicaKeyArgs WithTags(this global::Pulumi.AwsNative.Kms.ReplicaKeyArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kms.ReplicaKeyArgs WithTags(this global::Pulumi.AwsNative.Kms.ReplicaKeyArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kms.ReplicaKeyArgs WithTags(this global::Pulumi.AwsNative.Kms.ReplicaKeyArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
