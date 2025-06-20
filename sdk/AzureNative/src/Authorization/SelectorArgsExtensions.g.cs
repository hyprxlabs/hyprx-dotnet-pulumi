// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Authorization.Inputs;

namespace Pulumi.AzureNative.Authorization;

public static partial class SelectorArgsExtensions
{
    public static global::Pulumi.AzureNative.Authorization.Inputs.SelectorArgs WithIn(this global::Pulumi.AzureNative.Authorization.Inputs.SelectorArgs @selfRef, global::System.Collections.Generic.List<global::System.String> @in)
    {
        @selfRef.In = @in;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Authorization.Inputs.SelectorArgs WithIn(this global::Pulumi.AzureNative.Authorization.Inputs.SelectorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.In = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Authorization.Inputs.SelectorArgs WithIn(this global::Pulumi.AzureNative.Authorization.Inputs.SelectorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.In = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Authorization.Inputs.SelectorArgs WithKind(this global::Pulumi.AzureNative.Authorization.Inputs.SelectorArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Authorization.SelectorKind> kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Authorization.Inputs.SelectorArgs WithNotIn(this global::Pulumi.AzureNative.Authorization.Inputs.SelectorArgs @selfRef, global::System.Collections.Generic.List<global::System.String> notIn)
    {
        @selfRef.NotIn = notIn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Authorization.Inputs.SelectorArgs WithNotIn(this global::Pulumi.AzureNative.Authorization.Inputs.SelectorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.NotIn = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Authorization.Inputs.SelectorArgs WithNotIn(this global::Pulumi.AzureNative.Authorization.Inputs.SelectorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.NotIn = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
