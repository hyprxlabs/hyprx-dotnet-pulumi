// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class AwsS3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsS3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs WithEstablished(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsS3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.EstablishedMultiRegionAccessPointPolicyArgs established)
    {
        @selfRef.Established = established;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsS3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs WithEstablished(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsS3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.EstablishedMultiRegionAccessPointPolicyArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.EstablishedMultiRegionAccessPointPolicyArgs();
        @configure(@item);
        @selfRef.Established = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsS3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs WithProposed(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsS3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.ProposedMultiRegionAccessPointPolicyArgs proposed)
    {
        @selfRef.Proposed = proposed;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsS3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs WithProposed(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsS3ControlMultiRegionAccessPointPolicyDocumentPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.ProposedMultiRegionAccessPointPolicyArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.ProposedMultiRegionAccessPointPolicyArgs();
        @configure(@item);
        @selfRef.Proposed = @item;
        return @selfRef;
    }

}
