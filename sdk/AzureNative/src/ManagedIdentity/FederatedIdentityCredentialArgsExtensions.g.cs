// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ManagedIdentity;

public static partial class FederatedIdentityCredentialArgsExtensions
{
    public static global::Pulumi.AzureNative.ManagedIdentity.FederatedIdentityCredentialArgs WithAudiences(this global::Pulumi.AzureNative.ManagedIdentity.FederatedIdentityCredentialArgs @selfRef, global::System.Collections.Generic.List<global::System.String> audiences)
    {
        @selfRef.Audiences = audiences;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedIdentity.FederatedIdentityCredentialArgs WithAudiences(this global::Pulumi.AzureNative.ManagedIdentity.FederatedIdentityCredentialArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Audiences = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedIdentity.FederatedIdentityCredentialArgs WithAudiences(this global::Pulumi.AzureNative.ManagedIdentity.FederatedIdentityCredentialArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Audiences = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedIdentity.FederatedIdentityCredentialArgs WithFederatedIdentityCredentialResourceName(this global::Pulumi.AzureNative.ManagedIdentity.FederatedIdentityCredentialArgs @selfRef, global::System.String federatedIdentityCredentialResourceName)
    {
        @selfRef.FederatedIdentityCredentialResourceName = federatedIdentityCredentialResourceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedIdentity.FederatedIdentityCredentialArgs WithIssuer(this global::Pulumi.AzureNative.ManagedIdentity.FederatedIdentityCredentialArgs @selfRef, global::System.String issuer)
    {
        @selfRef.Issuer = issuer;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedIdentity.FederatedIdentityCredentialArgs WithResourceGroupName(this global::Pulumi.AzureNative.ManagedIdentity.FederatedIdentityCredentialArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedIdentity.FederatedIdentityCredentialArgs WithResourceName(this global::Pulumi.AzureNative.ManagedIdentity.FederatedIdentityCredentialArgs @selfRef, global::System.String resourceName)
    {
        @selfRef.ResourceName = resourceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedIdentity.FederatedIdentityCredentialArgs WithSubject(this global::Pulumi.AzureNative.ManagedIdentity.FederatedIdentityCredentialArgs @selfRef, global::System.String subject)
    {
        @selfRef.Subject = subject;
        return @selfRef;
    }

}
