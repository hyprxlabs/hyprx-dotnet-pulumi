// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.CleanRoomsMl.Inputs;

namespace Pulumi.AwsNative.CleanRoomsMl;

public static partial class TrainingDatasetDatasetArgsExtensions
{
    public static global::Pulumi.AwsNative.CleanRoomsMl.Inputs.TrainingDatasetDatasetArgs WithInputConfig(this global::Pulumi.AwsNative.CleanRoomsMl.Inputs.TrainingDatasetDatasetArgs @selfRef, global::Pulumi.AwsNative.CleanRoomsMl.Inputs.TrainingDatasetDatasetInputConfigArgs inputConfig)
    {
        @selfRef.InputConfig = inputConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CleanRoomsMl.Inputs.TrainingDatasetDatasetArgs WithInputConfig(this global::Pulumi.AwsNative.CleanRoomsMl.Inputs.TrainingDatasetDatasetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CleanRoomsMl.Inputs.TrainingDatasetDatasetInputConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.CleanRoomsMl.Inputs.TrainingDatasetDatasetInputConfigArgs();
        @configure(@item);
        @selfRef.InputConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CleanRoomsMl.Inputs.TrainingDatasetDatasetArgs WithType(this global::Pulumi.AwsNative.CleanRoomsMl.Inputs.TrainingDatasetDatasetArgs @selfRef, global::Pulumi.AwsNative.CleanRoomsMl.TrainingDatasetDatasetType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CleanRoomsMl.Inputs.TrainingDatasetDatasetArgs WithType(this global::Pulumi.AwsNative.CleanRoomsMl.Inputs.TrainingDatasetDatasetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CleanRoomsMl.TrainingDatasetDatasetType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.CleanRoomsMl.TrainingDatasetDatasetType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
