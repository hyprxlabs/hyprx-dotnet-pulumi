// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ConfidentialLedger.Inputs;

namespace Pulumi.AzureNative.ConfidentialLedger;

public static partial class CertificateTagsArgsExtensions
{
    public static global::Pulumi.AzureNative.ConfidentialLedger.Inputs.CertificateTagsArgs WithTags(this global::Pulumi.AzureNative.ConfidentialLedger.Inputs.CertificateTagsArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConfidentialLedger.Inputs.CertificateTagsArgs WithTags(this global::Pulumi.AzureNative.ConfidentialLedger.Inputs.CertificateTagsArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConfidentialLedger.Inputs.CertificateTagsArgs WithTags(this global::Pulumi.AzureNative.ConfidentialLedger.Inputs.CertificateTagsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
