// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Route53.Inputs;

namespace Pulumi.AwsNative.Route53;

public static partial class HealthCheckTagArgsExtensions
{
    public static global::Pulumi.AwsNative.Route53.Inputs.HealthCheckTagArgs WithKey(this global::Pulumi.AwsNative.Route53.Inputs.HealthCheckTagArgs @selfRef, global::System.String key)
    {
        @selfRef.Key = key;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Route53.Inputs.HealthCheckTagArgs WithValue(this global::Pulumi.AwsNative.Route53.Inputs.HealthCheckTagArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
