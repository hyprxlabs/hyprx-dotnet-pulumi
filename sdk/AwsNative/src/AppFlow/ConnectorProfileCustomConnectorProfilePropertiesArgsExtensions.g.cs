// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AppFlow.Inputs;

namespace Pulumi.AwsNative.AppFlow;

public static partial class ConnectorProfileCustomConnectorProfilePropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileCustomConnectorProfilePropertiesArgs WithOAuth2Properties(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileCustomConnectorProfilePropertiesArgs @selfRef, global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileOAuth2PropertiesArgs oAuth2Properties)
    {
        @selfRef.OAuth2Properties = oAuth2Properties;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileCustomConnectorProfilePropertiesArgs WithOAuth2Properties(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileCustomConnectorProfilePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileOAuth2PropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileOAuth2PropertiesArgs();
        @configure(@item);
        @selfRef.OAuth2Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileCustomConnectorProfilePropertiesArgs WithProfileProperties(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileCustomConnectorProfilePropertiesArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> profileProperties)
    {
        @selfRef.ProfileProperties = profileProperties;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileCustomConnectorProfilePropertiesArgs WithProfileProperties(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileCustomConnectorProfilePropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.ProfileProperties = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileCustomConnectorProfilePropertiesArgs WithProfileProperties(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileCustomConnectorProfilePropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.ProfileProperties = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
