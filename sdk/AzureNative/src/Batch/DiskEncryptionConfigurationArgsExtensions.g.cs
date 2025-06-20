// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Batch.Inputs;

namespace Pulumi.AzureNative.Batch;

public static partial class DiskEncryptionConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.Batch.Inputs.DiskEncryptionConfigurationArgs WithTargets(this global::Pulumi.AzureNative.Batch.Inputs.DiskEncryptionConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Batch.DiskEncryptionTarget> targets)
    {
        @selfRef.Targets = targets;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.DiskEncryptionConfigurationArgs WithTargets(this global::Pulumi.AzureNative.Batch.Inputs.DiskEncryptionConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Batch.DiskEncryptionTarget>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Batch.DiskEncryptionTarget>();
        @configure(@list);
        @selfRef.Targets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.DiskEncryptionConfigurationArgs WithTargets(this global::Pulumi.AzureNative.Batch.Inputs.DiskEncryptionConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Batch.DiskEncryptionTarget>> @create)
    {
        @selfRef.Targets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
