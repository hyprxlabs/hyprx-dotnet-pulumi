// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Route53RecoveryControl.Inputs;

namespace Pulumi.AwsNative.Route53RecoveryControl;

public static partial class SafetyRuleAssertionRuleArgsExtensions
{
    public static global::Pulumi.AwsNative.Route53RecoveryControl.Inputs.SafetyRuleAssertionRuleArgs WithAssertedControls(this global::Pulumi.AwsNative.Route53RecoveryControl.Inputs.SafetyRuleAssertionRuleArgs @selfRef, global::System.Collections.Generic.List<global::System.String> assertedControls)
    {
        @selfRef.AssertedControls = assertedControls;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Route53RecoveryControl.Inputs.SafetyRuleAssertionRuleArgs WithAssertedControls(this global::Pulumi.AwsNative.Route53RecoveryControl.Inputs.SafetyRuleAssertionRuleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AssertedControls = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Route53RecoveryControl.Inputs.SafetyRuleAssertionRuleArgs WithAssertedControls(this global::Pulumi.AwsNative.Route53RecoveryControl.Inputs.SafetyRuleAssertionRuleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AssertedControls = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Route53RecoveryControl.Inputs.SafetyRuleAssertionRuleArgs WithWaitPeriodMs(this global::Pulumi.AwsNative.Route53RecoveryControl.Inputs.SafetyRuleAssertionRuleArgs @selfRef, global::System.Int32 waitPeriodMs)
    {
        @selfRef.WaitPeriodMs = waitPeriodMs;
        return @selfRef;
    }

}
