// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.EntityResolution.Inputs;

namespace Pulumi.AwsNative.EntityResolution;

public static partial class IdNamespaceIdMappingWorkflowPropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.EntityResolution.Inputs.IdNamespaceIdMappingWorkflowPropertiesArgs WithIdMappingType(this global::Pulumi.AwsNative.EntityResolution.Inputs.IdNamespaceIdMappingWorkflowPropertiesArgs @selfRef, global::Pulumi.AwsNative.EntityResolution.IdNamespaceIdMappingWorkflowPropertiesIdMappingType idMappingType)
    {
        @selfRef.IdMappingType = idMappingType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EntityResolution.Inputs.IdNamespaceIdMappingWorkflowPropertiesArgs WithIdMappingType(this global::Pulumi.AwsNative.EntityResolution.Inputs.IdNamespaceIdMappingWorkflowPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.EntityResolution.IdNamespaceIdMappingWorkflowPropertiesIdMappingType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.EntityResolution.IdNamespaceIdMappingWorkflowPropertiesIdMappingType>();
        @configure(@item);
        @selfRef.IdMappingType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EntityResolution.Inputs.IdNamespaceIdMappingWorkflowPropertiesArgs WithProviderProperties(this global::Pulumi.AwsNative.EntityResolution.Inputs.IdNamespaceIdMappingWorkflowPropertiesArgs @selfRef, global::Pulumi.AwsNative.EntityResolution.Inputs.IdNamespaceNamespaceProviderPropertiesArgs providerProperties)
    {
        @selfRef.ProviderProperties = providerProperties;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EntityResolution.Inputs.IdNamespaceIdMappingWorkflowPropertiesArgs WithProviderProperties(this global::Pulumi.AwsNative.EntityResolution.Inputs.IdNamespaceIdMappingWorkflowPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.EntityResolution.Inputs.IdNamespaceNamespaceProviderPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.EntityResolution.Inputs.IdNamespaceNamespaceProviderPropertiesArgs();
        @configure(@item);
        @selfRef.ProviderProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EntityResolution.Inputs.IdNamespaceIdMappingWorkflowPropertiesArgs WithRuleBasedProperties(this global::Pulumi.AwsNative.EntityResolution.Inputs.IdNamespaceIdMappingWorkflowPropertiesArgs @selfRef, global::Pulumi.AwsNative.EntityResolution.Inputs.IdNamespaceNamespaceRuleBasedPropertiesArgs ruleBasedProperties)
    {
        @selfRef.RuleBasedProperties = ruleBasedProperties;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EntityResolution.Inputs.IdNamespaceIdMappingWorkflowPropertiesArgs WithRuleBasedProperties(this global::Pulumi.AwsNative.EntityResolution.Inputs.IdNamespaceIdMappingWorkflowPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.EntityResolution.Inputs.IdNamespaceNamespaceRuleBasedPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.EntityResolution.Inputs.IdNamespaceNamespaceRuleBasedPropertiesArgs();
        @configure(@item);
        @selfRef.RuleBasedProperties = @item;
        return @selfRef;
    }

}
