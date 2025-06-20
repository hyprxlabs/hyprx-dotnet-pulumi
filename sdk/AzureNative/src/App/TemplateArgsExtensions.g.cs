// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.App.Inputs;

namespace Pulumi.AzureNative.App;

public static partial class TemplateArgsExtensions
{
    public static global::Pulumi.AzureNative.App.Inputs.TemplateArgs WithContainers(this global::Pulumi.AzureNative.App.Inputs.TemplateArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.ContainerArgs> containers)
    {
        @selfRef.Containers = containers;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.TemplateArgs WithContainers(this global::Pulumi.AzureNative.App.Inputs.TemplateArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.ContainerArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.ContainerArgs>();
        @configure(@list);
        @selfRef.Containers = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.TemplateArgs WithContainers(this global::Pulumi.AzureNative.App.Inputs.TemplateArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.App.Inputs.ContainerArgs>> @create)
    {
        @selfRef.Containers = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.TemplateArgs WithInitContainers(this global::Pulumi.AzureNative.App.Inputs.TemplateArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.InitContainerArgs> initContainers)
    {
        @selfRef.InitContainers = initContainers;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.TemplateArgs WithInitContainers(this global::Pulumi.AzureNative.App.Inputs.TemplateArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.InitContainerArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.InitContainerArgs>();
        @configure(@list);
        @selfRef.InitContainers = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.TemplateArgs WithInitContainers(this global::Pulumi.AzureNative.App.Inputs.TemplateArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.App.Inputs.InitContainerArgs>> @create)
    {
        @selfRef.InitContainers = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.TemplateArgs WithRevisionSuffix(this global::Pulumi.AzureNative.App.Inputs.TemplateArgs @selfRef, global::System.String revisionSuffix)
    {
        @selfRef.RevisionSuffix = revisionSuffix;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.TemplateArgs WithScale(this global::Pulumi.AzureNative.App.Inputs.TemplateArgs @selfRef, global::Pulumi.AzureNative.App.Inputs.ScaleArgs scale)
    {
        @selfRef.Scale = scale;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.TemplateArgs WithScale(this global::Pulumi.AzureNative.App.Inputs.TemplateArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.App.Inputs.ScaleArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.App.Inputs.ScaleArgs();
        @configure(@item);
        @selfRef.Scale = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.TemplateArgs WithServiceBinds(this global::Pulumi.AzureNative.App.Inputs.TemplateArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.ServiceBindArgs> serviceBinds)
    {
        @selfRef.ServiceBinds = serviceBinds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.TemplateArgs WithServiceBinds(this global::Pulumi.AzureNative.App.Inputs.TemplateArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.ServiceBindArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.ServiceBindArgs>();
        @configure(@list);
        @selfRef.ServiceBinds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.TemplateArgs WithServiceBinds(this global::Pulumi.AzureNative.App.Inputs.TemplateArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.App.Inputs.ServiceBindArgs>> @create)
    {
        @selfRef.ServiceBinds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.TemplateArgs WithTerminationGracePeriodSeconds(this global::Pulumi.AzureNative.App.Inputs.TemplateArgs @selfRef, global::System.Double terminationGracePeriodSeconds)
    {
        @selfRef.TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.TemplateArgs WithVolumes(this global::Pulumi.AzureNative.App.Inputs.TemplateArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.VolumeArgs> volumes)
    {
        @selfRef.Volumes = volumes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.TemplateArgs WithVolumes(this global::Pulumi.AzureNative.App.Inputs.TemplateArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.VolumeArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.VolumeArgs>();
        @configure(@list);
        @selfRef.Volumes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.TemplateArgs WithVolumes(this global::Pulumi.AzureNative.App.Inputs.TemplateArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.App.Inputs.VolumeArgs>> @create)
    {
        @selfRef.Volumes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
