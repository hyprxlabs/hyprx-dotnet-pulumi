// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.DeviceFarm;

public static partial class DevicePoolArgsExtensions
{
    public static global::Pulumi.AwsNative.DeviceFarm.DevicePoolArgs WithDescription(this global::Pulumi.AwsNative.DeviceFarm.DevicePoolArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DeviceFarm.DevicePoolArgs WithMaxDevices(this global::Pulumi.AwsNative.DeviceFarm.DevicePoolArgs @selfRef, global::System.Int32 maxDevices)
    {
        @selfRef.MaxDevices = maxDevices;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DeviceFarm.DevicePoolArgs WithName(this global::Pulumi.AwsNative.DeviceFarm.DevicePoolArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DeviceFarm.DevicePoolArgs WithProjectArn(this global::Pulumi.AwsNative.DeviceFarm.DevicePoolArgs @selfRef, global::System.String projectArn)
    {
        @selfRef.ProjectArn = projectArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DeviceFarm.DevicePoolArgs WithRules(this global::Pulumi.AwsNative.DeviceFarm.DevicePoolArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.DeviceFarm.Inputs.DevicePoolRuleArgs> rules)
    {
        @selfRef.Rules = rules;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DeviceFarm.DevicePoolArgs WithRules(this global::Pulumi.AwsNative.DeviceFarm.DevicePoolArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.DeviceFarm.Inputs.DevicePoolRuleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.DeviceFarm.Inputs.DevicePoolRuleArgs>();
        @configure(@list);
        @selfRef.Rules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DeviceFarm.DevicePoolArgs WithRules(this global::Pulumi.AwsNative.DeviceFarm.DevicePoolArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.DeviceFarm.Inputs.DevicePoolRuleArgs>> @create)
    {
        @selfRef.Rules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DeviceFarm.DevicePoolArgs WithTags(this global::Pulumi.AwsNative.DeviceFarm.DevicePoolArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DeviceFarm.DevicePoolArgs WithTags(this global::Pulumi.AwsNative.DeviceFarm.DevicePoolArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DeviceFarm.DevicePoolArgs WithTags(this global::Pulumi.AwsNative.DeviceFarm.DevicePoolArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
