// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Migrate.Inputs;

namespace Pulumi.AzureNative.Migrate;

public static partial class SqlAssessmentV3PropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.Migrate.Inputs.SqlAssessmentV3PropertiesArgs WithFallbackMachineAssessmentArmId(this global::Pulumi.AzureNative.Migrate.Inputs.SqlAssessmentV3PropertiesArgs @selfRef, global::System.String fallbackMachineAssessmentArmId)
    {
        @selfRef.FallbackMachineAssessmentArmId = fallbackMachineAssessmentArmId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.SqlAssessmentV3PropertiesArgs WithScope(this global::Pulumi.AzureNative.Migrate.Inputs.SqlAssessmentV3PropertiesArgs @selfRef, global::Pulumi.AzureNative.Migrate.Inputs.ScopeArgs scope)
    {
        @selfRef.Scope = scope;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.SqlAssessmentV3PropertiesArgs WithScope(this global::Pulumi.AzureNative.Migrate.Inputs.SqlAssessmentV3PropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Migrate.Inputs.ScopeArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Migrate.Inputs.ScopeArgs();
        @configure(@item);
        @selfRef.Scope = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.SqlAssessmentV3PropertiesArgs WithSettings(this global::Pulumi.AzureNative.Migrate.Inputs.SqlAssessmentV3PropertiesArgs @selfRef, global::Pulumi.AzureNative.Migrate.Inputs.SqlAssessmentSettingsArgs settings)
    {
        @selfRef.Settings = settings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.SqlAssessmentV3PropertiesArgs WithSettings(this global::Pulumi.AzureNative.Migrate.Inputs.SqlAssessmentV3PropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Migrate.Inputs.SqlAssessmentSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Migrate.Inputs.SqlAssessmentSettingsArgs();
        @configure(@item);
        @selfRef.Settings = @item;
        return @selfRef;
    }

}
