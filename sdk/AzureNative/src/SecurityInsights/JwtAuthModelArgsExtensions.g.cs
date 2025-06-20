// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.SecurityInsights.Inputs;

namespace Pulumi.AzureNative.SecurityInsights;

public static partial class JwtAuthModelArgsExtensions
{
    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs WithHeaders(this global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> headers)
    {
        @selfRef.Headers = headers;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs WithHeaders(this global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Headers = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs WithHeaders(this global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Headers = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs WithIsCredentialsInHeaders(this global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs @selfRef, bool isCredentialsInHeaders = true)
    {
        @selfRef.IsCredentialsInHeaders = isCredentialsInHeaders;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs WithIsJsonRequest(this global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs @selfRef, bool isJsonRequest = true)
    {
        @selfRef.IsJsonRequest = isJsonRequest;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs WithPassword(this global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> password)
    {
        @selfRef.Password = password;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs WithPassword(this global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Password = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs WithPassword(this global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Password = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs WithQueryParameters(this global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> queryParameters)
    {
        @selfRef.QueryParameters = queryParameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs WithQueryParameters(this global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.QueryParameters = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs WithQueryParameters(this global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.QueryParameters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs WithRequestTimeoutInSeconds(this global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs @selfRef, global::System.Int32 requestTimeoutInSeconds)
    {
        @selfRef.RequestTimeoutInSeconds = requestTimeoutInSeconds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs WithTokenEndpoint(this global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs @selfRef, global::System.String tokenEndpoint)
    {
        @selfRef.TokenEndpoint = tokenEndpoint;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs WithType(this global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs WithUserName(this global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> userName)
    {
        @selfRef.UserName = userName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs WithUserName(this global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.UserName = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs WithUserName(this global::Pulumi.AzureNative.SecurityInsights.Inputs.JwtAuthModelArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.UserName = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
