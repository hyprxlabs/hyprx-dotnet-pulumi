// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Events.Inputs;

namespace Pulumi.AwsNative.Events;

public static partial class EndpointReplicationConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.Events.Inputs.EndpointReplicationConfigArgs WithState(this global::Pulumi.AwsNative.Events.Inputs.EndpointReplicationConfigArgs @selfRef, global::Pulumi.AwsNative.Events.EndpointReplicationState state)
    {
        @selfRef.State = state;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.EndpointReplicationConfigArgs WithState(this global::Pulumi.AwsNative.Events.Inputs.EndpointReplicationConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Events.EndpointReplicationState> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Events.EndpointReplicationState>();
        @configure(@item);
        @selfRef.State = @item;
        return @selfRef;
    }

}
