// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.NetworkFirewall.Inputs;

namespace Pulumi.AwsNative.NetworkFirewall;

public static partial class TlsInspectionConfigurationAddressArgsExtensions
{
    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.TlsInspectionConfigurationAddressArgs WithAddressDefinition(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.TlsInspectionConfigurationAddressArgs @selfRef, global::System.String addressDefinition)
    {
        @selfRef.AddressDefinition = addressDefinition;
        return @selfRef;
    }

}
