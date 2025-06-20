// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.SqlVirtualMachine.Inputs;

namespace Pulumi.AzureNative.SqlVirtualMachine;

public static partial class SqlConnectivityUpdateSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.SqlConnectivityUpdateSettingsArgs WithConnectivityType(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.SqlConnectivityUpdateSettingsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.SqlVirtualMachine.ConnectivityType> connectivityType)
    {
        @selfRef.ConnectivityType = connectivityType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.SqlConnectivityUpdateSettingsArgs WithPort(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.SqlConnectivityUpdateSettingsArgs @selfRef, global::System.Int32 port)
    {
        @selfRef.Port = port;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.SqlConnectivityUpdateSettingsArgs WithSqlAuthUpdatePassword(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.SqlConnectivityUpdateSettingsArgs @selfRef, global::System.String sqlAuthUpdatePassword)
    {
        @selfRef.SqlAuthUpdatePassword = sqlAuthUpdatePassword;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.SqlConnectivityUpdateSettingsArgs WithSqlAuthUpdateUserName(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.SqlConnectivityUpdateSettingsArgs @selfRef, global::System.String sqlAuthUpdateUserName)
    {
        @selfRef.SqlAuthUpdateUserName = sqlAuthUpdateUserName;
        return @selfRef;
    }

}
