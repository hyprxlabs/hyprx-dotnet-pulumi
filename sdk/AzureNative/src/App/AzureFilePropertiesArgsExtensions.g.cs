// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.App.Inputs;

namespace Pulumi.AzureNative.App;

public static partial class AzureFilePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.App.Inputs.AzureFilePropertiesArgs WithAccessMode(this global::Pulumi.AzureNative.App.Inputs.AzureFilePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.App.AccessMode> accessMode)
    {
        @selfRef.AccessMode = accessMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.AzureFilePropertiesArgs WithAccountKey(this global::Pulumi.AzureNative.App.Inputs.AzureFilePropertiesArgs @selfRef, global::System.String accountKey)
    {
        @selfRef.AccountKey = accountKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.AzureFilePropertiesArgs WithAccountName(this global::Pulumi.AzureNative.App.Inputs.AzureFilePropertiesArgs @selfRef, global::System.String accountName)
    {
        @selfRef.AccountName = accountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.AzureFilePropertiesArgs WithShareName(this global::Pulumi.AzureNative.App.Inputs.AzureFilePropertiesArgs @selfRef, global::System.String shareName)
    {
        @selfRef.ShareName = shareName;
        return @selfRef;
    }

}
