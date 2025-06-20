// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class ManagedIdentityCredentialArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.ManagedIdentityCredentialArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.ManagedIdentityCredentialArgs @selfRef, global::System.Collections.Generic.List<global::System.Object> annotations)
    {
        @selfRef.Annotations = annotations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ManagedIdentityCredentialArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.ManagedIdentityCredentialArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Object>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Object>();
        @configure(@list);
        @selfRef.Annotations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ManagedIdentityCredentialArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.ManagedIdentityCredentialArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Object>> @create)
    {
        @selfRef.Annotations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ManagedIdentityCredentialArgs WithDescription(this global::Pulumi.AzureNative.DataFactory.Inputs.ManagedIdentityCredentialArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ManagedIdentityCredentialArgs WithResourceId(this global::Pulumi.AzureNative.DataFactory.Inputs.ManagedIdentityCredentialArgs @selfRef, global::System.String resourceId)
    {
        @selfRef.ResourceId = resourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ManagedIdentityCredentialArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.ManagedIdentityCredentialArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
