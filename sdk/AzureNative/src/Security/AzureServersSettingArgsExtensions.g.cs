// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Security;

public static partial class AzureServersSettingArgsExtensions
{
    public static global::Pulumi.AzureNative.Security.AzureServersSettingArgs WithKind(this global::Pulumi.AzureNative.Security.AzureServersSettingArgs @selfRef, global::System.String kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.AzureServersSettingArgs WithSelectedProvider(this global::Pulumi.AzureNative.Security.AzureServersSettingArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Security.ServerVulnerabilityAssessmentsAzureSettingSelectedProvider> selectedProvider)
    {
        @selfRef.SelectedProvider = selectedProvider;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.AzureServersSettingArgs WithSettingKind(this global::Pulumi.AzureNative.Security.AzureServersSettingArgs @selfRef, global::System.String settingKind)
    {
        @selfRef.SettingKind = settingKind;
        return @selfRef;
    }

}
