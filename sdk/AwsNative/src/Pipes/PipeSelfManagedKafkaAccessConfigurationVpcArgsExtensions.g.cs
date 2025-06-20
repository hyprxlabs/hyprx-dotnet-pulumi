// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Pipes.Inputs;

namespace Pulumi.AwsNative.Pipes;

public static partial class PipeSelfManagedKafkaAccessConfigurationVpcArgsExtensions
{
    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeSelfManagedKafkaAccessConfigurationVpcArgs WithSecurityGroup(this global::Pulumi.AwsNative.Pipes.Inputs.PipeSelfManagedKafkaAccessConfigurationVpcArgs @selfRef, global::System.Collections.Generic.List<global::System.String> securityGroup)
    {
        @selfRef.SecurityGroup = securityGroup;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeSelfManagedKafkaAccessConfigurationVpcArgs WithSecurityGroup(this global::Pulumi.AwsNative.Pipes.Inputs.PipeSelfManagedKafkaAccessConfigurationVpcArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SecurityGroup = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeSelfManagedKafkaAccessConfigurationVpcArgs WithSecurityGroup(this global::Pulumi.AwsNative.Pipes.Inputs.PipeSelfManagedKafkaAccessConfigurationVpcArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SecurityGroup = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeSelfManagedKafkaAccessConfigurationVpcArgs WithSubnets(this global::Pulumi.AwsNative.Pipes.Inputs.PipeSelfManagedKafkaAccessConfigurationVpcArgs @selfRef, global::System.Collections.Generic.List<global::System.String> subnets)
    {
        @selfRef.Subnets = subnets;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeSelfManagedKafkaAccessConfigurationVpcArgs WithSubnets(this global::Pulumi.AwsNative.Pipes.Inputs.PipeSelfManagedKafkaAccessConfigurationVpcArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Subnets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeSelfManagedKafkaAccessConfigurationVpcArgs WithSubnets(this global::Pulumi.AwsNative.Pipes.Inputs.PipeSelfManagedKafkaAccessConfigurationVpcArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Subnets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
