// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Redshift.Inputs;

namespace Pulumi.AwsNative.Redshift;

public static partial class ClusterEndpointArgsExtensions
{
    public static global::Pulumi.AwsNative.Redshift.Inputs.ClusterEndpointArgs WithAddress(this global::Pulumi.AwsNative.Redshift.Inputs.ClusterEndpointArgs @selfRef, global::System.String address)
    {
        @selfRef.Address = address;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Redshift.Inputs.ClusterEndpointArgs WithPort(this global::Pulumi.AwsNative.Redshift.Inputs.ClusterEndpointArgs @selfRef, global::System.String port)
    {
        @selfRef.Port = port;
        return @selfRef;
    }

}
