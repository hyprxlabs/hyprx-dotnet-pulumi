// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Dns.Inputs;

namespace Pulumi.AzureNative.Dns;

public static partial class MxRecordArgsExtensions
{
    public static global::Pulumi.AzureNative.Dns.Inputs.MxRecordArgs WithExchange(this global::Pulumi.AzureNative.Dns.Inputs.MxRecordArgs @selfRef, global::System.String exchange)
    {
        @selfRef.Exchange = exchange;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Dns.Inputs.MxRecordArgs WithPreference(this global::Pulumi.AzureNative.Dns.Inputs.MxRecordArgs @selfRef, global::System.Int32 preference)
    {
        @selfRef.Preference = preference;
        return @selfRef;
    }

}
