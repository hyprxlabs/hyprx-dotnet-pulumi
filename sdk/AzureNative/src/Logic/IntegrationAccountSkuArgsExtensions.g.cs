// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Logic.Inputs;

namespace Pulumi.AzureNative.Logic;

public static partial class IntegrationAccountSkuArgsExtensions
{
    public static global::Pulumi.AzureNative.Logic.Inputs.IntegrationAccountSkuArgs WithName(this global::Pulumi.AzureNative.Logic.Inputs.IntegrationAccountSkuArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Logic.IntegrationAccountSkuName> name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

}
