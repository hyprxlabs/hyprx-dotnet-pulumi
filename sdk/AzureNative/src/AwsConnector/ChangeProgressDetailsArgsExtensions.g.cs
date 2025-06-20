// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class ChangeProgressDetailsArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ChangeProgressDetailsArgs WithChangeId(this global::Pulumi.AzureNative.AwsConnector.Inputs.ChangeProgressDetailsArgs @selfRef, global::System.String changeId)
    {
        @selfRef.ChangeId = changeId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ChangeProgressDetailsArgs WithConfigChangeStatus(this global::Pulumi.AzureNative.AwsConnector.Inputs.ChangeProgressDetailsArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.ConfigChangeStatusEnumValueArgs configChangeStatus)
    {
        @selfRef.ConfigChangeStatus = configChangeStatus;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ChangeProgressDetailsArgs WithConfigChangeStatus(this global::Pulumi.AzureNative.AwsConnector.Inputs.ChangeProgressDetailsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.ConfigChangeStatusEnumValueArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.ConfigChangeStatusEnumValueArgs();
        @configure(@item);
        @selfRef.ConfigChangeStatus = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ChangeProgressDetailsArgs WithInitiatedBy(this global::Pulumi.AzureNative.AwsConnector.Inputs.ChangeProgressDetailsArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.InitiatedByEnumValueArgs initiatedBy)
    {
        @selfRef.InitiatedBy = initiatedBy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ChangeProgressDetailsArgs WithInitiatedBy(this global::Pulumi.AzureNative.AwsConnector.Inputs.ChangeProgressDetailsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.InitiatedByEnumValueArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.InitiatedByEnumValueArgs();
        @configure(@item);
        @selfRef.InitiatedBy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ChangeProgressDetailsArgs WithLastUpdatedTime(this global::Pulumi.AzureNative.AwsConnector.Inputs.ChangeProgressDetailsArgs @selfRef, global::System.String lastUpdatedTime)
    {
        @selfRef.LastUpdatedTime = lastUpdatedTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ChangeProgressDetailsArgs WithMessage(this global::Pulumi.AzureNative.AwsConnector.Inputs.ChangeProgressDetailsArgs @selfRef, global::System.String message)
    {
        @selfRef.Message = message;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ChangeProgressDetailsArgs WithStartTime(this global::Pulumi.AzureNative.AwsConnector.Inputs.ChangeProgressDetailsArgs @selfRef, global::System.String startTime)
    {
        @selfRef.StartTime = startTime;
        return @selfRef;
    }

}
