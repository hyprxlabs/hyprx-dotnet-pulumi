// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.DeviceFarm.Inputs;

namespace Pulumi.AwsNative.DeviceFarm;

public static partial class DevicePoolRuleArgsExtensions
{
    public static global::Pulumi.AwsNative.DeviceFarm.Inputs.DevicePoolRuleArgs WithAttribute(this global::Pulumi.AwsNative.DeviceFarm.Inputs.DevicePoolRuleArgs @selfRef, global::Pulumi.AwsNative.DeviceFarm.DevicePoolRuleAttribute attribute)
    {
        @selfRef.Attribute = attribute;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DeviceFarm.Inputs.DevicePoolRuleArgs WithAttribute(this global::Pulumi.AwsNative.DeviceFarm.Inputs.DevicePoolRuleArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DeviceFarm.DevicePoolRuleAttribute> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.DeviceFarm.DevicePoolRuleAttribute>();
        @configure(@item);
        @selfRef.Attribute = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DeviceFarm.Inputs.DevicePoolRuleArgs WithOperator(this global::Pulumi.AwsNative.DeviceFarm.Inputs.DevicePoolRuleArgs @selfRef, global::Pulumi.AwsNative.DeviceFarm.DevicePoolRuleOperator @operator)
    {
        @selfRef.Operator = @operator;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DeviceFarm.Inputs.DevicePoolRuleArgs WithOperator(this global::Pulumi.AwsNative.DeviceFarm.Inputs.DevicePoolRuleArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DeviceFarm.DevicePoolRuleOperator> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.DeviceFarm.DevicePoolRuleOperator>();
        @configure(@item);
        @selfRef.Operator = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DeviceFarm.Inputs.DevicePoolRuleArgs WithValue(this global::Pulumi.AwsNative.DeviceFarm.Inputs.DevicePoolRuleArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
