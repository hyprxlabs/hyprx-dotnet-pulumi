// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.KafkaConnect.Inputs;

namespace Pulumi.AwsNative.KafkaConnect;

public static partial class ConnectorVpcArgsExtensions
{
    public static global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorVpcArgs WithSecurityGroups(this global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorVpcArgs @selfRef, global::System.Collections.Generic.List<global::System.String> securityGroups)
    {
        @selfRef.SecurityGroups = securityGroups;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorVpcArgs WithSecurityGroups(this global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorVpcArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SecurityGroups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorVpcArgs WithSecurityGroups(this global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorVpcArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SecurityGroups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorVpcArgs WithSubnets(this global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorVpcArgs @selfRef, global::System.Collections.Generic.List<global::System.String> subnets)
    {
        @selfRef.Subnets = subnets;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorVpcArgs WithSubnets(this global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorVpcArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Subnets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorVpcArgs WithSubnets(this global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorVpcArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Subnets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
