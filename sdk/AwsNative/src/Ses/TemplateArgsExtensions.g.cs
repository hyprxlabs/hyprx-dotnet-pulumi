// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ses.Inputs;

namespace Pulumi.AwsNative.Ses;

public static partial class TemplateArgsExtensions
{
    public static global::Pulumi.AwsNative.Ses.Inputs.TemplateArgs WithHtmlPart(this global::Pulumi.AwsNative.Ses.Inputs.TemplateArgs @selfRef, global::System.String htmlPart)
    {
        @selfRef.HtmlPart = htmlPart;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ses.Inputs.TemplateArgs WithSubjectPart(this global::Pulumi.AwsNative.Ses.Inputs.TemplateArgs @selfRef, global::System.String subjectPart)
    {
        @selfRef.SubjectPart = subjectPart;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ses.Inputs.TemplateArgs WithTemplateName(this global::Pulumi.AwsNative.Ses.Inputs.TemplateArgs @selfRef, global::System.String templateName)
    {
        @selfRef.TemplateName = templateName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ses.Inputs.TemplateArgs WithTextPart(this global::Pulumi.AwsNative.Ses.Inputs.TemplateArgs @selfRef, global::System.String textPart)
    {
        @selfRef.TextPart = textPart;
        return @selfRef;
    }

}
