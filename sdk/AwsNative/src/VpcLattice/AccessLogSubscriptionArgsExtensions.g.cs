// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.VpcLattice;

public static partial class AccessLogSubscriptionArgsExtensions
{
    public static global::Pulumi.AwsNative.VpcLattice.AccessLogSubscriptionArgs WithDestinationArn(this global::Pulumi.AwsNative.VpcLattice.AccessLogSubscriptionArgs @selfRef, global::System.String destinationArn)
    {
        @selfRef.DestinationArn = destinationArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.VpcLattice.AccessLogSubscriptionArgs WithResourceIdentifier(this global::Pulumi.AwsNative.VpcLattice.AccessLogSubscriptionArgs @selfRef, global::System.String resourceIdentifier)
    {
        @selfRef.ResourceIdentifier = resourceIdentifier;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.VpcLattice.AccessLogSubscriptionArgs WithServiceNetworkLogType(this global::Pulumi.AwsNative.VpcLattice.AccessLogSubscriptionArgs @selfRef, global::Pulumi.AwsNative.VpcLattice.AccessLogSubscriptionServiceNetworkLogType serviceNetworkLogType)
    {
        @selfRef.ServiceNetworkLogType = serviceNetworkLogType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.VpcLattice.AccessLogSubscriptionArgs WithServiceNetworkLogType(this global::Pulumi.AwsNative.VpcLattice.AccessLogSubscriptionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.VpcLattice.AccessLogSubscriptionServiceNetworkLogType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.VpcLattice.AccessLogSubscriptionServiceNetworkLogType>();
        @configure(@item);
        @selfRef.ServiceNetworkLogType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.VpcLattice.AccessLogSubscriptionArgs WithTags(this global::Pulumi.AwsNative.VpcLattice.AccessLogSubscriptionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.VpcLattice.AccessLogSubscriptionArgs WithTags(this global::Pulumi.AwsNative.VpcLattice.AccessLogSubscriptionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.VpcLattice.AccessLogSubscriptionArgs WithTags(this global::Pulumi.AwsNative.VpcLattice.AccessLogSubscriptionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
