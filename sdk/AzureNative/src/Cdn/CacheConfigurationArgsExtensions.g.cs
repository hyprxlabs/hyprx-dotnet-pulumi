// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Cdn.Inputs;

namespace Pulumi.AzureNative.Cdn;

public static partial class CacheConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.Cdn.Inputs.CacheConfigurationArgs WithCacheBehavior(this global::Pulumi.AzureNative.Cdn.Inputs.CacheConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Cdn.RuleCacheBehavior> cacheBehavior)
    {
        @selfRef.CacheBehavior = cacheBehavior;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.CacheConfigurationArgs WithCacheDuration(this global::Pulumi.AzureNative.Cdn.Inputs.CacheConfigurationArgs @selfRef, global::System.String cacheDuration)
    {
        @selfRef.CacheDuration = cacheDuration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.CacheConfigurationArgs WithIsCompressionEnabled(this global::Pulumi.AzureNative.Cdn.Inputs.CacheConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Cdn.RuleIsCompressionEnabled> isCompressionEnabled)
    {
        @selfRef.IsCompressionEnabled = isCompressionEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.CacheConfigurationArgs WithQueryParameters(this global::Pulumi.AzureNative.Cdn.Inputs.CacheConfigurationArgs @selfRef, global::System.String queryParameters)
    {
        @selfRef.QueryParameters = queryParameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.CacheConfigurationArgs WithQueryStringCachingBehavior(this global::Pulumi.AzureNative.Cdn.Inputs.CacheConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Cdn.RuleQueryStringCachingBehavior> queryStringCachingBehavior)
    {
        @selfRef.QueryStringCachingBehavior = queryStringCachingBehavior;
        return @selfRef;
    }

}
