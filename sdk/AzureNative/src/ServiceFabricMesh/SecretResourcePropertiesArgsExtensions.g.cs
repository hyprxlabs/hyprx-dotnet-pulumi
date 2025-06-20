// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ServiceFabricMesh.Inputs;

namespace Pulumi.AzureNative.ServiceFabricMesh;

public static partial class SecretResourcePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.SecretResourcePropertiesArgs WithContentType(this global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.SecretResourcePropertiesArgs @selfRef, global::System.String contentType)
    {
        @selfRef.ContentType = contentType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.SecretResourcePropertiesArgs WithDescription(this global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.SecretResourcePropertiesArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.SecretResourcePropertiesArgs WithKind(this global::Pulumi.AzureNative.ServiceFabricMesh.Inputs.SecretResourcePropertiesArgs @selfRef, global::System.String kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

}
