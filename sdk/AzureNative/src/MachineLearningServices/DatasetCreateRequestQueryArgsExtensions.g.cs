// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class DatasetCreateRequestQueryArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.DatasetCreateRequestQueryArgs WithDatastoreName(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.DatasetCreateRequestQueryArgs @selfRef, global::System.String datastoreName)
    {
        @selfRef.DatastoreName = datastoreName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.DatasetCreateRequestQueryArgs WithQuery(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.DatasetCreateRequestQueryArgs @selfRef, global::System.String query)
    {
        @selfRef.Query = query;
        return @selfRef;
    }

}
