// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.WaFv2.Inputs;

namespace Pulumi.AwsNative.WaFv2;

public static partial class WebAclTextTransformationArgsExtensions
{
    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclTextTransformationArgs WithPriority(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclTextTransformationArgs @selfRef, global::System.Int32 priority)
    {
        @selfRef.Priority = priority;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclTextTransformationArgs WithType(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclTextTransformationArgs @selfRef, global::Pulumi.AwsNative.WaFv2.WebAclTextTransformationType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclTextTransformationArgs WithType(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclTextTransformationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.WaFv2.WebAclTextTransformationType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.WaFv2.WebAclTextTransformationType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
