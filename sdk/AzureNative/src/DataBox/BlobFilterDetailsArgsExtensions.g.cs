// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataBox.Inputs;

namespace Pulumi.AzureNative.DataBox;

public static partial class BlobFilterDetailsArgsExtensions
{
    public static global::Pulumi.AzureNative.DataBox.Inputs.BlobFilterDetailsArgs WithBlobPathList(this global::Pulumi.AzureNative.DataBox.Inputs.BlobFilterDetailsArgs @selfRef, global::System.Collections.Generic.List<global::System.String> blobPathList)
    {
        @selfRef.BlobPathList = blobPathList;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataBox.Inputs.BlobFilterDetailsArgs WithBlobPathList(this global::Pulumi.AzureNative.DataBox.Inputs.BlobFilterDetailsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.BlobPathList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataBox.Inputs.BlobFilterDetailsArgs WithBlobPathList(this global::Pulumi.AzureNative.DataBox.Inputs.BlobFilterDetailsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.BlobPathList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataBox.Inputs.BlobFilterDetailsArgs WithBlobPrefixList(this global::Pulumi.AzureNative.DataBox.Inputs.BlobFilterDetailsArgs @selfRef, global::System.Collections.Generic.List<global::System.String> blobPrefixList)
    {
        @selfRef.BlobPrefixList = blobPrefixList;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataBox.Inputs.BlobFilterDetailsArgs WithBlobPrefixList(this global::Pulumi.AzureNative.DataBox.Inputs.BlobFilterDetailsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.BlobPrefixList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataBox.Inputs.BlobFilterDetailsArgs WithBlobPrefixList(this global::Pulumi.AzureNative.DataBox.Inputs.BlobFilterDetailsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.BlobPrefixList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataBox.Inputs.BlobFilterDetailsArgs WithContainerList(this global::Pulumi.AzureNative.DataBox.Inputs.BlobFilterDetailsArgs @selfRef, global::System.Collections.Generic.List<global::System.String> containerList)
    {
        @selfRef.ContainerList = containerList;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataBox.Inputs.BlobFilterDetailsArgs WithContainerList(this global::Pulumi.AzureNative.DataBox.Inputs.BlobFilterDetailsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ContainerList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataBox.Inputs.BlobFilterDetailsArgs WithContainerList(this global::Pulumi.AzureNative.DataBox.Inputs.BlobFilterDetailsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ContainerList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
