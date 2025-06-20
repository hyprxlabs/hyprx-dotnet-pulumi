// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.NetworkCloud;

public static partial class ConsoleArgsExtensions
{
    public static global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs WithConsoleName(this global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs @selfRef, global::System.String consoleName)
    {
        @selfRef.ConsoleName = consoleName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs WithEnabled(this global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.NetworkCloud.ConsoleEnabled> enabled)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs WithExpiration(this global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs @selfRef, global::System.String expiration)
    {
        @selfRef.Expiration = expiration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs WithExtendedLocation(this global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs @selfRef, global::Pulumi.AzureNative.NetworkCloud.Inputs.ExtendedLocationArgs extendedLocation)
    {
        @selfRef.ExtendedLocation = extendedLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs WithExtendedLocation(this global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.NetworkCloud.Inputs.ExtendedLocationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.NetworkCloud.Inputs.ExtendedLocationArgs();
        @configure(@item);
        @selfRef.ExtendedLocation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs WithLocation(this global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs WithResourceGroupName(this global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs WithSshPublicKey(this global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs @selfRef, global::Pulumi.AzureNative.NetworkCloud.Inputs.SshPublicKeyArgs sshPublicKey)
    {
        @selfRef.SshPublicKey = sshPublicKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs WithSshPublicKey(this global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.NetworkCloud.Inputs.SshPublicKeyArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.NetworkCloud.Inputs.SshPublicKeyArgs();
        @configure(@item);
        @selfRef.SshPublicKey = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs WithTags(this global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs WithTags(this global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs WithTags(this global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs WithVirtualMachineName(this global::Pulumi.AzureNative.NetworkCloud.ConsoleArgs @selfRef, global::System.String virtualMachineName)
    {
        @selfRef.VirtualMachineName = virtualMachineName;
        return @selfRef;
    }

}
