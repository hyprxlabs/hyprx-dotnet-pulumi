// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DesktopVirtualization;

public static partial class AppAttachPackageArgsExtensions
{
    public static global::Pulumi.AzureNative.DesktopVirtualization.AppAttachPackageArgs WithAppAttachPackageName(this global::Pulumi.AzureNative.DesktopVirtualization.AppAttachPackageArgs @selfRef, global::System.String appAttachPackageName)
    {
        @selfRef.AppAttachPackageName = appAttachPackageName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DesktopVirtualization.AppAttachPackageArgs WithLocation(this global::Pulumi.AzureNative.DesktopVirtualization.AppAttachPackageArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DesktopVirtualization.AppAttachPackageArgs WithProperties(this global::Pulumi.AzureNative.DesktopVirtualization.AppAttachPackageArgs @selfRef, global::Pulumi.AzureNative.DesktopVirtualization.Inputs.AppAttachPackagePropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DesktopVirtualization.AppAttachPackageArgs WithProperties(this global::Pulumi.AzureNative.DesktopVirtualization.AppAttachPackageArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DesktopVirtualization.Inputs.AppAttachPackagePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DesktopVirtualization.Inputs.AppAttachPackagePropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DesktopVirtualization.AppAttachPackageArgs WithResourceGroupName(this global::Pulumi.AzureNative.DesktopVirtualization.AppAttachPackageArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DesktopVirtualization.AppAttachPackageArgs WithTags(this global::Pulumi.AzureNative.DesktopVirtualization.AppAttachPackageArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DesktopVirtualization.AppAttachPackageArgs WithTags(this global::Pulumi.AzureNative.DesktopVirtualization.AppAttachPackageArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DesktopVirtualization.AppAttachPackageArgs WithTags(this global::Pulumi.AzureNative.DesktopVirtualization.AppAttachPackageArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
