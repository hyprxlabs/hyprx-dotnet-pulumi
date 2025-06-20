// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.AppRunner;

public static partial class AutoScalingConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.AppRunner.AutoScalingConfigurationArgs WithAutoScalingConfigurationName(this global::Pulumi.AwsNative.AppRunner.AutoScalingConfigurationArgs @selfRef, global::System.String autoScalingConfigurationName)
    {
        @selfRef.AutoScalingConfigurationName = autoScalingConfigurationName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.AutoScalingConfigurationArgs WithMaxConcurrency(this global::Pulumi.AwsNative.AppRunner.AutoScalingConfigurationArgs @selfRef, global::System.Int32 maxConcurrency)
    {
        @selfRef.MaxConcurrency = maxConcurrency;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.AutoScalingConfigurationArgs WithMaxSize(this global::Pulumi.AwsNative.AppRunner.AutoScalingConfigurationArgs @selfRef, global::System.Int32 maxSize)
    {
        @selfRef.MaxSize = maxSize;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.AutoScalingConfigurationArgs WithMinSize(this global::Pulumi.AwsNative.AppRunner.AutoScalingConfigurationArgs @selfRef, global::System.Int32 minSize)
    {
        @selfRef.MinSize = minSize;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.AutoScalingConfigurationArgs WithTags(this global::Pulumi.AwsNative.AppRunner.AutoScalingConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.CreateOnlyTagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.AutoScalingConfigurationArgs WithTags(this global::Pulumi.AwsNative.AppRunner.AutoScalingConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.CreateOnlyTagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.CreateOnlyTagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.AutoScalingConfigurationArgs WithTags(this global::Pulumi.AwsNative.AppRunner.AutoScalingConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.CreateOnlyTagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
