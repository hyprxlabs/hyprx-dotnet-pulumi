// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Glue.Inputs;

namespace Pulumi.AwsNative.Glue;

public static partial class CrawlerRecrawlPolicyArgsExtensions
{
    public static global::Pulumi.AwsNative.Glue.Inputs.CrawlerRecrawlPolicyArgs WithRecrawlBehavior(this global::Pulumi.AwsNative.Glue.Inputs.CrawlerRecrawlPolicyArgs @selfRef, global::System.String recrawlBehavior)
    {
        @selfRef.RecrawlBehavior = recrawlBehavior;
        return @selfRef;
    }

}
