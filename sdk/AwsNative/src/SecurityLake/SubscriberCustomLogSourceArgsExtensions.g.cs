// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SecurityLake.Inputs;

namespace Pulumi.AwsNative.SecurityLake;

public static partial class SubscriberCustomLogSourceArgsExtensions
{
    public static global::Pulumi.AwsNative.SecurityLake.Inputs.SubscriberCustomLogSourceArgs WithSourceName(this global::Pulumi.AwsNative.SecurityLake.Inputs.SubscriberCustomLogSourceArgs @selfRef, global::System.String sourceName)
    {
        @selfRef.SourceName = sourceName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SecurityLake.Inputs.SubscriberCustomLogSourceArgs WithSourceVersion(this global::Pulumi.AwsNative.SecurityLake.Inputs.SubscriberCustomLogSourceArgs @selfRef, global::System.String sourceVersion)
    {
        @selfRef.SourceVersion = sourceVersion;
        return @selfRef;
    }

}
