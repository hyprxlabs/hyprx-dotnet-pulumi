// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ecs.Inputs;

namespace Pulumi.AwsNative.Ecs;

public static partial class TaskDefinitionHostEntryArgsExtensions
{
    public static global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionHostEntryArgs WithHostname(this global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionHostEntryArgs @selfRef, global::System.String hostname)
    {
        @selfRef.Hostname = hostname;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionHostEntryArgs WithIpAddress(this global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionHostEntryArgs @selfRef, global::System.String ipAddress)
    {
        @selfRef.IpAddress = ipAddress;
        return @selfRef;
    }

}
