// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AppComplianceAutomation;

public static partial class EvidenceArgsExtensions
{
    public static global::Pulumi.AzureNative.AppComplianceAutomation.EvidenceArgs WithControlId(this global::Pulumi.AzureNative.AppComplianceAutomation.EvidenceArgs @selfRef, global::System.String controlId)
    {
        @selfRef.ControlId = controlId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppComplianceAutomation.EvidenceArgs WithEvidenceName(this global::Pulumi.AzureNative.AppComplianceAutomation.EvidenceArgs @selfRef, global::System.String evidenceName)
    {
        @selfRef.EvidenceName = evidenceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppComplianceAutomation.EvidenceArgs WithEvidenceType(this global::Pulumi.AzureNative.AppComplianceAutomation.EvidenceArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AppComplianceAutomation.EvidenceType> evidenceType)
    {
        @selfRef.EvidenceType = evidenceType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppComplianceAutomation.EvidenceArgs WithExtraData(this global::Pulumi.AzureNative.AppComplianceAutomation.EvidenceArgs @selfRef, global::System.String extraData)
    {
        @selfRef.ExtraData = extraData;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppComplianceAutomation.EvidenceArgs WithFilePath(this global::Pulumi.AzureNative.AppComplianceAutomation.EvidenceArgs @selfRef, global::System.String filePath)
    {
        @selfRef.FilePath = filePath;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppComplianceAutomation.EvidenceArgs WithOfferGuid(this global::Pulumi.AzureNative.AppComplianceAutomation.EvidenceArgs @selfRef, global::System.String offerGuid)
    {
        @selfRef.OfferGuid = offerGuid;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppComplianceAutomation.EvidenceArgs WithReportCreatorTenantId(this global::Pulumi.AzureNative.AppComplianceAutomation.EvidenceArgs @selfRef, global::System.String reportCreatorTenantId)
    {
        @selfRef.ReportCreatorTenantId = reportCreatorTenantId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppComplianceAutomation.EvidenceArgs WithReportName(this global::Pulumi.AzureNative.AppComplianceAutomation.EvidenceArgs @selfRef, global::System.String reportName)
    {
        @selfRef.ReportName = reportName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppComplianceAutomation.EvidenceArgs WithResponsibilityId(this global::Pulumi.AzureNative.AppComplianceAutomation.EvidenceArgs @selfRef, global::System.String responsibilityId)
    {
        @selfRef.ResponsibilityId = responsibilityId;
        return @selfRef;
    }

}
