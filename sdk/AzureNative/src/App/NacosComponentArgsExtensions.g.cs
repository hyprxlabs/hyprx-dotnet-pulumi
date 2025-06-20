// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.App.Inputs;

namespace Pulumi.AzureNative.App;

public static partial class NacosComponentArgsExtensions
{
    public static global::Pulumi.AzureNative.App.Inputs.NacosComponentArgs WithComponentType(this global::Pulumi.AzureNative.App.Inputs.NacosComponentArgs @selfRef, global::System.String componentType)
    {
        @selfRef.ComponentType = componentType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.NacosComponentArgs WithConfigurations(this global::Pulumi.AzureNative.App.Inputs.NacosComponentArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.JavaComponentConfigurationPropertyArgs> configurations)
    {
        @selfRef.Configurations = configurations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.NacosComponentArgs WithConfigurations(this global::Pulumi.AzureNative.App.Inputs.NacosComponentArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.JavaComponentConfigurationPropertyArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.JavaComponentConfigurationPropertyArgs>();
        @configure(@list);
        @selfRef.Configurations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.NacosComponentArgs WithConfigurations(this global::Pulumi.AzureNative.App.Inputs.NacosComponentArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.App.Inputs.JavaComponentConfigurationPropertyArgs>> @create)
    {
        @selfRef.Configurations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.NacosComponentArgs WithScale(this global::Pulumi.AzureNative.App.Inputs.NacosComponentArgs @selfRef, global::Pulumi.AzureNative.App.Inputs.JavaComponentPropertiesScaleArgs scale)
    {
        @selfRef.Scale = scale;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.NacosComponentArgs WithScale(this global::Pulumi.AzureNative.App.Inputs.NacosComponentArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.App.Inputs.JavaComponentPropertiesScaleArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.App.Inputs.JavaComponentPropertiesScaleArgs();
        @configure(@item);
        @selfRef.Scale = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.NacosComponentArgs WithServiceBinds(this global::Pulumi.AzureNative.App.Inputs.NacosComponentArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.JavaComponentServiceBindArgs> serviceBinds)
    {
        @selfRef.ServiceBinds = serviceBinds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.NacosComponentArgs WithServiceBinds(this global::Pulumi.AzureNative.App.Inputs.NacosComponentArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.JavaComponentServiceBindArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.JavaComponentServiceBindArgs>();
        @configure(@list);
        @selfRef.ServiceBinds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.NacosComponentArgs WithServiceBinds(this global::Pulumi.AzureNative.App.Inputs.NacosComponentArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.App.Inputs.JavaComponentServiceBindArgs>> @create)
    {
        @selfRef.ServiceBinds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
