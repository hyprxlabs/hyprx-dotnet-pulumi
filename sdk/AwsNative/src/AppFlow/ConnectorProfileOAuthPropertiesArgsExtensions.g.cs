// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AppFlow.Inputs;

namespace Pulumi.AwsNative.AppFlow;

public static partial class ConnectorProfileOAuthPropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileOAuthPropertiesArgs WithAuthCodeUrl(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileOAuthPropertiesArgs @selfRef, global::System.String authCodeUrl)
    {
        @selfRef.AuthCodeUrl = authCodeUrl;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileOAuthPropertiesArgs WithOAuthScopes(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileOAuthPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> oAuthScopes)
    {
        @selfRef.OAuthScopes = oAuthScopes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileOAuthPropertiesArgs WithOAuthScopes(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileOAuthPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.OAuthScopes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileOAuthPropertiesArgs WithOAuthScopes(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileOAuthPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.OAuthScopes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileOAuthPropertiesArgs WithTokenUrl(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileOAuthPropertiesArgs @selfRef, global::System.String tokenUrl)
    {
        @selfRef.TokenUrl = tokenUrl;
        return @selfRef;
    }

}
