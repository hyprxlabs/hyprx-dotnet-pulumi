// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.B2bi.Inputs;

namespace Pulumi.AwsNative.B2bi;

public static partial class PartnershipOutboundEdiOptionsPropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.B2bi.Inputs.PartnershipOutboundEdiOptionsPropertiesArgs WithX12(this global::Pulumi.AwsNative.B2bi.Inputs.PartnershipOutboundEdiOptionsPropertiesArgs @selfRef, global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12EnvelopeArgs x12)
    {
        @selfRef.X12 = x12;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.B2bi.Inputs.PartnershipOutboundEdiOptionsPropertiesArgs WithX12(this global::Pulumi.AwsNative.B2bi.Inputs.PartnershipOutboundEdiOptionsPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12EnvelopeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12EnvelopeArgs();
        @configure(@item);
        @selfRef.X12 = @item;
        return @selfRef;
    }

}
