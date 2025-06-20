// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class ApplicationSecurityGroupArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationSecurityGroupArgs WithId(this global::Pulumi.AzureNative.Network.Inputs.ApplicationSecurityGroupArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationSecurityGroupArgs WithLocation(this global::Pulumi.AzureNative.Network.Inputs.ApplicationSecurityGroupArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationSecurityGroupArgs WithTags(this global::Pulumi.AzureNative.Network.Inputs.ApplicationSecurityGroupArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationSecurityGroupArgs WithTags(this global::Pulumi.AzureNative.Network.Inputs.ApplicationSecurityGroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationSecurityGroupArgs WithTags(this global::Pulumi.AzureNative.Network.Inputs.ApplicationSecurityGroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
