// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.IoT;

public static partial class ThingTypeArgsExtensions
{
    public static global::Pulumi.AwsNative.IoT.ThingTypeArgs WithDeprecateThingType(this global::Pulumi.AwsNative.IoT.ThingTypeArgs @selfRef, bool deprecateThingType = true)
    {
        @selfRef.DeprecateThingType = deprecateThingType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.ThingTypeArgs WithTags(this global::Pulumi.AwsNative.IoT.ThingTypeArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.ThingTypeArgs WithTags(this global::Pulumi.AwsNative.IoT.ThingTypeArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.ThingTypeArgs WithTags(this global::Pulumi.AwsNative.IoT.ThingTypeArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.ThingTypeArgs WithThingTypeName(this global::Pulumi.AwsNative.IoT.ThingTypeArgs @selfRef, global::System.String thingTypeName)
    {
        @selfRef.ThingTypeName = thingTypeName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.ThingTypeArgs WithThingTypeProperties(this global::Pulumi.AwsNative.IoT.ThingTypeArgs @selfRef, global::Pulumi.AwsNative.IoT.Inputs.ThingTypePropertiesPropertiesArgs thingTypeProperties)
    {
        @selfRef.ThingTypeProperties = thingTypeProperties;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.ThingTypeArgs WithThingTypeProperties(this global::Pulumi.AwsNative.IoT.ThingTypeArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoT.Inputs.ThingTypePropertiesPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoT.Inputs.ThingTypePropertiesPropertiesArgs();
        @configure(@item);
        @selfRef.ThingTypeProperties = @item;
        return @selfRef;
    }

}
