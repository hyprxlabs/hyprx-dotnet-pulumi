// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Sql;

public static partial class ServerAzureADAdministratorArgsExtensions
{
    public static global::Pulumi.AzureNative.Sql.ServerAzureADAdministratorArgs WithAdministratorName(this global::Pulumi.AzureNative.Sql.ServerAzureADAdministratorArgs @selfRef, global::System.String administratorName)
    {
        @selfRef.AdministratorName = administratorName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ServerAzureADAdministratorArgs WithAdministratorType(this global::Pulumi.AzureNative.Sql.ServerAzureADAdministratorArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Sql.AdministratorType> administratorType)
    {
        @selfRef.AdministratorType = administratorType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ServerAzureADAdministratorArgs WithLogin(this global::Pulumi.AzureNative.Sql.ServerAzureADAdministratorArgs @selfRef, global::System.String login)
    {
        @selfRef.Login = login;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ServerAzureADAdministratorArgs WithResourceGroupName(this global::Pulumi.AzureNative.Sql.ServerAzureADAdministratorArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ServerAzureADAdministratorArgs WithServerName(this global::Pulumi.AzureNative.Sql.ServerAzureADAdministratorArgs @selfRef, global::System.String serverName)
    {
        @selfRef.ServerName = serverName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ServerAzureADAdministratorArgs WithSid(this global::Pulumi.AzureNative.Sql.ServerAzureADAdministratorArgs @selfRef, global::System.String sid)
    {
        @selfRef.Sid = sid;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ServerAzureADAdministratorArgs WithTenantId(this global::Pulumi.AzureNative.Sql.ServerAzureADAdministratorArgs @selfRef, global::System.String tenantId)
    {
        @selfRef.TenantId = tenantId;
        return @selfRef;
    }

}
