// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ElasticBeanstalk.Inputs;

namespace Pulumi.AwsNative.ElasticBeanstalk;

public static partial class ConfigurationTemplateSourceConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ConfigurationTemplateSourceConfigurationArgs WithApplicationName(this global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ConfigurationTemplateSourceConfigurationArgs @selfRef, global::System.String applicationName)
    {
        @selfRef.ApplicationName = applicationName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ConfigurationTemplateSourceConfigurationArgs WithTemplateName(this global::Pulumi.AwsNative.ElasticBeanstalk.Inputs.ConfigurationTemplateSourceConfigurationArgs @selfRef, global::System.String templateName)
    {
        @selfRef.TemplateName = templateName;
        return @selfRef;
    }

}
