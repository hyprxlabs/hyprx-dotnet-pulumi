// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ec2.Inputs;

namespace Pulumi.AwsNative.Ec2;

public static partial class LaunchTemplateBaselinePerformanceFactorsArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateBaselinePerformanceFactorsArgs WithCpu(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateBaselinePerformanceFactorsArgs @selfRef, global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateCpuArgs cpu)
    {
        @selfRef.Cpu = cpu;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateBaselinePerformanceFactorsArgs WithCpu(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateBaselinePerformanceFactorsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateCpuArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateCpuArgs();
        @configure(@item);
        @selfRef.Cpu = @item;
        return @selfRef;
    }

}
