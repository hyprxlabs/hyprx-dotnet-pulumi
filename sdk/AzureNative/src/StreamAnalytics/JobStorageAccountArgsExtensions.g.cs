// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.StreamAnalytics.Inputs;

namespace Pulumi.AzureNative.StreamAnalytics;

public static partial class JobStorageAccountArgsExtensions
{
    public static global::Pulumi.AzureNative.StreamAnalytics.Inputs.JobStorageAccountArgs WithAccountKey(this global::Pulumi.AzureNative.StreamAnalytics.Inputs.JobStorageAccountArgs @selfRef, global::System.String accountKey)
    {
        @selfRef.AccountKey = accountKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StreamAnalytics.Inputs.JobStorageAccountArgs WithAccountName(this global::Pulumi.AzureNative.StreamAnalytics.Inputs.JobStorageAccountArgs @selfRef, global::System.String accountName)
    {
        @selfRef.AccountName = accountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StreamAnalytics.Inputs.JobStorageAccountArgs WithAuthenticationMode(this global::Pulumi.AzureNative.StreamAnalytics.Inputs.JobStorageAccountArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.StreamAnalytics.AuthenticationMode> authenticationMode)
    {
        @selfRef.AuthenticationMode = authenticationMode;
        return @selfRef;
    }

}
