// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Compute.Inputs;

namespace Pulumi.AzureNative.Compute;

public static partial class UserArtifactManageArgsExtensions
{
    public static global::Pulumi.AzureNative.Compute.Inputs.UserArtifactManageArgs WithInstall(this global::Pulumi.AzureNative.Compute.Inputs.UserArtifactManageArgs @selfRef, global::System.String install)
    {
        @selfRef.Install = install;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.UserArtifactManageArgs WithRemove(this global::Pulumi.AzureNative.Compute.Inputs.UserArtifactManageArgs @selfRef, global::System.String remove)
    {
        @selfRef.Remove = remove;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.UserArtifactManageArgs WithUpdate(this global::Pulumi.AzureNative.Compute.Inputs.UserArtifactManageArgs @selfRef, global::System.String update)
    {
        @selfRef.Update = update;
        return @selfRef;
    }

}
