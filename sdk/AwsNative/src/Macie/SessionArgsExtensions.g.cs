// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Macie;

public static partial class SessionArgsExtensions
{
    public static global::Pulumi.AwsNative.Macie.SessionArgs WithFindingPublishingFrequency(this global::Pulumi.AwsNative.Macie.SessionArgs @selfRef, global::Pulumi.AwsNative.Macie.SessionFindingPublishingFrequency findingPublishingFrequency)
    {
        @selfRef.FindingPublishingFrequency = findingPublishingFrequency;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Macie.SessionArgs WithFindingPublishingFrequency(this global::Pulumi.AwsNative.Macie.SessionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Macie.SessionFindingPublishingFrequency> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Macie.SessionFindingPublishingFrequency>();
        @configure(@item);
        @selfRef.FindingPublishingFrequency = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Macie.SessionArgs WithStatus(this global::Pulumi.AwsNative.Macie.SessionArgs @selfRef, global::Pulumi.AwsNative.Macie.SessionStatus status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Macie.SessionArgs WithStatus(this global::Pulumi.AwsNative.Macie.SessionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Macie.SessionStatus> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Macie.SessionStatus>();
        @configure(@item);
        @selfRef.Status = @item;
        return @selfRef;
    }

}
