// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class AzureDataLakeGen2DatastoreArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs WithAccountName(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs @selfRef, global::System.String accountName)
    {
        @selfRef.AccountName = accountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs WithDatastoreType(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs @selfRef, global::System.String datastoreType)
    {
        @selfRef.DatastoreType = datastoreType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs WithDescription(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs WithEndpoint(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs @selfRef, global::System.String endpoint)
    {
        @selfRef.Endpoint = endpoint;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs WithFilesystem(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs @selfRef, global::System.String filesystem)
    {
        @selfRef.Filesystem = filesystem;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Properties = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Properties = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs WithProtocol(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs @selfRef, global::System.String protocol)
    {
        @selfRef.Protocol = protocol;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs WithResourceGroup(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs @selfRef, global::System.String resourceGroup)
    {
        @selfRef.ResourceGroup = resourceGroup;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs WithServiceDataAccessAuthIdentity(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.ServiceDataAccessAuthIdentity> serviceDataAccessAuthIdentity)
    {
        @selfRef.ServiceDataAccessAuthIdentity = serviceDataAccessAuthIdentity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs WithSubscriptionId(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs @selfRef, global::System.String subscriptionId)
    {
        @selfRef.SubscriptionId = subscriptionId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs WithTags(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs WithTags(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs WithTags(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.AzureDataLakeGen2DatastoreArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
