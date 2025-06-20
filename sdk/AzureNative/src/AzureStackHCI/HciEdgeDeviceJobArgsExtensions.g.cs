// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AzureStackHCI;

public static partial class HciEdgeDeviceJobArgsExtensions
{
    public static global::Pulumi.AzureNative.AzureStackHCI.HciEdgeDeviceJobArgs WithEdgeDeviceName(this global::Pulumi.AzureNative.AzureStackHCI.HciEdgeDeviceJobArgs @selfRef, global::System.String edgeDeviceName)
    {
        @selfRef.EdgeDeviceName = edgeDeviceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.HciEdgeDeviceJobArgs WithJobsName(this global::Pulumi.AzureNative.AzureStackHCI.HciEdgeDeviceJobArgs @selfRef, global::System.String jobsName)
    {
        @selfRef.JobsName = jobsName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.HciEdgeDeviceJobArgs WithKind(this global::Pulumi.AzureNative.AzureStackHCI.HciEdgeDeviceJobArgs @selfRef, global::System.String kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.HciEdgeDeviceJobArgs WithProperties(this global::Pulumi.AzureNative.AzureStackHCI.HciEdgeDeviceJobArgs @selfRef, global::Pulumi.Union<global::Pulumi.AzureNative.AzureStackHCI.Inputs.HciCollectLogJobPropertiesArgs, global::Pulumi.AzureNative.AzureStackHCI.Inputs.HciRemoteSupportJobPropertiesArgs> properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.HciEdgeDeviceJobArgs WithResourceUri(this global::Pulumi.AzureNative.AzureStackHCI.HciEdgeDeviceJobArgs @selfRef, global::System.String resourceUri)
    {
        @selfRef.ResourceUri = resourceUri;
        return @selfRef;
    }

}
