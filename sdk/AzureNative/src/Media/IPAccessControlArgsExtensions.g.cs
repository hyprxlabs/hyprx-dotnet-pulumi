// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Media.Inputs;

namespace Pulumi.AzureNative.Media;

public static partial class IPAccessControlArgsExtensions
{
    public static global::Pulumi.AzureNative.Media.Inputs.IPAccessControlArgs WithAllow(this global::Pulumi.AzureNative.Media.Inputs.IPAccessControlArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Media.Inputs.IPRangeArgs> allow)
    {
        @selfRef.Allow = allow;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.IPAccessControlArgs WithAllow(this global::Pulumi.AzureNative.Media.Inputs.IPAccessControlArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Media.Inputs.IPRangeArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Media.Inputs.IPRangeArgs>();
        @configure(@list);
        @selfRef.Allow = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.IPAccessControlArgs WithAllow(this global::Pulumi.AzureNative.Media.Inputs.IPAccessControlArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Media.Inputs.IPRangeArgs>> @create)
    {
        @selfRef.Allow = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
