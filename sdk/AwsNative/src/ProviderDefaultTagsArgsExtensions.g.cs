// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Inputs;

namespace Pulumi.AwsNative;

public static partial class ProviderDefaultTagsArgsExtensions
{
    public static global::Pulumi.AwsNative.Inputs.ProviderDefaultTagsArgs WithTags(this global::Pulumi.AwsNative.Inputs.ProviderDefaultTagsArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Inputs.ProviderDefaultTagsArgs WithTags(this global::Pulumi.AwsNative.Inputs.ProviderDefaultTagsArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Inputs.ProviderDefaultTagsArgs WithTags(this global::Pulumi.AwsNative.Inputs.ProviderDefaultTagsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
