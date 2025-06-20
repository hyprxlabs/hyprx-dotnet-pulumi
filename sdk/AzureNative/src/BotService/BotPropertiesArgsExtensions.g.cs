// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.BotService.Inputs;

namespace Pulumi.AzureNative.BotService;

public static partial class BotPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithAllSettings(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> allSettings)
    {
        @selfRef.AllSettings = allSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithAllSettings(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.AllSettings = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithAllSettings(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.AllSettings = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithAppPasswordHint(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.String appPasswordHint)
    {
        @selfRef.AppPasswordHint = appPasswordHint;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithCmekKeyVaultUrl(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.String cmekKeyVaultUrl)
    {
        @selfRef.CmekKeyVaultUrl = cmekKeyVaultUrl;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithDescription(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithDeveloperAppInsightKey(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.String developerAppInsightKey)
    {
        @selfRef.DeveloperAppInsightKey = developerAppInsightKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithDeveloperAppInsightsApiKey(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.String developerAppInsightsApiKey)
    {
        @selfRef.DeveloperAppInsightsApiKey = developerAppInsightsApiKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithDeveloperAppInsightsApplicationId(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.String developerAppInsightsApplicationId)
    {
        @selfRef.DeveloperAppInsightsApplicationId = developerAppInsightsApplicationId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithDisableLocalAuth(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, bool disableLocalAuth = true)
    {
        @selfRef.DisableLocalAuth = disableLocalAuth;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithDisplayName(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.String displayName)
    {
        @selfRef.DisplayName = displayName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithEndpoint(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.String endpoint)
    {
        @selfRef.Endpoint = endpoint;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithIconUrl(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.String iconUrl)
    {
        @selfRef.IconUrl = iconUrl;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithIsCmekEnabled(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, bool isCmekEnabled = true)
    {
        @selfRef.IsCmekEnabled = isCmekEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithIsStreamingSupported(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, bool isStreamingSupported = true)
    {
        @selfRef.IsStreamingSupported = isStreamingSupported;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithLuisAppIds(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> luisAppIds)
    {
        @selfRef.LuisAppIds = luisAppIds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithLuisAppIds(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.LuisAppIds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithLuisAppIds(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.LuisAppIds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithLuisKey(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.String luisKey)
    {
        @selfRef.LuisKey = luisKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithManifestUrl(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.String manifestUrl)
    {
        @selfRef.ManifestUrl = manifestUrl;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithMsaAppId(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.String msaAppId)
    {
        @selfRef.MsaAppId = msaAppId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithMsaAppMSIResourceId(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.String msaAppMSIResourceId)
    {
        @selfRef.MsaAppMSIResourceId = msaAppMSIResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithMsaAppTenantId(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.String msaAppTenantId)
    {
        @selfRef.MsaAppTenantId = msaAppTenantId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithMsaAppType(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.BotService.MsaAppType> msaAppType)
    {
        @selfRef.MsaAppType = msaAppType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithOpenWithHint(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.String openWithHint)
    {
        @selfRef.OpenWithHint = openWithHint;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithParameters(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> parameters)
    {
        @selfRef.Parameters = parameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithParameters(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Parameters = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithParameters(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Parameters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithPublicNetworkAccess(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.BotService.PublicNetworkAccess> publicNetworkAccess)
    {
        @selfRef.PublicNetworkAccess = publicNetworkAccess;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithPublishingCredentials(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.String publishingCredentials)
    {
        @selfRef.PublishingCredentials = publishingCredentials;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithSchemaTransformationVersion(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.String schemaTransformationVersion)
    {
        @selfRef.SchemaTransformationVersion = schemaTransformationVersion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithStorageResourceId(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.String storageResourceId)
    {
        @selfRef.StorageResourceId = storageResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs WithTenantId(this global::Pulumi.AzureNative.BotService.Inputs.BotPropertiesArgs @selfRef, global::System.String tenantId)
    {
        @selfRef.TenantId = tenantId;
        return @selfRef;
    }

}
