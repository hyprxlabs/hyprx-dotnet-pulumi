// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ec2.Inputs;

namespace Pulumi.AwsNative.Ec2;

public static partial class IpamPoolSourceResourceArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.Inputs.IpamPoolSourceResourceArgs WithResourceId(this global::Pulumi.AwsNative.Ec2.Inputs.IpamPoolSourceResourceArgs @selfRef, global::System.String resourceId)
    {
        @selfRef.ResourceId = resourceId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.IpamPoolSourceResourceArgs WithResourceOwner(this global::Pulumi.AwsNative.Ec2.Inputs.IpamPoolSourceResourceArgs @selfRef, global::System.String resourceOwner)
    {
        @selfRef.ResourceOwner = resourceOwner;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.IpamPoolSourceResourceArgs WithResourceRegion(this global::Pulumi.AwsNative.Ec2.Inputs.IpamPoolSourceResourceArgs @selfRef, global::System.String resourceRegion)
    {
        @selfRef.ResourceRegion = resourceRegion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.IpamPoolSourceResourceArgs WithResourceType(this global::Pulumi.AwsNative.Ec2.Inputs.IpamPoolSourceResourceArgs @selfRef, global::System.String resourceType)
    {
        @selfRef.ResourceType = resourceType;
        return @selfRef;
    }

}
