// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AppConfiguration;

public static partial class ReplicaArgsExtensions
{
    public static global::Pulumi.AzureNative.AppConfiguration.ReplicaArgs WithConfigStoreName(this global::Pulumi.AzureNative.AppConfiguration.ReplicaArgs @selfRef, global::System.String configStoreName)
    {
        @selfRef.ConfigStoreName = configStoreName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ReplicaArgs WithLocation(this global::Pulumi.AzureNative.AppConfiguration.ReplicaArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ReplicaArgs WithReplicaName(this global::Pulumi.AzureNative.AppConfiguration.ReplicaArgs @selfRef, global::System.String replicaName)
    {
        @selfRef.ReplicaName = replicaName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ReplicaArgs WithResourceGroupName(this global::Pulumi.AzureNative.AppConfiguration.ReplicaArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

}
