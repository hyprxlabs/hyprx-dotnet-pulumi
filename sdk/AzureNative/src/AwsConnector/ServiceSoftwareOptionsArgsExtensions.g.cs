// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class ServiceSoftwareOptionsArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ServiceSoftwareOptionsArgs WithAutomatedUpdateDate(this global::Pulumi.AzureNative.AwsConnector.Inputs.ServiceSoftwareOptionsArgs @selfRef, global::System.String automatedUpdateDate)
    {
        @selfRef.AutomatedUpdateDate = automatedUpdateDate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ServiceSoftwareOptionsArgs WithCancellable(this global::Pulumi.AzureNative.AwsConnector.Inputs.ServiceSoftwareOptionsArgs @selfRef, bool cancellable = true)
    {
        @selfRef.Cancellable = cancellable;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ServiceSoftwareOptionsArgs WithCurrentVersion(this global::Pulumi.AzureNative.AwsConnector.Inputs.ServiceSoftwareOptionsArgs @selfRef, global::System.String currentVersion)
    {
        @selfRef.CurrentVersion = currentVersion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ServiceSoftwareOptionsArgs WithDescription(this global::Pulumi.AzureNative.AwsConnector.Inputs.ServiceSoftwareOptionsArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ServiceSoftwareOptionsArgs WithNewVersion(this global::Pulumi.AzureNative.AwsConnector.Inputs.ServiceSoftwareOptionsArgs @selfRef, global::System.String newVersion)
    {
        @selfRef.NewVersion = newVersion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ServiceSoftwareOptionsArgs WithOptionalDeployment(this global::Pulumi.AzureNative.AwsConnector.Inputs.ServiceSoftwareOptionsArgs @selfRef, bool optionalDeployment = true)
    {
        @selfRef.OptionalDeployment = optionalDeployment;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ServiceSoftwareOptionsArgs WithUpdateAvailable(this global::Pulumi.AzureNative.AwsConnector.Inputs.ServiceSoftwareOptionsArgs @selfRef, bool updateAvailable = true)
    {
        @selfRef.UpdateAvailable = updateAvailable;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ServiceSoftwareOptionsArgs WithUpdateStatus(this global::Pulumi.AzureNative.AwsConnector.Inputs.ServiceSoftwareOptionsArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.DeploymentStatusEnumValueArgs updateStatus)
    {
        @selfRef.UpdateStatus = updateStatus;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ServiceSoftwareOptionsArgs WithUpdateStatus(this global::Pulumi.AzureNative.AwsConnector.Inputs.ServiceSoftwareOptionsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.DeploymentStatusEnumValueArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.DeploymentStatusEnumValueArgs();
        @configure(@item);
        @selfRef.UpdateStatus = @item;
        return @selfRef;
    }

}
