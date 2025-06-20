// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class Ec2VolumePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs WithArn(this global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs @selfRef, global::System.String arn)
    {
        @selfRef.Arn = arn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs WithAwsAccountId(this global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs @selfRef, global::System.String awsAccountId)
    {
        @selfRef.AwsAccountId = awsAccountId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs WithAwsProperties(this global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2VolumePropertiesArgs awsProperties)
    {
        @selfRef.AwsProperties = awsProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs WithAwsProperties(this global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2VolumePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2VolumePropertiesArgs();
        @configure(@item);
        @selfRef.AwsProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs WithAwsRegion(this global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs @selfRef, global::System.String awsRegion)
    {
        @selfRef.AwsRegion = awsRegion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs WithAwsSourceSchema(this global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs @selfRef, global::System.String awsSourceSchema)
    {
        @selfRef.AwsSourceSchema = awsSourceSchema;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs WithAwsTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> awsTags)
    {
        @selfRef.AwsTags = awsTags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs WithAwsTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.AwsTags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs WithAwsTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.AwsTags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs WithPublicCloudConnectorsResourceId(this global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs @selfRef, global::System.String publicCloudConnectorsResourceId)
    {
        @selfRef.PublicCloudConnectorsResourceId = publicCloudConnectorsResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs WithPublicCloudResourceName(this global::Pulumi.AzureNative.AwsConnector.Inputs.Ec2VolumePropertiesArgs @selfRef, global::System.String publicCloudResourceName)
    {
        @selfRef.PublicCloudResourceName = publicCloudResourceName;
        return @selfRef;
    }

}
