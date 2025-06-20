// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Migrate;

public static partial class AvsAssessmentsV2OperationArgsExtensions
{
    public static global::Pulumi.AzureNative.Migrate.AvsAssessmentsV2OperationArgs WithAssessmentName(this global::Pulumi.AzureNative.Migrate.AvsAssessmentsV2OperationArgs @selfRef, global::System.String assessmentName)
    {
        @selfRef.AssessmentName = assessmentName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AvsAssessmentsV2OperationArgs WithProjectName(this global::Pulumi.AzureNative.Migrate.AvsAssessmentsV2OperationArgs @selfRef, global::System.String projectName)
    {
        @selfRef.ProjectName = projectName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AvsAssessmentsV2OperationArgs WithProperties(this global::Pulumi.AzureNative.Migrate.AvsAssessmentsV2OperationArgs @selfRef, global::Pulumi.AzureNative.Migrate.Inputs.AvsAssessmentPropertiesV2Args properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AvsAssessmentsV2OperationArgs WithProperties(this global::Pulumi.AzureNative.Migrate.AvsAssessmentsV2OperationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Migrate.Inputs.AvsAssessmentPropertiesV2Args> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Migrate.Inputs.AvsAssessmentPropertiesV2Args();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AvsAssessmentsV2OperationArgs WithResourceGroupName(this global::Pulumi.AzureNative.Migrate.AvsAssessmentsV2OperationArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

}
