// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DevHub.Inputs;

namespace Pulumi.AzureNative.DevHub;

public static partial class IacTemplatePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.DevHub.Inputs.IacTemplatePropertiesArgs WithInstanceName(this global::Pulumi.AzureNative.DevHub.Inputs.IacTemplatePropertiesArgs @selfRef, global::System.String instanceName)
    {
        @selfRef.InstanceName = instanceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevHub.Inputs.IacTemplatePropertiesArgs WithInstanceStage(this global::Pulumi.AzureNative.DevHub.Inputs.IacTemplatePropertiesArgs @selfRef, global::System.String instanceStage)
    {
        @selfRef.InstanceStage = instanceStage;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevHub.Inputs.IacTemplatePropertiesArgs WithQuickStartTemplateType(this global::Pulumi.AzureNative.DevHub.Inputs.IacTemplatePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DevHub.QuickStartTemplateType> quickStartTemplateType)
    {
        @selfRef.QuickStartTemplateType = quickStartTemplateType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevHub.Inputs.IacTemplatePropertiesArgs WithSourceResourceId(this global::Pulumi.AzureNative.DevHub.Inputs.IacTemplatePropertiesArgs @selfRef, global::System.String sourceResourceId)
    {
        @selfRef.SourceResourceId = sourceResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevHub.Inputs.IacTemplatePropertiesArgs WithTemplateDetails(this global::Pulumi.AzureNative.DevHub.Inputs.IacTemplatePropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DevHub.Inputs.IacTemplateDetailsArgs> templateDetails)
    {
        @selfRef.TemplateDetails = templateDetails;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevHub.Inputs.IacTemplatePropertiesArgs WithTemplateDetails(this global::Pulumi.AzureNative.DevHub.Inputs.IacTemplatePropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DevHub.Inputs.IacTemplateDetailsArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DevHub.Inputs.IacTemplateDetailsArgs>();
        @configure(@list);
        @selfRef.TemplateDetails = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevHub.Inputs.IacTemplatePropertiesArgs WithTemplateDetails(this global::Pulumi.AzureNative.DevHub.Inputs.IacTemplatePropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DevHub.Inputs.IacTemplateDetailsArgs>> @create)
    {
        @selfRef.TemplateDetails = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevHub.Inputs.IacTemplatePropertiesArgs WithTemplateName(this global::Pulumi.AzureNative.DevHub.Inputs.IacTemplatePropertiesArgs @selfRef, global::System.String templateName)
    {
        @selfRef.TemplateName = templateName;
        return @selfRef;
    }

}
