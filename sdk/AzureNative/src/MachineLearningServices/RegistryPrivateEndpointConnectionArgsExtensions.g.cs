// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class RegistryPrivateEndpointConnectionArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.RegistryPrivateEndpointConnectionArgs WithId(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.RegistryPrivateEndpointConnectionArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.RegistryPrivateEndpointConnectionArgs WithLocation(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.RegistryPrivateEndpointConnectionArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.RegistryPrivateEndpointConnectionArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.RegistryPrivateEndpointConnectionArgs @selfRef, global::Pulumi.AzureNative.MachineLearningServices.Inputs.RegistryPrivateEndpointConnectionPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.RegistryPrivateEndpointConnectionArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.RegistryPrivateEndpointConnectionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.Inputs.RegistryPrivateEndpointConnectionPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MachineLearningServices.Inputs.RegistryPrivateEndpointConnectionPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

}
