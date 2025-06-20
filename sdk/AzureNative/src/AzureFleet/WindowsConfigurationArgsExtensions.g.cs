// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AzureFleet.Inputs;

namespace Pulumi.AzureNative.AzureFleet;

public static partial class WindowsConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs WithAdditionalUnattendContent(this global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AzureFleet.Inputs.AdditionalUnattendContentArgs> additionalUnattendContent)
    {
        @selfRef.AdditionalUnattendContent = additionalUnattendContent;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs WithAdditionalUnattendContent(this global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AzureFleet.Inputs.AdditionalUnattendContentArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AzureFleet.Inputs.AdditionalUnattendContentArgs>();
        @configure(@list);
        @selfRef.AdditionalUnattendContent = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs WithAdditionalUnattendContent(this global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AzureFleet.Inputs.AdditionalUnattendContentArgs>> @create)
    {
        @selfRef.AdditionalUnattendContent = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs WithEnableAutomaticUpdates(this global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs @selfRef, bool enableAutomaticUpdates = true)
    {
        @selfRef.EnableAutomaticUpdates = enableAutomaticUpdates;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs WithEnableVMAgentPlatformUpdates(this global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs @selfRef, bool enableVMAgentPlatformUpdates = true)
    {
        @selfRef.EnableVMAgentPlatformUpdates = enableVMAgentPlatformUpdates;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs WithPatchSettings(this global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs @selfRef, global::Pulumi.AzureNative.AzureFleet.Inputs.PatchSettingsArgs patchSettings)
    {
        @selfRef.PatchSettings = patchSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs WithPatchSettings(this global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureFleet.Inputs.PatchSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureFleet.Inputs.PatchSettingsArgs();
        @configure(@item);
        @selfRef.PatchSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs WithProvisionVMAgent(this global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs @selfRef, bool provisionVMAgent = true)
    {
        @selfRef.ProvisionVMAgent = provisionVMAgent;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs WithTimeZone(this global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs @selfRef, global::System.String timeZone)
    {
        @selfRef.TimeZone = timeZone;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs WithWinRM(this global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs @selfRef, global::Pulumi.AzureNative.AzureFleet.Inputs.WinRMConfigurationArgs winRM)
    {
        @selfRef.WinRM = winRM;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs WithWinRM(this global::Pulumi.AzureNative.AzureFleet.Inputs.WindowsConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureFleet.Inputs.WinRMConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureFleet.Inputs.WinRMConfigurationArgs();
        @configure(@item);
        @selfRef.WinRM = @item;
        return @selfRef;
    }

}
