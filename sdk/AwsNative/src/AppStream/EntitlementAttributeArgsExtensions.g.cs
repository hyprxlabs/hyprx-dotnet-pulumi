// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AppStream.Inputs;

namespace Pulumi.AwsNative.AppStream;

public static partial class EntitlementAttributeArgsExtensions
{
    public static global::Pulumi.AwsNative.AppStream.Inputs.EntitlementAttributeArgs WithName(this global::Pulumi.AwsNative.AppStream.Inputs.EntitlementAttributeArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppStream.Inputs.EntitlementAttributeArgs WithValue(this global::Pulumi.AwsNative.AppStream.Inputs.EntitlementAttributeArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
