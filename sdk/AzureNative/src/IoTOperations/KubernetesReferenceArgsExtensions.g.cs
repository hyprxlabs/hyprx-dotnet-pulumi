// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.IoTOperations.Inputs;

namespace Pulumi.AzureNative.IoTOperations;

public static partial class KubernetesReferenceArgsExtensions
{
    public static global::Pulumi.AzureNative.IoTOperations.Inputs.KubernetesReferenceArgs WithApiGroup(this global::Pulumi.AzureNative.IoTOperations.Inputs.KubernetesReferenceArgs @selfRef, global::System.String apiGroup)
    {
        @selfRef.ApiGroup = apiGroup;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperations.Inputs.KubernetesReferenceArgs WithKind(this global::Pulumi.AzureNative.IoTOperations.Inputs.KubernetesReferenceArgs @selfRef, global::System.String kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperations.Inputs.KubernetesReferenceArgs WithName(this global::Pulumi.AzureNative.IoTOperations.Inputs.KubernetesReferenceArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperations.Inputs.KubernetesReferenceArgs WithNamespace(this global::Pulumi.AzureNative.IoTOperations.Inputs.KubernetesReferenceArgs @selfRef, global::System.String @namespace)
    {
        @selfRef.Namespace = @namespace;
        return @selfRef;
    }

}
