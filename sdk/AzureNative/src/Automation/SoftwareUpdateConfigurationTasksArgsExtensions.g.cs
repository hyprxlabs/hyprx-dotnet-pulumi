// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Automation.Inputs;

namespace Pulumi.AzureNative.Automation;

public static partial class SoftwareUpdateConfigurationTasksArgsExtensions
{
    public static global::Pulumi.AzureNative.Automation.Inputs.SoftwareUpdateConfigurationTasksArgs WithPostTask(this global::Pulumi.AzureNative.Automation.Inputs.SoftwareUpdateConfigurationTasksArgs @selfRef, global::Pulumi.AzureNative.Automation.Inputs.TaskPropertiesArgs postTask)
    {
        @selfRef.PostTask = postTask;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.SoftwareUpdateConfigurationTasksArgs WithPostTask(this global::Pulumi.AzureNative.Automation.Inputs.SoftwareUpdateConfigurationTasksArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Automation.Inputs.TaskPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Automation.Inputs.TaskPropertiesArgs();
        @configure(@item);
        @selfRef.PostTask = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.SoftwareUpdateConfigurationTasksArgs WithPreTask(this global::Pulumi.AzureNative.Automation.Inputs.SoftwareUpdateConfigurationTasksArgs @selfRef, global::Pulumi.AzureNative.Automation.Inputs.TaskPropertiesArgs preTask)
    {
        @selfRef.PreTask = preTask;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.SoftwareUpdateConfigurationTasksArgs WithPreTask(this global::Pulumi.AzureNative.Automation.Inputs.SoftwareUpdateConfigurationTasksArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Automation.Inputs.TaskPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Automation.Inputs.TaskPropertiesArgs();
        @configure(@item);
        @selfRef.PreTask = @item;
        return @selfRef;
    }

}
