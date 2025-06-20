// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Logic.Inputs;

namespace Pulumi.AzureNative.Logic;

public static partial class EdifactOneWayAgreementArgsExtensions
{
    public static global::Pulumi.AzureNative.Logic.Inputs.EdifactOneWayAgreementArgs WithProtocolSettings(this global::Pulumi.AzureNative.Logic.Inputs.EdifactOneWayAgreementArgs @selfRef, global::Pulumi.AzureNative.Logic.Inputs.EdifactProtocolSettingsArgs protocolSettings)
    {
        @selfRef.ProtocolSettings = protocolSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.EdifactOneWayAgreementArgs WithProtocolSettings(this global::Pulumi.AzureNative.Logic.Inputs.EdifactOneWayAgreementArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Logic.Inputs.EdifactProtocolSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Logic.Inputs.EdifactProtocolSettingsArgs();
        @configure(@item);
        @selfRef.ProtocolSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.EdifactOneWayAgreementArgs WithReceiverBusinessIdentity(this global::Pulumi.AzureNative.Logic.Inputs.EdifactOneWayAgreementArgs @selfRef, global::Pulumi.AzureNative.Logic.Inputs.BusinessIdentityArgs receiverBusinessIdentity)
    {
        @selfRef.ReceiverBusinessIdentity = receiverBusinessIdentity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.EdifactOneWayAgreementArgs WithReceiverBusinessIdentity(this global::Pulumi.AzureNative.Logic.Inputs.EdifactOneWayAgreementArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Logic.Inputs.BusinessIdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Logic.Inputs.BusinessIdentityArgs();
        @configure(@item);
        @selfRef.ReceiverBusinessIdentity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.EdifactOneWayAgreementArgs WithSenderBusinessIdentity(this global::Pulumi.AzureNative.Logic.Inputs.EdifactOneWayAgreementArgs @selfRef, global::Pulumi.AzureNative.Logic.Inputs.BusinessIdentityArgs senderBusinessIdentity)
    {
        @selfRef.SenderBusinessIdentity = senderBusinessIdentity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.EdifactOneWayAgreementArgs WithSenderBusinessIdentity(this global::Pulumi.AzureNative.Logic.Inputs.EdifactOneWayAgreementArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Logic.Inputs.BusinessIdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Logic.Inputs.BusinessIdentityArgs();
        @configure(@item);
        @selfRef.SenderBusinessIdentity = @item;
        return @selfRef;
    }

}
