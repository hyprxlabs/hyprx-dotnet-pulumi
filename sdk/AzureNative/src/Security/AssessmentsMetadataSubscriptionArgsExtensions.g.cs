// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Security;

public static partial class AssessmentsMetadataSubscriptionArgsExtensions
{
    public static global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs WithAssessmentMetadataName(this global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs @selfRef, global::System.String assessmentMetadataName)
    {
        @selfRef.AssessmentMetadataName = assessmentMetadataName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs WithAssessmentType(this global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Security.AssessmentType> assessmentType)
    {
        @selfRef.AssessmentType = assessmentType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs WithCategories(this global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Security.Categories>> categories)
    {
        @selfRef.Categories = categories;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs WithCategories(this global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Security.Categories>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Security.Categories>>();
        @configure(@list);
        @selfRef.Categories = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs WithCategories(this global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Security.Categories>>> @create)
    {
        @selfRef.Categories = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs WithDescription(this global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs WithDisplayName(this global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs @selfRef, global::System.String displayName)
    {
        @selfRef.DisplayName = displayName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs WithImplementationEffort(this global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Security.ImplementationEffort> implementationEffort)
    {
        @selfRef.ImplementationEffort = implementationEffort;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs WithPreview(this global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs @selfRef, bool preview = true)
    {
        @selfRef.Preview = preview;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs WithRemediationDescription(this global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs @selfRef, global::System.String remediationDescription)
    {
        @selfRef.RemediationDescription = remediationDescription;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs WithSeverity(this global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Security.Severity> severity)
    {
        @selfRef.Severity = severity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs WithThreats(this global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Security.Threats>> threats)
    {
        @selfRef.Threats = threats;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs WithThreats(this global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Security.Threats>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Security.Threats>>();
        @configure(@list);
        @selfRef.Threats = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs WithThreats(this global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Security.Threats>>> @create)
    {
        @selfRef.Threats = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs WithUserImpact(this global::Pulumi.AzureNative.Security.AssessmentsMetadataSubscriptionArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Security.UserImpact> userImpact)
    {
        @selfRef.UserImpact = userImpact;
        return @selfRef;
    }

}
