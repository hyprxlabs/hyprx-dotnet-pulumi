// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Wisdom.Inputs;

namespace Pulumi.AwsNative.Wisdom;

public static partial class AiAgentAssociationConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentAssociationConfigurationArgs WithAssociationConfigurationData(this global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentAssociationConfigurationArgs @selfRef, global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentAssociationConfigurationDataPropertiesArgs associationConfigurationData)
    {
        @selfRef.AssociationConfigurationData = associationConfigurationData;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentAssociationConfigurationArgs WithAssociationConfigurationData(this global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentAssociationConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentAssociationConfigurationDataPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentAssociationConfigurationDataPropertiesArgs();
        @configure(@item);
        @selfRef.AssociationConfigurationData = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentAssociationConfigurationArgs WithAssociationId(this global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentAssociationConfigurationArgs @selfRef, global::System.String associationId)
    {
        @selfRef.AssociationId = associationId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentAssociationConfigurationArgs WithAssociationType(this global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentAssociationConfigurationArgs @selfRef, global::Pulumi.AwsNative.Wisdom.AiAgentAiAgentAssociationConfigurationType associationType)
    {
        @selfRef.AssociationType = associationType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentAssociationConfigurationArgs WithAssociationType(this global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentAssociationConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Wisdom.AiAgentAiAgentAssociationConfigurationType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Wisdom.AiAgentAiAgentAssociationConfigurationType>();
        @configure(@item);
        @selfRef.AssociationType = @item;
        return @selfRef;
    }

}
