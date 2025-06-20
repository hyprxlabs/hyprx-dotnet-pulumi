// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.HybridNetwork;

public static partial class ConfigurationGroupValueArgsExtensions
{
    public static global::Pulumi.AzureNative.HybridNetwork.ConfigurationGroupValueArgs WithConfigurationGroupValueName(this global::Pulumi.AzureNative.HybridNetwork.ConfigurationGroupValueArgs @selfRef, global::System.String configurationGroupValueName)
    {
        @selfRef.ConfigurationGroupValueName = configurationGroupValueName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.ConfigurationGroupValueArgs WithLocation(this global::Pulumi.AzureNative.HybridNetwork.ConfigurationGroupValueArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.ConfigurationGroupValueArgs WithProperties(this global::Pulumi.AzureNative.HybridNetwork.ConfigurationGroupValueArgs @selfRef, global::Pulumi.Union<global::Pulumi.AzureNative.HybridNetwork.Inputs.ConfigurationValueWithSecretsArgs, global::Pulumi.AzureNative.HybridNetwork.Inputs.ConfigurationValueWithoutSecretsArgs> properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.ConfigurationGroupValueArgs WithResourceGroupName(this global::Pulumi.AzureNative.HybridNetwork.ConfigurationGroupValueArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.ConfigurationGroupValueArgs WithTags(this global::Pulumi.AzureNative.HybridNetwork.ConfigurationGroupValueArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.ConfigurationGroupValueArgs WithTags(this global::Pulumi.AzureNative.HybridNetwork.ConfigurationGroupValueArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.ConfigurationGroupValueArgs WithTags(this global::Pulumi.AzureNative.HybridNetwork.ConfigurationGroupValueArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
