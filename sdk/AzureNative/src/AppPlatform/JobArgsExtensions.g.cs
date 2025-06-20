// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AppPlatform;

public static partial class JobArgsExtensions
{
    public static global::Pulumi.AzureNative.AppPlatform.JobArgs WithJobName(this global::Pulumi.AzureNative.AppPlatform.JobArgs @selfRef, global::System.String jobName)
    {
        @selfRef.JobName = jobName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.JobArgs WithProperties(this global::Pulumi.AzureNative.AppPlatform.JobArgs @selfRef, global::Pulumi.AzureNative.AppPlatform.Inputs.JobResourcePropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.JobArgs WithProperties(this global::Pulumi.AzureNative.AppPlatform.JobArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AppPlatform.Inputs.JobResourcePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AppPlatform.Inputs.JobResourcePropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.JobArgs WithResourceGroupName(this global::Pulumi.AzureNative.AppPlatform.JobArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.JobArgs WithServiceName(this global::Pulumi.AzureNative.AppPlatform.JobArgs @selfRef, global::System.String serviceName)
    {
        @selfRef.ServiceName = serviceName;
        return @selfRef;
    }

}
