// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class InstanceTypeEnumValueArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.InstanceTypeEnumValueArgs WithValue(this global::Pulumi.AzureNative.AwsConnector.Inputs.InstanceTypeEnumValueArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AwsConnector.InstanceType> value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
