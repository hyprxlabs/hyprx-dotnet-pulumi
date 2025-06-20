// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class DataQualityJobDefinitionMonitoringOutputConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionMonitoringOutputConfigArgs WithKmsKeyId(this global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionMonitoringOutputConfigArgs @selfRef, global::System.String kmsKeyId)
    {
        @selfRef.KmsKeyId = kmsKeyId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionMonitoringOutputConfigArgs WithMonitoringOutputs(this global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionMonitoringOutputConfigArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionMonitoringOutputArgs> monitoringOutputs)
    {
        @selfRef.MonitoringOutputs = monitoringOutputs;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionMonitoringOutputConfigArgs WithMonitoringOutputs(this global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionMonitoringOutputConfigArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionMonitoringOutputArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionMonitoringOutputArgs>();
        @configure(@list);
        @selfRef.MonitoringOutputs = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionMonitoringOutputConfigArgs WithMonitoringOutputs(this global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionMonitoringOutputConfigArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionMonitoringOutputArgs>> @create)
    {
        @selfRef.MonitoringOutputs = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
