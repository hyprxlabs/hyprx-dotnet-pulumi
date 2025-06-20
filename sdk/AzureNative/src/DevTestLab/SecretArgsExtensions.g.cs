// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DevTestLab;

public static partial class SecretArgsExtensions
{
    public static global::Pulumi.AzureNative.DevTestLab.SecretArgs WithLabName(this global::Pulumi.AzureNative.DevTestLab.SecretArgs @selfRef, global::System.String labName)
    {
        @selfRef.LabName = labName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.SecretArgs WithLocation(this global::Pulumi.AzureNative.DevTestLab.SecretArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.SecretArgs WithName(this global::Pulumi.AzureNative.DevTestLab.SecretArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.SecretArgs WithResourceGroupName(this global::Pulumi.AzureNative.DevTestLab.SecretArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.SecretArgs WithTags(this global::Pulumi.AzureNative.DevTestLab.SecretArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.SecretArgs WithTags(this global::Pulumi.AzureNative.DevTestLab.SecretArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.SecretArgs WithTags(this global::Pulumi.AzureNative.DevTestLab.SecretArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.SecretArgs WithUserName(this global::Pulumi.AzureNative.DevTestLab.SecretArgs @selfRef, global::System.String userName)
    {
        @selfRef.UserName = userName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.SecretArgs WithValue(this global::Pulumi.AzureNative.DevTestLab.SecretArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
