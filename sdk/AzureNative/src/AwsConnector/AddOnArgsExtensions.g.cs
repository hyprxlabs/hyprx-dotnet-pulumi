// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class AddOnArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AddOnArgs WithAddOnType(this global::Pulumi.AzureNative.AwsConnector.Inputs.AddOnArgs @selfRef, global::System.String addOnType)
    {
        @selfRef.AddOnType = addOnType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AddOnArgs WithAutoSnapshotAddOnRequest(this global::Pulumi.AzureNative.AwsConnector.Inputs.AddOnArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.AutoSnapshotAddOnArgs autoSnapshotAddOnRequest)
    {
        @selfRef.AutoSnapshotAddOnRequest = autoSnapshotAddOnRequest;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AddOnArgs WithAutoSnapshotAddOnRequest(this global::Pulumi.AzureNative.AwsConnector.Inputs.AddOnArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.AutoSnapshotAddOnArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.AutoSnapshotAddOnArgs();
        @configure(@item);
        @selfRef.AutoSnapshotAddOnRequest = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AddOnArgs WithStatus(this global::Pulumi.AzureNative.AwsConnector.Inputs.AddOnArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AwsConnector.AddOnStatus> status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

}
