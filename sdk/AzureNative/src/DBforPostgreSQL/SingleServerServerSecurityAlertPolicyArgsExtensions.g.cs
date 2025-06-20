// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DBforPostgreSQL;

public static partial class SingleServerServerSecurityAlertPolicyArgsExtensions
{
    public static global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs WithDisabledAlerts(this global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs @selfRef, global::System.Collections.Generic.List<global::System.String> disabledAlerts)
    {
        @selfRef.DisabledAlerts = disabledAlerts;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs WithDisabledAlerts(this global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.DisabledAlerts = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs WithDisabledAlerts(this global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.DisabledAlerts = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs WithEmailAccountAdmins(this global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs @selfRef, bool emailAccountAdmins = true)
    {
        @selfRef.EmailAccountAdmins = emailAccountAdmins;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs WithEmailAddresses(this global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs @selfRef, global::System.Collections.Generic.List<global::System.String> emailAddresses)
    {
        @selfRef.EmailAddresses = emailAddresses;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs WithEmailAddresses(this global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.EmailAddresses = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs WithEmailAddresses(this global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.EmailAddresses = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs WithResourceGroupName(this global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs WithRetentionDays(this global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs @selfRef, global::System.Int32 retentionDays)
    {
        @selfRef.RetentionDays = retentionDays;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs WithSecurityAlertPolicyName(this global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs @selfRef, global::System.String securityAlertPolicyName)
    {
        @selfRef.SecurityAlertPolicyName = securityAlertPolicyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs WithServerName(this global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs @selfRef, global::System.String serverName)
    {
        @selfRef.ServerName = serverName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs WithState(this global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs @selfRef, global::Pulumi.AzureNative.DBforPostgreSQL.ServerSecurityAlertPolicyState state)
    {
        @selfRef.State = state;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs WithState(this global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DBforPostgreSQL.ServerSecurityAlertPolicyState> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.DBforPostgreSQL.ServerSecurityAlertPolicyState>();
        @configure(@item);
        @selfRef.State = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs WithStorageAccountAccessKey(this global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs @selfRef, global::System.String storageAccountAccessKey)
    {
        @selfRef.StorageAccountAccessKey = storageAccountAccessKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs WithStorageEndpoint(this global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerServerSecurityAlertPolicyArgs @selfRef, global::System.String storageEndpoint)
    {
        @selfRef.StorageEndpoint = storageEndpoint;
        return @selfRef;
    }

}
