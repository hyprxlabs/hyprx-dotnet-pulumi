// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.CostManagement.Inputs;

namespace Pulumi.AzureNative.CostManagement;

public static partial class FileDestinationArgsExtensions
{
    public static global::Pulumi.AzureNative.CostManagement.Inputs.FileDestinationArgs WithFileFormats(this global::Pulumi.AzureNative.CostManagement.Inputs.FileDestinationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.CostManagement.FileFormat>> fileFormats)
    {
        @selfRef.FileFormats = fileFormats;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CostManagement.Inputs.FileDestinationArgs WithFileFormats(this global::Pulumi.AzureNative.CostManagement.Inputs.FileDestinationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.CostManagement.FileFormat>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.CostManagement.FileFormat>>();
        @configure(@list);
        @selfRef.FileFormats = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CostManagement.Inputs.FileDestinationArgs WithFileFormats(this global::Pulumi.AzureNative.CostManagement.Inputs.FileDestinationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.CostManagement.FileFormat>>> @create)
    {
        @selfRef.FileFormats = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
