// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class FailActivityArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs WithDependsOn(this global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.ActivityDependencyArgs> dependsOn)
    {
        @selfRef.DependsOn = dependsOn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs WithDependsOn(this global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.ActivityDependencyArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.ActivityDependencyArgs>();
        @configure(@list);
        @selfRef.DependsOn = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs WithDependsOn(this global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DataFactory.Inputs.ActivityDependencyArgs>> @create)
    {
        @selfRef.DependsOn = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs WithDescription(this global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs WithErrorCode(this global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs @selfRef, global::System.Object errorCode)
    {
        @selfRef.ErrorCode = errorCode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs WithErrorCode(this global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.ErrorCode = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs WithMessage(this global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs @selfRef, global::System.Object message)
    {
        @selfRef.Message = message;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs WithMessage(this global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Message = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs WithName(this global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs WithOnInactiveMarkAs(this global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DataFactory.ActivityOnInactiveMarkAs> onInactiveMarkAs)
    {
        @selfRef.OnInactiveMarkAs = onInactiveMarkAs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs WithState(this global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DataFactory.ActivityState> state)
    {
        @selfRef.State = state;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs WithUserProperties(this global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.UserPropertyArgs> userProperties)
    {
        @selfRef.UserProperties = userProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs WithUserProperties(this global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.UserPropertyArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.UserPropertyArgs>();
        @configure(@list);
        @selfRef.UserProperties = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs WithUserProperties(this global::Pulumi.AzureNative.DataFactory.Inputs.FailActivityArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DataFactory.Inputs.UserPropertyArgs>> @create)
    {
        @selfRef.UserProperties = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
