// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.GameLift.Inputs;

namespace Pulumi.AwsNative.GameLift;

public static partial class FleetCertificateConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.GameLift.Inputs.FleetCertificateConfigurationArgs WithCertificateType(this global::Pulumi.AwsNative.GameLift.Inputs.FleetCertificateConfigurationArgs @selfRef, global::Pulumi.AwsNative.GameLift.FleetCertificateConfigurationCertificateType certificateType)
    {
        @selfRef.CertificateType = certificateType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GameLift.Inputs.FleetCertificateConfigurationArgs WithCertificateType(this global::Pulumi.AwsNative.GameLift.Inputs.FleetCertificateConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.GameLift.FleetCertificateConfigurationCertificateType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.GameLift.FleetCertificateConfigurationCertificateType>();
        @configure(@item);
        @selfRef.CertificateType = @item;
        return @selfRef;
    }

}
