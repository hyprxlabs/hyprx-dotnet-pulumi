// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ApplicationInsights;

public static partial class WorkbookArgsExtensions
{
    public static global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs WithCategory(this global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs @selfRef, global::System.String category)
    {
        @selfRef.Category = category;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs WithDescription(this global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs WithDisplayName(this global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs @selfRef, global::System.String displayName)
    {
        @selfRef.DisplayName = displayName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs WithIdentity(this global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs @selfRef, global::Pulumi.AzureNative.ApplicationInsights.Inputs.WorkbookResourceIdentityArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs WithIdentity(this global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ApplicationInsights.Inputs.WorkbookResourceIdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ApplicationInsights.Inputs.WorkbookResourceIdentityArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs WithKind(this global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ApplicationInsights.WorkbookSharedTypeKind> kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs WithLocation(this global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs WithResourceGroupName(this global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs WithResourceName(this global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs @selfRef, global::System.String resourceName)
    {
        @selfRef.ResourceName = resourceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs WithSerializedData(this global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs @selfRef, global::System.String serializedData)
    {
        @selfRef.SerializedData = serializedData;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs WithSourceId(this global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs @selfRef, global::System.String sourceId)
    {
        @selfRef.SourceId = sourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs WithStorageUri(this global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs @selfRef, global::System.String storageUri)
    {
        @selfRef.StorageUri = storageUri;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs WithTags(this global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs WithTags(this global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs WithTags(this global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs WithVersion(this global::Pulumi.AzureNative.ApplicationInsights.WorkbookArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
