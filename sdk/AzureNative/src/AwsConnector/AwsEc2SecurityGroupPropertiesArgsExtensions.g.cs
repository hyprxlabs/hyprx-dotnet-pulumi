// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class AwsEc2SecurityGroupPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs WithDescription(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs WithGroupId(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs @selfRef, global::System.String groupId)
    {
        @selfRef.GroupId = groupId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs WithGroupName(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs @selfRef, global::System.String groupName)
    {
        @selfRef.GroupName = groupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs WithIpPermissions(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.IpPermissionArgs> ipPermissions)
    {
        @selfRef.IpPermissions = ipPermissions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs WithIpPermissions(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.IpPermissionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.IpPermissionArgs>();
        @configure(@list);
        @selfRef.IpPermissions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs WithIpPermissions(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.IpPermissionArgs>> @create)
    {
        @selfRef.IpPermissions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs WithIpPermissionsEgress(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.IpPermissionArgs> ipPermissionsEgress)
    {
        @selfRef.IpPermissionsEgress = ipPermissionsEgress;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs WithIpPermissionsEgress(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.IpPermissionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.IpPermissionArgs>();
        @configure(@list);
        @selfRef.IpPermissionsEgress = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs WithIpPermissionsEgress(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.IpPermissionArgs>> @create)
    {
        @selfRef.IpPermissionsEgress = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs WithOwnerId(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs @selfRef, global::System.String ownerId)
    {
        @selfRef.OwnerId = ownerId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs WithVpcId(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEc2SecurityGroupPropertiesArgs @selfRef, global::System.String vpcId)
    {
        @selfRef.VpcId = vpcId;
        return @selfRef;
    }

}
