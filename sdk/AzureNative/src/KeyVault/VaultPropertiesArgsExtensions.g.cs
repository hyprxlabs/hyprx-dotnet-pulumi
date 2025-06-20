// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.KeyVault.Inputs;

namespace Pulumi.AzureNative.KeyVault;

public static partial class VaultPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs WithAccessPolicies(this global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.KeyVault.Inputs.AccessPolicyEntryArgs> accessPolicies)
    {
        @selfRef.AccessPolicies = accessPolicies;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs WithAccessPolicies(this global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.KeyVault.Inputs.AccessPolicyEntryArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.KeyVault.Inputs.AccessPolicyEntryArgs>();
        @configure(@list);
        @selfRef.AccessPolicies = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs WithAccessPolicies(this global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.KeyVault.Inputs.AccessPolicyEntryArgs>> @create)
    {
        @selfRef.AccessPolicies = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs WithCreateMode(this global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs @selfRef, global::Pulumi.AzureNative.KeyVault.CreateMode createMode)
    {
        @selfRef.CreateMode = createMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs WithCreateMode(this global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.KeyVault.CreateMode> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.KeyVault.CreateMode>();
        @configure(@item);
        @selfRef.CreateMode = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs WithEnablePurgeProtection(this global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs @selfRef, bool enablePurgeProtection = true)
    {
        @selfRef.EnablePurgeProtection = enablePurgeProtection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs WithEnableRbacAuthorization(this global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs @selfRef, bool enableRbacAuthorization = true)
    {
        @selfRef.EnableRbacAuthorization = enableRbacAuthorization;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs WithEnableSoftDelete(this global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs @selfRef, bool enableSoftDelete = true)
    {
        @selfRef.EnableSoftDelete = enableSoftDelete;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs WithEnabledForDeployment(this global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs @selfRef, bool enabledForDeployment = true)
    {
        @selfRef.EnabledForDeployment = enabledForDeployment;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs WithEnabledForDiskEncryption(this global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs @selfRef, bool enabledForDiskEncryption = true)
    {
        @selfRef.EnabledForDiskEncryption = enabledForDiskEncryption;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs WithEnabledForTemplateDeployment(this global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs @selfRef, bool enabledForTemplateDeployment = true)
    {
        @selfRef.EnabledForTemplateDeployment = enabledForTemplateDeployment;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs WithNetworkAcls(this global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs @selfRef, global::Pulumi.AzureNative.KeyVault.Inputs.NetworkRuleSetArgs networkAcls)
    {
        @selfRef.NetworkAcls = networkAcls;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs WithNetworkAcls(this global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.KeyVault.Inputs.NetworkRuleSetArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.KeyVault.Inputs.NetworkRuleSetArgs();
        @configure(@item);
        @selfRef.NetworkAcls = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs WithPublicNetworkAccess(this global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs @selfRef, global::System.String publicNetworkAccess)
    {
        @selfRef.PublicNetworkAccess = publicNetworkAccess;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs WithSku(this global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs @selfRef, global::Pulumi.AzureNative.KeyVault.Inputs.SkuArgs sku)
    {
        @selfRef.Sku = sku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs WithSku(this global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.KeyVault.Inputs.SkuArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.KeyVault.Inputs.SkuArgs();
        @configure(@item);
        @selfRef.Sku = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs WithSoftDeleteRetentionInDays(this global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs @selfRef, global::System.Int32 softDeleteRetentionInDays)
    {
        @selfRef.SoftDeleteRetentionInDays = softDeleteRetentionInDays;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs WithTenantId(this global::Pulumi.AzureNative.KeyVault.Inputs.VaultPropertiesArgs @selfRef, global::System.String tenantId)
    {
        @selfRef.TenantId = tenantId;
        return @selfRef;
    }

}
