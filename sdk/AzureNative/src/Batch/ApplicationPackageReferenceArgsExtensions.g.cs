// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Batch.Inputs;

namespace Pulumi.AzureNative.Batch;

public static partial class ApplicationPackageReferenceArgsExtensions
{
    public static global::Pulumi.AzureNative.Batch.Inputs.ApplicationPackageReferenceArgs WithId(this global::Pulumi.AzureNative.Batch.Inputs.ApplicationPackageReferenceArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.ApplicationPackageReferenceArgs WithVersion(this global::Pulumi.AzureNative.Batch.Inputs.ApplicationPackageReferenceArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
