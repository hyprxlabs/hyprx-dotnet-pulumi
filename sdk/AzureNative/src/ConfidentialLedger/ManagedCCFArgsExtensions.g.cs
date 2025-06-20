// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ConfidentialLedger;

public static partial class ManagedCCFArgsExtensions
{
    public static global::Pulumi.AzureNative.ConfidentialLedger.ManagedCCFArgs WithAppName(this global::Pulumi.AzureNative.ConfidentialLedger.ManagedCCFArgs @selfRef, global::System.String appName)
    {
        @selfRef.AppName = appName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConfidentialLedger.ManagedCCFArgs WithLocation(this global::Pulumi.AzureNative.ConfidentialLedger.ManagedCCFArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConfidentialLedger.ManagedCCFArgs WithProperties(this global::Pulumi.AzureNative.ConfidentialLedger.ManagedCCFArgs @selfRef, global::Pulumi.AzureNative.ConfidentialLedger.Inputs.ManagedCCFPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConfidentialLedger.ManagedCCFArgs WithProperties(this global::Pulumi.AzureNative.ConfidentialLedger.ManagedCCFArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ConfidentialLedger.Inputs.ManagedCCFPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ConfidentialLedger.Inputs.ManagedCCFPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConfidentialLedger.ManagedCCFArgs WithResourceGroupName(this global::Pulumi.AzureNative.ConfidentialLedger.ManagedCCFArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConfidentialLedger.ManagedCCFArgs WithTags(this global::Pulumi.AzureNative.ConfidentialLedger.ManagedCCFArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConfidentialLedger.ManagedCCFArgs WithTags(this global::Pulumi.AzureNative.ConfidentialLedger.ManagedCCFArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConfidentialLedger.ManagedCCFArgs WithTags(this global::Pulumi.AzureNative.ConfidentialLedger.ManagedCCFArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
