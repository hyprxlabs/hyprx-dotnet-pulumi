// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AzureArcData.Inputs;

namespace Pulumi.AzureNative.AzureArcData;

public static partial class SqlServerEsuLicensePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AzureArcData.Inputs.SqlServerEsuLicensePropertiesArgs WithActivationState(this global::Pulumi.AzureNative.AzureArcData.Inputs.SqlServerEsuLicensePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureArcData.State> activationState)
    {
        @selfRef.ActivationState = activationState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureArcData.Inputs.SqlServerEsuLicensePropertiesArgs WithBillingPlan(this global::Pulumi.AzureNative.AzureArcData.Inputs.SqlServerEsuLicensePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureArcData.BillingPlan> billingPlan)
    {
        @selfRef.BillingPlan = billingPlan;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureArcData.Inputs.SqlServerEsuLicensePropertiesArgs WithPhysicalCores(this global::Pulumi.AzureNative.AzureArcData.Inputs.SqlServerEsuLicensePropertiesArgs @selfRef, global::System.Int32 physicalCores)
    {
        @selfRef.PhysicalCores = physicalCores;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureArcData.Inputs.SqlServerEsuLicensePropertiesArgs WithScopeType(this global::Pulumi.AzureNative.AzureArcData.Inputs.SqlServerEsuLicensePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureArcData.ScopeType> scopeType)
    {
        @selfRef.ScopeType = scopeType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureArcData.Inputs.SqlServerEsuLicensePropertiesArgs WithVersion(this global::Pulumi.AzureNative.AzureArcData.Inputs.SqlServerEsuLicensePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureArcData.Version> version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
