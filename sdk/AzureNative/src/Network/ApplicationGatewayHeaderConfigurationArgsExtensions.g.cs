// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class ApplicationGatewayHeaderConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayHeaderConfigurationArgs WithHeaderName(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayHeaderConfigurationArgs @selfRef, global::System.String headerName)
    {
        @selfRef.HeaderName = headerName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayHeaderConfigurationArgs WithHeaderValue(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayHeaderConfigurationArgs @selfRef, global::System.String headerValue)
    {
        @selfRef.HeaderValue = headerValue;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayHeaderConfigurationArgs WithHeaderValueMatcher(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayHeaderConfigurationArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.HeaderValueMatcherArgs headerValueMatcher)
    {
        @selfRef.HeaderValueMatcher = headerValueMatcher;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayHeaderConfigurationArgs WithHeaderValueMatcher(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayHeaderConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.HeaderValueMatcherArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.HeaderValueMatcherArgs();
        @configure(@item);
        @selfRef.HeaderValueMatcher = @item;
        return @selfRef;
    }

}
