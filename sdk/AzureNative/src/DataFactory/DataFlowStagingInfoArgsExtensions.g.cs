// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class DataFlowStagingInfoArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.DataFlowStagingInfoArgs WithFolderPath(this global::Pulumi.AzureNative.DataFactory.Inputs.DataFlowStagingInfoArgs @selfRef, global::System.Object folderPath)
    {
        @selfRef.FolderPath = folderPath;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.DataFlowStagingInfoArgs WithFolderPath(this global::Pulumi.AzureNative.DataFactory.Inputs.DataFlowStagingInfoArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.FolderPath = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.DataFlowStagingInfoArgs WithLinkedService(this global::Pulumi.AzureNative.DataFactory.Inputs.DataFlowStagingInfoArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs linkedService)
    {
        @selfRef.LinkedService = linkedService;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.DataFlowStagingInfoArgs WithLinkedService(this global::Pulumi.AzureNative.DataFactory.Inputs.DataFlowStagingInfoArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs();
        @configure(@item);
        @selfRef.LinkedService = @item;
        return @selfRef;
    }

}
