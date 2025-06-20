// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Sql;

public static partial class FailoverGroupArgsExtensions
{
    public static global::Pulumi.AzureNative.Sql.FailoverGroupArgs WithDatabases(this global::Pulumi.AzureNative.Sql.FailoverGroupArgs @selfRef, global::System.Collections.Generic.List<global::System.String> databases)
    {
        @selfRef.Databases = databases;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.FailoverGroupArgs WithDatabases(this global::Pulumi.AzureNative.Sql.FailoverGroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Databases = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.FailoverGroupArgs WithDatabases(this global::Pulumi.AzureNative.Sql.FailoverGroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Databases = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.FailoverGroupArgs WithFailoverGroupName(this global::Pulumi.AzureNative.Sql.FailoverGroupArgs @selfRef, global::System.String failoverGroupName)
    {
        @selfRef.FailoverGroupName = failoverGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.FailoverGroupArgs WithPartnerServers(this global::Pulumi.AzureNative.Sql.FailoverGroupArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Sql.Inputs.PartnerInfoArgs> partnerServers)
    {
        @selfRef.PartnerServers = partnerServers;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.FailoverGroupArgs WithPartnerServers(this global::Pulumi.AzureNative.Sql.FailoverGroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Sql.Inputs.PartnerInfoArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Sql.Inputs.PartnerInfoArgs>();
        @configure(@list);
        @selfRef.PartnerServers = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.FailoverGroupArgs WithPartnerServers(this global::Pulumi.AzureNative.Sql.FailoverGroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Sql.Inputs.PartnerInfoArgs>> @create)
    {
        @selfRef.PartnerServers = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.FailoverGroupArgs WithReadOnlyEndpoint(this global::Pulumi.AzureNative.Sql.FailoverGroupArgs @selfRef, global::Pulumi.AzureNative.Sql.Inputs.FailoverGroupReadOnlyEndpointArgs readOnlyEndpoint)
    {
        @selfRef.ReadOnlyEndpoint = readOnlyEndpoint;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.FailoverGroupArgs WithReadOnlyEndpoint(this global::Pulumi.AzureNative.Sql.FailoverGroupArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Sql.Inputs.FailoverGroupReadOnlyEndpointArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Sql.Inputs.FailoverGroupReadOnlyEndpointArgs();
        @configure(@item);
        @selfRef.ReadOnlyEndpoint = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.FailoverGroupArgs WithReadWriteEndpoint(this global::Pulumi.AzureNative.Sql.FailoverGroupArgs @selfRef, global::Pulumi.AzureNative.Sql.Inputs.FailoverGroupReadWriteEndpointArgs readWriteEndpoint)
    {
        @selfRef.ReadWriteEndpoint = readWriteEndpoint;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.FailoverGroupArgs WithReadWriteEndpoint(this global::Pulumi.AzureNative.Sql.FailoverGroupArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Sql.Inputs.FailoverGroupReadWriteEndpointArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Sql.Inputs.FailoverGroupReadWriteEndpointArgs();
        @configure(@item);
        @selfRef.ReadWriteEndpoint = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.FailoverGroupArgs WithResourceGroupName(this global::Pulumi.AzureNative.Sql.FailoverGroupArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.FailoverGroupArgs WithSecondaryType(this global::Pulumi.AzureNative.Sql.FailoverGroupArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Sql.FailoverGroupDatabasesSecondaryType> secondaryType)
    {
        @selfRef.SecondaryType = secondaryType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.FailoverGroupArgs WithServerName(this global::Pulumi.AzureNative.Sql.FailoverGroupArgs @selfRef, global::System.String serverName)
    {
        @selfRef.ServerName = serverName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.FailoverGroupArgs WithTags(this global::Pulumi.AzureNative.Sql.FailoverGroupArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.FailoverGroupArgs WithTags(this global::Pulumi.AzureNative.Sql.FailoverGroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.FailoverGroupArgs WithTags(this global::Pulumi.AzureNative.Sql.FailoverGroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
