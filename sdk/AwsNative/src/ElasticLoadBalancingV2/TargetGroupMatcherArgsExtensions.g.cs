// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs;

namespace Pulumi.AwsNative.ElasticLoadBalancingV2;

public static partial class TargetGroupMatcherArgsExtensions
{
    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.TargetGroupMatcherArgs WithGrpcCode(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.TargetGroupMatcherArgs @selfRef, global::System.String grpcCode)
    {
        @selfRef.GrpcCode = grpcCode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.TargetGroupMatcherArgs WithHttpCode(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.TargetGroupMatcherArgs @selfRef, global::System.String httpCode)
    {
        @selfRef.HttpCode = httpCode;
        return @selfRef;
    }

}
