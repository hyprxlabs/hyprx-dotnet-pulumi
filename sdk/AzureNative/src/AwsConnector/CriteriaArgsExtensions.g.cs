// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class CriteriaArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.CriteriaArgs WithRegex(this global::Pulumi.AzureNative.AwsConnector.Inputs.CriteriaArgs @selfRef, global::System.String regex)
    {
        @selfRef.Regex = regex;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.CriteriaArgs WithS3WordsList(this global::Pulumi.AzureNative.AwsConnector.Inputs.CriteriaArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.S3WordsListArgs s3WordsList)
    {
        @selfRef.S3WordsList = s3WordsList;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.CriteriaArgs WithS3WordsList(this global::Pulumi.AzureNative.AwsConnector.Inputs.CriteriaArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.S3WordsListArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.S3WordsListArgs();
        @configure(@item);
        @selfRef.S3WordsList = @item;
        return @selfRef;
    }

}
