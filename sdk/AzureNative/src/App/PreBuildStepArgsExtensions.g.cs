// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.App.Inputs;

namespace Pulumi.AzureNative.App;

public static partial class PreBuildStepArgsExtensions
{
    public static global::Pulumi.AzureNative.App.Inputs.PreBuildStepArgs WithDescription(this global::Pulumi.AzureNative.App.Inputs.PreBuildStepArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.PreBuildStepArgs WithHttpGet(this global::Pulumi.AzureNative.App.Inputs.PreBuildStepArgs @selfRef, global::Pulumi.AzureNative.App.Inputs.HttpGetArgs httpGet)
    {
        @selfRef.HttpGet = httpGet;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.PreBuildStepArgs WithHttpGet(this global::Pulumi.AzureNative.App.Inputs.PreBuildStepArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.App.Inputs.HttpGetArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.App.Inputs.HttpGetArgs();
        @configure(@item);
        @selfRef.HttpGet = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.PreBuildStepArgs WithScripts(this global::Pulumi.AzureNative.App.Inputs.PreBuildStepArgs @selfRef, global::System.Collections.Generic.List<global::System.String> scripts)
    {
        @selfRef.Scripts = scripts;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.PreBuildStepArgs WithScripts(this global::Pulumi.AzureNative.App.Inputs.PreBuildStepArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Scripts = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.PreBuildStepArgs WithScripts(this global::Pulumi.AzureNative.App.Inputs.PreBuildStepArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Scripts = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
