// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.LookoutMetrics.Inputs;

namespace Pulumi.AwsNative.LookoutMetrics;

public static partial class AnomalyDetectorVpcConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorVpcConfigurationArgs WithSecurityGroupIdList(this global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorVpcConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::System.String> securityGroupIdList)
    {
        @selfRef.SecurityGroupIdList = securityGroupIdList;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorVpcConfigurationArgs WithSecurityGroupIdList(this global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorVpcConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SecurityGroupIdList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorVpcConfigurationArgs WithSecurityGroupIdList(this global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorVpcConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SecurityGroupIdList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorVpcConfigurationArgs WithSubnetIdList(this global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorVpcConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::System.String> subnetIdList)
    {
        @selfRef.SubnetIdList = subnetIdList;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorVpcConfigurationArgs WithSubnetIdList(this global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorVpcConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SubnetIdList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorVpcConfigurationArgs WithSubnetIdList(this global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorVpcConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SubnetIdList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
