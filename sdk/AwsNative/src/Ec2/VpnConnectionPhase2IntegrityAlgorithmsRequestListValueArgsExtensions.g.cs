// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ec2.Inputs;

namespace Pulumi.AwsNative.Ec2;

public static partial class VpnConnectionPhase2IntegrityAlgorithmsRequestListValueArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.Inputs.VpnConnectionPhase2IntegrityAlgorithmsRequestListValueArgs WithValue(this global::Pulumi.AwsNative.Ec2.Inputs.VpnConnectionPhase2IntegrityAlgorithmsRequestListValueArgs @selfRef, global::Pulumi.AwsNative.Ec2.VpnConnectionPhase2IntegrityAlgorithmsRequestListValueValue value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.VpnConnectionPhase2IntegrityAlgorithmsRequestListValueArgs WithValue(this global::Pulumi.AwsNative.Ec2.Inputs.VpnConnectionPhase2IntegrityAlgorithmsRequestListValueArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.VpnConnectionPhase2IntegrityAlgorithmsRequestListValueValue> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Ec2.VpnConnectionPhase2IntegrityAlgorithmsRequestListValueValue>();
        @configure(@item);
        @selfRef.Value = @item;
        return @selfRef;
    }

}
