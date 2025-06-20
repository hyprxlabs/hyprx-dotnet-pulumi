// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.AppSync;

public static partial class GraphQlApiArgsExtensions
{
    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithAdditionalAuthenticationProviders(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiAdditionalAuthenticationProviderArgs> additionalAuthenticationProviders)
    {
        @selfRef.AdditionalAuthenticationProviders = additionalAuthenticationProviders;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithAdditionalAuthenticationProviders(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiAdditionalAuthenticationProviderArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiAdditionalAuthenticationProviderArgs>();
        @configure(@list);
        @selfRef.AdditionalAuthenticationProviders = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithAdditionalAuthenticationProviders(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiAdditionalAuthenticationProviderArgs>> @create)
    {
        @selfRef.AdditionalAuthenticationProviders = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithApiType(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.String apiType)
    {
        @selfRef.ApiType = apiType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithAuthenticationType(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.String authenticationType)
    {
        @selfRef.AuthenticationType = authenticationType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithEnhancedMetricsConfig(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiEnhancedMetricsConfigArgs enhancedMetricsConfig)
    {
        @selfRef.EnhancedMetricsConfig = enhancedMetricsConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithEnhancedMetricsConfig(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiEnhancedMetricsConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiEnhancedMetricsConfigArgs();
        @configure(@item);
        @selfRef.EnhancedMetricsConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithEnvironmentVariables(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> environmentVariables)
    {
        @selfRef.EnvironmentVariables = environmentVariables;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithEnvironmentVariables(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.EnvironmentVariables = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithEnvironmentVariables(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.EnvironmentVariables = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithIntrospectionConfig(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.String introspectionConfig)
    {
        @selfRef.IntrospectionConfig = introspectionConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithLambdaAuthorizerConfig(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiLambdaAuthorizerConfigArgs lambdaAuthorizerConfig)
    {
        @selfRef.LambdaAuthorizerConfig = lambdaAuthorizerConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithLambdaAuthorizerConfig(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiLambdaAuthorizerConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiLambdaAuthorizerConfigArgs();
        @configure(@item);
        @selfRef.LambdaAuthorizerConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithLogConfig(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiLogConfigArgs logConfig)
    {
        @selfRef.LogConfig = logConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithLogConfig(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiLogConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiLogConfigArgs();
        @configure(@item);
        @selfRef.LogConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithMergedApiExecutionRoleArn(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.String mergedApiExecutionRoleArn)
    {
        @selfRef.MergedApiExecutionRoleArn = mergedApiExecutionRoleArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithName(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithOpenIdConnectConfig(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiOpenIdConnectConfigArgs openIdConnectConfig)
    {
        @selfRef.OpenIdConnectConfig = openIdConnectConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithOpenIdConnectConfig(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiOpenIdConnectConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiOpenIdConnectConfigArgs();
        @configure(@item);
        @selfRef.OpenIdConnectConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithOwnerContact(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.String ownerContact)
    {
        @selfRef.OwnerContact = ownerContact;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithQueryDepthLimit(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.Int32 queryDepthLimit)
    {
        @selfRef.QueryDepthLimit = queryDepthLimit;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithResolverCountLimit(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.Int32 resolverCountLimit)
    {
        @selfRef.ResolverCountLimit = resolverCountLimit;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithTags(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithTags(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithTags(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithUserPoolConfig(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiUserPoolConfigArgs userPoolConfig)
    {
        @selfRef.UserPoolConfig = userPoolConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithUserPoolConfig(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiUserPoolConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiUserPoolConfigArgs();
        @configure(@item);
        @selfRef.UserPoolConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithVisibility(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, global::System.String visibility)
    {
        @selfRef.Visibility = visibility;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.GraphQlApiArgs WithXrayEnabled(this global::Pulumi.AwsNative.AppSync.GraphQlApiArgs @selfRef, bool xrayEnabled = true)
    {
        @selfRef.XrayEnabled = xrayEnabled;
        return @selfRef;
    }

}
