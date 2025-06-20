// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.KeyVault.Inputs;

namespace Pulumi.AzureNative.KeyVault;

public static partial class RotationPolicyArgsExtensions
{
    public static global::Pulumi.AzureNative.KeyVault.Inputs.RotationPolicyArgs WithAttributes(this global::Pulumi.AzureNative.KeyVault.Inputs.RotationPolicyArgs @selfRef, global::Pulumi.AzureNative.KeyVault.Inputs.KeyRotationPolicyAttributesArgs attributes)
    {
        @selfRef.Attributes = attributes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.RotationPolicyArgs WithAttributes(this global::Pulumi.AzureNative.KeyVault.Inputs.RotationPolicyArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.KeyVault.Inputs.KeyRotationPolicyAttributesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.KeyVault.Inputs.KeyRotationPolicyAttributesArgs();
        @configure(@item);
        @selfRef.Attributes = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.RotationPolicyArgs WithLifetimeActions(this global::Pulumi.AzureNative.KeyVault.Inputs.RotationPolicyArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.KeyVault.Inputs.LifetimeActionArgs> lifetimeActions)
    {
        @selfRef.LifetimeActions = lifetimeActions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.RotationPolicyArgs WithLifetimeActions(this global::Pulumi.AzureNative.KeyVault.Inputs.RotationPolicyArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.KeyVault.Inputs.LifetimeActionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.KeyVault.Inputs.LifetimeActionArgs>();
        @configure(@list);
        @selfRef.LifetimeActions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.RotationPolicyArgs WithLifetimeActions(this global::Pulumi.AzureNative.KeyVault.Inputs.RotationPolicyArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.KeyVault.Inputs.LifetimeActionArgs>> @create)
    {
        @selfRef.LifetimeActions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
