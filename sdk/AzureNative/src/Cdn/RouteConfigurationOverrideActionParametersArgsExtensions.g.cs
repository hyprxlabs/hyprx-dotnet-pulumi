// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Cdn.Inputs;

namespace Pulumi.AzureNative.Cdn;

public static partial class RouteConfigurationOverrideActionParametersArgsExtensions
{
    public static global::Pulumi.AzureNative.Cdn.Inputs.RouteConfigurationOverrideActionParametersArgs WithCacheConfiguration(this global::Pulumi.AzureNative.Cdn.Inputs.RouteConfigurationOverrideActionParametersArgs @selfRef, global::Pulumi.AzureNative.Cdn.Inputs.CacheConfigurationArgs cacheConfiguration)
    {
        @selfRef.CacheConfiguration = cacheConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.RouteConfigurationOverrideActionParametersArgs WithCacheConfiguration(this global::Pulumi.AzureNative.Cdn.Inputs.RouteConfigurationOverrideActionParametersArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Cdn.Inputs.CacheConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Cdn.Inputs.CacheConfigurationArgs();
        @configure(@item);
        @selfRef.CacheConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.RouteConfigurationOverrideActionParametersArgs WithOriginGroupOverride(this global::Pulumi.AzureNative.Cdn.Inputs.RouteConfigurationOverrideActionParametersArgs @selfRef, global::Pulumi.AzureNative.Cdn.Inputs.OriginGroupOverrideArgs originGroupOverride)
    {
        @selfRef.OriginGroupOverride = originGroupOverride;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.RouteConfigurationOverrideActionParametersArgs WithOriginGroupOverride(this global::Pulumi.AzureNative.Cdn.Inputs.RouteConfigurationOverrideActionParametersArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Cdn.Inputs.OriginGroupOverrideArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Cdn.Inputs.OriginGroupOverrideArgs();
        @configure(@item);
        @selfRef.OriginGroupOverride = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.RouteConfigurationOverrideActionParametersArgs WithTypeName(this global::Pulumi.AzureNative.Cdn.Inputs.RouteConfigurationOverrideActionParametersArgs @selfRef, global::System.String typeName)
    {
        @selfRef.TypeName = typeName;
        return @selfRef;
    }

}
