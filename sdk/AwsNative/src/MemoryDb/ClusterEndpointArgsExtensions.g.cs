// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.MemoryDb.Inputs;

namespace Pulumi.AwsNative.MemoryDb;

public static partial class ClusterEndpointArgsExtensions
{
    public static global::Pulumi.AwsNative.MemoryDb.Inputs.ClusterEndpointArgs WithAddress(this global::Pulumi.AwsNative.MemoryDb.Inputs.ClusterEndpointArgs @selfRef, global::System.String address)
    {
        @selfRef.Address = address;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MemoryDb.Inputs.ClusterEndpointArgs WithPort(this global::Pulumi.AwsNative.MemoryDb.Inputs.ClusterEndpointArgs @selfRef, global::System.Int32 port)
    {
        @selfRef.Port = port;
        return @selfRef;
    }

}
