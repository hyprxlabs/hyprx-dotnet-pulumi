// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.IoTOperationsMQ.Inputs;

namespace Pulumi.AzureNative.IoTOperationsMQ;

public static partial class VolumeClaimDataSourceArgsExtensions
{
    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimDataSourceArgs WithApiGroup(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimDataSourceArgs @selfRef, global::System.String apiGroup)
    {
        @selfRef.ApiGroup = apiGroup;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimDataSourceArgs WithKind(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimDataSourceArgs @selfRef, global::System.String kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimDataSourceArgs WithName(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimDataSourceArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

}
