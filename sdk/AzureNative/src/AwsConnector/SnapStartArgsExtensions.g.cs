// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class SnapStartArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.SnapStartArgs WithApplyOn(this global::Pulumi.AzureNative.AwsConnector.Inputs.SnapStartArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AwsConnector.SnapStartApplyOn> applyOn)
    {
        @selfRef.ApplyOn = applyOn;
        return @selfRef;
    }

}
