// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class RdsExportTaskPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs WithArn(this global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs @selfRef, global::System.String arn)
    {
        @selfRef.Arn = arn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs WithAwsAccountId(this global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs @selfRef, global::System.String awsAccountId)
    {
        @selfRef.AwsAccountId = awsAccountId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs WithAwsProperties(this global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRdsExportTaskPropertiesArgs awsProperties)
    {
        @selfRef.AwsProperties = awsProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs WithAwsProperties(this global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRdsExportTaskPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.AwsRdsExportTaskPropertiesArgs();
        @configure(@item);
        @selfRef.AwsProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs WithAwsRegion(this global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs @selfRef, global::System.String awsRegion)
    {
        @selfRef.AwsRegion = awsRegion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs WithAwsSourceSchema(this global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs @selfRef, global::System.String awsSourceSchema)
    {
        @selfRef.AwsSourceSchema = awsSourceSchema;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs WithAwsTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> awsTags)
    {
        @selfRef.AwsTags = awsTags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs WithAwsTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.AwsTags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs WithAwsTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.AwsTags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs WithPublicCloudConnectorsResourceId(this global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs @selfRef, global::System.String publicCloudConnectorsResourceId)
    {
        @selfRef.PublicCloudConnectorsResourceId = publicCloudConnectorsResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs WithPublicCloudResourceName(this global::Pulumi.AzureNative.AwsConnector.Inputs.RdsExportTaskPropertiesArgs @selfRef, global::System.String publicCloudResourceName)
    {
        @selfRef.PublicCloudResourceName = publicCloudResourceName;
        return @selfRef;
    }

}
