// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class TarReadSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.TarReadSettingsArgs WithPreserveCompressionFileNameAsFolder(this global::Pulumi.AzureNative.DataFactory.Inputs.TarReadSettingsArgs @selfRef, global::System.Object preserveCompressionFileNameAsFolder)
    {
        @selfRef.PreserveCompressionFileNameAsFolder = preserveCompressionFileNameAsFolder;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TarReadSettingsArgs WithPreserveCompressionFileNameAsFolder(this global::Pulumi.AzureNative.DataFactory.Inputs.TarReadSettingsArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.PreserveCompressionFileNameAsFolder = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TarReadSettingsArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.TarReadSettingsArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
