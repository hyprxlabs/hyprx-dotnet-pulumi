// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Cdn.Inputs;

namespace Pulumi.AzureNative.Cdn;

public static partial class UrlSigningActionArgsExtensions
{
    public static global::Pulumi.AzureNative.Cdn.Inputs.UrlSigningActionArgs WithName(this global::Pulumi.AzureNative.Cdn.Inputs.UrlSigningActionArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.UrlSigningActionArgs WithParameters(this global::Pulumi.AzureNative.Cdn.Inputs.UrlSigningActionArgs @selfRef, global::Pulumi.AzureNative.Cdn.Inputs.UrlSigningActionParametersArgs parameters)
    {
        @selfRef.Parameters = parameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.UrlSigningActionArgs WithParameters(this global::Pulumi.AzureNative.Cdn.Inputs.UrlSigningActionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Cdn.Inputs.UrlSigningActionParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Cdn.Inputs.UrlSigningActionParametersArgs();
        @configure(@item);
        @selfRef.Parameters = @item;
        return @selfRef;
    }

}
