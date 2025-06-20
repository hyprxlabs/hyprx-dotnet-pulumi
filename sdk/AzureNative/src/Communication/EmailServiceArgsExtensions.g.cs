// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Communication;

public static partial class EmailServiceArgsExtensions
{
    public static global::Pulumi.AzureNative.Communication.EmailServiceArgs WithDataLocation(this global::Pulumi.AzureNative.Communication.EmailServiceArgs @selfRef, global::System.String dataLocation)
    {
        @selfRef.DataLocation = dataLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Communication.EmailServiceArgs WithEmailServiceName(this global::Pulumi.AzureNative.Communication.EmailServiceArgs @selfRef, global::System.String emailServiceName)
    {
        @selfRef.EmailServiceName = emailServiceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Communication.EmailServiceArgs WithLocation(this global::Pulumi.AzureNative.Communication.EmailServiceArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Communication.EmailServiceArgs WithResourceGroupName(this global::Pulumi.AzureNative.Communication.EmailServiceArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Communication.EmailServiceArgs WithTags(this global::Pulumi.AzureNative.Communication.EmailServiceArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Communication.EmailServiceArgs WithTags(this global::Pulumi.AzureNative.Communication.EmailServiceArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Communication.EmailServiceArgs WithTags(this global::Pulumi.AzureNative.Communication.EmailServiceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
