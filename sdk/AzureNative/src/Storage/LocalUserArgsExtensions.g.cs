// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Storage;

public static partial class LocalUserArgsExtensions
{
    public static global::Pulumi.AzureNative.Storage.LocalUserArgs WithAccountName(this global::Pulumi.AzureNative.Storage.LocalUserArgs @selfRef, global::System.String accountName)
    {
        @selfRef.AccountName = accountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.LocalUserArgs WithAllowAclAuthorization(this global::Pulumi.AzureNative.Storage.LocalUserArgs @selfRef, bool allowAclAuthorization = true)
    {
        @selfRef.AllowAclAuthorization = allowAclAuthorization;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.LocalUserArgs WithExtendedGroups(this global::Pulumi.AzureNative.Storage.LocalUserArgs @selfRef, global::System.Collections.Generic.List<global::System.Int32> extendedGroups)
    {
        @selfRef.ExtendedGroups = extendedGroups;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.LocalUserArgs WithExtendedGroups(this global::Pulumi.AzureNative.Storage.LocalUserArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Int32>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Int32>();
        @configure(@list);
        @selfRef.ExtendedGroups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.LocalUserArgs WithExtendedGroups(this global::Pulumi.AzureNative.Storage.LocalUserArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Int32>> @create)
    {
        @selfRef.ExtendedGroups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.LocalUserArgs WithGroupId(this global::Pulumi.AzureNative.Storage.LocalUserArgs @selfRef, global::System.Int32 groupId)
    {
        @selfRef.GroupId = groupId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.LocalUserArgs WithHasSharedKey(this global::Pulumi.AzureNative.Storage.LocalUserArgs @selfRef, bool hasSharedKey = true)
    {
        @selfRef.HasSharedKey = hasSharedKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.LocalUserArgs WithHasSshKey(this global::Pulumi.AzureNative.Storage.LocalUserArgs @selfRef, bool hasSshKey = true)
    {
        @selfRef.HasSshKey = hasSshKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.LocalUserArgs WithHasSshPassword(this global::Pulumi.AzureNative.Storage.LocalUserArgs @selfRef, bool hasSshPassword = true)
    {
        @selfRef.HasSshPassword = hasSshPassword;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.LocalUserArgs WithHomeDirectory(this global::Pulumi.AzureNative.Storage.LocalUserArgs @selfRef, global::System.String homeDirectory)
    {
        @selfRef.HomeDirectory = homeDirectory;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.LocalUserArgs WithIsNFSv3Enabled(this global::Pulumi.AzureNative.Storage.LocalUserArgs @selfRef, bool isNFSv3Enabled = true)
    {
        @selfRef.IsNFSv3Enabled = isNFSv3Enabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.LocalUserArgs WithPermissionScopes(this global::Pulumi.AzureNative.Storage.LocalUserArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Storage.Inputs.PermissionScopeArgs> permissionScopes)
    {
        @selfRef.PermissionScopes = permissionScopes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.LocalUserArgs WithPermissionScopes(this global::Pulumi.AzureNative.Storage.LocalUserArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Storage.Inputs.PermissionScopeArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Storage.Inputs.PermissionScopeArgs>();
        @configure(@list);
        @selfRef.PermissionScopes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.LocalUserArgs WithPermissionScopes(this global::Pulumi.AzureNative.Storage.LocalUserArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Storage.Inputs.PermissionScopeArgs>> @create)
    {
        @selfRef.PermissionScopes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.LocalUserArgs WithResourceGroupName(this global::Pulumi.AzureNative.Storage.LocalUserArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.LocalUserArgs WithSshAuthorizedKeys(this global::Pulumi.AzureNative.Storage.LocalUserArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Storage.Inputs.SshPublicKeyArgs> sshAuthorizedKeys)
    {
        @selfRef.SshAuthorizedKeys = sshAuthorizedKeys;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.LocalUserArgs WithSshAuthorizedKeys(this global::Pulumi.AzureNative.Storage.LocalUserArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Storage.Inputs.SshPublicKeyArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Storage.Inputs.SshPublicKeyArgs>();
        @configure(@list);
        @selfRef.SshAuthorizedKeys = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.LocalUserArgs WithSshAuthorizedKeys(this global::Pulumi.AzureNative.Storage.LocalUserArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Storage.Inputs.SshPublicKeyArgs>> @create)
    {
        @selfRef.SshAuthorizedKeys = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.LocalUserArgs WithUsername(this global::Pulumi.AzureNative.Storage.LocalUserArgs @selfRef, global::System.String username)
    {
        @selfRef.Username = username;
        return @selfRef;
    }

}
