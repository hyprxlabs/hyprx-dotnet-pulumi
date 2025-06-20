// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Sql;

public static partial class BackupLongTermRetentionPolicyArgsExtensions
{
    public static global::Pulumi.AzureNative.Sql.BackupLongTermRetentionPolicyArgs WithDatabaseName(this global::Pulumi.AzureNative.Sql.BackupLongTermRetentionPolicyArgs @selfRef, global::System.String databaseName)
    {
        @selfRef.DatabaseName = databaseName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.BackupLongTermRetentionPolicyArgs WithMonthlyRetention(this global::Pulumi.AzureNative.Sql.BackupLongTermRetentionPolicyArgs @selfRef, global::System.String monthlyRetention)
    {
        @selfRef.MonthlyRetention = monthlyRetention;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.BackupLongTermRetentionPolicyArgs WithPolicyName(this global::Pulumi.AzureNative.Sql.BackupLongTermRetentionPolicyArgs @selfRef, global::System.String policyName)
    {
        @selfRef.PolicyName = policyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.BackupLongTermRetentionPolicyArgs WithResourceGroupName(this global::Pulumi.AzureNative.Sql.BackupLongTermRetentionPolicyArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.BackupLongTermRetentionPolicyArgs WithServerName(this global::Pulumi.AzureNative.Sql.BackupLongTermRetentionPolicyArgs @selfRef, global::System.String serverName)
    {
        @selfRef.ServerName = serverName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.BackupLongTermRetentionPolicyArgs WithWeekOfYear(this global::Pulumi.AzureNative.Sql.BackupLongTermRetentionPolicyArgs @selfRef, global::System.Int32 weekOfYear)
    {
        @selfRef.WeekOfYear = weekOfYear;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.BackupLongTermRetentionPolicyArgs WithWeeklyRetention(this global::Pulumi.AzureNative.Sql.BackupLongTermRetentionPolicyArgs @selfRef, global::System.String weeklyRetention)
    {
        @selfRef.WeeklyRetention = weeklyRetention;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.BackupLongTermRetentionPolicyArgs WithYearlyRetention(this global::Pulumi.AzureNative.Sql.BackupLongTermRetentionPolicyArgs @selfRef, global::System.String yearlyRetention)
    {
        @selfRef.YearlyRetention = yearlyRetention;
        return @selfRef;
    }

}
