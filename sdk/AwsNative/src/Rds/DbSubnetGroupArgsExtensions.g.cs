// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Rds;

public static partial class DbSubnetGroupArgsExtensions
{
    public static global::Pulumi.AwsNative.Rds.DbSubnetGroupArgs WithDbSubnetGroupDescription(this global::Pulumi.AwsNative.Rds.DbSubnetGroupArgs @selfRef, global::System.String dbSubnetGroupDescription)
    {
        @selfRef.DbSubnetGroupDescription = dbSubnetGroupDescription;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbSubnetGroupArgs WithDbSubnetGroupName(this global::Pulumi.AwsNative.Rds.DbSubnetGroupArgs @selfRef, global::System.String dbSubnetGroupName)
    {
        @selfRef.DbSubnetGroupName = dbSubnetGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbSubnetGroupArgs WithSubnetIds(this global::Pulumi.AwsNative.Rds.DbSubnetGroupArgs @selfRef, global::System.Collections.Generic.List<global::System.String> subnetIds)
    {
        @selfRef.SubnetIds = subnetIds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbSubnetGroupArgs WithSubnetIds(this global::Pulumi.AwsNative.Rds.DbSubnetGroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SubnetIds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbSubnetGroupArgs WithSubnetIds(this global::Pulumi.AwsNative.Rds.DbSubnetGroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SubnetIds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbSubnetGroupArgs WithTags(this global::Pulumi.AwsNative.Rds.DbSubnetGroupArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbSubnetGroupArgs WithTags(this global::Pulumi.AwsNative.Rds.DbSubnetGroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbSubnetGroupArgs WithTags(this global::Pulumi.AwsNative.Rds.DbSubnetGroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
