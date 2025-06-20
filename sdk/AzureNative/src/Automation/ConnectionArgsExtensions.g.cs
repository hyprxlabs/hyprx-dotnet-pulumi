// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Automation;

public static partial class ConnectionArgsExtensions
{
    public static global::Pulumi.AzureNative.Automation.ConnectionArgs WithAutomationAccountName(this global::Pulumi.AzureNative.Automation.ConnectionArgs @selfRef, global::System.String automationAccountName)
    {
        @selfRef.AutomationAccountName = automationAccountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.ConnectionArgs WithConnectionName(this global::Pulumi.AzureNative.Automation.ConnectionArgs @selfRef, global::System.String connectionName)
    {
        @selfRef.ConnectionName = connectionName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.ConnectionArgs WithConnectionType(this global::Pulumi.AzureNative.Automation.ConnectionArgs @selfRef, global::Pulumi.AzureNative.Automation.Inputs.ConnectionTypeAssociationPropertyArgs connectionType)
    {
        @selfRef.ConnectionType = connectionType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.ConnectionArgs WithConnectionType(this global::Pulumi.AzureNative.Automation.ConnectionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Automation.Inputs.ConnectionTypeAssociationPropertyArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Automation.Inputs.ConnectionTypeAssociationPropertyArgs();
        @configure(@item);
        @selfRef.ConnectionType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.ConnectionArgs WithDescription(this global::Pulumi.AzureNative.Automation.ConnectionArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.ConnectionArgs WithFieldDefinitionValues(this global::Pulumi.AzureNative.Automation.ConnectionArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> fieldDefinitionValues)
    {
        @selfRef.FieldDefinitionValues = fieldDefinitionValues;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.ConnectionArgs WithFieldDefinitionValues(this global::Pulumi.AzureNative.Automation.ConnectionArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.FieldDefinitionValues = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.ConnectionArgs WithFieldDefinitionValues(this global::Pulumi.AzureNative.Automation.ConnectionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.FieldDefinitionValues = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.ConnectionArgs WithName(this global::Pulumi.AzureNative.Automation.ConnectionArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.ConnectionArgs WithResourceGroupName(this global::Pulumi.AzureNative.Automation.ConnectionArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

}
