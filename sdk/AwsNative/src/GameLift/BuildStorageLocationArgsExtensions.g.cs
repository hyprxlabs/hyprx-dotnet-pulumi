// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.GameLift.Inputs;

namespace Pulumi.AwsNative.GameLift;

public static partial class BuildStorageLocationArgsExtensions
{
    public static global::Pulumi.AwsNative.GameLift.Inputs.BuildStorageLocationArgs WithBucket(this global::Pulumi.AwsNative.GameLift.Inputs.BuildStorageLocationArgs @selfRef, global::System.String bucket)
    {
        @selfRef.Bucket = bucket;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GameLift.Inputs.BuildStorageLocationArgs WithKey(this global::Pulumi.AwsNative.GameLift.Inputs.BuildStorageLocationArgs @selfRef, global::System.String key)
    {
        @selfRef.Key = key;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GameLift.Inputs.BuildStorageLocationArgs WithObjectVersion(this global::Pulumi.AwsNative.GameLift.Inputs.BuildStorageLocationArgs @selfRef, global::System.String objectVersion)
    {
        @selfRef.ObjectVersion = objectVersion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GameLift.Inputs.BuildStorageLocationArgs WithRoleArn(this global::Pulumi.AwsNative.GameLift.Inputs.BuildStorageLocationArgs @selfRef, global::System.String roleArn)
    {
        @selfRef.RoleArn = roleArn;
        return @selfRef;
    }

}
