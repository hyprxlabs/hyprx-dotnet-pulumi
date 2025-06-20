// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.ApiGatewayV2;

public static partial class ModelArgsExtensions
{
    public static global::Pulumi.AwsNative.ApiGatewayV2.ModelArgs WithApiId(this global::Pulumi.AwsNative.ApiGatewayV2.ModelArgs @selfRef, global::System.String apiId)
    {
        @selfRef.ApiId = apiId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApiGatewayV2.ModelArgs WithContentType(this global::Pulumi.AwsNative.ApiGatewayV2.ModelArgs @selfRef, global::System.String contentType)
    {
        @selfRef.ContentType = contentType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApiGatewayV2.ModelArgs WithDescription(this global::Pulumi.AwsNative.ApiGatewayV2.ModelArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApiGatewayV2.ModelArgs WithName(this global::Pulumi.AwsNative.ApiGatewayV2.ModelArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApiGatewayV2.ModelArgs WithSchema(this global::Pulumi.AwsNative.ApiGatewayV2.ModelArgs @selfRef, global::System.Object schema)
    {
        @selfRef.Schema = schema;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApiGatewayV2.ModelArgs WithSchema(this global::Pulumi.AwsNative.ApiGatewayV2.ModelArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Schema = @item;
        return @selfRef;
    }

}
