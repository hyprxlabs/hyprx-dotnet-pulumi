// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Route53Profiles;

public static partial class ProfileAssociationArgsExtensions
{
    public static global::Pulumi.AwsNative.Route53Profiles.ProfileAssociationArgs WithArn(this global::Pulumi.AwsNative.Route53Profiles.ProfileAssociationArgs @selfRef, global::System.String arn)
    {
        @selfRef.Arn = arn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Route53Profiles.ProfileAssociationArgs WithName(this global::Pulumi.AwsNative.Route53Profiles.ProfileAssociationArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Route53Profiles.ProfileAssociationArgs WithProfileId(this global::Pulumi.AwsNative.Route53Profiles.ProfileAssociationArgs @selfRef, global::System.String profileId)
    {
        @selfRef.ProfileId = profileId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Route53Profiles.ProfileAssociationArgs WithResourceId(this global::Pulumi.AwsNative.Route53Profiles.ProfileAssociationArgs @selfRef, global::System.String resourceId)
    {
        @selfRef.ResourceId = resourceId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Route53Profiles.ProfileAssociationArgs WithTags(this global::Pulumi.AwsNative.Route53Profiles.ProfileAssociationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Route53Profiles.ProfileAssociationArgs WithTags(this global::Pulumi.AwsNative.Route53Profiles.ProfileAssociationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Route53Profiles.ProfileAssociationArgs WithTags(this global::Pulumi.AwsNative.Route53Profiles.ProfileAssociationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
