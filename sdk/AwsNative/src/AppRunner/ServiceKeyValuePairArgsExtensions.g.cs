// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AppRunner.Inputs;

namespace Pulumi.AwsNative.AppRunner;

public static partial class ServiceKeyValuePairArgsExtensions
{
    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceKeyValuePairArgs WithName(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceKeyValuePairArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceKeyValuePairArgs WithValue(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceKeyValuePairArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
