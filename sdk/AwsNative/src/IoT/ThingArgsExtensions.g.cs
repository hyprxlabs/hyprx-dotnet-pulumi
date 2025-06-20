// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.IoT;

public static partial class ThingArgsExtensions
{
    public static global::Pulumi.AwsNative.IoT.ThingArgs WithAttributePayload(this global::Pulumi.AwsNative.IoT.ThingArgs @selfRef, global::Pulumi.AwsNative.IoT.Inputs.ThingAttributePayloadArgs attributePayload)
    {
        @selfRef.AttributePayload = attributePayload;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.ThingArgs WithAttributePayload(this global::Pulumi.AwsNative.IoT.ThingArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoT.Inputs.ThingAttributePayloadArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoT.Inputs.ThingAttributePayloadArgs();
        @configure(@item);
        @selfRef.AttributePayload = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.ThingArgs WithThingName(this global::Pulumi.AwsNative.IoT.ThingArgs @selfRef, global::System.String thingName)
    {
        @selfRef.ThingName = thingName;
        return @selfRef;
    }

}
