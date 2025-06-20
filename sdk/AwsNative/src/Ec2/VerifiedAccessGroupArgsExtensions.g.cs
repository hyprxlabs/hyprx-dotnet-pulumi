// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ec2;

public static partial class VerifiedAccessGroupArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.VerifiedAccessGroupArgs WithDescription(this global::Pulumi.AwsNative.Ec2.VerifiedAccessGroupArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VerifiedAccessGroupArgs WithPolicyDocument(this global::Pulumi.AwsNative.Ec2.VerifiedAccessGroupArgs @selfRef, global::System.String policyDocument)
    {
        @selfRef.PolicyDocument = policyDocument;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VerifiedAccessGroupArgs WithPolicyEnabled(this global::Pulumi.AwsNative.Ec2.VerifiedAccessGroupArgs @selfRef, bool policyEnabled = true)
    {
        @selfRef.PolicyEnabled = policyEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VerifiedAccessGroupArgs WithSseSpecification(this global::Pulumi.AwsNative.Ec2.VerifiedAccessGroupArgs @selfRef, global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessGroupSseSpecificationArgs sseSpecification)
    {
        @selfRef.SseSpecification = sseSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VerifiedAccessGroupArgs WithSseSpecification(this global::Pulumi.AwsNative.Ec2.VerifiedAccessGroupArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessGroupSseSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessGroupSseSpecificationArgs();
        @configure(@item);
        @selfRef.SseSpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VerifiedAccessGroupArgs WithTags(this global::Pulumi.AwsNative.Ec2.VerifiedAccessGroupArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VerifiedAccessGroupArgs WithTags(this global::Pulumi.AwsNative.Ec2.VerifiedAccessGroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VerifiedAccessGroupArgs WithTags(this global::Pulumi.AwsNative.Ec2.VerifiedAccessGroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VerifiedAccessGroupArgs WithVerifiedAccessInstanceId(this global::Pulumi.AwsNative.Ec2.VerifiedAccessGroupArgs @selfRef, global::System.String verifiedAccessInstanceId)
    {
        @selfRef.VerifiedAccessInstanceId = verifiedAccessInstanceId;
        return @selfRef;
    }

}
