// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoT.Inputs;

namespace Pulumi.AwsNative.IoT;

public static partial class ThingAttributePayloadArgsExtensions
{
    public static global::Pulumi.AwsNative.IoT.Inputs.ThingAttributePayloadArgs WithAttributes(this global::Pulumi.AwsNative.IoT.Inputs.ThingAttributePayloadArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> attributes)
    {
        @selfRef.Attributes = attributes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.ThingAttributePayloadArgs WithAttributes(this global::Pulumi.AwsNative.IoT.Inputs.ThingAttributePayloadArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Attributes = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.ThingAttributePayloadArgs WithAttributes(this global::Pulumi.AwsNative.IoT.Inputs.ThingAttributePayloadArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Attributes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
