// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ElasticBeanstalk.Inputs;

namespace Pulumi.AwsNative.ElasticBeanstalk;

public static partial class ApplicationMaxAgeRuleArgsExtensions
{
    public static global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ApplicationMaxAgeRuleArgs WithDeleteSourceFromS3(this global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ApplicationMaxAgeRuleArgs @selfRef, bool deleteSourceFromS3 = true)
    {
        @selfRef.DeleteSourceFromS3 = deleteSourceFromS3;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ApplicationMaxAgeRuleArgs WithEnabled(this global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ApplicationMaxAgeRuleArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ApplicationMaxAgeRuleArgs WithMaxAgeInDays(this global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ApplicationMaxAgeRuleArgs @selfRef, global::System.Int32 maxAgeInDays)
    {
        @selfRef.MaxAgeInDays = maxAgeInDays;
        return @selfRef;
    }

}
