// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Bedrock;

public static partial class BlueprintArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.BlueprintArgs WithBlueprintName(this global::Pulumi.AwsNative.Bedrock.BlueprintArgs @selfRef, global::System.String blueprintName)
    {
        @selfRef.BlueprintName = blueprintName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.BlueprintArgs WithKmsEncryptionContext(this global::Pulumi.AwsNative.Bedrock.BlueprintArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> kmsEncryptionContext)
    {
        @selfRef.KmsEncryptionContext = kmsEncryptionContext;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.BlueprintArgs WithKmsEncryptionContext(this global::Pulumi.AwsNative.Bedrock.BlueprintArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.KmsEncryptionContext = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.BlueprintArgs WithKmsEncryptionContext(this global::Pulumi.AwsNative.Bedrock.BlueprintArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.KmsEncryptionContext = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.BlueprintArgs WithKmsKeyId(this global::Pulumi.AwsNative.Bedrock.BlueprintArgs @selfRef, global::System.String kmsKeyId)
    {
        @selfRef.KmsKeyId = kmsKeyId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.BlueprintArgs WithSchema(this global::Pulumi.AwsNative.Bedrock.BlueprintArgs @selfRef, global::System.Object schema)
    {
        @selfRef.Schema = schema;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.BlueprintArgs WithSchema(this global::Pulumi.AwsNative.Bedrock.BlueprintArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Schema = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.BlueprintArgs WithTags(this global::Pulumi.AwsNative.Bedrock.BlueprintArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.BlueprintArgs WithTags(this global::Pulumi.AwsNative.Bedrock.BlueprintArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.BlueprintArgs WithTags(this global::Pulumi.AwsNative.Bedrock.BlueprintArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.BlueprintArgs WithType(this global::Pulumi.AwsNative.Bedrock.BlueprintArgs @selfRef, global::Pulumi.AwsNative.Bedrock.BlueprintType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.BlueprintArgs WithType(this global::Pulumi.AwsNative.Bedrock.BlueprintArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.BlueprintType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Bedrock.BlueprintType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
