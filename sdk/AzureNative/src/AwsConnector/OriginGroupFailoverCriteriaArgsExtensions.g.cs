// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class OriginGroupFailoverCriteriaArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.OriginGroupFailoverCriteriaArgs WithStatusCodes(this global::Pulumi.AzureNative.AwsConnector.Inputs.OriginGroupFailoverCriteriaArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.StatusCodesArgs statusCodes)
    {
        @selfRef.StatusCodes = statusCodes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.OriginGroupFailoverCriteriaArgs WithStatusCodes(this global::Pulumi.AzureNative.AwsConnector.Inputs.OriginGroupFailoverCriteriaArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.StatusCodesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.StatusCodesArgs();
        @configure(@item);
        @selfRef.StatusCodes = @item;
        return @selfRef;
    }

}
