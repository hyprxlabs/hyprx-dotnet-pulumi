// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Events.Inputs;

namespace Pulumi.AwsNative.Events;

public static partial class RuleEcsParametersArgsExtensions
{
    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithCapacityProviderStrategy(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Events.Inputs.RuleCapacityProviderStrategyItemArgs> capacityProviderStrategy)
    {
        @selfRef.CapacityProviderStrategy = capacityProviderStrategy;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithCapacityProviderStrategy(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Events.Inputs.RuleCapacityProviderStrategyItemArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Events.Inputs.RuleCapacityProviderStrategyItemArgs>();
        @configure(@list);
        @selfRef.CapacityProviderStrategy = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithCapacityProviderStrategy(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Events.Inputs.RuleCapacityProviderStrategyItemArgs>> @create)
    {
        @selfRef.CapacityProviderStrategy = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithEnableEcsManagedTags(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, bool enableEcsManagedTags = true)
    {
        @selfRef.EnableEcsManagedTags = enableEcsManagedTags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithEnableExecuteCommand(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, bool enableExecuteCommand = true)
    {
        @selfRef.EnableExecuteCommand = enableExecuteCommand;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithGroup(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, global::System.String group)
    {
        @selfRef.Group = group;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithLaunchType(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, global::System.String launchType)
    {
        @selfRef.LaunchType = launchType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithNetworkConfiguration(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, global::Pulumi.AwsNative.Events.Inputs.RuleNetworkConfigurationArgs networkConfiguration)
    {
        @selfRef.NetworkConfiguration = networkConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithNetworkConfiguration(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Events.Inputs.RuleNetworkConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Events.Inputs.RuleNetworkConfigurationArgs();
        @configure(@item);
        @selfRef.NetworkConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithPlacementConstraints(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Events.Inputs.RulePlacementConstraintArgs> placementConstraints)
    {
        @selfRef.PlacementConstraints = placementConstraints;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithPlacementConstraints(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Events.Inputs.RulePlacementConstraintArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Events.Inputs.RulePlacementConstraintArgs>();
        @configure(@list);
        @selfRef.PlacementConstraints = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithPlacementConstraints(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Events.Inputs.RulePlacementConstraintArgs>> @create)
    {
        @selfRef.PlacementConstraints = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithPlacementStrategies(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Events.Inputs.RulePlacementStrategyArgs> placementStrategies)
    {
        @selfRef.PlacementStrategies = placementStrategies;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithPlacementStrategies(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Events.Inputs.RulePlacementStrategyArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Events.Inputs.RulePlacementStrategyArgs>();
        @configure(@list);
        @selfRef.PlacementStrategies = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithPlacementStrategies(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Events.Inputs.RulePlacementStrategyArgs>> @create)
    {
        @selfRef.PlacementStrategies = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithPlatformVersion(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, global::System.String platformVersion)
    {
        @selfRef.PlatformVersion = platformVersion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithPropagateTags(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, global::System.String propagateTags)
    {
        @selfRef.PropagateTags = propagateTags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithReferenceId(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, global::System.String referenceId)
    {
        @selfRef.ReferenceId = referenceId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithTagList(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Events.Inputs.RuleTagArgs> tagList)
    {
        @selfRef.TagList = tagList;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithTagList(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Events.Inputs.RuleTagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Events.Inputs.RuleTagArgs>();
        @configure(@list);
        @selfRef.TagList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithTagList(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Events.Inputs.RuleTagArgs>> @create)
    {
        @selfRef.TagList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithTaskCount(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, global::System.Int32 taskCount)
    {
        @selfRef.TaskCount = taskCount;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs WithTaskDefinitionArn(this global::Pulumi.AwsNative.Events.Inputs.RuleEcsParametersArgs @selfRef, global::System.String taskDefinitionArn)
    {
        @selfRef.TaskDefinitionArn = taskDefinitionArn;
        return @selfRef;
    }

}
