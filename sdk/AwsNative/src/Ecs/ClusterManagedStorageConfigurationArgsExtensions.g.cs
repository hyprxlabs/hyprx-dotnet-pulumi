// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ecs.Inputs;

namespace Pulumi.AwsNative.Ecs;

public static partial class ClusterManagedStorageConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Ecs.Inputs.ClusterManagedStorageConfigurationArgs WithFargateEphemeralStorageKmsKeyId(this global::Pulumi.AwsNative.Ecs.Inputs.ClusterManagedStorageConfigurationArgs @selfRef, global::System.String fargateEphemeralStorageKmsKeyId)
    {
        @selfRef.FargateEphemeralStorageKmsKeyId = fargateEphemeralStorageKmsKeyId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.ClusterManagedStorageConfigurationArgs WithKmsKeyId(this global::Pulumi.AwsNative.Ecs.Inputs.ClusterManagedStorageConfigurationArgs @selfRef, global::System.String kmsKeyId)
    {
        @selfRef.KmsKeyId = kmsKeyId;
        return @selfRef;
    }

}
