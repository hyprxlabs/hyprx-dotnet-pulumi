// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Dashboard.Inputs;

namespace Pulumi.AzureNative.Dashboard;

public static partial class SecurityArgsExtensions
{
    public static global::Pulumi.AzureNative.Dashboard.Inputs.SecurityArgs WithCsrfAlwaysCheck(this global::Pulumi.AzureNative.Dashboard.Inputs.SecurityArgs @selfRef, bool csrfAlwaysCheck = true)
    {
        @selfRef.CsrfAlwaysCheck = csrfAlwaysCheck;
        return @selfRef;
    }

}
