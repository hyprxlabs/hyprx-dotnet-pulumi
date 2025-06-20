// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.LabServices.Inputs;

namespace Pulumi.AzureNative.LabServices;

public static partial class AutoShutdownProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.LabServices.Inputs.AutoShutdownProfileArgs WithDisconnectDelay(this global::Pulumi.AzureNative.LabServices.Inputs.AutoShutdownProfileArgs @selfRef, global::System.String disconnectDelay)
    {
        @selfRef.DisconnectDelay = disconnectDelay;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.LabServices.Inputs.AutoShutdownProfileArgs WithIdleDelay(this global::Pulumi.AzureNative.LabServices.Inputs.AutoShutdownProfileArgs @selfRef, global::System.String idleDelay)
    {
        @selfRef.IdleDelay = idleDelay;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.LabServices.Inputs.AutoShutdownProfileArgs WithNoConnectDelay(this global::Pulumi.AzureNative.LabServices.Inputs.AutoShutdownProfileArgs @selfRef, global::System.String noConnectDelay)
    {
        @selfRef.NoConnectDelay = noConnectDelay;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.LabServices.Inputs.AutoShutdownProfileArgs WithShutdownOnDisconnect(this global::Pulumi.AzureNative.LabServices.Inputs.AutoShutdownProfileArgs @selfRef, global::Pulumi.AzureNative.LabServices.EnableState shutdownOnDisconnect)
    {
        @selfRef.ShutdownOnDisconnect = shutdownOnDisconnect;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.LabServices.Inputs.AutoShutdownProfileArgs WithShutdownOnDisconnect(this global::Pulumi.AzureNative.LabServices.Inputs.AutoShutdownProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.LabServices.EnableState> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.LabServices.EnableState>();
        @configure(@item);
        @selfRef.ShutdownOnDisconnect = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.LabServices.Inputs.AutoShutdownProfileArgs WithShutdownOnIdle(this global::Pulumi.AzureNative.LabServices.Inputs.AutoShutdownProfileArgs @selfRef, global::Pulumi.AzureNative.LabServices.ShutdownOnIdleMode shutdownOnIdle)
    {
        @selfRef.ShutdownOnIdle = shutdownOnIdle;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.LabServices.Inputs.AutoShutdownProfileArgs WithShutdownOnIdle(this global::Pulumi.AzureNative.LabServices.Inputs.AutoShutdownProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.LabServices.ShutdownOnIdleMode> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.LabServices.ShutdownOnIdleMode>();
        @configure(@item);
        @selfRef.ShutdownOnIdle = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.LabServices.Inputs.AutoShutdownProfileArgs WithShutdownWhenNotConnected(this global::Pulumi.AzureNative.LabServices.Inputs.AutoShutdownProfileArgs @selfRef, global::Pulumi.AzureNative.LabServices.EnableState shutdownWhenNotConnected)
    {
        @selfRef.ShutdownWhenNotConnected = shutdownWhenNotConnected;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.LabServices.Inputs.AutoShutdownProfileArgs WithShutdownWhenNotConnected(this global::Pulumi.AzureNative.LabServices.Inputs.AutoShutdownProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.LabServices.EnableState> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.LabServices.EnableState>();
        @configure(@item);
        @selfRef.ShutdownWhenNotConnected = @item;
        return @selfRef;
    }

}
