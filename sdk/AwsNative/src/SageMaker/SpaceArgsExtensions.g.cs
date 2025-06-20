// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.SageMaker;

public static partial class SpaceArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.SpaceArgs WithDomainId(this global::Pulumi.AwsNative.SageMaker.SpaceArgs @selfRef, global::System.String domainId)
    {
        @selfRef.DomainId = domainId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.SpaceArgs WithOwnershipSettings(this global::Pulumi.AwsNative.SageMaker.SpaceArgs @selfRef, global::Pulumi.AwsNative.SageMaker.Inputs.SpaceOwnershipSettingsArgs ownershipSettings)
    {
        @selfRef.OwnershipSettings = ownershipSettings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.SpaceArgs WithOwnershipSettings(this global::Pulumi.AwsNative.SageMaker.SpaceArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.Inputs.SpaceOwnershipSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.SageMaker.Inputs.SpaceOwnershipSettingsArgs();
        @configure(@item);
        @selfRef.OwnershipSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.SpaceArgs WithSpaceDisplayName(this global::Pulumi.AwsNative.SageMaker.SpaceArgs @selfRef, global::System.String spaceDisplayName)
    {
        @selfRef.SpaceDisplayName = spaceDisplayName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.SpaceArgs WithSpaceName(this global::Pulumi.AwsNative.SageMaker.SpaceArgs @selfRef, global::System.String spaceName)
    {
        @selfRef.SpaceName = spaceName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.SpaceArgs WithSpaceSettings(this global::Pulumi.AwsNative.SageMaker.SpaceArgs @selfRef, global::Pulumi.AwsNative.SageMaker.Inputs.SpaceSettingsArgs spaceSettings)
    {
        @selfRef.SpaceSettings = spaceSettings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.SpaceArgs WithSpaceSettings(this global::Pulumi.AwsNative.SageMaker.SpaceArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.Inputs.SpaceSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.SageMaker.Inputs.SpaceSettingsArgs();
        @configure(@item);
        @selfRef.SpaceSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.SpaceArgs WithSpaceSharingSettings(this global::Pulumi.AwsNative.SageMaker.SpaceArgs @selfRef, global::Pulumi.AwsNative.SageMaker.Inputs.SpaceSharingSettingsArgs spaceSharingSettings)
    {
        @selfRef.SpaceSharingSettings = spaceSharingSettings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.SpaceArgs WithSpaceSharingSettings(this global::Pulumi.AwsNative.SageMaker.SpaceArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.Inputs.SpaceSharingSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.SageMaker.Inputs.SpaceSharingSettingsArgs();
        @configure(@item);
        @selfRef.SpaceSharingSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.SpaceArgs WithTags(this global::Pulumi.AwsNative.SageMaker.SpaceArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.SpaceArgs WithTags(this global::Pulumi.AwsNative.SageMaker.SpaceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.SpaceArgs WithTags(this global::Pulumi.AwsNative.SageMaker.SpaceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
