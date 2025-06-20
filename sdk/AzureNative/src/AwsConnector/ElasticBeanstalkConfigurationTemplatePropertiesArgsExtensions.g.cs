// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class ElasticBeanstalkConfigurationTemplatePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs WithArn(this global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs @selfRef, global::System.String arn)
    {
        @selfRef.Arn = arn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs WithAwsAccountId(this global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs @selfRef, global::System.String awsAccountId)
    {
        @selfRef.AwsAccountId = awsAccountId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs WithAwsProperties(this global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticBeanstalkConfigurationTemplatePropertiesArgs awsProperties)
    {
        @selfRef.AwsProperties = awsProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs WithAwsProperties(this global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticBeanstalkConfigurationTemplatePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticBeanstalkConfigurationTemplatePropertiesArgs();
        @configure(@item);
        @selfRef.AwsProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs WithAwsRegion(this global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs @selfRef, global::System.String awsRegion)
    {
        @selfRef.AwsRegion = awsRegion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs WithAwsSourceSchema(this global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs @selfRef, global::System.String awsSourceSchema)
    {
        @selfRef.AwsSourceSchema = awsSourceSchema;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs WithAwsTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> awsTags)
    {
        @selfRef.AwsTags = awsTags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs WithAwsTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.AwsTags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs WithAwsTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.AwsTags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs WithPublicCloudConnectorsResourceId(this global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs @selfRef, global::System.String publicCloudConnectorsResourceId)
    {
        @selfRef.PublicCloudConnectorsResourceId = publicCloudConnectorsResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs WithPublicCloudResourceName(this global::Pulumi.AzureNative.AwsConnector.Inputs.ElasticBeanstalkConfigurationTemplatePropertiesArgs @selfRef, global::System.String publicCloudResourceName)
    {
        @selfRef.PublicCloudResourceName = publicCloudResourceName;
        return @selfRef;
    }

}
