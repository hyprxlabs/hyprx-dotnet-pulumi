// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ec2;

public static partial class IpamResourceDiscoveryAssociationArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.IpamResourceDiscoveryAssociationArgs WithIpamId(this global::Pulumi.AwsNative.Ec2.IpamResourceDiscoveryAssociationArgs @selfRef, global::System.String ipamId)
    {
        @selfRef.IpamId = ipamId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.IpamResourceDiscoveryAssociationArgs WithIpamResourceDiscoveryId(this global::Pulumi.AwsNative.Ec2.IpamResourceDiscoveryAssociationArgs @selfRef, global::System.String ipamResourceDiscoveryId)
    {
        @selfRef.IpamResourceDiscoveryId = ipamResourceDiscoveryId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.IpamResourceDiscoveryAssociationArgs WithTags(this global::Pulumi.AwsNative.Ec2.IpamResourceDiscoveryAssociationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.IpamResourceDiscoveryAssociationArgs WithTags(this global::Pulumi.AwsNative.Ec2.IpamResourceDiscoveryAssociationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.IpamResourceDiscoveryAssociationArgs WithTags(this global::Pulumi.AwsNative.Ec2.IpamResourceDiscoveryAssociationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
