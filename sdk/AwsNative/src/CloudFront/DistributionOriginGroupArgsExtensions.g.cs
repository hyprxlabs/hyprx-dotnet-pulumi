// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.CloudFront.Inputs;

namespace Pulumi.AwsNative.CloudFront;

public static partial class DistributionOriginGroupArgsExtensions
{
    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupArgs WithFailoverCriteria(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupArgs @selfRef, global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupFailoverCriteriaArgs failoverCriteria)
    {
        @selfRef.FailoverCriteria = failoverCriteria;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupArgs WithFailoverCriteria(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupFailoverCriteriaArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupFailoverCriteriaArgs();
        @configure(@item);
        @selfRef.FailoverCriteria = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupArgs WithId(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupArgs WithMembers(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupArgs @selfRef, global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupMembersArgs members)
    {
        @selfRef.Members = members;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupArgs WithMembers(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupMembersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupMembersArgs();
        @configure(@item);
        @selfRef.Members = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupArgs WithSelectionCriteria(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupArgs @selfRef, global::Pulumi.AwsNative.CloudFront.DistributionOriginGroupSelectionCriteria selectionCriteria)
    {
        @selfRef.SelectionCriteria = selectionCriteria;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupArgs WithSelectionCriteria(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CloudFront.DistributionOriginGroupSelectionCriteria> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.CloudFront.DistributionOriginGroupSelectionCriteria>();
        @configure(@item);
        @selfRef.SelectionCriteria = @item;
        return @selfRef;
    }

}
