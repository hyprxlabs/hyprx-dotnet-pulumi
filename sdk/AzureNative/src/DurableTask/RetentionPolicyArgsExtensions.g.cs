// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DurableTask;

public static partial class RetentionPolicyArgsExtensions
{
    public static global::Pulumi.AzureNative.DurableTask.RetentionPolicyArgs WithProperties(this global::Pulumi.AzureNative.DurableTask.RetentionPolicyArgs @selfRef, global::Pulumi.AzureNative.DurableTask.Inputs.RetentionPolicyPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DurableTask.RetentionPolicyArgs WithProperties(this global::Pulumi.AzureNative.DurableTask.RetentionPolicyArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DurableTask.Inputs.RetentionPolicyPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DurableTask.Inputs.RetentionPolicyPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DurableTask.RetentionPolicyArgs WithResourceGroupName(this global::Pulumi.AzureNative.DurableTask.RetentionPolicyArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DurableTask.RetentionPolicyArgs WithSchedulerName(this global::Pulumi.AzureNative.DurableTask.RetentionPolicyArgs @selfRef, global::System.String schedulerName)
    {
        @selfRef.SchedulerName = schedulerName;
        return @selfRef;
    }

}
