// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Security.Inputs;

namespace Pulumi.AzureNative.Security;

public static partial class JitNetworkAccessPortRuleArgsExtensions
{
    public static global::Pulumi.AzureNative.Security.Inputs.JitNetworkAccessPortRuleArgs WithAllowedSourceAddressPrefix(this global::Pulumi.AzureNative.Security.Inputs.JitNetworkAccessPortRuleArgs @selfRef, global::System.String allowedSourceAddressPrefix)
    {
        @selfRef.AllowedSourceAddressPrefix = allowedSourceAddressPrefix;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.JitNetworkAccessPortRuleArgs WithAllowedSourceAddressPrefixes(this global::Pulumi.AzureNative.Security.Inputs.JitNetworkAccessPortRuleArgs @selfRef, global::System.Collections.Generic.List<global::System.String> allowedSourceAddressPrefixes)
    {
        @selfRef.AllowedSourceAddressPrefixes = allowedSourceAddressPrefixes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.JitNetworkAccessPortRuleArgs WithAllowedSourceAddressPrefixes(this global::Pulumi.AzureNative.Security.Inputs.JitNetworkAccessPortRuleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AllowedSourceAddressPrefixes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.JitNetworkAccessPortRuleArgs WithAllowedSourceAddressPrefixes(this global::Pulumi.AzureNative.Security.Inputs.JitNetworkAccessPortRuleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AllowedSourceAddressPrefixes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.JitNetworkAccessPortRuleArgs WithMaxRequestAccessDuration(this global::Pulumi.AzureNative.Security.Inputs.JitNetworkAccessPortRuleArgs @selfRef, global::System.String maxRequestAccessDuration)
    {
        @selfRef.MaxRequestAccessDuration = maxRequestAccessDuration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.JitNetworkAccessPortRuleArgs WithNumber(this global::Pulumi.AzureNative.Security.Inputs.JitNetworkAccessPortRuleArgs @selfRef, global::System.Int32 number)
    {
        @selfRef.Number = number;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.JitNetworkAccessPortRuleArgs WithProtocol(this global::Pulumi.AzureNative.Security.Inputs.JitNetworkAccessPortRuleArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Security.Protocol> protocol)
    {
        @selfRef.Protocol = protocol;
        return @selfRef;
    }

}
