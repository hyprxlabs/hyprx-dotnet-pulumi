// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Security.Inputs;

namespace Pulumi.AzureNative.Security;

public static partial class AutomationTriggeringRuleArgsExtensions
{
    public static global::Pulumi.AzureNative.Security.Inputs.AutomationTriggeringRuleArgs WithExpectedValue(this global::Pulumi.AzureNative.Security.Inputs.AutomationTriggeringRuleArgs @selfRef, global::System.String expectedValue)
    {
        @selfRef.ExpectedValue = expectedValue;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.AutomationTriggeringRuleArgs WithOperator(this global::Pulumi.AzureNative.Security.Inputs.AutomationTriggeringRuleArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Security.Operator> @operator)
    {
        @selfRef.Operator = @operator;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.AutomationTriggeringRuleArgs WithPropertyJPath(this global::Pulumi.AzureNative.Security.Inputs.AutomationTriggeringRuleArgs @selfRef, global::System.String propertyJPath)
    {
        @selfRef.PropertyJPath = propertyJPath;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.AutomationTriggeringRuleArgs WithPropertyType(this global::Pulumi.AzureNative.Security.Inputs.AutomationTriggeringRuleArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Security.PropertyType> propertyType)
    {
        @selfRef.PropertyType = propertyType;
        return @selfRef;
    }

}
