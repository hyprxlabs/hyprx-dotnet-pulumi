// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Web.Inputs;

namespace Pulumi.AzureNative.Web;

public static partial class ConnectionErrorArgsExtensions
{
    public static global::Pulumi.AzureNative.Web.Inputs.ConnectionErrorArgs WithCode(this global::Pulumi.AzureNative.Web.Inputs.ConnectionErrorArgs @selfRef, global::System.String code)
    {
        @selfRef.Code = code;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.ConnectionErrorArgs WithEtag(this global::Pulumi.AzureNative.Web.Inputs.ConnectionErrorArgs @selfRef, global::System.String etag)
    {
        @selfRef.Etag = etag;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.ConnectionErrorArgs WithLocation(this global::Pulumi.AzureNative.Web.Inputs.ConnectionErrorArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.ConnectionErrorArgs WithMessage(this global::Pulumi.AzureNative.Web.Inputs.ConnectionErrorArgs @selfRef, global::System.String message)
    {
        @selfRef.Message = message;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.ConnectionErrorArgs WithTags(this global::Pulumi.AzureNative.Web.Inputs.ConnectionErrorArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.ConnectionErrorArgs WithTags(this global::Pulumi.AzureNative.Web.Inputs.ConnectionErrorArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.ConnectionErrorArgs WithTags(this global::Pulumi.AzureNative.Web.Inputs.ConnectionErrorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
