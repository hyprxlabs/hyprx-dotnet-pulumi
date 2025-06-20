// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Events.Inputs;

namespace Pulumi.AwsNative.Events;

public static partial class RuleTargetArgsExtensions
{
    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithAppSyncParameters(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::Pulumi.AwsNative.Events.Inputs.RuleAppSyncParametersArgs appSyncParameters)
    {
        @selfRef.AppSyncParameters = appSyncParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithAppSyncParameters(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Events.Inputs.RuleAppSyncParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Events.Inputs.RuleAppSyncParametersArgs();
        @configure(@item);
        @selfRef.AppSyncParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithArn(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::System.String arn)
    {
        @selfRef.Arn = arn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithBatchParameters(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::Pulumi.AwsNative.Events.Inputs.RuleBatchParametersArgs batchParameters)
    {
        @selfRef.BatchParameters = batchParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithBatchParameters(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Events.Inputs.RuleBatchParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Events.Inputs.RuleBatchParametersArgs();
        @configure(@item);
        @selfRef.BatchParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithDeadLetterConfig(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::Pulumi.AwsNative.Events.Inputs.RuleDeadLetterConfigArgs deadLetterConfig)
    {
        @selfRef.DeadLetterConfig = deadLetterConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithDeadLetterConfig(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Events.Inputs.RuleDeadLetterConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Events.Inputs.RuleDeadLetterConfigArgs();
        @configure(@item);
        @selfRef.DeadLetterConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithEcsParameters(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs ecsParameters)
    {
        @selfRef.EcsParameters = ecsParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithEcsParameters(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs();
        @configure(@item);
        @selfRef.EcsParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithHttpParameters(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::Pulumi.AwsNative.Events.Inputs.RuleHttpParametersArgs httpParameters)
    {
        @selfRef.HttpParameters = httpParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithHttpParameters(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Events.Inputs.RuleHttpParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Events.Inputs.RuleHttpParametersArgs();
        @configure(@item);
        @selfRef.HttpParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithId(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithInput(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::System.String input)
    {
        @selfRef.Input = input;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithInputPath(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::System.String inputPath)
    {
        @selfRef.InputPath = inputPath;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithInputTransformer(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::Pulumi.AwsNative.Events.Inputs.RuleInputTransformerArgs inputTransformer)
    {
        @selfRef.InputTransformer = inputTransformer;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithInputTransformer(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Events.Inputs.RuleInputTransformerArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Events.Inputs.RuleInputTransformerArgs();
        @configure(@item);
        @selfRef.InputTransformer = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithKinesisParameters(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::Pulumi.AwsNative.Events.Inputs.RuleKinesisParametersArgs kinesisParameters)
    {
        @selfRef.KinesisParameters = kinesisParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithKinesisParameters(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Events.Inputs.RuleKinesisParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Events.Inputs.RuleKinesisParametersArgs();
        @configure(@item);
        @selfRef.KinesisParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithRedshiftDataParameters(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::Pulumi.AwsNative.Events.Inputs.RuleRedshiftDataParametersArgs redshiftDataParameters)
    {
        @selfRef.RedshiftDataParameters = redshiftDataParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithRedshiftDataParameters(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Events.Inputs.RuleRedshiftDataParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Events.Inputs.RuleRedshiftDataParametersArgs();
        @configure(@item);
        @selfRef.RedshiftDataParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithRetryPolicy(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::Pulumi.AwsNative.Events.Inputs.RuleRetryPolicyArgs retryPolicy)
    {
        @selfRef.RetryPolicy = retryPolicy;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithRetryPolicy(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Events.Inputs.RuleRetryPolicyArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Events.Inputs.RuleRetryPolicyArgs();
        @configure(@item);
        @selfRef.RetryPolicy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithRoleArn(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::System.String roleArn)
    {
        @selfRef.RoleArn = roleArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithRunCommandParameters(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::Pulumi.AwsNative.Events.Inputs.RuleRunCommandParametersArgs runCommandParameters)
    {
        @selfRef.RunCommandParameters = runCommandParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithRunCommandParameters(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Events.Inputs.RuleRunCommandParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Events.Inputs.RuleRunCommandParametersArgs();
        @configure(@item);
        @selfRef.RunCommandParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithSageMakerPipelineParameters(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::Pulumi.AwsNative.Events.Inputs.RuleSageMakerPipelineParametersArgs sageMakerPipelineParameters)
    {
        @selfRef.SageMakerPipelineParameters = sageMakerPipelineParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithSageMakerPipelineParameters(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Events.Inputs.RuleSageMakerPipelineParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Events.Inputs.RuleSageMakerPipelineParametersArgs();
        @configure(@item);
        @selfRef.SageMakerPipelineParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithSqsParameters(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::Pulumi.AwsNative.Events.Inputs.RuleSqsParametersArgs sqsParameters)
    {
        @selfRef.SqsParameters = sqsParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs WithSqsParameters(this global::Pulumi.AwsNative.Events.Inputs.RuleTargetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Events.Inputs.RuleSqsParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Events.Inputs.RuleSqsParametersArgs();
        @configure(@item);
        @selfRef.SqsParameters = @item;
        return @selfRef;
    }

}
