// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Dms.Inputs;

namespace Pulumi.AwsNative.Dms;

public static partial class SettingsPropertiesRedshiftSettingsPropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.Dms.Inputs.SettingsPropertiesRedshiftSettingsPropertiesArgs WithDatabaseName(this global::Pulumi.AwsNative.Dms.Inputs.SettingsPropertiesRedshiftSettingsPropertiesArgs @selfRef, global::System.String databaseName)
    {
        @selfRef.DatabaseName = databaseName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Dms.Inputs.SettingsPropertiesRedshiftSettingsPropertiesArgs WithPort(this global::Pulumi.AwsNative.Dms.Inputs.SettingsPropertiesRedshiftSettingsPropertiesArgs @selfRef, global::System.Int32 port)
    {
        @selfRef.Port = port;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Dms.Inputs.SettingsPropertiesRedshiftSettingsPropertiesArgs WithServerName(this global::Pulumi.AwsNative.Dms.Inputs.SettingsPropertiesRedshiftSettingsPropertiesArgs @selfRef, global::System.String serverName)
    {
        @selfRef.ServerName = serverName;
        return @selfRef;
    }

}
