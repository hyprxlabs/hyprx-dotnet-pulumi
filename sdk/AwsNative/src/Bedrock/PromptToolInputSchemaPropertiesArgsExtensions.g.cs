// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class PromptToolInputSchemaPropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.PromptToolInputSchemaPropertiesArgs WithJson(this global::Pulumi.AwsNative.Bedrock.Inputs.PromptToolInputSchemaPropertiesArgs @selfRef, global::System.Object json)
    {
        @selfRef.Json = json;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.PromptToolInputSchemaPropertiesArgs WithJson(this global::Pulumi.AwsNative.Bedrock.Inputs.PromptToolInputSchemaPropertiesArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Json = @item;
        return @selfRef;
    }

}
