// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class FieldToMatchArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.FieldToMatchArgs WithMethod(this global::Pulumi.AzureNative.AwsConnector.Inputs.FieldToMatchArgs @selfRef, global::System.Object method)
    {
        @selfRef.Method = method;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.FieldToMatchArgs WithMethod(this global::Pulumi.AzureNative.AwsConnector.Inputs.FieldToMatchArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Method = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.FieldToMatchArgs WithQueryString(this global::Pulumi.AzureNative.AwsConnector.Inputs.FieldToMatchArgs @selfRef, global::System.Object queryString)
    {
        @selfRef.QueryString = queryString;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.FieldToMatchArgs WithQueryString(this global::Pulumi.AzureNative.AwsConnector.Inputs.FieldToMatchArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.QueryString = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.FieldToMatchArgs WithSingleHeader(this global::Pulumi.AzureNative.AwsConnector.Inputs.FieldToMatchArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.SingleHeaderModelPropertiesArgs singleHeader)
    {
        @selfRef.SingleHeader = singleHeader;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.FieldToMatchArgs WithSingleHeader(this global::Pulumi.AzureNative.AwsConnector.Inputs.FieldToMatchArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.SingleHeaderModelPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.SingleHeaderModelPropertiesArgs();
        @configure(@item);
        @selfRef.SingleHeader = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.FieldToMatchArgs WithUriPath(this global::Pulumi.AzureNative.AwsConnector.Inputs.FieldToMatchArgs @selfRef, global::System.Object uriPath)
    {
        @selfRef.UriPath = uriPath;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.FieldToMatchArgs WithUriPath(this global::Pulumi.AzureNative.AwsConnector.Inputs.FieldToMatchArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.UriPath = @item;
        return @selfRef;
    }

}
