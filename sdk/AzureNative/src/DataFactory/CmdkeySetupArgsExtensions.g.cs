// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class CmdkeySetupArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.CmdkeySetupArgs WithPassword(this global::Pulumi.AzureNative.DataFactory.Inputs.CmdkeySetupArgs @selfRef, global::Pulumi.Union<global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs, global::Pulumi.AzureNative.DataFactory.Inputs.SecureStringArgs> password)
    {
        @selfRef.Password = password;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.CmdkeySetupArgs WithTargetName(this global::Pulumi.AzureNative.DataFactory.Inputs.CmdkeySetupArgs @selfRef, global::System.Object targetName)
    {
        @selfRef.TargetName = targetName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.CmdkeySetupArgs WithTargetName(this global::Pulumi.AzureNative.DataFactory.Inputs.CmdkeySetupArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.TargetName = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.CmdkeySetupArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.CmdkeySetupArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.CmdkeySetupArgs WithUserName(this global::Pulumi.AzureNative.DataFactory.Inputs.CmdkeySetupArgs @selfRef, global::System.Object userName)
    {
        @selfRef.UserName = userName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.CmdkeySetupArgs WithUserName(this global::Pulumi.AzureNative.DataFactory.Inputs.CmdkeySetupArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.UserName = @item;
        return @selfRef;
    }

}
