// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Wisdom.Inputs;

namespace Pulumi.AwsNative.Wisdom;

public static partial class KnowledgeBaseAppIntegrationsConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Wisdom.Inputs.KnowledgeBaseAppIntegrationsConfigurationArgs WithAppIntegrationArn(this global::Pulumi.AwsNative.Wisdom.Inputs.KnowledgeBaseAppIntegrationsConfigurationArgs @selfRef, global::System.String appIntegrationArn)
    {
        @selfRef.AppIntegrationArn = appIntegrationArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.KnowledgeBaseAppIntegrationsConfigurationArgs WithObjectFields(this global::Pulumi.AwsNative.Wisdom.Inputs.KnowledgeBaseAppIntegrationsConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::System.String> objectFields)
    {
        @selfRef.ObjectFields = objectFields;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.KnowledgeBaseAppIntegrationsConfigurationArgs WithObjectFields(this global::Pulumi.AwsNative.Wisdom.Inputs.KnowledgeBaseAppIntegrationsConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ObjectFields = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.KnowledgeBaseAppIntegrationsConfigurationArgs WithObjectFields(this global::Pulumi.AwsNative.Wisdom.Inputs.KnowledgeBaseAppIntegrationsConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ObjectFields = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
