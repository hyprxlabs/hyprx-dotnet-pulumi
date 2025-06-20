// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AppFlow.Inputs;

namespace Pulumi.AwsNative.AppFlow;

public static partial class ConnectorProfileConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileConfigArgs WithConnectorProfileCredentials(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileConfigArgs @selfRef, global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileCredentialsArgs connectorProfileCredentials)
    {
        @selfRef.ConnectorProfileCredentials = connectorProfileCredentials;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileConfigArgs WithConnectorProfileCredentials(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileCredentialsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileCredentialsArgs();
        @configure(@item);
        @selfRef.ConnectorProfileCredentials = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileConfigArgs WithConnectorProfileProperties(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileConfigArgs @selfRef, global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfilePropertiesArgs connectorProfileProperties)
    {
        @selfRef.ConnectorProfileProperties = connectorProfileProperties;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileConfigArgs WithConnectorProfileProperties(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfilePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfilePropertiesArgs();
        @configure(@item);
        @selfRef.ConnectorProfileProperties = @item;
        return @selfRef;
    }

}
