// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class AwsMacie2JobSummaryPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs WithBucketCriteria(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.S3BucketCriteriaForJobArgs bucketCriteria)
    {
        @selfRef.BucketCriteria = bucketCriteria;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs WithBucketCriteria(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.S3BucketCriteriaForJobArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.S3BucketCriteriaForJobArgs();
        @configure(@item);
        @selfRef.BucketCriteria = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs WithBucketDefinitions(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.S3BucketDefinitionForJobArgs> bucketDefinitions)
    {
        @selfRef.BucketDefinitions = bucketDefinitions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs WithBucketDefinitions(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.S3BucketDefinitionForJobArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.S3BucketDefinitionForJobArgs>();
        @configure(@list);
        @selfRef.BucketDefinitions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs WithBucketDefinitions(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.S3BucketDefinitionForJobArgs>> @create)
    {
        @selfRef.BucketDefinitions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs WithCreatedAt(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs @selfRef, global::System.String createdAt)
    {
        @selfRef.CreatedAt = createdAt;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs WithJobId(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs @selfRef, global::System.String jobId)
    {
        @selfRef.JobId = jobId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs WithJobStatus(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.JobStatusEnumValueArgs jobStatus)
    {
        @selfRef.JobStatus = jobStatus;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs WithJobStatus(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.JobStatusEnumValueArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.JobStatusEnumValueArgs();
        @configure(@item);
        @selfRef.JobStatus = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs WithJobType(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.JobTypeEnumValueArgs jobType)
    {
        @selfRef.JobType = jobType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs WithJobType(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.JobTypeEnumValueArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.JobTypeEnumValueArgs();
        @configure(@item);
        @selfRef.JobType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs WithLastRunErrorStatus(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.LastRunErrorStatusArgs lastRunErrorStatus)
    {
        @selfRef.LastRunErrorStatus = lastRunErrorStatus;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs WithLastRunErrorStatus(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.LastRunErrorStatusArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.LastRunErrorStatusArgs();
        @configure(@item);
        @selfRef.LastRunErrorStatus = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs WithName(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs WithUserPausedDetails(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.UserPausedDetailsArgs userPausedDetails)
    {
        @selfRef.UserPausedDetails = userPausedDetails;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs WithUserPausedDetails(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacie2JobSummaryPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.UserPausedDetailsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.UserPausedDetailsArgs();
        @configure(@item);
        @selfRef.UserPausedDetails = @item;
        return @selfRef;
    }

}
