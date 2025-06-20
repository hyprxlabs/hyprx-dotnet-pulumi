// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ApiManagement;

public static partial class ApiPolicyArgsExtensions
{
    public static global::Pulumi.AzureNative.ApiManagement.ApiPolicyArgs WithApiId(this global::Pulumi.AzureNative.ApiManagement.ApiPolicyArgs @selfRef, global::System.String apiId)
    {
        @selfRef.ApiId = apiId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.ApiPolicyArgs WithFormat(this global::Pulumi.AzureNative.ApiManagement.ApiPolicyArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ApiManagement.PolicyContentFormat> format)
    {
        @selfRef.Format = format;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.ApiPolicyArgs WithPolicyId(this global::Pulumi.AzureNative.ApiManagement.ApiPolicyArgs @selfRef, global::System.String policyId)
    {
        @selfRef.PolicyId = policyId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.ApiPolicyArgs WithResourceGroupName(this global::Pulumi.AzureNative.ApiManagement.ApiPolicyArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.ApiPolicyArgs WithServiceName(this global::Pulumi.AzureNative.ApiManagement.ApiPolicyArgs @selfRef, global::System.String serviceName)
    {
        @selfRef.ServiceName = serviceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.ApiPolicyArgs WithValue(this global::Pulumi.AzureNative.ApiManagement.ApiPolicyArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
