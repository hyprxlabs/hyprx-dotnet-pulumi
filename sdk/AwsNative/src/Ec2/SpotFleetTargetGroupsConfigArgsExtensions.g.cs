// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ec2.Inputs;

namespace Pulumi.AwsNative.Ec2;

public static partial class SpotFleetTargetGroupsConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetTargetGroupsConfigArgs WithTargetGroups(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetTargetGroupsConfigArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetTargetGroupArgs> targetGroups)
    {
        @selfRef.TargetGroups = targetGroups;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetTargetGroupsConfigArgs WithTargetGroups(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetTargetGroupsConfigArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetTargetGroupArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetTargetGroupArgs>();
        @configure(@list);
        @selfRef.TargetGroups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetTargetGroupsConfigArgs WithTargetGroups(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetTargetGroupsConfigArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetTargetGroupArgs>> @create)
    {
        @selfRef.TargetGroups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
