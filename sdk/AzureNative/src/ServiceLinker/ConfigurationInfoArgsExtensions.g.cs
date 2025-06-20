// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ServiceLinker.Inputs;

namespace Pulumi.AzureNative.ServiceLinker;

public static partial class ConfigurationInfoArgsExtensions
{
    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs WithAction(this global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ServiceLinker.ActionType> action)
    {
        @selfRef.Action = action;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs WithAdditionalConfigurations(this global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> additionalConfigurations)
    {
        @selfRef.AdditionalConfigurations = additionalConfigurations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs WithAdditionalConfigurations(this global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.AdditionalConfigurations = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs WithAdditionalConfigurations(this global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.AdditionalConfigurations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs WithAdditionalConnectionStringProperties(this global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> additionalConnectionStringProperties)
    {
        @selfRef.AdditionalConnectionStringProperties = additionalConnectionStringProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs WithAdditionalConnectionStringProperties(this global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.AdditionalConnectionStringProperties = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs WithAdditionalConnectionStringProperties(this global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.AdditionalConnectionStringProperties = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs WithConfigurationStore(this global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs @selfRef, global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationStoreArgs configurationStore)
    {
        @selfRef.ConfigurationStore = configurationStore;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs WithConfigurationStore(this global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationStoreArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationStoreArgs();
        @configure(@item);
        @selfRef.ConfigurationStore = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs WithCustomizedKeys(this global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> customizedKeys)
    {
        @selfRef.CustomizedKeys = customizedKeys;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs WithCustomizedKeys(this global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.CustomizedKeys = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs WithCustomizedKeys(this global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.CustomizedKeys = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs WithDaprProperties(this global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs @selfRef, global::Pulumi.AzureNative.ServiceLinker.Inputs.DaprPropertiesArgs daprProperties)
    {
        @selfRef.DaprProperties = daprProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs WithDaprProperties(this global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ServiceLinker.Inputs.DaprPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ServiceLinker.Inputs.DaprPropertiesArgs();
        @configure(@item);
        @selfRef.DaprProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs WithDeleteOrUpdateBehavior(this global::Pulumi.AzureNative.ServiceLinker.Inputs.ConfigurationInfoArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ServiceLinker.DeleteOrUpdateBehavior> deleteOrUpdateBehavior)
    {
        @selfRef.DeleteOrUpdateBehavior = deleteOrUpdateBehavior;
        return @selfRef;
    }

}
