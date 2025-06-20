// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Migrate.Inputs;

namespace Pulumi.AzureNative.Migrate;

public static partial class AzureArcSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.Migrate.Inputs.AzureArcSettingsArgs WithAzureArcState(this global::Pulumi.AzureNative.Migrate.Inputs.AzureArcSettingsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.AzureArcState> azureArcState)
    {
        @selfRef.AzureArcState = azureArcState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.AzureArcSettingsArgs WithLaborCostPercentage(this global::Pulumi.AzureNative.Migrate.Inputs.AzureArcSettingsArgs @selfRef, global::System.Double laborCostPercentage)
    {
        @selfRef.LaborCostPercentage = laborCostPercentage;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.AzureArcSettingsArgs WithManagementSettings(this global::Pulumi.AzureNative.Migrate.Inputs.AzureArcSettingsArgs @selfRef, global::Pulumi.AzureNative.Migrate.Inputs.AzureArcManagementSettingsArgs managementSettings)
    {
        @selfRef.ManagementSettings = managementSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.AzureArcSettingsArgs WithManagementSettings(this global::Pulumi.AzureNative.Migrate.Inputs.AzureArcSettingsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Migrate.Inputs.AzureArcManagementSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Migrate.Inputs.AzureArcManagementSettingsArgs();
        @configure(@item);
        @selfRef.ManagementSettings = @item;
        return @selfRef;
    }

}
