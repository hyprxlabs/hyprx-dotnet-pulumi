// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MobileNetwork.Inputs;

namespace Pulumi.AzureNative.MobileNetwork;

public static partial class SignalingConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.MobileNetwork.Inputs.SignalingConfigurationArgs WithNasEncryption(this global::Pulumi.AzureNative.MobileNetwork.Inputs.SignalingConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MobileNetwork.NasEncryptionType>> nasEncryption)
    {
        @selfRef.NasEncryption = nasEncryption;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.Inputs.SignalingConfigurationArgs WithNasEncryption(this global::Pulumi.AzureNative.MobileNetwork.Inputs.SignalingConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MobileNetwork.NasEncryptionType>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MobileNetwork.NasEncryptionType>>();
        @configure(@list);
        @selfRef.NasEncryption = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.Inputs.SignalingConfigurationArgs WithNasEncryption(this global::Pulumi.AzureNative.MobileNetwork.Inputs.SignalingConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MobileNetwork.NasEncryptionType>>> @create)
    {
        @selfRef.NasEncryption = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.Inputs.SignalingConfigurationArgs WithNasReroute(this global::Pulumi.AzureNative.MobileNetwork.Inputs.SignalingConfigurationArgs @selfRef, global::Pulumi.AzureNative.MobileNetwork.Inputs.NASRerouteConfigurationArgs nasReroute)
    {
        @selfRef.NasReroute = nasReroute;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.Inputs.SignalingConfigurationArgs WithNasReroute(this global::Pulumi.AzureNative.MobileNetwork.Inputs.SignalingConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MobileNetwork.Inputs.NASRerouteConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MobileNetwork.Inputs.NASRerouteConfigurationArgs();
        @configure(@item);
        @selfRef.NasReroute = @item;
        return @selfRef;
    }

}
