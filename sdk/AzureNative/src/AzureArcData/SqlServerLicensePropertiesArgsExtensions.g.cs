// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AzureArcData.Inputs;

namespace Pulumi.AzureNative.AzureArcData;

public static partial class SqlServerLicensePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AzureArcData.Inputs.SqlServerLicensePropertiesArgs WithActivationState(this global::Pulumi.AzureNative.AzureArcData.Inputs.SqlServerLicensePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureArcData.ActivationState> activationState)
    {
        @selfRef.ActivationState = activationState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureArcData.Inputs.SqlServerLicensePropertiesArgs WithBillingPlan(this global::Pulumi.AzureNative.AzureArcData.Inputs.SqlServerLicensePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureArcData.BillingPlan> billingPlan)
    {
        @selfRef.BillingPlan = billingPlan;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureArcData.Inputs.SqlServerLicensePropertiesArgs WithLicenseCategory(this global::Pulumi.AzureNative.AzureArcData.Inputs.SqlServerLicensePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureArcData.LicenseCategory> licenseCategory)
    {
        @selfRef.LicenseCategory = licenseCategory;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureArcData.Inputs.SqlServerLicensePropertiesArgs WithPhysicalCores(this global::Pulumi.AzureNative.AzureArcData.Inputs.SqlServerLicensePropertiesArgs @selfRef, global::System.Int32 physicalCores)
    {
        @selfRef.PhysicalCores = physicalCores;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureArcData.Inputs.SqlServerLicensePropertiesArgs WithScopeType(this global::Pulumi.AzureNative.AzureArcData.Inputs.SqlServerLicensePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureArcData.ScopeType> scopeType)
    {
        @selfRef.ScopeType = scopeType;
        return @selfRef;
    }

}
