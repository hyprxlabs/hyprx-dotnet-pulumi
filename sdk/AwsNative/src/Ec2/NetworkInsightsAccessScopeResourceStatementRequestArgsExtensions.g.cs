// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ec2.Inputs;

namespace Pulumi.AwsNative.Ec2;

public static partial class NetworkInsightsAccessScopeResourceStatementRequestArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopeResourceStatementRequestArgs WithResourceTypes(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopeResourceStatementRequestArgs @selfRef, global::System.Collections.Generic.List<global::System.String> resourceTypes)
    {
        @selfRef.ResourceTypes = resourceTypes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopeResourceStatementRequestArgs WithResourceTypes(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopeResourceStatementRequestArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ResourceTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopeResourceStatementRequestArgs WithResourceTypes(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopeResourceStatementRequestArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ResourceTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopeResourceStatementRequestArgs WithResources(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopeResourceStatementRequestArgs @selfRef, global::System.Collections.Generic.List<global::System.String> resources)
    {
        @selfRef.Resources = resources;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopeResourceStatementRequestArgs WithResources(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopeResourceStatementRequestArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Resources = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopeResourceStatementRequestArgs WithResources(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopeResourceStatementRequestArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Resources = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
