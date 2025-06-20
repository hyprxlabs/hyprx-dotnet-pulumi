// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.OffAzure.Inputs;

namespace Pulumi.AzureNative.OffAzure;

public static partial class SiteSpnPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.OffAzure.Inputs.SiteSpnPropertiesArgs WithAadAuthority(this global::Pulumi.AzureNative.OffAzure.Inputs.SiteSpnPropertiesArgs @selfRef, global::System.String aadAuthority)
    {
        @selfRef.AadAuthority = aadAuthority;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.OffAzure.Inputs.SiteSpnPropertiesArgs WithApplicationId(this global::Pulumi.AzureNative.OffAzure.Inputs.SiteSpnPropertiesArgs @selfRef, global::System.String applicationId)
    {
        @selfRef.ApplicationId = applicationId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.OffAzure.Inputs.SiteSpnPropertiesArgs WithAudience(this global::Pulumi.AzureNative.OffAzure.Inputs.SiteSpnPropertiesArgs @selfRef, global::System.String audience)
    {
        @selfRef.Audience = audience;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.OffAzure.Inputs.SiteSpnPropertiesArgs WithObjectId(this global::Pulumi.AzureNative.OffAzure.Inputs.SiteSpnPropertiesArgs @selfRef, global::System.String objectId)
    {
        @selfRef.ObjectId = objectId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.OffAzure.Inputs.SiteSpnPropertiesArgs WithRawCertData(this global::Pulumi.AzureNative.OffAzure.Inputs.SiteSpnPropertiesArgs @selfRef, global::System.String rawCertData)
    {
        @selfRef.RawCertData = rawCertData;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.OffAzure.Inputs.SiteSpnPropertiesArgs WithTenantId(this global::Pulumi.AzureNative.OffAzure.Inputs.SiteSpnPropertiesArgs @selfRef, global::System.String tenantId)
    {
        @selfRef.TenantId = tenantId;
        return @selfRef;
    }

}
