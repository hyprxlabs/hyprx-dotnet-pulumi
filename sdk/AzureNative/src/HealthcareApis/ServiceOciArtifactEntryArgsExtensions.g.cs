// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HealthcareApis.Inputs;

namespace Pulumi.AzureNative.HealthcareApis;

public static partial class ServiceOciArtifactEntryArgsExtensions
{
    public static global::Pulumi.AzureNative.HealthcareApis.Inputs.ServiceOciArtifactEntryArgs WithDigest(this global::Pulumi.AzureNative.HealthcareApis.Inputs.ServiceOciArtifactEntryArgs @selfRef, global::System.String digest)
    {
        @selfRef.Digest = digest;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HealthcareApis.Inputs.ServiceOciArtifactEntryArgs WithImageName(this global::Pulumi.AzureNative.HealthcareApis.Inputs.ServiceOciArtifactEntryArgs @selfRef, global::System.String imageName)
    {
        @selfRef.ImageName = imageName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HealthcareApis.Inputs.ServiceOciArtifactEntryArgs WithLoginServer(this global::Pulumi.AzureNative.HealthcareApis.Inputs.ServiceOciArtifactEntryArgs @selfRef, global::System.String loginServer)
    {
        @selfRef.LoginServer = loginServer;
        return @selfRef;
    }

}
