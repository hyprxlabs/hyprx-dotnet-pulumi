// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Kendra.Inputs;

namespace Pulumi.AwsNative.Kendra;

public static partial class DataSourceWebCrawlerAuthenticationConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceWebCrawlerAuthenticationConfigurationArgs WithBasicAuthentication(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceWebCrawlerAuthenticationConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceWebCrawlerBasicAuthenticationArgs> basicAuthentication)
    {
        @selfRef.BasicAuthentication = basicAuthentication;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceWebCrawlerAuthenticationConfigurationArgs WithBasicAuthentication(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceWebCrawlerAuthenticationConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceWebCrawlerBasicAuthenticationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceWebCrawlerBasicAuthenticationArgs>();
        @configure(@list);
        @selfRef.BasicAuthentication = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceWebCrawlerAuthenticationConfigurationArgs WithBasicAuthentication(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceWebCrawlerAuthenticationConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceWebCrawlerBasicAuthenticationArgs>> @create)
    {
        @selfRef.BasicAuthentication = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
