// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.ApiGateway;

public static partial class DocumentationVersionArgsExtensions
{
    public static global::Pulumi.AwsNative.ApiGateway.DocumentationVersionArgs WithDescription(this global::Pulumi.AwsNative.ApiGateway.DocumentationVersionArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApiGateway.DocumentationVersionArgs WithDocumentationVersionValue(this global::Pulumi.AwsNative.ApiGateway.DocumentationVersionArgs @selfRef, global::System.String documentationVersionValue)
    {
        @selfRef.DocumentationVersionValue = documentationVersionValue;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApiGateway.DocumentationVersionArgs WithRestApiId(this global::Pulumi.AwsNative.ApiGateway.DocumentationVersionArgs @selfRef, global::System.String restApiId)
    {
        @selfRef.RestApiId = restApiId;
        return @selfRef;
    }

}
