// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DataLakeStore;

public static partial class AccountArgsExtensions
{
    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithAccountName(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.String accountName)
    {
        @selfRef.AccountName = accountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithDefaultGroup(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.String defaultGroup)
    {
        @selfRef.DefaultGroup = defaultGroup;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithEncryptionConfig(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::Pulumi.AzureNative.DataLakeStore.Inputs.EncryptionConfigArgs encryptionConfig)
    {
        @selfRef.EncryptionConfig = encryptionConfig;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithEncryptionConfig(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataLakeStore.Inputs.EncryptionConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataLakeStore.Inputs.EncryptionConfigArgs();
        @configure(@item);
        @selfRef.EncryptionConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithEncryptionState(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::Pulumi.AzureNative.DataLakeStore.EncryptionState encryptionState)
    {
        @selfRef.EncryptionState = encryptionState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithEncryptionState(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataLakeStore.EncryptionState> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.DataLakeStore.EncryptionState>();
        @configure(@item);
        @selfRef.EncryptionState = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithFirewallAllowAzureIps(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::Pulumi.AzureNative.DataLakeStore.FirewallAllowAzureIpsState firewallAllowAzureIps)
    {
        @selfRef.FirewallAllowAzureIps = firewallAllowAzureIps;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithFirewallAllowAzureIps(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataLakeStore.FirewallAllowAzureIpsState> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.DataLakeStore.FirewallAllowAzureIpsState>();
        @configure(@item);
        @selfRef.FirewallAllowAzureIps = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithFirewallRules(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataLakeStore.Inputs.CreateFirewallRuleWithAccountParametersArgs> firewallRules)
    {
        @selfRef.FirewallRules = firewallRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithFirewallRules(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataLakeStore.Inputs.CreateFirewallRuleWithAccountParametersArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataLakeStore.Inputs.CreateFirewallRuleWithAccountParametersArgs>();
        @configure(@list);
        @selfRef.FirewallRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithFirewallRules(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DataLakeStore.Inputs.CreateFirewallRuleWithAccountParametersArgs>> @create)
    {
        @selfRef.FirewallRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithFirewallState(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::Pulumi.AzureNative.DataLakeStore.FirewallState firewallState)
    {
        @selfRef.FirewallState = firewallState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithFirewallState(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataLakeStore.FirewallState> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.DataLakeStore.FirewallState>();
        @configure(@item);
        @selfRef.FirewallState = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithIdentity(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::Pulumi.AzureNative.DataLakeStore.Inputs.EncryptionIdentityArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithIdentity(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataLakeStore.Inputs.EncryptionIdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataLakeStore.Inputs.EncryptionIdentityArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithLocation(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithNewTier(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::Pulumi.AzureNative.DataLakeStore.TierType newTier)
    {
        @selfRef.NewTier = newTier;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithNewTier(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataLakeStore.TierType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.DataLakeStore.TierType>();
        @configure(@item);
        @selfRef.NewTier = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithResourceGroupName(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithTags(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithTags(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithTags(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithTrustedIdProviderState(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::Pulumi.AzureNative.DataLakeStore.TrustedIdProviderState trustedIdProviderState)
    {
        @selfRef.TrustedIdProviderState = trustedIdProviderState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithTrustedIdProviderState(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataLakeStore.TrustedIdProviderState> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.DataLakeStore.TrustedIdProviderState>();
        @configure(@item);
        @selfRef.TrustedIdProviderState = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithTrustedIdProviders(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataLakeStore.Inputs.CreateTrustedIdProviderWithAccountParametersArgs> trustedIdProviders)
    {
        @selfRef.TrustedIdProviders = trustedIdProviders;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithTrustedIdProviders(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataLakeStore.Inputs.CreateTrustedIdProviderWithAccountParametersArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataLakeStore.Inputs.CreateTrustedIdProviderWithAccountParametersArgs>();
        @configure(@list);
        @selfRef.TrustedIdProviders = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithTrustedIdProviders(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DataLakeStore.Inputs.CreateTrustedIdProviderWithAccountParametersArgs>> @create)
    {
        @selfRef.TrustedIdProviders = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithVirtualNetworkRules(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataLakeStore.Inputs.CreateVirtualNetworkRuleWithAccountParametersArgs> virtualNetworkRules)
    {
        @selfRef.VirtualNetworkRules = virtualNetworkRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithVirtualNetworkRules(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataLakeStore.Inputs.CreateVirtualNetworkRuleWithAccountParametersArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataLakeStore.Inputs.CreateVirtualNetworkRuleWithAccountParametersArgs>();
        @configure(@list);
        @selfRef.VirtualNetworkRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataLakeStore.AccountArgs WithVirtualNetworkRules(this global::Pulumi.AzureNative.DataLakeStore.AccountArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DataLakeStore.Inputs.CreateVirtualNetworkRuleWithAccountParametersArgs>> @create)
    {
        @selfRef.VirtualNetworkRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
