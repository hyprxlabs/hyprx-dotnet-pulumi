// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Evidently.Inputs;

namespace Pulumi.AwsNative.Evidently;

public static partial class LaunchGroupObjectArgsExtensions
{
    public static global::Pulumi.AwsNative.Evidently.Inputs.LaunchGroupObjectArgs WithDescription(this global::Pulumi.AwsNative.Evidently.Inputs.LaunchGroupObjectArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Evidently.Inputs.LaunchGroupObjectArgs WithFeature(this global::Pulumi.AwsNative.Evidently.Inputs.LaunchGroupObjectArgs @selfRef, global::System.String feature)
    {
        @selfRef.Feature = feature;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Evidently.Inputs.LaunchGroupObjectArgs WithGroupName(this global::Pulumi.AwsNative.Evidently.Inputs.LaunchGroupObjectArgs @selfRef, global::System.String groupName)
    {
        @selfRef.GroupName = groupName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Evidently.Inputs.LaunchGroupObjectArgs WithVariation(this global::Pulumi.AwsNative.Evidently.Inputs.LaunchGroupObjectArgs @selfRef, global::System.String variation)
    {
        @selfRef.Variation = variation;
        return @selfRef;
    }

}
