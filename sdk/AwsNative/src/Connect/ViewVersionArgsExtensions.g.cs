// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Connect;

public static partial class ViewVersionArgsExtensions
{
    public static global::Pulumi.AwsNative.Connect.ViewVersionArgs WithVersionDescription(this global::Pulumi.AwsNative.Connect.ViewVersionArgs @selfRef, global::System.String versionDescription)
    {
        @selfRef.VersionDescription = versionDescription;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.ViewVersionArgs WithViewArn(this global::Pulumi.AwsNative.Connect.ViewVersionArgs @selfRef, global::System.String viewArn)
    {
        @selfRef.ViewArn = viewArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.ViewVersionArgs WithViewContentSha256(this global::Pulumi.AwsNative.Connect.ViewVersionArgs @selfRef, global::System.String viewContentSha256)
    {
        @selfRef.ViewContentSha256 = viewContentSha256;
        return @selfRef;
    }

}
