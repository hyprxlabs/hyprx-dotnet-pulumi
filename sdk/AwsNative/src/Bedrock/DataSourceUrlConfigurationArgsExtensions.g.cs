// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class DataSourceUrlConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceUrlConfigurationArgs WithSeedUrls(this global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceUrlConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceSeedUrlArgs> seedUrls)
    {
        @selfRef.SeedUrls = seedUrls;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceUrlConfigurationArgs WithSeedUrls(this global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceUrlConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceSeedUrlArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceSeedUrlArgs>();
        @configure(@list);
        @selfRef.SeedUrls = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceUrlConfigurationArgs WithSeedUrls(this global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceUrlConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceSeedUrlArgs>> @create)
    {
        @selfRef.SeedUrls = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
