// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Sql;

public static partial class ServerCommunicationLinkArgsExtensions
{
    public static global::Pulumi.AzureNative.Sql.ServerCommunicationLinkArgs WithCommunicationLinkName(this global::Pulumi.AzureNative.Sql.ServerCommunicationLinkArgs @selfRef, global::System.String communicationLinkName)
    {
        @selfRef.CommunicationLinkName = communicationLinkName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ServerCommunicationLinkArgs WithPartnerServer(this global::Pulumi.AzureNative.Sql.ServerCommunicationLinkArgs @selfRef, global::System.String partnerServer)
    {
        @selfRef.PartnerServer = partnerServer;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ServerCommunicationLinkArgs WithResourceGroupName(this global::Pulumi.AzureNative.Sql.ServerCommunicationLinkArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ServerCommunicationLinkArgs WithServerName(this global::Pulumi.AzureNative.Sql.ServerCommunicationLinkArgs @selfRef, global::System.String serverName)
    {
        @selfRef.ServerName = serverName;
        return @selfRef;
    }

}
