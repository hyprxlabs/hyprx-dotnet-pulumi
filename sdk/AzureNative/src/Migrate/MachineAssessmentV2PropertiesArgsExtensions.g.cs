// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Migrate.Inputs;

namespace Pulumi.AzureNative.Migrate;

public static partial class MachineAssessmentV2PropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.Migrate.Inputs.MachineAssessmentV2PropertiesArgs WithScope(this global::Pulumi.AzureNative.Migrate.Inputs.MachineAssessmentV2PropertiesArgs @selfRef, global::Pulumi.AzureNative.Migrate.Inputs.ScopeArgs scope)
    {
        @selfRef.Scope = scope;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.MachineAssessmentV2PropertiesArgs WithScope(this global::Pulumi.AzureNative.Migrate.Inputs.MachineAssessmentV2PropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Migrate.Inputs.ScopeArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Migrate.Inputs.ScopeArgs();
        @configure(@item);
        @selfRef.Scope = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.MachineAssessmentV2PropertiesArgs WithSettings(this global::Pulumi.AzureNative.Migrate.Inputs.MachineAssessmentV2PropertiesArgs @selfRef, global::Pulumi.AzureNative.Migrate.Inputs.MachineAssessmentSettingsArgs settings)
    {
        @selfRef.Settings = settings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.MachineAssessmentV2PropertiesArgs WithSettings(this global::Pulumi.AzureNative.Migrate.Inputs.MachineAssessmentV2PropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Migrate.Inputs.MachineAssessmentSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Migrate.Inputs.MachineAssessmentSettingsArgs();
        @configure(@item);
        @selfRef.Settings = @item;
        return @selfRef;
    }

}
