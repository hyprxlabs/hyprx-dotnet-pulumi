// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.MemoryDb;

public static partial class SubnetGroupArgsExtensions
{
    public static global::Pulumi.AwsNative.MemoryDb.SubnetGroupArgs WithDescription(this global::Pulumi.AwsNative.MemoryDb.SubnetGroupArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MemoryDb.SubnetGroupArgs WithSubnetGroupName(this global::Pulumi.AwsNative.MemoryDb.SubnetGroupArgs @selfRef, global::System.String subnetGroupName)
    {
        @selfRef.SubnetGroupName = subnetGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MemoryDb.SubnetGroupArgs WithSubnetIds(this global::Pulumi.AwsNative.MemoryDb.SubnetGroupArgs @selfRef, global::System.Collections.Generic.List<global::System.String> subnetIds)
    {
        @selfRef.SubnetIds = subnetIds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MemoryDb.SubnetGroupArgs WithSubnetIds(this global::Pulumi.AwsNative.MemoryDb.SubnetGroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SubnetIds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MemoryDb.SubnetGroupArgs WithSubnetIds(this global::Pulumi.AwsNative.MemoryDb.SubnetGroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SubnetIds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MemoryDb.SubnetGroupArgs WithTags(this global::Pulumi.AwsNative.MemoryDb.SubnetGroupArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MemoryDb.SubnetGroupArgs WithTags(this global::Pulumi.AwsNative.MemoryDb.SubnetGroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MemoryDb.SubnetGroupArgs WithTags(this global::Pulumi.AwsNative.MemoryDb.SubnetGroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
