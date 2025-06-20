// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DatabaseFleetManager.Inputs;

namespace Pulumi.AzureNative.DatabaseFleetManager;

public static partial class FleetDatabasePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs WithCollation(this global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs @selfRef, global::System.String collation)
    {
        @selfRef.Collation = collation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs WithCreateMode(this global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DatabaseFleetManager.DatabaseCreateMode> createMode)
    {
        @selfRef.CreateMode = createMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs WithIdentity(this global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs @selfRef, global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.IdentityArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs WithIdentity(this global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.IdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.IdentityArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs WithResourceTags(this global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> resourceTags)
    {
        @selfRef.ResourceTags = resourceTags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs WithResourceTags(this global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.ResourceTags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs WithResourceTags(this global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.ResourceTags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs WithRestoreFromTime(this global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs @selfRef, global::System.String restoreFromTime)
    {
        @selfRef.RestoreFromTime = restoreFromTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs WithSourceDatabaseName(this global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs @selfRef, global::System.String sourceDatabaseName)
    {
        @selfRef.SourceDatabaseName = sourceDatabaseName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs WithTierName(this global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs @selfRef, global::System.String tierName)
    {
        @selfRef.TierName = tierName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs WithTransparentDataEncryption(this global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs @selfRef, global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.TransparentDataEncryptionArgs transparentDataEncryption)
    {
        @selfRef.TransparentDataEncryption = transparentDataEncryption;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs WithTransparentDataEncryption(this global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FleetDatabasePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.TransparentDataEncryptionArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.TransparentDataEncryptionArgs();
        @configure(@item);
        @selfRef.TransparentDataEncryption = @item;
        return @selfRef;
    }

}
