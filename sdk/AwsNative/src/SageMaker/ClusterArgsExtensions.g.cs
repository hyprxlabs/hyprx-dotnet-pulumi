// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.SageMaker;

public static partial class ClusterArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.ClusterArgs WithClusterName(this global::Pulumi.AwsNative.SageMaker.ClusterArgs @selfRef, global::System.String clusterName)
    {
        @selfRef.ClusterName = clusterName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ClusterArgs WithInstanceGroups(this global::Pulumi.AwsNative.SageMaker.ClusterArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.Inputs.ClusterInstanceGroupArgs> instanceGroups)
    {
        @selfRef.InstanceGroups = instanceGroups;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ClusterArgs WithInstanceGroups(this global::Pulumi.AwsNative.SageMaker.ClusterArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.Inputs.ClusterInstanceGroupArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.Inputs.ClusterInstanceGroupArgs>();
        @configure(@list);
        @selfRef.InstanceGroups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ClusterArgs WithInstanceGroups(this global::Pulumi.AwsNative.SageMaker.ClusterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.SageMaker.Inputs.ClusterInstanceGroupArgs>> @create)
    {
        @selfRef.InstanceGroups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ClusterArgs WithNodeRecovery(this global::Pulumi.AwsNative.SageMaker.ClusterArgs @selfRef, global::Pulumi.AwsNative.SageMaker.ClusterNodeRecovery nodeRecovery)
    {
        @selfRef.NodeRecovery = nodeRecovery;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ClusterArgs WithNodeRecovery(this global::Pulumi.AwsNative.SageMaker.ClusterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.ClusterNodeRecovery> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.SageMaker.ClusterNodeRecovery>();
        @configure(@item);
        @selfRef.NodeRecovery = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ClusterArgs WithOrchestrator(this global::Pulumi.AwsNative.SageMaker.ClusterArgs @selfRef, global::Pulumi.AwsNative.SageMaker.Inputs.ClusterOrchestratorArgs orchestrator)
    {
        @selfRef.Orchestrator = orchestrator;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ClusterArgs WithOrchestrator(this global::Pulumi.AwsNative.SageMaker.ClusterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.Inputs.ClusterOrchestratorArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.SageMaker.Inputs.ClusterOrchestratorArgs();
        @configure(@item);
        @selfRef.Orchestrator = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ClusterArgs WithTags(this global::Pulumi.AwsNative.SageMaker.ClusterArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ClusterArgs WithTags(this global::Pulumi.AwsNative.SageMaker.ClusterArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ClusterArgs WithTags(this global::Pulumi.AwsNative.SageMaker.ClusterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ClusterArgs WithVpcConfig(this global::Pulumi.AwsNative.SageMaker.ClusterArgs @selfRef, global::Pulumi.AwsNative.SageMaker.Inputs.ClusterVpcConfigArgs vpcConfig)
    {
        @selfRef.VpcConfig = vpcConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ClusterArgs WithVpcConfig(this global::Pulumi.AwsNative.SageMaker.ClusterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.Inputs.ClusterVpcConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.SageMaker.Inputs.ClusterVpcConfigArgs();
        @configure(@item);
        @selfRef.VpcConfig = @item;
        return @selfRef;
    }

}
