// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Monitor.Inputs;

namespace Pulumi.AzureNative.Monitor;

public static partial class AzureAppPushReceiverArgsExtensions
{
    public static global::Pulumi.AzureNative.Monitor.Inputs.AzureAppPushReceiverArgs WithEmailAddress(this global::Pulumi.AzureNative.Monitor.Inputs.AzureAppPushReceiverArgs @selfRef, global::System.String emailAddress)
    {
        @selfRef.EmailAddress = emailAddress;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.AzureAppPushReceiverArgs WithName(this global::Pulumi.AzureNative.Monitor.Inputs.AzureAppPushReceiverArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

}
