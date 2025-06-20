// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.FrontDoor.Inputs;

namespace Pulumi.AzureNative.FrontDoor;

public static partial class BackendPoolArgsExtensions
{
    public static global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs WithBackends(this global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.BackendArgs> backends)
    {
        @selfRef.Backends = backends;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs WithBackends(this global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.BackendArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.BackendArgs>();
        @configure(@list);
        @selfRef.Backends = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs WithBackends(this global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.FrontDoor.Inputs.BackendArgs>> @create)
    {
        @selfRef.Backends = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs WithHealthProbeSettings(this global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs @selfRef, global::Pulumi.AzureNative.FrontDoor.Inputs.SubResourceArgs healthProbeSettings)
    {
        @selfRef.HealthProbeSettings = healthProbeSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs WithHealthProbeSettings(this global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.FrontDoor.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.FrontDoor.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.HealthProbeSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs WithId(this global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs WithLoadBalancingSettings(this global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs @selfRef, global::Pulumi.AzureNative.FrontDoor.Inputs.SubResourceArgs loadBalancingSettings)
    {
        @selfRef.LoadBalancingSettings = loadBalancingSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs WithLoadBalancingSettings(this global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.FrontDoor.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.FrontDoor.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.LoadBalancingSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs WithName(this global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

}
