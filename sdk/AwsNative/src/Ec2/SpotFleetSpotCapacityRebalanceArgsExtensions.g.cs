// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ec2.Inputs;

namespace Pulumi.AwsNative.Ec2;

public static partial class SpotFleetSpotCapacityRebalanceArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetSpotCapacityRebalanceArgs WithReplacementStrategy(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetSpotCapacityRebalanceArgs @selfRef, global::Pulumi.AwsNative.Ec2.SpotFleetSpotCapacityRebalanceReplacementStrategy replacementStrategy)
    {
        @selfRef.ReplacementStrategy = replacementStrategy;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetSpotCapacityRebalanceArgs WithReplacementStrategy(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetSpotCapacityRebalanceArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.SpotFleetSpotCapacityRebalanceReplacementStrategy> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Ec2.SpotFleetSpotCapacityRebalanceReplacementStrategy>();
        @configure(@item);
        @selfRef.ReplacementStrategy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetSpotCapacityRebalanceArgs WithTerminationDelay(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetSpotCapacityRebalanceArgs @selfRef, global::System.Int32 terminationDelay)
    {
        @selfRef.TerminationDelay = terminationDelay;
        return @selfRef;
    }

}
