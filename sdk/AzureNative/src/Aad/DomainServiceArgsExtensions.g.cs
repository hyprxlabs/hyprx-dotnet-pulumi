// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Aad;

public static partial class DomainServiceArgsExtensions
{
    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithConfigDiagnostics(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::Pulumi.AzureNative.Aad.Inputs.ConfigDiagnosticsArgs configDiagnostics)
    {
        @selfRef.ConfigDiagnostics = configDiagnostics;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithConfigDiagnostics(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Aad.Inputs.ConfigDiagnosticsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Aad.Inputs.ConfigDiagnosticsArgs();
        @configure(@item);
        @selfRef.ConfigDiagnostics = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithDomainConfigurationType(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::System.String domainConfigurationType)
    {
        @selfRef.DomainConfigurationType = domainConfigurationType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithDomainName(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::System.String domainName)
    {
        @selfRef.DomainName = domainName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithDomainSecuritySettings(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::Pulumi.AzureNative.Aad.Inputs.DomainSecuritySettingsArgs domainSecuritySettings)
    {
        @selfRef.DomainSecuritySettings = domainSecuritySettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithDomainSecuritySettings(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Aad.Inputs.DomainSecuritySettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Aad.Inputs.DomainSecuritySettingsArgs();
        @configure(@item);
        @selfRef.DomainSecuritySettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithDomainServiceName(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::System.String domainServiceName)
    {
        @selfRef.DomainServiceName = domainServiceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithFilteredSync(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Aad.FilteredSync> filteredSync)
    {
        @selfRef.FilteredSync = filteredSync;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithLdapsSettings(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::Pulumi.AzureNative.Aad.Inputs.LdapsSettingsArgs ldapsSettings)
    {
        @selfRef.LdapsSettings = ldapsSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithLdapsSettings(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Aad.Inputs.LdapsSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Aad.Inputs.LdapsSettingsArgs();
        @configure(@item);
        @selfRef.LdapsSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithLocation(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithNotificationSettings(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::Pulumi.AzureNative.Aad.Inputs.NotificationSettingsArgs notificationSettings)
    {
        @selfRef.NotificationSettings = notificationSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithNotificationSettings(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Aad.Inputs.NotificationSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Aad.Inputs.NotificationSettingsArgs();
        @configure(@item);
        @selfRef.NotificationSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithReplicaSets(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Aad.Inputs.ReplicaSetArgs> replicaSets)
    {
        @selfRef.ReplicaSets = replicaSets;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithReplicaSets(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Aad.Inputs.ReplicaSetArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Aad.Inputs.ReplicaSetArgs>();
        @configure(@list);
        @selfRef.ReplicaSets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithReplicaSets(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Aad.Inputs.ReplicaSetArgs>> @create)
    {
        @selfRef.ReplicaSets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithResourceForestSettings(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::Pulumi.AzureNative.Aad.Inputs.ResourceForestSettingsArgs resourceForestSettings)
    {
        @selfRef.ResourceForestSettings = resourceForestSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithResourceForestSettings(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Aad.Inputs.ResourceForestSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Aad.Inputs.ResourceForestSettingsArgs();
        @configure(@item);
        @selfRef.ResourceForestSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithResourceGroupName(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithSku(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::System.String sku)
    {
        @selfRef.Sku = sku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithSyncScope(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Aad.SyncScope> syncScope)
    {
        @selfRef.SyncScope = syncScope;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithTags(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithTags(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.DomainServiceArgs WithTags(this global::Pulumi.AzureNative.Aad.DomainServiceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
