// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.AppSync;

public static partial class DomainNameApiAssociationArgsExtensions
{
    public static global::Pulumi.AwsNative.AppSync.DomainNameApiAssociationArgs WithApiId(this global::Pulumi.AwsNative.AppSync.DomainNameApiAssociationArgs @selfRef, global::System.String apiId)
    {
        @selfRef.ApiId = apiId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.DomainNameApiAssociationArgs WithDomainName(this global::Pulumi.AwsNative.AppSync.DomainNameApiAssociationArgs @selfRef, global::System.String domainName)
    {
        @selfRef.DomainName = domainName;
        return @selfRef;
    }

}
