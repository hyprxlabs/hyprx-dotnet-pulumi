// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class RegistryEnvironmentVersionArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.RegistryEnvironmentVersionArgs WithEnvironmentName(this global::Pulumi.AzureNative.MachineLearningServices.RegistryEnvironmentVersionArgs @selfRef, global::System.String environmentName)
    {
        @selfRef.EnvironmentName = environmentName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.RegistryEnvironmentVersionArgs WithEnvironmentVersionProperties(this global::Pulumi.AzureNative.MachineLearningServices.RegistryEnvironmentVersionArgs @selfRef, global::Pulumi.AzureNative.MachineLearningServices.Inputs.EnvironmentVersionArgs environmentVersionProperties)
    {
        @selfRef.EnvironmentVersionProperties = environmentVersionProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.RegistryEnvironmentVersionArgs WithEnvironmentVersionProperties(this global::Pulumi.AzureNative.MachineLearningServices.RegistryEnvironmentVersionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.Inputs.EnvironmentVersionArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MachineLearningServices.Inputs.EnvironmentVersionArgs();
        @configure(@item);
        @selfRef.EnvironmentVersionProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.RegistryEnvironmentVersionArgs WithRegistryName(this global::Pulumi.AzureNative.MachineLearningServices.RegistryEnvironmentVersionArgs @selfRef, global::System.String registryName)
    {
        @selfRef.RegistryName = registryName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.RegistryEnvironmentVersionArgs WithResourceGroupName(this global::Pulumi.AzureNative.MachineLearningServices.RegistryEnvironmentVersionArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.RegistryEnvironmentVersionArgs WithVersion(this global::Pulumi.AzureNative.MachineLearningServices.RegistryEnvironmentVersionArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
