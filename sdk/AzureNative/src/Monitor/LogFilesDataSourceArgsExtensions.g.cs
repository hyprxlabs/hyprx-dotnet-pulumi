// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Monitor.Inputs;

namespace Pulumi.AzureNative.Monitor;

public static partial class LogFilesDataSourceArgsExtensions
{
    public static global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceArgs WithFilePatterns(this global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceArgs @selfRef, global::System.Collections.Generic.List<global::System.String> filePatterns)
    {
        @selfRef.FilePatterns = filePatterns;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceArgs WithFilePatterns(this global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.FilePatterns = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceArgs WithFilePatterns(this global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.FilePatterns = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceArgs WithFormat(this global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Monitor.KnownLogFilesDataSourceFormat> format)
    {
        @selfRef.Format = format;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceArgs WithName(this global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceArgs WithSettings(this global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceArgs @selfRef, global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceSettingsArgs settings)
    {
        @selfRef.Settings = settings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceArgs WithSettings(this global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceSettingsArgs();
        @configure(@item);
        @selfRef.Settings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceArgs WithStreams(this global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceArgs @selfRef, global::System.Collections.Generic.List<global::System.String> streams)
    {
        @selfRef.Streams = streams;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceArgs WithStreams(this global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Streams = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceArgs WithStreams(this global::Pulumi.AzureNative.Monitor.Inputs.LogFilesDataSourceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Streams = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
