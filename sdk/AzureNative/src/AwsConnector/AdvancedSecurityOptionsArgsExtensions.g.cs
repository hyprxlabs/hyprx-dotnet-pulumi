// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class AdvancedSecurityOptionsArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AdvancedSecurityOptionsArgs WithAnonymousAuthDisableDate(this global::Pulumi.AzureNative.AwsConnector.Inputs.AdvancedSecurityOptionsArgs @selfRef, global::System.String anonymousAuthDisableDate)
    {
        @selfRef.AnonymousAuthDisableDate = anonymousAuthDisableDate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AdvancedSecurityOptionsArgs WithAnonymousAuthEnabled(this global::Pulumi.AzureNative.AwsConnector.Inputs.AdvancedSecurityOptionsArgs @selfRef, bool anonymousAuthEnabled = true)
    {
        @selfRef.AnonymousAuthEnabled = anonymousAuthEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AdvancedSecurityOptionsArgs WithEnabled(this global::Pulumi.AzureNative.AwsConnector.Inputs.AdvancedSecurityOptionsArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AdvancedSecurityOptionsArgs WithInternalUserDatabaseEnabled(this global::Pulumi.AzureNative.AwsConnector.Inputs.AdvancedSecurityOptionsArgs @selfRef, bool internalUserDatabaseEnabled = true)
    {
        @selfRef.InternalUserDatabaseEnabled = internalUserDatabaseEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AdvancedSecurityOptionsArgs WithSamlOptions(this global::Pulumi.AzureNative.AwsConnector.Inputs.AdvancedSecurityOptionsArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.SAMLOptionsOutputArgs samlOptions)
    {
        @selfRef.SamlOptions = samlOptions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AdvancedSecurityOptionsArgs WithSamlOptions(this global::Pulumi.AzureNative.AwsConnector.Inputs.AdvancedSecurityOptionsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.SAMLOptionsOutputArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.SAMLOptionsOutputArgs();
        @configure(@item);
        @selfRef.SamlOptions = @item;
        return @selfRef;
    }

}
