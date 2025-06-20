// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.CleanRooms.Inputs;

namespace Pulumi.AwsNative.CleanRooms;

public static partial class MembershipProtectedQueryS3OutputConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.CleanRooms.Inputs.MembershipProtectedQueryS3OutputConfigurationArgs WithBucket(this global::Pulumi.AwsNative.CleanRooms.Inputs.MembershipProtectedQueryS3OutputConfigurationArgs @selfRef, global::System.String bucket)
    {
        @selfRef.Bucket = bucket;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CleanRooms.Inputs.MembershipProtectedQueryS3OutputConfigurationArgs WithKeyPrefix(this global::Pulumi.AwsNative.CleanRooms.Inputs.MembershipProtectedQueryS3OutputConfigurationArgs @selfRef, global::System.String keyPrefix)
    {
        @selfRef.KeyPrefix = keyPrefix;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CleanRooms.Inputs.MembershipProtectedQueryS3OutputConfigurationArgs WithResultFormat(this global::Pulumi.AwsNative.CleanRooms.Inputs.MembershipProtectedQueryS3OutputConfigurationArgs @selfRef, global::Pulumi.AwsNative.CleanRooms.MembershipResultFormat resultFormat)
    {
        @selfRef.ResultFormat = resultFormat;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CleanRooms.Inputs.MembershipProtectedQueryS3OutputConfigurationArgs WithResultFormat(this global::Pulumi.AwsNative.CleanRooms.Inputs.MembershipProtectedQueryS3OutputConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CleanRooms.MembershipResultFormat> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.CleanRooms.MembershipResultFormat>();
        @configure(@item);
        @selfRef.ResultFormat = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CleanRooms.Inputs.MembershipProtectedQueryS3OutputConfigurationArgs WithSingleFileOutput(this global::Pulumi.AwsNative.CleanRooms.Inputs.MembershipProtectedQueryS3OutputConfigurationArgs @selfRef, bool singleFileOutput = true)
    {
        @selfRef.SingleFileOutput = singleFileOutput;
        return @selfRef;
    }

}
