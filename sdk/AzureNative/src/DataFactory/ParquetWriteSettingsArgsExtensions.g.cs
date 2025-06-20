// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class ParquetWriteSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.ParquetWriteSettingsArgs WithFileNamePrefix(this global::Pulumi.AzureNative.DataFactory.Inputs.ParquetWriteSettingsArgs @selfRef, global::System.Object fileNamePrefix)
    {
        @selfRef.FileNamePrefix = fileNamePrefix;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ParquetWriteSettingsArgs WithFileNamePrefix(this global::Pulumi.AzureNative.DataFactory.Inputs.ParquetWriteSettingsArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.FileNamePrefix = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ParquetWriteSettingsArgs WithMaxRowsPerFile(this global::Pulumi.AzureNative.DataFactory.Inputs.ParquetWriteSettingsArgs @selfRef, global::System.Object maxRowsPerFile)
    {
        @selfRef.MaxRowsPerFile = maxRowsPerFile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ParquetWriteSettingsArgs WithMaxRowsPerFile(this global::Pulumi.AzureNative.DataFactory.Inputs.ParquetWriteSettingsArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.MaxRowsPerFile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ParquetWriteSettingsArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.ParquetWriteSettingsArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
