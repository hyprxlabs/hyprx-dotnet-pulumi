// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ServiceFabric.Inputs;

namespace Pulumi.AzureNative.ServiceFabric;

public static partial class ServicePlacementInvalidDomainPolicyArgsExtensions
{
    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.ServicePlacementInvalidDomainPolicyArgs WithDomainName(this global::Pulumi.AzureNative.ServiceFabric.Inputs.ServicePlacementInvalidDomainPolicyArgs @selfRef, global::System.String domainName)
    {
        @selfRef.DomainName = domainName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.ServicePlacementInvalidDomainPolicyArgs WithType(this global::Pulumi.AzureNative.ServiceFabric.Inputs.ServicePlacementInvalidDomainPolicyArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
