// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Lex.Inputs;

namespace Pulumi.AwsNative.Lex;

public static partial class BotGrammarSlotTypeSourceArgsExtensions
{
    public static global::Pulumi.AwsNative.Lex.Inputs.BotGrammarSlotTypeSourceArgs WithKmsKeyArn(this global::Pulumi.AwsNative.Lex.Inputs.BotGrammarSlotTypeSourceArgs @selfRef, global::System.String kmsKeyArn)
    {
        @selfRef.KmsKeyArn = kmsKeyArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotGrammarSlotTypeSourceArgs WithS3BucketName(this global::Pulumi.AwsNative.Lex.Inputs.BotGrammarSlotTypeSourceArgs @selfRef, global::System.String s3BucketName)
    {
        @selfRef.S3BucketName = s3BucketName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotGrammarSlotTypeSourceArgs WithS3ObjectKey(this global::Pulumi.AwsNative.Lex.Inputs.BotGrammarSlotTypeSourceArgs @selfRef, global::System.String s3ObjectKey)
    {
        @selfRef.S3ObjectKey = s3ObjectKey;
        return @selfRef;
    }

}
