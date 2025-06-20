// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.CostManagement;

public static partial class CloudConnectorArgsExtensions
{
    public static global::Pulumi.AzureNative.CostManagement.CloudConnectorArgs WithBillingModel(this global::Pulumi.AzureNative.CostManagement.CloudConnectorArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.CostManagement.ConnectorBillingModel> billingModel)
    {
        @selfRef.BillingModel = billingModel;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CostManagement.CloudConnectorArgs WithConnectorName(this global::Pulumi.AzureNative.CostManagement.CloudConnectorArgs @selfRef, global::System.String connectorName)
    {
        @selfRef.ConnectorName = connectorName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CostManagement.CloudConnectorArgs WithCredentialsKey(this global::Pulumi.AzureNative.CostManagement.CloudConnectorArgs @selfRef, global::System.String credentialsKey)
    {
        @selfRef.CredentialsKey = credentialsKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CostManagement.CloudConnectorArgs WithCredentialsSecret(this global::Pulumi.AzureNative.CostManagement.CloudConnectorArgs @selfRef, global::System.String credentialsSecret)
    {
        @selfRef.CredentialsSecret = credentialsSecret;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CostManagement.CloudConnectorArgs WithDefaultManagementGroupId(this global::Pulumi.AzureNative.CostManagement.CloudConnectorArgs @selfRef, global::System.String defaultManagementGroupId)
    {
        @selfRef.DefaultManagementGroupId = defaultManagementGroupId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CostManagement.CloudConnectorArgs WithDisplayName(this global::Pulumi.AzureNative.CostManagement.CloudConnectorArgs @selfRef, global::System.String displayName)
    {
        @selfRef.DisplayName = displayName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CostManagement.CloudConnectorArgs WithKind(this global::Pulumi.AzureNative.CostManagement.CloudConnectorArgs @selfRef, global::System.String kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CostManagement.CloudConnectorArgs WithReportId(this global::Pulumi.AzureNative.CostManagement.CloudConnectorArgs @selfRef, global::System.String reportId)
    {
        @selfRef.ReportId = reportId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CostManagement.CloudConnectorArgs WithSubscriptionId(this global::Pulumi.AzureNative.CostManagement.CloudConnectorArgs @selfRef, global::System.String subscriptionId)
    {
        @selfRef.SubscriptionId = subscriptionId;
        return @selfRef;
    }

}
