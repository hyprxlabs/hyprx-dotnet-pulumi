// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Kms;

public static partial class AliasArgsExtensions
{
    public static global::Pulumi.AwsNative.Kms.AliasArgs WithAliasName(this global::Pulumi.AwsNative.Kms.AliasArgs @selfRef, global::System.String aliasName)
    {
        @selfRef.AliasName = aliasName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kms.AliasArgs WithTargetKeyId(this global::Pulumi.AwsNative.Kms.AliasArgs @selfRef, global::System.String targetKeyId)
    {
        @selfRef.TargetKeyId = targetKeyId;
        return @selfRef;
    }

}
