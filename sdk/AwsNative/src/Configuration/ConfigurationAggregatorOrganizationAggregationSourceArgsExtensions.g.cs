// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Configuration.Inputs;

namespace Pulumi.AwsNative.Configuration;

public static partial class ConfigurationAggregatorOrganizationAggregationSourceArgsExtensions
{
    public static global::Pulumi.AwsNative.Configuration.Inputs.ConfigurationAggregatorOrganizationAggregationSourceArgs WithAllAwsRegions(this global::Pulumi.AwsNative.Configuration.Inputs.ConfigurationAggregatorOrganizationAggregationSourceArgs @selfRef, bool allAwsRegions = true)
    {
        @selfRef.AllAwsRegions = allAwsRegions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Configuration.Inputs.ConfigurationAggregatorOrganizationAggregationSourceArgs WithAwsRegions(this global::Pulumi.AwsNative.Configuration.Inputs.ConfigurationAggregatorOrganizationAggregationSourceArgs @selfRef, global::System.Collections.Generic.List<global::System.String> awsRegions)
    {
        @selfRef.AwsRegions = awsRegions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Configuration.Inputs.ConfigurationAggregatorOrganizationAggregationSourceArgs WithAwsRegions(this global::Pulumi.AwsNative.Configuration.Inputs.ConfigurationAggregatorOrganizationAggregationSourceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AwsRegions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Configuration.Inputs.ConfigurationAggregatorOrganizationAggregationSourceArgs WithAwsRegions(this global::Pulumi.AwsNative.Configuration.Inputs.ConfigurationAggregatorOrganizationAggregationSourceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AwsRegions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Configuration.Inputs.ConfigurationAggregatorOrganizationAggregationSourceArgs WithRoleArn(this global::Pulumi.AwsNative.Configuration.Inputs.ConfigurationAggregatorOrganizationAggregationSourceArgs @selfRef, global::System.String roleArn)
    {
        @selfRef.RoleArn = roleArn;
        return @selfRef;
    }

}
