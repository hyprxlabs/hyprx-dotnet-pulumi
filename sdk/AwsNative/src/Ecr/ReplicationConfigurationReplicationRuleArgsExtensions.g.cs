// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ecr.Inputs;

namespace Pulumi.AwsNative.Ecr;

public static partial class ReplicationConfigurationReplicationRuleArgsExtensions
{
    public static global::Pulumi.AwsNative.Ecr.Inputs.ReplicationConfigurationReplicationRuleArgs WithDestinations(this global::Pulumi.AwsNative.Ecr.Inputs.ReplicationConfigurationReplicationRuleArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ecr.Inputs.ReplicationConfigurationReplicationDestinationArgs> destinations)
    {
        @selfRef.Destinations = destinations;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecr.Inputs.ReplicationConfigurationReplicationRuleArgs WithDestinations(this global::Pulumi.AwsNative.Ecr.Inputs.ReplicationConfigurationReplicationRuleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ecr.Inputs.ReplicationConfigurationReplicationDestinationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ecr.Inputs.ReplicationConfigurationReplicationDestinationArgs>();
        @configure(@list);
        @selfRef.Destinations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecr.Inputs.ReplicationConfigurationReplicationRuleArgs WithDestinations(this global::Pulumi.AwsNative.Ecr.Inputs.ReplicationConfigurationReplicationRuleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Ecr.Inputs.ReplicationConfigurationReplicationDestinationArgs>> @create)
    {
        @selfRef.Destinations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecr.Inputs.ReplicationConfigurationReplicationRuleArgs WithRepositoryFilters(this global::Pulumi.AwsNative.Ecr.Inputs.ReplicationConfigurationReplicationRuleArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ecr.Inputs.ReplicationConfigurationRepositoryFilterArgs> repositoryFilters)
    {
        @selfRef.RepositoryFilters = repositoryFilters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecr.Inputs.ReplicationConfigurationReplicationRuleArgs WithRepositoryFilters(this global::Pulumi.AwsNative.Ecr.Inputs.ReplicationConfigurationReplicationRuleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ecr.Inputs.ReplicationConfigurationRepositoryFilterArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ecr.Inputs.ReplicationConfigurationRepositoryFilterArgs>();
        @configure(@list);
        @selfRef.RepositoryFilters = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecr.Inputs.ReplicationConfigurationReplicationRuleArgs WithRepositoryFilters(this global::Pulumi.AwsNative.Ecr.Inputs.ReplicationConfigurationReplicationRuleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Ecr.Inputs.ReplicationConfigurationRepositoryFilterArgs>> @create)
    {
        @selfRef.RepositoryFilters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
