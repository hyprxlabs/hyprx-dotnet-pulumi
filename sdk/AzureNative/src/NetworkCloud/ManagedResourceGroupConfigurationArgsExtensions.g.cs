// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.NetworkCloud.Inputs;

namespace Pulumi.AzureNative.NetworkCloud;

public static partial class ManagedResourceGroupConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.NetworkCloud.Inputs.ManagedResourceGroupConfigurationArgs WithLocation(this global::Pulumi.AzureNative.NetworkCloud.Inputs.ManagedResourceGroupConfigurationArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.Inputs.ManagedResourceGroupConfigurationArgs WithName(this global::Pulumi.AzureNative.NetworkCloud.Inputs.ManagedResourceGroupConfigurationArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

}
