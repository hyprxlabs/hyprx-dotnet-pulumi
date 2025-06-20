// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ec2.Inputs;

namespace Pulumi.AwsNative.Ec2;

public static partial class Ec2FleetTagSpecificationArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetTagSpecificationArgs WithResourceType(this global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetTagSpecificationArgs @selfRef, global::Pulumi.AwsNative.Ec2.Ec2FleetTagSpecificationResourceType resourceType)
    {
        @selfRef.ResourceType = resourceType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetTagSpecificationArgs WithResourceType(this global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetTagSpecificationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.Ec2FleetTagSpecificationResourceType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Ec2.Ec2FleetTagSpecificationResourceType>();
        @configure(@item);
        @selfRef.ResourceType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetTagSpecificationArgs WithTags(this global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetTagSpecificationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetTagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetTagSpecificationArgs WithTags(this global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetTagSpecificationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetTagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetTagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetTagSpecificationArgs WithTags(this global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetTagSpecificationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetTagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
