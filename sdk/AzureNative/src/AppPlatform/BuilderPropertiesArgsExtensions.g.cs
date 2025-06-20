// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AppPlatform.Inputs;

namespace Pulumi.AzureNative.AppPlatform;

public static partial class BuilderPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AppPlatform.Inputs.BuilderPropertiesArgs WithBuildpackGroups(this global::Pulumi.AzureNative.AppPlatform.Inputs.BuilderPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AppPlatform.Inputs.BuildpacksGroupPropertiesArgs> buildpackGroups)
    {
        @selfRef.BuildpackGroups = buildpackGroups;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.BuilderPropertiesArgs WithBuildpackGroups(this global::Pulumi.AzureNative.AppPlatform.Inputs.BuilderPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AppPlatform.Inputs.BuildpacksGroupPropertiesArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AppPlatform.Inputs.BuildpacksGroupPropertiesArgs>();
        @configure(@list);
        @selfRef.BuildpackGroups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.BuilderPropertiesArgs WithBuildpackGroups(this global::Pulumi.AzureNative.AppPlatform.Inputs.BuilderPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AppPlatform.Inputs.BuildpacksGroupPropertiesArgs>> @create)
    {
        @selfRef.BuildpackGroups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.BuilderPropertiesArgs WithStack(this global::Pulumi.AzureNative.AppPlatform.Inputs.BuilderPropertiesArgs @selfRef, global::Pulumi.AzureNative.AppPlatform.Inputs.StackPropertiesArgs stack)
    {
        @selfRef.Stack = stack;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.BuilderPropertiesArgs WithStack(this global::Pulumi.AzureNative.AppPlatform.Inputs.BuilderPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AppPlatform.Inputs.StackPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AppPlatform.Inputs.StackPropertiesArgs();
        @configure(@item);
        @selfRef.Stack = @item;
        return @selfRef;
    }

}
