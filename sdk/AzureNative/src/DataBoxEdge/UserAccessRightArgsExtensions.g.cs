// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataBoxEdge.Inputs;

namespace Pulumi.AzureNative.DataBoxEdge;

public static partial class UserAccessRightArgsExtensions
{
    public static global::Pulumi.AzureNative.DataBoxEdge.Inputs.UserAccessRightArgs WithAccessType(this global::Pulumi.AzureNative.DataBoxEdge.Inputs.UserAccessRightArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DataBoxEdge.ShareAccessType> accessType)
    {
        @selfRef.AccessType = accessType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataBoxEdge.Inputs.UserAccessRightArgs WithUserId(this global::Pulumi.AzureNative.DataBoxEdge.Inputs.UserAccessRightArgs @selfRef, global::System.String userId)
    {
        @selfRef.UserId = userId;
        return @selfRef;
    }

}
