// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ApiGateway.Inputs;

namespace Pulumi.AwsNative.ApiGateway;

public static partial class ApiKeyStageKeyArgsExtensions
{
    public static global::Pulumi.AwsNative.ApiGateway.Inputs.ApiKeyStageKeyArgs WithRestApiId(this global::Pulumi.AwsNative.ApiGateway.Inputs.ApiKeyStageKeyArgs @selfRef, global::System.String restApiId)
    {
        @selfRef.RestApiId = restApiId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApiGateway.Inputs.ApiKeyStageKeyArgs WithStageName(this global::Pulumi.AwsNative.ApiGateway.Inputs.ApiKeyStageKeyArgs @selfRef, global::System.String stageName)
    {
        @selfRef.StageName = stageName;
        return @selfRef;
    }

}
