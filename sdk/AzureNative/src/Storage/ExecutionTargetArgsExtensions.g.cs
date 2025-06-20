// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Storage.Inputs;

namespace Pulumi.AzureNative.Storage;

public static partial class ExecutionTargetArgsExtensions
{
    public static global::Pulumi.AzureNative.Storage.Inputs.ExecutionTargetArgs WithExcludePrefix(this global::Pulumi.AzureNative.Storage.Inputs.ExecutionTargetArgs @selfRef, global::System.Collections.Generic.List<global::System.String> excludePrefix)
    {
        @selfRef.ExcludePrefix = excludePrefix;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.Inputs.ExecutionTargetArgs WithExcludePrefix(this global::Pulumi.AzureNative.Storage.Inputs.ExecutionTargetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ExcludePrefix = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.Inputs.ExecutionTargetArgs WithExcludePrefix(this global::Pulumi.AzureNative.Storage.Inputs.ExecutionTargetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ExcludePrefix = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.Inputs.ExecutionTargetArgs WithPrefix(this global::Pulumi.AzureNative.Storage.Inputs.ExecutionTargetArgs @selfRef, global::System.Collections.Generic.List<global::System.String> prefix)
    {
        @selfRef.Prefix = prefix;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.Inputs.ExecutionTargetArgs WithPrefix(this global::Pulumi.AzureNative.Storage.Inputs.ExecutionTargetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Prefix = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.Inputs.ExecutionTargetArgs WithPrefix(this global::Pulumi.AzureNative.Storage.Inputs.ExecutionTargetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Prefix = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
