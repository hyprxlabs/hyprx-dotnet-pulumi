// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.OpenSearchService.Inputs;

namespace Pulumi.AwsNative.OpenSearchService;

public static partial class DomainNodeConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainNodeConfigArgs WithCount(this global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainNodeConfigArgs @selfRef, global::System.Int32 count)
    {
        @selfRef.Count = count;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainNodeConfigArgs WithEnabled(this global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainNodeConfigArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainNodeConfigArgs WithType(this global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainNodeConfigArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
