// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Batch.Inputs;

namespace Pulumi.AzureNative.Batch;

public static partial class VMExtensionArgsExtensions
{
    public static global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs WithAutoUpgradeMinorVersion(this global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs @selfRef, bool autoUpgradeMinorVersion = true)
    {
        @selfRef.AutoUpgradeMinorVersion = autoUpgradeMinorVersion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs WithEnableAutomaticUpgrade(this global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs @selfRef, bool enableAutomaticUpgrade = true)
    {
        @selfRef.EnableAutomaticUpgrade = enableAutomaticUpgrade;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs WithName(this global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs WithProtectedSettings(this global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs @selfRef, global::System.Object protectedSettings)
    {
        @selfRef.ProtectedSettings = protectedSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs WithProtectedSettings(this global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.ProtectedSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs WithProvisionAfterExtensions(this global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs @selfRef, global::System.Collections.Generic.List<global::System.String> provisionAfterExtensions)
    {
        @selfRef.ProvisionAfterExtensions = provisionAfterExtensions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs WithProvisionAfterExtensions(this global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ProvisionAfterExtensions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs WithProvisionAfterExtensions(this global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ProvisionAfterExtensions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs WithPublisher(this global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs @selfRef, global::System.String publisher)
    {
        @selfRef.Publisher = publisher;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs WithSettings(this global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs @selfRef, global::System.Object settings)
    {
        @selfRef.Settings = settings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs WithSettings(this global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Settings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs WithType(this global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs WithTypeHandlerVersion(this global::Pulumi.AzureNative.Batch.Inputs.VMExtensionArgs @selfRef, global::System.String typeHandlerVersion)
    {
        @selfRef.TypeHandlerVersion = typeHandlerVersion;
        return @selfRef;
    }

}
