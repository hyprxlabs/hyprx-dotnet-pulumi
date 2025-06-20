// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ecs.Inputs;

namespace Pulumi.AwsNative.Ecs;

public static partial class ClusterConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Ecs.Inputs.ClusterConfigurationArgs WithExecuteCommandConfiguration(this global::Pulumi.AwsNative.Ecs.Inputs.ClusterConfigurationArgs @selfRef, global::Pulumi.AwsNative.Ecs.Inputs.ClusterExecuteCommandConfigurationArgs executeCommandConfiguration)
    {
        @selfRef.ExecuteCommandConfiguration = executeCommandConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.ClusterConfigurationArgs WithExecuteCommandConfiguration(this global::Pulumi.AwsNative.Ecs.Inputs.ClusterConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ecs.Inputs.ClusterExecuteCommandConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ecs.Inputs.ClusterExecuteCommandConfigurationArgs();
        @configure(@item);
        @selfRef.ExecuteCommandConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.ClusterConfigurationArgs WithManagedStorageConfiguration(this global::Pulumi.AwsNative.Ecs.Inputs.ClusterConfigurationArgs @selfRef, global::Pulumi.AwsNative.Ecs.Inputs.ClusterManagedStorageConfigurationArgs managedStorageConfiguration)
    {
        @selfRef.ManagedStorageConfiguration = managedStorageConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.ClusterConfigurationArgs WithManagedStorageConfiguration(this global::Pulumi.AwsNative.Ecs.Inputs.ClusterConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ecs.Inputs.ClusterManagedStorageConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ecs.Inputs.ClusterManagedStorageConfigurationArgs();
        @configure(@item);
        @selfRef.ManagedStorageConfiguration = @item;
        return @selfRef;
    }

}
