// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.DataZone.Inputs;

namespace Pulumi.AwsNative.DataZone;

public static partial class DataSourceSageMakerRunConfigurationInputArgsExtensions
{
    public static global::Pulumi.AwsNative.DataZone.Inputs.DataSourceSageMakerRunConfigurationInputArgs WithTrackingAssets(this global::Pulumi.AwsNative.DataZone.Inputs.DataSourceSageMakerRunConfigurationInputArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.Object> trackingAssets)
    {
        @selfRef.TrackingAssets = trackingAssets;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataZone.Inputs.DataSourceSageMakerRunConfigurationInputArgs WithTrackingAssets(this global::Pulumi.AwsNative.DataZone.Inputs.DataSourceSageMakerRunConfigurationInputArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.Object>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.Object>();
        @configure(@dict);
        @selfRef.TrackingAssets = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataZone.Inputs.DataSourceSageMakerRunConfigurationInputArgs WithTrackingAssets(this global::Pulumi.AwsNative.DataZone.Inputs.DataSourceSageMakerRunConfigurationInputArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.Object>> @create)
    {
        @selfRef.TrackingAssets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
