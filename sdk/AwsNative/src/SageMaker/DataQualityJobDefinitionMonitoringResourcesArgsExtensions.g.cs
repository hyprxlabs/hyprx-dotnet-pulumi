// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class DataQualityJobDefinitionMonitoringResourcesArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionMonitoringResourcesArgs WithClusterConfig(this global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionMonitoringResourcesArgs @selfRef, global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionClusterConfigArgs clusterConfig)
    {
        @selfRef.ClusterConfig = clusterConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionMonitoringResourcesArgs WithClusterConfig(this global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionMonitoringResourcesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionClusterConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionClusterConfigArgs();
        @configure(@item);
        @selfRef.ClusterConfig = @item;
        return @selfRef;
    }

}
