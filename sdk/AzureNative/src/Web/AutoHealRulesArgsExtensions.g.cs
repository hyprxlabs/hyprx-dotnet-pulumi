// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Web.Inputs;

namespace Pulumi.AzureNative.Web;

public static partial class AutoHealRulesArgsExtensions
{
    public static global::Pulumi.AzureNative.Web.Inputs.AutoHealRulesArgs WithActions(this global::Pulumi.AzureNative.Web.Inputs.AutoHealRulesArgs @selfRef, global::Pulumi.AzureNative.Web.Inputs.AutoHealActionsArgs actions)
    {
        @selfRef.Actions = actions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.AutoHealRulesArgs WithActions(this global::Pulumi.AzureNative.Web.Inputs.AutoHealRulesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Web.Inputs.AutoHealActionsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Web.Inputs.AutoHealActionsArgs();
        @configure(@item);
        @selfRef.Actions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.AutoHealRulesArgs WithTriggers(this global::Pulumi.AzureNative.Web.Inputs.AutoHealRulesArgs @selfRef, global::Pulumi.AzureNative.Web.Inputs.AutoHealTriggersArgs triggers)
    {
        @selfRef.Triggers = triggers;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.AutoHealRulesArgs WithTriggers(this global::Pulumi.AzureNative.Web.Inputs.AutoHealRulesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Web.Inputs.AutoHealTriggersArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Web.Inputs.AutoHealTriggersArgs();
        @configure(@item);
        @selfRef.Triggers = @item;
        return @selfRef;
    }

}
