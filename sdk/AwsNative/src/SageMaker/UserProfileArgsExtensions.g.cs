// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.SageMaker;

public static partial class UserProfileArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.UserProfileArgs WithDomainId(this global::Pulumi.AwsNative.SageMaker.UserProfileArgs @selfRef, global::System.String domainId)
    {
        @selfRef.DomainId = domainId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.UserProfileArgs WithSingleSignOnUserIdentifier(this global::Pulumi.AwsNative.SageMaker.UserProfileArgs @selfRef, global::System.String singleSignOnUserIdentifier)
    {
        @selfRef.SingleSignOnUserIdentifier = singleSignOnUserIdentifier;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.UserProfileArgs WithSingleSignOnUserValue(this global::Pulumi.AwsNative.SageMaker.UserProfileArgs @selfRef, global::System.String singleSignOnUserValue)
    {
        @selfRef.SingleSignOnUserValue = singleSignOnUserValue;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.UserProfileArgs WithTags(this global::Pulumi.AwsNative.SageMaker.UserProfileArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.CreateOnlyTagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.UserProfileArgs WithTags(this global::Pulumi.AwsNative.SageMaker.UserProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.CreateOnlyTagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.CreateOnlyTagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.UserProfileArgs WithTags(this global::Pulumi.AwsNative.SageMaker.UserProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.CreateOnlyTagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.UserProfileArgs WithUserProfileName(this global::Pulumi.AwsNative.SageMaker.UserProfileArgs @selfRef, global::System.String userProfileName)
    {
        @selfRef.UserProfileName = userProfileName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.UserProfileArgs WithUserSettings(this global::Pulumi.AwsNative.SageMaker.UserProfileArgs @selfRef, global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileUserSettingsArgs userSettings)
    {
        @selfRef.UserSettings = userSettings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.UserProfileArgs WithUserSettings(this global::Pulumi.AwsNative.SageMaker.UserProfileArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileUserSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileUserSettingsArgs();
        @configure(@item);
        @selfRef.UserSettings = @item;
        return @selfRef;
    }

}
