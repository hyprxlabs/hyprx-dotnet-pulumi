// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.DataZone.Inputs;

namespace Pulumi.AwsNative.DataZone;

public static partial class ConnectionAwsLocationArgsExtensions
{
    public static global::Pulumi.AwsNative.DataZone.Inputs.ConnectionAwsLocationArgs WithAccessRole(this global::Pulumi.AwsNative.DataZone.Inputs.ConnectionAwsLocationArgs @selfRef, global::System.String accessRole)
    {
        @selfRef.AccessRole = accessRole;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataZone.Inputs.ConnectionAwsLocationArgs WithAwsAccountId(this global::Pulumi.AwsNative.DataZone.Inputs.ConnectionAwsLocationArgs @selfRef, global::System.String awsAccountId)
    {
        @selfRef.AwsAccountId = awsAccountId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataZone.Inputs.ConnectionAwsLocationArgs WithAwsRegion(this global::Pulumi.AwsNative.DataZone.Inputs.ConnectionAwsLocationArgs @selfRef, global::System.String awsRegion)
    {
        @selfRef.AwsRegion = awsRegion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataZone.Inputs.ConnectionAwsLocationArgs WithIamConnectionId(this global::Pulumi.AwsNative.DataZone.Inputs.ConnectionAwsLocationArgs @selfRef, global::System.String iamConnectionId)
    {
        @selfRef.IamConnectionId = iamConnectionId;
        return @selfRef;
    }

}
