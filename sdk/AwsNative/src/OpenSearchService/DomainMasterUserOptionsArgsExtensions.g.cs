// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.OpenSearchService.Inputs;

namespace Pulumi.AwsNative.OpenSearchService;

public static partial class DomainMasterUserOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainMasterUserOptionsArgs WithMasterUserArn(this global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainMasterUserOptionsArgs @selfRef, global::System.String masterUserArn)
    {
        @selfRef.MasterUserArn = masterUserArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainMasterUserOptionsArgs WithMasterUserName(this global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainMasterUserOptionsArgs @selfRef, global::System.String masterUserName)
    {
        @selfRef.MasterUserName = masterUserName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainMasterUserOptionsArgs WithMasterUserPassword(this global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainMasterUserOptionsArgs @selfRef, global::System.String masterUserPassword)
    {
        @selfRef.MasterUserPassword = masterUserPassword;
        return @selfRef;
    }

}
