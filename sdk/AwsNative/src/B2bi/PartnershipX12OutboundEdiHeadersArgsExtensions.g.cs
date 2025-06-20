// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.B2bi.Inputs;

namespace Pulumi.AwsNative.B2bi;

public static partial class PartnershipX12OutboundEdiHeadersArgsExtensions
{
    public static global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12OutboundEdiHeadersArgs WithDelimiters(this global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12OutboundEdiHeadersArgs @selfRef, global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12DelimitersArgs delimiters)
    {
        @selfRef.Delimiters = delimiters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12OutboundEdiHeadersArgs WithDelimiters(this global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12OutboundEdiHeadersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12DelimitersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12DelimitersArgs();
        @configure(@item);
        @selfRef.Delimiters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12OutboundEdiHeadersArgs WithFunctionalGroupHeaders(this global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12OutboundEdiHeadersArgs @selfRef, global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12FunctionalGroupHeadersArgs functionalGroupHeaders)
    {
        @selfRef.FunctionalGroupHeaders = functionalGroupHeaders;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12OutboundEdiHeadersArgs WithFunctionalGroupHeaders(this global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12OutboundEdiHeadersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12FunctionalGroupHeadersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12FunctionalGroupHeadersArgs();
        @configure(@item);
        @selfRef.FunctionalGroupHeaders = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12OutboundEdiHeadersArgs WithInterchangeControlHeaders(this global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12OutboundEdiHeadersArgs @selfRef, global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12InterchangeControlHeadersArgs interchangeControlHeaders)
    {
        @selfRef.InterchangeControlHeaders = interchangeControlHeaders;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12OutboundEdiHeadersArgs WithInterchangeControlHeaders(this global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12OutboundEdiHeadersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12InterchangeControlHeadersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12InterchangeControlHeadersArgs();
        @configure(@item);
        @selfRef.InterchangeControlHeaders = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12OutboundEdiHeadersArgs WithValidateEdi(this global::Pulumi.AwsNative.B2bi.Inputs.PartnershipX12OutboundEdiHeadersArgs @selfRef, bool validateEdi = true)
    {
        @selfRef.ValidateEdi = validateEdi;
        return @selfRef;
    }

}
