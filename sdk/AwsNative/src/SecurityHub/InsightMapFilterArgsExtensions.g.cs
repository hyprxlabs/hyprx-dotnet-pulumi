// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SecurityHub.Inputs;

namespace Pulumi.AwsNative.SecurityHub;

public static partial class InsightMapFilterArgsExtensions
{
    public static global::Pulumi.AwsNative.SecurityHub.Inputs.InsightMapFilterArgs WithComparison(this global::Pulumi.AwsNative.SecurityHub.Inputs.InsightMapFilterArgs @selfRef, global::Pulumi.AwsNative.SecurityHub.InsightMapFilterComparison comparison)
    {
        @selfRef.Comparison = comparison;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SecurityHub.Inputs.InsightMapFilterArgs WithComparison(this global::Pulumi.AwsNative.SecurityHub.Inputs.InsightMapFilterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SecurityHub.InsightMapFilterComparison> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.SecurityHub.InsightMapFilterComparison>();
        @configure(@item);
        @selfRef.Comparison = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SecurityHub.Inputs.InsightMapFilterArgs WithKey(this global::Pulumi.AwsNative.SecurityHub.Inputs.InsightMapFilterArgs @selfRef, global::System.String key)
    {
        @selfRef.Key = key;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SecurityHub.Inputs.InsightMapFilterArgs WithValue(this global::Pulumi.AwsNative.SecurityHub.Inputs.InsightMapFilterArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
