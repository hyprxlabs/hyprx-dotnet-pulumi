// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Connect;

public static partial class SecurityKeyArgsExtensions
{
    public static global::Pulumi.AwsNative.Connect.SecurityKeyArgs WithInstanceId(this global::Pulumi.AwsNative.Connect.SecurityKeyArgs @selfRef, global::System.String instanceId)
    {
        @selfRef.InstanceId = instanceId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.SecurityKeyArgs WithKey(this global::Pulumi.AwsNative.Connect.SecurityKeyArgs @selfRef, global::System.String key)
    {
        @selfRef.Key = key;
        return @selfRef;
    }

}
