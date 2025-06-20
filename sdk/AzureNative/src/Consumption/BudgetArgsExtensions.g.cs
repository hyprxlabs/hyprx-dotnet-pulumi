// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Consumption;

public static partial class BudgetArgsExtensions
{
    public static global::Pulumi.AzureNative.Consumption.BudgetArgs WithAmount(this global::Pulumi.AzureNative.Consumption.BudgetArgs @selfRef, global::System.Double amount)
    {
        @selfRef.Amount = amount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Consumption.BudgetArgs WithBudgetName(this global::Pulumi.AzureNative.Consumption.BudgetArgs @selfRef, global::System.String budgetName)
    {
        @selfRef.BudgetName = budgetName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Consumption.BudgetArgs WithCategory(this global::Pulumi.AzureNative.Consumption.BudgetArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Consumption.CategoryType> category)
    {
        @selfRef.Category = category;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Consumption.BudgetArgs WithETag(this global::Pulumi.AzureNative.Consumption.BudgetArgs @selfRef, global::System.String eTag)
    {
        @selfRef.ETag = eTag;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Consumption.BudgetArgs WithFilter(this global::Pulumi.AzureNative.Consumption.BudgetArgs @selfRef, global::Pulumi.AzureNative.Consumption.Inputs.BudgetFilterArgs filter)
    {
        @selfRef.Filter = filter;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Consumption.BudgetArgs WithFilter(this global::Pulumi.AzureNative.Consumption.BudgetArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Consumption.Inputs.BudgetFilterArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Consumption.Inputs.BudgetFilterArgs();
        @configure(@item);
        @selfRef.Filter = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Consumption.BudgetArgs WithNotifications(this global::Pulumi.AzureNative.Consumption.BudgetArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.Consumption.Inputs.NotificationArgs> notifications)
    {
        @selfRef.Notifications = notifications;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Consumption.BudgetArgs WithNotifications(this global::Pulumi.AzureNative.Consumption.BudgetArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.Consumption.Inputs.NotificationArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.Consumption.Inputs.NotificationArgs>();
        @configure(@dict);
        @selfRef.Notifications = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Consumption.BudgetArgs WithNotifications(this global::Pulumi.AzureNative.Consumption.BudgetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AzureNative.Consumption.Inputs.NotificationArgs>> @create)
    {
        @selfRef.Notifications = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Consumption.BudgetArgs WithScope(this global::Pulumi.AzureNative.Consumption.BudgetArgs @selfRef, global::System.String scope)
    {
        @selfRef.Scope = scope;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Consumption.BudgetArgs WithTimeGrain(this global::Pulumi.AzureNative.Consumption.BudgetArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Consumption.TimeGrainType> timeGrain)
    {
        @selfRef.TimeGrain = timeGrain;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Consumption.BudgetArgs WithTimePeriod(this global::Pulumi.AzureNative.Consumption.BudgetArgs @selfRef, global::Pulumi.AzureNative.Consumption.Inputs.BudgetTimePeriodArgs timePeriod)
    {
        @selfRef.TimePeriod = timePeriod;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Consumption.BudgetArgs WithTimePeriod(this global::Pulumi.AzureNative.Consumption.BudgetArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Consumption.Inputs.BudgetTimePeriodArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Consumption.Inputs.BudgetTimePeriodArgs();
        @configure(@item);
        @selfRef.TimePeriod = @item;
        return @selfRef;
    }

}
