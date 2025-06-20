// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.QuickSight;

public static partial class ThemeArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.ThemeArgs WithAwsAccountId(this global::Pulumi.AwsNative.QuickSight.ThemeArgs @selfRef, global::System.String awsAccountId)
    {
        @selfRef.AwsAccountId = awsAccountId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.ThemeArgs WithBaseThemeId(this global::Pulumi.AwsNative.QuickSight.ThemeArgs @selfRef, global::System.String baseThemeId)
    {
        @selfRef.BaseThemeId = baseThemeId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.ThemeArgs WithConfiguration(this global::Pulumi.AwsNative.QuickSight.ThemeArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.ThemeConfigurationArgs configuration)
    {
        @selfRef.Configuration = configuration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.ThemeArgs WithConfiguration(this global::Pulumi.AwsNative.QuickSight.ThemeArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.ThemeConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.ThemeConfigurationArgs();
        @configure(@item);
        @selfRef.Configuration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.ThemeArgs WithName(this global::Pulumi.AwsNative.QuickSight.ThemeArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.ThemeArgs WithPermissions(this global::Pulumi.AwsNative.QuickSight.ThemeArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.ThemeResourcePermissionArgs> permissions)
    {
        @selfRef.Permissions = permissions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.ThemeArgs WithPermissions(this global::Pulumi.AwsNative.QuickSight.ThemeArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.ThemeResourcePermissionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.ThemeResourcePermissionArgs>();
        @configure(@list);
        @selfRef.Permissions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.ThemeArgs WithPermissions(this global::Pulumi.AwsNative.QuickSight.ThemeArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.ThemeResourcePermissionArgs>> @create)
    {
        @selfRef.Permissions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.ThemeArgs WithTags(this global::Pulumi.AwsNative.QuickSight.ThemeArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.ThemeArgs WithTags(this global::Pulumi.AwsNative.QuickSight.ThemeArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.ThemeArgs WithTags(this global::Pulumi.AwsNative.QuickSight.ThemeArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.ThemeArgs WithThemeId(this global::Pulumi.AwsNative.QuickSight.ThemeArgs @selfRef, global::System.String themeId)
    {
        @selfRef.ThemeId = themeId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.ThemeArgs WithVersionDescription(this global::Pulumi.AwsNative.QuickSight.ThemeArgs @selfRef, global::System.String versionDescription)
    {
        @selfRef.VersionDescription = versionDescription;
        return @selfRef;
    }

}
