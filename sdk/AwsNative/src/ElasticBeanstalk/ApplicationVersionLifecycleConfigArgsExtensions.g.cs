// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ElasticBeanstalk.Inputs;

namespace Pulumi.AwsNative.ElasticBeanstalk;

public static partial class ApplicationVersionLifecycleConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ApplicationVersionLifecycleConfigArgs WithMaxAgeRule(this global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ApplicationVersionLifecycleConfigArgs @selfRef, global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ApplicationMaxAgeRuleArgs maxAgeRule)
    {
        @selfRef.MaxAgeRule = maxAgeRule;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ApplicationVersionLifecycleConfigArgs WithMaxAgeRule(this global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ApplicationVersionLifecycleConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ApplicationMaxAgeRuleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ApplicationMaxAgeRuleArgs();
        @configure(@item);
        @selfRef.MaxAgeRule = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ApplicationVersionLifecycleConfigArgs WithMaxCountRule(this global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ApplicationVersionLifecycleConfigArgs @selfRef, global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ApplicationMaxCountRuleArgs maxCountRule)
    {
        @selfRef.MaxCountRule = maxCountRule;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ApplicationVersionLifecycleConfigArgs WithMaxCountRule(this global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ApplicationVersionLifecycleConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ApplicationMaxCountRuleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ApplicationMaxCountRuleArgs();
        @configure(@item);
        @selfRef.MaxCountRule = @item;
        return @selfRef;
    }

}
