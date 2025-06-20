// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Migrate.Inputs;

namespace Pulumi.AzureNative.Migrate;

public static partial class IISWebApplicationArgsExtensions
{
    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithApplicationId(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.String applicationId)
    {
        @selfRef.ApplicationId = applicationId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithApplicationName(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.String applicationName)
    {
        @selfRef.ApplicationName = applicationName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithApplicationScratchPath(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.String applicationScratchPath)
    {
        @selfRef.ApplicationScratchPath = applicationScratchPath;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithApplications(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.IISApplicationDetailsArgs> applications)
    {
        @selfRef.Applications = applications;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithApplications(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.IISApplicationDetailsArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.IISApplicationDetailsArgs>();
        @configure(@list);
        @selfRef.Applications = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithApplications(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Migrate.Inputs.IISApplicationDetailsArgs>> @create)
    {
        @selfRef.Applications = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithBindings(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.BindingArgs> bindings)
    {
        @selfRef.Bindings = bindings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithBindings(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.BindingArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.BindingArgs>();
        @configure(@list);
        @selfRef.Bindings = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithBindings(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Migrate.Inputs.BindingArgs>> @create)
    {
        @selfRef.Bindings = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithConfigurations(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationConfigurationArgs> configurations)
    {
        @selfRef.Configurations = configurations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithConfigurations(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationConfigurationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationConfigurationArgs>();
        @configure(@list);
        @selfRef.Configurations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithConfigurations(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationConfigurationArgs>> @create)
    {
        @selfRef.Configurations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithDirectories(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationDirectoryArgs> directories)
    {
        @selfRef.Directories = directories;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithDirectories(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationDirectoryArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationDirectoryArgs>();
        @configure(@list);
        @selfRef.Directories = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithDirectories(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationDirectoryArgs>> @create)
    {
        @selfRef.Directories = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithDiscoveredFrameworks(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationFrameworkArgs> discoveredFrameworks)
    {
        @selfRef.DiscoveredFrameworks = discoveredFrameworks;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithDiscoveredFrameworks(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationFrameworkArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationFrameworkArgs>();
        @configure(@list);
        @selfRef.DiscoveredFrameworks = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithDiscoveredFrameworks(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationFrameworkArgs>> @create)
    {
        @selfRef.DiscoveredFrameworks = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithDisplayName(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.String displayName)
    {
        @selfRef.DisplayName = displayName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithIisWebServer(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::Pulumi.AzureNative.Migrate.Inputs.IISWebServerArgs iisWebServer)
    {
        @selfRef.IisWebServer = iisWebServer;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithIisWebServer(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Migrate.Inputs.IISWebServerArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Migrate.Inputs.IISWebServerArgs();
        @configure(@item);
        @selfRef.IisWebServer = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithLimits(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::Pulumi.AzureNative.Migrate.Inputs.ResourceRequirementsArgs limits)
    {
        @selfRef.Limits = limits;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithLimits(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Migrate.Inputs.ResourceRequirementsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Migrate.Inputs.ResourceRequirementsArgs();
        @configure(@item);
        @selfRef.Limits = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithPath(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::Pulumi.AzureNative.Migrate.Inputs.DirectoryPathArgs path)
    {
        @selfRef.Path = path;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithPath(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Migrate.Inputs.DirectoryPathArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Migrate.Inputs.DirectoryPathArgs();
        @configure(@item);
        @selfRef.Path = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithPrimaryFramework(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationFrameworkArgs primaryFramework)
    {
        @selfRef.PrimaryFramework = primaryFramework;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithPrimaryFramework(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationFrameworkArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationFrameworkArgs();
        @configure(@item);
        @selfRef.PrimaryFramework = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithRequests(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::Pulumi.AzureNative.Migrate.Inputs.ResourceRequirementsArgs requests)
    {
        @selfRef.Requests = requests;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithRequests(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Migrate.Inputs.ResourceRequirementsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Migrate.Inputs.ResourceRequirementsArgs();
        @configure(@item);
        @selfRef.Requests = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithVirtualApplications(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.IISVirtualApplicationDetailsArgs> virtualApplications)
    {
        @selfRef.VirtualApplications = virtualApplications;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithVirtualApplications(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.IISVirtualApplicationDetailsArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.IISVirtualApplicationDetailsArgs>();
        @configure(@list);
        @selfRef.VirtualApplications = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithVirtualApplications(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Migrate.Inputs.IISVirtualApplicationDetailsArgs>> @create)
    {
        @selfRef.VirtualApplications = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithWebServerId(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.String webServerId)
    {
        @selfRef.WebServerId = webServerId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs WithWebServerName(this global::Pulumi.AzureNative.Migrate.Inputs.IISWebApplicationArgs @selfRef, global::System.String webServerName)
    {
        @selfRef.WebServerName = webServerName;
        return @selfRef;
    }

}
