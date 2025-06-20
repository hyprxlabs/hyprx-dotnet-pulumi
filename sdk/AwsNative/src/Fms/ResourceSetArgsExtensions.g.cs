// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Fms;

public static partial class ResourceSetArgsExtensions
{
    public static global::Pulumi.AwsNative.Fms.ResourceSetArgs WithDescription(this global::Pulumi.AwsNative.Fms.ResourceSetArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.ResourceSetArgs WithName(this global::Pulumi.AwsNative.Fms.ResourceSetArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.ResourceSetArgs WithResourceTypeList(this global::Pulumi.AwsNative.Fms.ResourceSetArgs @selfRef, global::System.Collections.Generic.List<global::System.String> resourceTypeList)
    {
        @selfRef.ResourceTypeList = resourceTypeList;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.ResourceSetArgs WithResourceTypeList(this global::Pulumi.AwsNative.Fms.ResourceSetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ResourceTypeList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.ResourceSetArgs WithResourceTypeList(this global::Pulumi.AwsNative.Fms.ResourceSetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ResourceTypeList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.ResourceSetArgs WithResources(this global::Pulumi.AwsNative.Fms.ResourceSetArgs @selfRef, global::System.Collections.Generic.List<global::System.String> resources)
    {
        @selfRef.Resources = resources;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.ResourceSetArgs WithResources(this global::Pulumi.AwsNative.Fms.ResourceSetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Resources = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.ResourceSetArgs WithResources(this global::Pulumi.AwsNative.Fms.ResourceSetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Resources = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.ResourceSetArgs WithTags(this global::Pulumi.AwsNative.Fms.ResourceSetArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.ResourceSetArgs WithTags(this global::Pulumi.AwsNative.Fms.ResourceSetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.ResourceSetArgs WithTags(this global::Pulumi.AwsNative.Fms.ResourceSetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
