// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Budgets.Inputs;

namespace Pulumi.AwsNative.Budgets;

public static partial class BudgetsActionSubscriberArgsExtensions
{
    public static global::Pulumi.AwsNative.Budgets.Inputs.BudgetsActionSubscriberArgs WithAddress(this global::Pulumi.AwsNative.Budgets.Inputs.BudgetsActionSubscriberArgs @selfRef, global::System.String address)
    {
        @selfRef.Address = address;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Budgets.Inputs.BudgetsActionSubscriberArgs WithType(this global::Pulumi.AwsNative.Budgets.Inputs.BudgetsActionSubscriberArgs @selfRef, global::Pulumi.AwsNative.Budgets.BudgetsActionSubscriberType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Budgets.Inputs.BudgetsActionSubscriberArgs WithType(this global::Pulumi.AwsNative.Budgets.Inputs.BudgetsActionSubscriberArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Budgets.BudgetsActionSubscriberType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Budgets.BudgetsActionSubscriberType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
