// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Dashboard.Inputs;

namespace Pulumi.AzureNative.Dashboard;

public static partial class GrafanaConfigurationsArgsExtensions
{
    public static global::Pulumi.AzureNative.Dashboard.Inputs.GrafanaConfigurationsArgs WithSecurity(this global::Pulumi.AzureNative.Dashboard.Inputs.GrafanaConfigurationsArgs @selfRef, global::Pulumi.AzureNative.Dashboard.Inputs.SecurityArgs security)
    {
        @selfRef.Security = security;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Dashboard.Inputs.GrafanaConfigurationsArgs WithSecurity(this global::Pulumi.AzureNative.Dashboard.Inputs.GrafanaConfigurationsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Dashboard.Inputs.SecurityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Dashboard.Inputs.SecurityArgs();
        @configure(@item);
        @selfRef.Security = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Dashboard.Inputs.GrafanaConfigurationsArgs WithSmtp(this global::Pulumi.AzureNative.Dashboard.Inputs.GrafanaConfigurationsArgs @selfRef, global::Pulumi.AzureNative.Dashboard.Inputs.SmtpArgs smtp)
    {
        @selfRef.Smtp = smtp;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Dashboard.Inputs.GrafanaConfigurationsArgs WithSmtp(this global::Pulumi.AzureNative.Dashboard.Inputs.GrafanaConfigurationsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Dashboard.Inputs.SmtpArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Dashboard.Inputs.SmtpArgs();
        @configure(@item);
        @selfRef.Smtp = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Dashboard.Inputs.GrafanaConfigurationsArgs WithSnapshots(this global::Pulumi.AzureNative.Dashboard.Inputs.GrafanaConfigurationsArgs @selfRef, global::Pulumi.AzureNative.Dashboard.Inputs.SnapshotsArgs snapshots)
    {
        @selfRef.Snapshots = snapshots;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Dashboard.Inputs.GrafanaConfigurationsArgs WithSnapshots(this global::Pulumi.AzureNative.Dashboard.Inputs.GrafanaConfigurationsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Dashboard.Inputs.SnapshotsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Dashboard.Inputs.SnapshotsArgs();
        @configure(@item);
        @selfRef.Snapshots = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Dashboard.Inputs.GrafanaConfigurationsArgs WithUsers(this global::Pulumi.AzureNative.Dashboard.Inputs.GrafanaConfigurationsArgs @selfRef, global::Pulumi.AzureNative.Dashboard.Inputs.UsersArgs users)
    {
        @selfRef.Users = users;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Dashboard.Inputs.GrafanaConfigurationsArgs WithUsers(this global::Pulumi.AzureNative.Dashboard.Inputs.GrafanaConfigurationsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Dashboard.Inputs.UsersArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Dashboard.Inputs.UsersArgs();
        @configure(@item);
        @selfRef.Users = @item;
        return @selfRef;
    }

}
