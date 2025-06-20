// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.EventGrid.Inputs;

namespace Pulumi.AzureNative.EventGrid;

public static partial class MonitorAlertEventSubscriptionDestinationArgsExtensions
{
    public static global::Pulumi.AzureNative.EventGrid.Inputs.MonitorAlertEventSubscriptionDestinationArgs WithActionGroups(this global::Pulumi.AzureNative.EventGrid.Inputs.MonitorAlertEventSubscriptionDestinationArgs @selfRef, global::System.Collections.Generic.List<global::System.String> actionGroups)
    {
        @selfRef.ActionGroups = actionGroups;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.MonitorAlertEventSubscriptionDestinationArgs WithActionGroups(this global::Pulumi.AzureNative.EventGrid.Inputs.MonitorAlertEventSubscriptionDestinationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ActionGroups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.MonitorAlertEventSubscriptionDestinationArgs WithActionGroups(this global::Pulumi.AzureNative.EventGrid.Inputs.MonitorAlertEventSubscriptionDestinationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ActionGroups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.MonitorAlertEventSubscriptionDestinationArgs WithDescription(this global::Pulumi.AzureNative.EventGrid.Inputs.MonitorAlertEventSubscriptionDestinationArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.MonitorAlertEventSubscriptionDestinationArgs WithEndpointType(this global::Pulumi.AzureNative.EventGrid.Inputs.MonitorAlertEventSubscriptionDestinationArgs @selfRef, global::System.String endpointType)
    {
        @selfRef.EndpointType = endpointType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.MonitorAlertEventSubscriptionDestinationArgs WithSeverity(this global::Pulumi.AzureNative.EventGrid.Inputs.MonitorAlertEventSubscriptionDestinationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.EventGrid.MonitorAlertSeverity> severity)
    {
        @selfRef.Severity = severity;
        return @selfRef;
    }

}
