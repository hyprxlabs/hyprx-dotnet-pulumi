// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.WaFv2;

public static partial class WebAclAssociationArgsExtensions
{
    public static global::Pulumi.AwsNative.WaFv2.WebAclAssociationArgs WithResourceArn(this global::Pulumi.AwsNative.WaFv2.WebAclAssociationArgs @selfRef, global::System.String resourceArn)
    {
        @selfRef.ResourceArn = resourceArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclAssociationArgs WithWebAclArn(this global::Pulumi.AwsNative.WaFv2.WebAclAssociationArgs @selfRef, global::System.String webAclArn)
    {
        @selfRef.WebAclArn = webAclArn;
        return @selfRef;
    }

}
