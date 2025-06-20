// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.VirtualMachineImages.Inputs;

namespace Pulumi.AzureNative.VirtualMachineImages;

public static partial class ImageTemplateFileValidatorArgsExtensions
{
    public static global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplateFileValidatorArgs WithDestination(this global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplateFileValidatorArgs @selfRef, global::System.String destination)
    {
        @selfRef.Destination = destination;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplateFileValidatorArgs WithName(this global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplateFileValidatorArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplateFileValidatorArgs WithSha256Checksum(this global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplateFileValidatorArgs @selfRef, global::System.String sha256Checksum)
    {
        @selfRef.Sha256Checksum = sha256Checksum;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplateFileValidatorArgs WithSourceUri(this global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplateFileValidatorArgs @selfRef, global::System.String sourceUri)
    {
        @selfRef.SourceUri = sourceUri;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplateFileValidatorArgs WithType(this global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplateFileValidatorArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
