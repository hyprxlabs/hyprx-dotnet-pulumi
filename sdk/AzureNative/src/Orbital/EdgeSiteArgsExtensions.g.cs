// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Orbital;

public static partial class EdgeSiteArgsExtensions
{
    public static global::Pulumi.AzureNative.Orbital.EdgeSiteArgs WithEdgeSiteName(this global::Pulumi.AzureNative.Orbital.EdgeSiteArgs @selfRef, global::System.String edgeSiteName)
    {
        @selfRef.EdgeSiteName = edgeSiteName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Orbital.EdgeSiteArgs WithGlobalCommunicationsSite(this global::Pulumi.AzureNative.Orbital.EdgeSiteArgs @selfRef, global::Pulumi.AzureNative.Orbital.Inputs.EdgeSitesPropertiesGlobalCommunicationsSiteArgs globalCommunicationsSite)
    {
        @selfRef.GlobalCommunicationsSite = globalCommunicationsSite;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Orbital.EdgeSiteArgs WithGlobalCommunicationsSite(this global::Pulumi.AzureNative.Orbital.EdgeSiteArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Orbital.Inputs.EdgeSitesPropertiesGlobalCommunicationsSiteArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Orbital.Inputs.EdgeSitesPropertiesGlobalCommunicationsSiteArgs();
        @configure(@item);
        @selfRef.GlobalCommunicationsSite = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Orbital.EdgeSiteArgs WithLocation(this global::Pulumi.AzureNative.Orbital.EdgeSiteArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Orbital.EdgeSiteArgs WithResourceGroupName(this global::Pulumi.AzureNative.Orbital.EdgeSiteArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Orbital.EdgeSiteArgs WithTags(this global::Pulumi.AzureNative.Orbital.EdgeSiteArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Orbital.EdgeSiteArgs WithTags(this global::Pulumi.AzureNative.Orbital.EdgeSiteArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Orbital.EdgeSiteArgs WithTags(this global::Pulumi.AzureNative.Orbital.EdgeSiteArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
