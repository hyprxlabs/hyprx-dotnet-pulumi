// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class MacieAllowListPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs WithArn(this global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs @selfRef, global::System.String arn)
    {
        @selfRef.Arn = arn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs WithAwsAccountId(this global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs @selfRef, global::System.String awsAccountId)
    {
        @selfRef.AwsAccountId = awsAccountId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs WithAwsProperties(this global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacieAllowListPropertiesArgs awsProperties)
    {
        @selfRef.AwsProperties = awsProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs WithAwsProperties(this global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacieAllowListPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.AwsMacieAllowListPropertiesArgs();
        @configure(@item);
        @selfRef.AwsProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs WithAwsRegion(this global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs @selfRef, global::System.String awsRegion)
    {
        @selfRef.AwsRegion = awsRegion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs WithAwsSourceSchema(this global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs @selfRef, global::System.String awsSourceSchema)
    {
        @selfRef.AwsSourceSchema = awsSourceSchema;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs WithAwsTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> awsTags)
    {
        @selfRef.AwsTags = awsTags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs WithAwsTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.AwsTags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs WithAwsTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.AwsTags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs WithPublicCloudConnectorsResourceId(this global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs @selfRef, global::System.String publicCloudConnectorsResourceId)
    {
        @selfRef.PublicCloudConnectorsResourceId = publicCloudConnectorsResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs WithPublicCloudResourceName(this global::Pulumi.AzureNative.AwsConnector.Inputs.MacieAllowListPropertiesArgs @selfRef, global::System.String publicCloudResourceName)
    {
        @selfRef.PublicCloudResourceName = publicCloudResourceName;
        return @selfRef;
    }

}
