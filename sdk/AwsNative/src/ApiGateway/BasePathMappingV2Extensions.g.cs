// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.ApiGateway;

public static partial class BasePathMappingV2Extensions
{

    extension(BasePathMappingV2)
    {
        public static BasePathMappingV2 New(string @id, global::Pulumi.AwsNative.ApiGateway.BasePathMappingV2Args @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new BasePathMappingV2(@id, @args, @options);
        }

        public static BasePathMappingV2 New(string @id, global::System.Action<global::Pulumi.AwsNative.ApiGateway.BasePathMappingV2Args>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.ApiGateway.BasePathMappingV2Args @args = new();
            global::Pulumi.CustomResourceOptions? @options = null;
            if (@configureArgs is not null)
            {
                @configureArgs(@args);
            }

            if (@configureOptions is not null)
            {
                @options = new();
                @configureOptions(@options);
            }

            return new BasePathMappingV2(@id, @args, @options);
        }

    }

}
