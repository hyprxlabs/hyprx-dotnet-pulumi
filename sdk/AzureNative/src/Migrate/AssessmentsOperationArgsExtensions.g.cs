// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Migrate;

public static partial class AssessmentsOperationArgsExtensions
{
    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithAssessmentName(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::System.String assessmentName)
    {
        @selfRef.AssessmentName = assessmentName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithAzureDiskTypes(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.AzureDiskType>> azureDiskTypes)
    {
        @selfRef.AzureDiskTypes = azureDiskTypes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithAzureDiskTypes(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.AzureDiskType>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.AzureDiskType>>();
        @configure(@list);
        @selfRef.AzureDiskTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithAzureDiskTypes(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.AzureDiskType>>> @create)
    {
        @selfRef.AzureDiskTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithAzureHybridUseBenefit(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.AzureHybridUseBenefit> azureHybridUseBenefit)
    {
        @selfRef.AzureHybridUseBenefit = azureHybridUseBenefit;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithAzureLocation(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::System.String azureLocation)
    {
        @selfRef.AzureLocation = azureLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithAzureOfferCode(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.AzureOfferCode> azureOfferCode)
    {
        @selfRef.AzureOfferCode = azureOfferCode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithAzurePricingTier(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.AzurePricingTier> azurePricingTier)
    {
        @selfRef.AzurePricingTier = azurePricingTier;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithAzureStorageRedundancy(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.AzureStorageRedundancy> azureStorageRedundancy)
    {
        @selfRef.AzureStorageRedundancy = azureStorageRedundancy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithAzureVmFamilies(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.AzureVmFamily>> azureVmFamilies)
    {
        @selfRef.AzureVmFamilies = azureVmFamilies;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithAzureVmFamilies(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.AzureVmFamily>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.AzureVmFamily>>();
        @configure(@list);
        @selfRef.AzureVmFamilies = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithAzureVmFamilies(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.AzureVmFamily>>> @create)
    {
        @selfRef.AzureVmFamilies = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithCurrency(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.AzureCurrency> currency)
    {
        @selfRef.Currency = currency;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithDiscountPercentage(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::System.Double discountPercentage)
    {
        @selfRef.DiscountPercentage = discountPercentage;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithEaSubscriptionId(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::System.String eaSubscriptionId)
    {
        @selfRef.EaSubscriptionId = eaSubscriptionId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithGroupName(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::System.String groupName)
    {
        @selfRef.GroupName = groupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithLinuxAzureHybridUseBenefit(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.AzureHybridUseBenefit> linuxAzureHybridUseBenefit)
    {
        @selfRef.LinuxAzureHybridUseBenefit = linuxAzureHybridUseBenefit;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithPercentile(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.Percentile> percentile)
    {
        @selfRef.Percentile = percentile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithPerfDataEndTime(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::System.String perfDataEndTime)
    {
        @selfRef.PerfDataEndTime = perfDataEndTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithPerfDataStartTime(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::System.String perfDataStartTime)
    {
        @selfRef.PerfDataStartTime = perfDataStartTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithProjectName(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::System.String projectName)
    {
        @selfRef.ProjectName = projectName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithProvisioningState(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.ProvisioningState> provisioningState)
    {
        @selfRef.ProvisioningState = provisioningState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithReservedInstance(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.AzureReservedInstance> reservedInstance)
    {
        @selfRef.ReservedInstance = reservedInstance;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithResourceGroupName(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithScalingFactor(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::System.Double scalingFactor)
    {
        @selfRef.ScalingFactor = scalingFactor;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithSizingCriterion(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.AssessmentSizingCriterion> sizingCriterion)
    {
        @selfRef.SizingCriterion = sizingCriterion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithTimeRange(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.TimeRange> timeRange)
    {
        @selfRef.TimeRange = timeRange;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithVmUptime(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::Pulumi.AzureNative.Migrate.Inputs.VmUptimeArgs vmUptime)
    {
        @selfRef.VmUptime = vmUptime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs WithVmUptime(this global::Pulumi.AzureNative.Migrate.AssessmentsOperationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Migrate.Inputs.VmUptimeArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Migrate.Inputs.VmUptimeArgs();
        @configure(@item);
        @selfRef.VmUptime = @item;
        return @selfRef;
    }

}
