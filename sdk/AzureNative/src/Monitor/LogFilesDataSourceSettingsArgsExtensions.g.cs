// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Monitor.Inputs;

namespace Pulumi.AzureNative.Monitor;

public static partial class LogFilesDataSourceSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceSettingsArgs WithText(this global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceSettingsArgs @selfRef, global::Pulumi.AzureNative.Monitor.Inputs.LogFileSettingsTextArgs text)
    {
        @selfRef.Text = text;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceSettingsArgs WithText(this global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceSettingsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Monitor.Inputs.LogFileSettingsTextArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Monitor.Inputs.LogFileSettingsTextArgs();
        @configure(@item);
        @selfRef.Text = @item;
        return @selfRef;
    }

}
