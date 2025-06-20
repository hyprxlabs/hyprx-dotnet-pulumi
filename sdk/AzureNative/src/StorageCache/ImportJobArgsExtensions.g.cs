// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.StorageCache;

public static partial class ImportJobArgsExtensions
{
    public static global::Pulumi.AzureNative.StorageCache.ImportJobArgs WithAmlFilesystemName(this global::Pulumi.AzureNative.StorageCache.ImportJobArgs @selfRef, global::System.String amlFilesystemName)
    {
        @selfRef.AmlFilesystemName = amlFilesystemName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.ImportJobArgs WithConflictResolutionMode(this global::Pulumi.AzureNative.StorageCache.ImportJobArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.StorageCache.ConflictResolutionMode> conflictResolutionMode)
    {
        @selfRef.ConflictResolutionMode = conflictResolutionMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.ImportJobArgs WithImportJobName(this global::Pulumi.AzureNative.StorageCache.ImportJobArgs @selfRef, global::System.String importJobName)
    {
        @selfRef.ImportJobName = importJobName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.ImportJobArgs WithImportPrefixes(this global::Pulumi.AzureNative.StorageCache.ImportJobArgs @selfRef, global::System.Collections.Generic.List<global::System.String> importPrefixes)
    {
        @selfRef.ImportPrefixes = importPrefixes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.ImportJobArgs WithImportPrefixes(this global::Pulumi.AzureNative.StorageCache.ImportJobArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ImportPrefixes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.ImportJobArgs WithImportPrefixes(this global::Pulumi.AzureNative.StorageCache.ImportJobArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ImportPrefixes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.ImportJobArgs WithLocation(this global::Pulumi.AzureNative.StorageCache.ImportJobArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.ImportJobArgs WithMaximumErrors(this global::Pulumi.AzureNative.StorageCache.ImportJobArgs @selfRef, global::System.Int32 maximumErrors)
    {
        @selfRef.MaximumErrors = maximumErrors;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.ImportJobArgs WithResourceGroupName(this global::Pulumi.AzureNative.StorageCache.ImportJobArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.ImportJobArgs WithTags(this global::Pulumi.AzureNative.StorageCache.ImportJobArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.ImportJobArgs WithTags(this global::Pulumi.AzureNative.StorageCache.ImportJobArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.ImportJobArgs WithTags(this global::Pulumi.AzureNative.StorageCache.ImportJobArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
