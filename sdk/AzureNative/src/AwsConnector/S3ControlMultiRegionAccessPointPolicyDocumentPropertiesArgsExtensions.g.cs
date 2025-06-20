// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs WithArn(this global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs @selfRef, global::System.String arn)
    {
        @selfRef.Arn = arn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs WithAwsAccountId(this global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs @selfRef, global::System.String awsAccountId)
    {
        @selfRef.AwsAccountId = awsAccountId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs WithAwsProperties(this global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.AwsS3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs awsProperties)
    {
        @selfRef.AwsProperties = awsProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs WithAwsProperties(this global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.AwsS3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.AwsS3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs();
        @configure(@item);
        @selfRef.AwsProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs WithAwsRegion(this global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs @selfRef, global::System.String awsRegion)
    {
        @selfRef.AwsRegion = awsRegion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs WithAwsSourceSchema(this global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs @selfRef, global::System.String awsSourceSchema)
    {
        @selfRef.AwsSourceSchema = awsSourceSchema;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs WithAwsTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> awsTags)
    {
        @selfRef.AwsTags = awsTags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs WithAwsTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.AwsTags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs WithAwsTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.AwsTags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs WithPublicCloudConnectorsResourceId(this global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs @selfRef, global::System.String publicCloudConnectorsResourceId)
    {
        @selfRef.PublicCloudConnectorsResourceId = publicCloudConnectorsResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs WithPublicCloudResourceName(this global::Pulumi.AzureNative.AwsConnector.Inputs.S3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs @selfRef, global::System.String publicCloudResourceName)
    {
        @selfRef.PublicCloudResourceName = publicCloudResourceName;
        return @selfRef;
    }

}
