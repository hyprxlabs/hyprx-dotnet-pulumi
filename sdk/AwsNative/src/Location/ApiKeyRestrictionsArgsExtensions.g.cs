// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Location.Inputs;

namespace Pulumi.AwsNative.Location;

public static partial class ApiKeyRestrictionsArgsExtensions
{
    public static global::Pulumi.AwsNative.Location.Inputs.ApiKeyRestrictionsArgs WithAllowActions(this global::Pulumi.AwsNative.Location.Inputs.ApiKeyRestrictionsArgs @selfRef, global::System.Collections.Generic.List<global::System.String> allowActions)
    {
        @selfRef.AllowActions = allowActions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Location.Inputs.ApiKeyRestrictionsArgs WithAllowActions(this global::Pulumi.AwsNative.Location.Inputs.ApiKeyRestrictionsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AllowActions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Location.Inputs.ApiKeyRestrictionsArgs WithAllowActions(this global::Pulumi.AwsNative.Location.Inputs.ApiKeyRestrictionsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AllowActions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Location.Inputs.ApiKeyRestrictionsArgs WithAllowReferers(this global::Pulumi.AwsNative.Location.Inputs.ApiKeyRestrictionsArgs @selfRef, global::System.Collections.Generic.List<global::System.String> allowReferers)
    {
        @selfRef.AllowReferers = allowReferers;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Location.Inputs.ApiKeyRestrictionsArgs WithAllowReferers(this global::Pulumi.AwsNative.Location.Inputs.ApiKeyRestrictionsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AllowReferers = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Location.Inputs.ApiKeyRestrictionsArgs WithAllowReferers(this global::Pulumi.AwsNative.Location.Inputs.ApiKeyRestrictionsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AllowReferers = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Location.Inputs.ApiKeyRestrictionsArgs WithAllowResources(this global::Pulumi.AwsNative.Location.Inputs.ApiKeyRestrictionsArgs @selfRef, global::System.Collections.Generic.List<global::System.String> allowResources)
    {
        @selfRef.AllowResources = allowResources;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Location.Inputs.ApiKeyRestrictionsArgs WithAllowResources(this global::Pulumi.AwsNative.Location.Inputs.ApiKeyRestrictionsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AllowResources = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Location.Inputs.ApiKeyRestrictionsArgs WithAllowResources(this global::Pulumi.AwsNative.Location.Inputs.ApiKeyRestrictionsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AllowResources = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
