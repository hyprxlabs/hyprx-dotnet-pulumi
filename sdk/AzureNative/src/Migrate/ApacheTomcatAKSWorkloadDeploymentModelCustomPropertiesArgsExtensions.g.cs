// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Migrate.Inputs;

namespace Pulumi.AzureNative.Migrate;

public static partial class ApacheTomcatAKSWorkloadDeploymentModelCustomPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentModelCustomPropertiesArgs WithApacheTomcatAksWorkloadDeploymentProperties(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentModelCustomPropertiesArgs @selfRef, global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs apacheTomcatAksWorkloadDeploymentProperties)
    {
        @selfRef.ApacheTomcatAksWorkloadDeploymentProperties = apacheTomcatAksWorkloadDeploymentProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentModelCustomPropertiesArgs WithApacheTomcatAksWorkloadDeploymentProperties(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentModelCustomPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs();
        @configure(@item);
        @selfRef.ApacheTomcatAksWorkloadDeploymentProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentModelCustomPropertiesArgs WithInstanceType(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentModelCustomPropertiesArgs @selfRef, global::System.String instanceType)
    {
        @selfRef.InstanceType = instanceType;
        return @selfRef;
    }

}
