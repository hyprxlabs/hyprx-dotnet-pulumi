// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Security.Inputs;

namespace Pulumi.AzureNative.Security;

public static partial class GcpProjectDetailsArgsExtensions
{
    public static global::Pulumi.AzureNative.Security.Inputs.GcpProjectDetailsArgs WithProjectId(this global::Pulumi.AzureNative.Security.Inputs.GcpProjectDetailsArgs @selfRef, global::System.String projectId)
    {
        @selfRef.ProjectId = projectId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.GcpProjectDetailsArgs WithProjectNumber(this global::Pulumi.AzureNative.Security.Inputs.GcpProjectDetailsArgs @selfRef, global::System.String projectNumber)
    {
        @selfRef.ProjectNumber = projectNumber;
        return @selfRef;
    }

}
