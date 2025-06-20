// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class ExecutionActivityArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs WithDependsOn(this global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.ActivityDependencyArgs> dependsOn)
    {
        @selfRef.DependsOn = dependsOn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs WithDependsOn(this global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.ActivityDependencyArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.ActivityDependencyArgs>();
        @configure(@list);
        @selfRef.DependsOn = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs WithDependsOn(this global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DataFactory.Inputs.ActivityDependencyArgs>> @create)
    {
        @selfRef.DependsOn = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs WithDescription(this global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs WithLinkedServiceName(this global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs linkedServiceName)
    {
        @selfRef.LinkedServiceName = linkedServiceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs WithLinkedServiceName(this global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs();
        @configure(@item);
        @selfRef.LinkedServiceName = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs WithName(this global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs WithOnInactiveMarkAs(this global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DataFactory.ActivityOnInactiveMarkAs> onInactiveMarkAs)
    {
        @selfRef.OnInactiveMarkAs = onInactiveMarkAs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs WithPolicy(this global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.ActivityPolicyArgs policy)
    {
        @selfRef.Policy = policy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs WithPolicy(this global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.ActivityPolicyArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.ActivityPolicyArgs();
        @configure(@item);
        @selfRef.Policy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs WithState(this global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DataFactory.ActivityState> state)
    {
        @selfRef.State = state;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs WithUserProperties(this global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.UserPropertyArgs> userProperties)
    {
        @selfRef.UserProperties = userProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs WithUserProperties(this global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.UserPropertyArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.UserPropertyArgs>();
        @configure(@list);
        @selfRef.UserProperties = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs WithUserProperties(this global::Pulumi.AzureNative.DataFactory.Inputs.ExecutionActivityArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DataFactory.Inputs.UserPropertyArgs>> @create)
    {
        @selfRef.UserProperties = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
