// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.CloudFront.Inputs;

namespace Pulumi.AwsNative.CloudFront;

public static partial class DistributionOriginGroupsArgsExtensions
{
    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupsArgs WithItems(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupArgs> items)
    {
        @selfRef.Items = items;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupsArgs WithItems(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupArgs>();
        @configure(@list);
        @selfRef.Items = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupsArgs WithItems(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupArgs>> @create)
    {
        @selfRef.Items = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupsArgs WithQuantity(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupsArgs @selfRef, global::System.Int32 quantity)
    {
        @selfRef.Quantity = quantity;
        return @selfRef;
    }

}
