// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Batch.Inputs;

namespace Pulumi.AzureNative.Batch;

public static partial class WindowsUserConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.Batch.Inputs.WindowsUserConfigurationArgs WithLoginMode(this global::Pulumi.AzureNative.Batch.Inputs.WindowsUserConfigurationArgs @selfRef, global::Pulumi.AzureNative.Batch.LoginMode loginMode)
    {
        @selfRef.LoginMode = loginMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.WindowsUserConfigurationArgs WithLoginMode(this global::Pulumi.AzureNative.Batch.Inputs.WindowsUserConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Batch.LoginMode> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.Batch.LoginMode>();
        @configure(@item);
        @selfRef.LoginMode = @item;
        return @selfRef;
    }

}
