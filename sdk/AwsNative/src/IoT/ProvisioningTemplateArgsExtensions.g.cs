// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.IoT;

public static partial class ProvisioningTemplateArgsExtensions
{
    public static global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs WithDescription(this global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs WithEnabled(this global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs WithPreProvisioningHook(this global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs @selfRef, global::Pulumi.AwsNative.IoT.Inputs.ProvisioningTemplateProvisioningHookArgs preProvisioningHook)
    {
        @selfRef.PreProvisioningHook = preProvisioningHook;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs WithPreProvisioningHook(this global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoT.Inputs.ProvisioningTemplateProvisioningHookArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoT.Inputs.ProvisioningTemplateProvisioningHookArgs();
        @configure(@item);
        @selfRef.PreProvisioningHook = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs WithProvisioningRoleArn(this global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs @selfRef, global::System.String provisioningRoleArn)
    {
        @selfRef.ProvisioningRoleArn = provisioningRoleArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs WithTags(this global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs WithTags(this global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs WithTags(this global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs WithTemplateBody(this global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs @selfRef, global::System.String templateBody)
    {
        @selfRef.TemplateBody = templateBody;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs WithTemplateName(this global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs @selfRef, global::System.String templateName)
    {
        @selfRef.TemplateName = templateName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs WithTemplateType(this global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs @selfRef, global::Pulumi.AwsNative.IoT.ProvisioningTemplateTemplateType templateType)
    {
        @selfRef.TemplateType = templateType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs WithTemplateType(this global::Pulumi.AwsNative.IoT.ProvisioningTemplateArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoT.ProvisioningTemplateTemplateType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.IoT.ProvisioningTemplateTemplateType>();
        @configure(@item);
        @selfRef.TemplateType = @item;
        return @selfRef;
    }

}
