// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Sso.Inputs;

namespace Pulumi.AwsNative.Sso;

public static partial class PermissionSetPermissionsBoundaryArgsExtensions
{
    public static global::Pulumi.AwsNative.Sso.Inputs.PermissionSetPermissionsBoundaryArgs WithCustomerManagedPolicyReference(this global::Pulumi.AwsNative.Sso.Inputs.PermissionSetPermissionsBoundaryArgs @selfRef, global::Pulumi.AwsNative.Sso.Inputs.PermissionSetCustomerManagedPolicyReferenceArgs customerManagedPolicyReference)
    {
        @selfRef.CustomerManagedPolicyReference = customerManagedPolicyReference;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Sso.Inputs.PermissionSetPermissionsBoundaryArgs WithCustomerManagedPolicyReference(this global::Pulumi.AwsNative.Sso.Inputs.PermissionSetPermissionsBoundaryArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Sso.Inputs.PermissionSetCustomerManagedPolicyReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Sso.Inputs.PermissionSetCustomerManagedPolicyReferenceArgs();
        @configure(@item);
        @selfRef.CustomerManagedPolicyReference = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Sso.Inputs.PermissionSetPermissionsBoundaryArgs WithManagedPolicyArn(this global::Pulumi.AwsNative.Sso.Inputs.PermissionSetPermissionsBoundaryArgs @selfRef, global::System.String managedPolicyArn)
    {
        @selfRef.ManagedPolicyArn = managedPolicyArn;
        return @selfRef;
    }

}
