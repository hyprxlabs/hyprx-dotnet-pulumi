// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.WorkSpacesThinClient.Inputs;

namespace Pulumi.AwsNative.WorkSpacesThinClient;

public static partial class EnvironmentTagArgsExtensions
{
    public static global::Pulumi.AwsNative.WorkSpacesThinClient.Inputs.EnvironmentTagArgs WithKey(this global::Pulumi.AwsNative.WorkSpacesThinClient.Inputs.EnvironmentTagArgs @selfRef, global::System.String key)
    {
        @selfRef.Key = key;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WorkSpacesThinClient.Inputs.EnvironmentTagArgs WithValue(this global::Pulumi.AwsNative.WorkSpacesThinClient.Inputs.EnvironmentTagArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
