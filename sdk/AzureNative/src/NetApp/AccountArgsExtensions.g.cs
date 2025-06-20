// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.NetApp;

public static partial class AccountArgsExtensions
{
    public static global::Pulumi.AzureNative.NetApp.AccountArgs WithAccountName(this global::Pulumi.AzureNative.NetApp.AccountArgs @selfRef, global::System.String accountName)
    {
        @selfRef.AccountName = accountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.AccountArgs WithActiveDirectories(this global::Pulumi.AzureNative.NetApp.AccountArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.NetApp.Inputs.ActiveDirectoryArgs> activeDirectories)
    {
        @selfRef.ActiveDirectories = activeDirectories;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.AccountArgs WithActiveDirectories(this global::Pulumi.AzureNative.NetApp.AccountArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.NetApp.Inputs.ActiveDirectoryArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.NetApp.Inputs.ActiveDirectoryArgs>();
        @configure(@list);
        @selfRef.ActiveDirectories = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.AccountArgs WithActiveDirectories(this global::Pulumi.AzureNative.NetApp.AccountArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.NetApp.Inputs.ActiveDirectoryArgs>> @create)
    {
        @selfRef.ActiveDirectories = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.AccountArgs WithEncryption(this global::Pulumi.AzureNative.NetApp.AccountArgs @selfRef, global::Pulumi.AzureNative.NetApp.Inputs.AccountEncryptionArgs encryption)
    {
        @selfRef.Encryption = encryption;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.AccountArgs WithEncryption(this global::Pulumi.AzureNative.NetApp.AccountArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.NetApp.Inputs.AccountEncryptionArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.NetApp.Inputs.AccountEncryptionArgs();
        @configure(@item);
        @selfRef.Encryption = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.AccountArgs WithIdentity(this global::Pulumi.AzureNative.NetApp.AccountArgs @selfRef, global::Pulumi.AzureNative.NetApp.Inputs.ManagedServiceIdentityArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.AccountArgs WithIdentity(this global::Pulumi.AzureNative.NetApp.AccountArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.NetApp.Inputs.ManagedServiceIdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.NetApp.Inputs.ManagedServiceIdentityArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.AccountArgs WithLocation(this global::Pulumi.AzureNative.NetApp.AccountArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.AccountArgs WithResourceGroupName(this global::Pulumi.AzureNative.NetApp.AccountArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.AccountArgs WithTags(this global::Pulumi.AzureNative.NetApp.AccountArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.AccountArgs WithTags(this global::Pulumi.AzureNative.NetApp.AccountArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.AccountArgs WithTags(this global::Pulumi.AzureNative.NetApp.AccountArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
