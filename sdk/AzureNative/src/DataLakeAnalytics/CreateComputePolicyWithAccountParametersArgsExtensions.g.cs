// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataLakeAnalytics.Inputs;

namespace Pulumi.AzureNative.DataLakeAnalytics;

public static partial class CreateComputePolicyWithAccountParametersArgsExtensions
{
    public static global::Pulumi.AzureNative.DataLakeAnalytics.Inputs.CreateComputePolicyWithAccountParametersArgs WithMaxDegreeOfParallelismPerJob(this global::Pulumi.AzureNative.DataLakeAnalytics.Inputs.CreateComputePolicyWithAccountParametersArgs @selfRef, global::System.Int32 maxDegreeOfParallelismPerJob)
    {
        @selfRef.MaxDegreeOfParallelismPerJob = maxDegreeOfParallelismPerJob;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeAnalytics.Inputs.CreateComputePolicyWithAccountParametersArgs WithMinPriorityPerJob(this global::Pulumi.AzureNative.DataLakeAnalytics.Inputs.CreateComputePolicyWithAccountParametersArgs @selfRef, global::System.Int32 minPriorityPerJob)
    {
        @selfRef.MinPriorityPerJob = minPriorityPerJob;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeAnalytics.Inputs.CreateComputePolicyWithAccountParametersArgs WithName(this global::Pulumi.AzureNative.DataLakeAnalytics.Inputs.CreateComputePolicyWithAccountParametersArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeAnalytics.Inputs.CreateComputePolicyWithAccountParametersArgs WithObjectId(this global::Pulumi.AzureNative.DataLakeAnalytics.Inputs.CreateComputePolicyWithAccountParametersArgs @selfRef, global::System.String objectId)
    {
        @selfRef.ObjectId = objectId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeAnalytics.Inputs.CreateComputePolicyWithAccountParametersArgs WithObjectType(this global::Pulumi.AzureNative.DataLakeAnalytics.Inputs.CreateComputePolicyWithAccountParametersArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DataLakeAnalytics.AADObjectType> objectType)
    {
        @selfRef.ObjectType = objectType;
        return @selfRef;
    }

}
