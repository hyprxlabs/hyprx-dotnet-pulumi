// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ses.Inputs;

namespace Pulumi.AwsNative.Ses;

public static partial class EmailIdentityMailFromAttributesArgsExtensions
{
    public static global::Pulumi.AwsNative.Ses.Inputs.EmailIdentityMailFromAttributesArgs WithBehaviorOnMxFailure(this global::Pulumi.AwsNative.Ses.Inputs.EmailIdentityMailFromAttributesArgs @selfRef, global::System.String behaviorOnMxFailure)
    {
        @selfRef.BehaviorOnMxFailure = behaviorOnMxFailure;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ses.Inputs.EmailIdentityMailFromAttributesArgs WithMailFromDomain(this global::Pulumi.AwsNative.Ses.Inputs.EmailIdentityMailFromAttributesArgs @selfRef, global::System.String mailFromDomain)
    {
        @selfRef.MailFromDomain = mailFromDomain;
        return @selfRef;
    }

}
