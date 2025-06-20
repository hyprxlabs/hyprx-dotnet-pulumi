// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ServiceFabric.Inputs;

namespace Pulumi.AzureNative.ServiceFabric;

public static partial class VaultSecretGroupArgsExtensions
{
    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.VaultSecretGroupArgs WithSourceVault(this global::Pulumi.AzureNative.ServiceFabric.Inputs.VaultSecretGroupArgs @selfRef, global::Pulumi.AzureNative.ServiceFabric.Inputs.SubResourceArgs sourceVault)
    {
        @selfRef.SourceVault = sourceVault;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.VaultSecretGroupArgs WithSourceVault(this global::Pulumi.AzureNative.ServiceFabric.Inputs.VaultSecretGroupArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ServiceFabric.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ServiceFabric.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.SourceVault = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.VaultSecretGroupArgs WithVaultCertificates(this global::Pulumi.AzureNative.ServiceFabric.Inputs.VaultSecretGroupArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.VaultCertificateArgs> vaultCertificates)
    {
        @selfRef.VaultCertificates = vaultCertificates;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.VaultSecretGroupArgs WithVaultCertificates(this global::Pulumi.AzureNative.ServiceFabric.Inputs.VaultSecretGroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.VaultCertificateArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.VaultCertificateArgs>();
        @configure(@list);
        @selfRef.VaultCertificates = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.VaultSecretGroupArgs WithVaultCertificates(this global::Pulumi.AzureNative.ServiceFabric.Inputs.VaultSecretGroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ServiceFabric.Inputs.VaultCertificateArgs>> @create)
    {
        @selfRef.VaultCertificates = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
