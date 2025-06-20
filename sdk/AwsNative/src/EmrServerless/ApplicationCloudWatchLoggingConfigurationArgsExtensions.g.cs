// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.EmrServerless.Inputs;

namespace Pulumi.AwsNative.EmrServerless;

public static partial class ApplicationCloudWatchLoggingConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationCloudWatchLoggingConfigurationArgs WithEnabled(this global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationCloudWatchLoggingConfigurationArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationCloudWatchLoggingConfigurationArgs WithEncryptionKeyArn(this global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationCloudWatchLoggingConfigurationArgs @selfRef, global::System.String encryptionKeyArn)
    {
        @selfRef.EncryptionKeyArn = encryptionKeyArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationCloudWatchLoggingConfigurationArgs WithLogGroupName(this global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationCloudWatchLoggingConfigurationArgs @selfRef, global::System.String logGroupName)
    {
        @selfRef.LogGroupName = logGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationCloudWatchLoggingConfigurationArgs WithLogStreamNamePrefix(this global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationCloudWatchLoggingConfigurationArgs @selfRef, global::System.String logStreamNamePrefix)
    {
        @selfRef.LogStreamNamePrefix = logStreamNamePrefix;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationCloudWatchLoggingConfigurationArgs WithLogTypeMap(this global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationCloudWatchLoggingConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationLogTypeMapKeyValuePairArgs> logTypeMap)
    {
        @selfRef.LogTypeMap = logTypeMap;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationCloudWatchLoggingConfigurationArgs WithLogTypeMap(this global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationCloudWatchLoggingConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationLogTypeMapKeyValuePairArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationLogTypeMapKeyValuePairArgs>();
        @configure(@list);
        @selfRef.LogTypeMap = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationCloudWatchLoggingConfigurationArgs WithLogTypeMap(this global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationCloudWatchLoggingConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationLogTypeMapKeyValuePairArgs>> @create)
    {
        @selfRef.LogTypeMap = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
