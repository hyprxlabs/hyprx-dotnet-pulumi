// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Kendra.Inputs;

namespace Pulumi.AwsNative.Kendra;

public static partial class DataSourceProxyConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceProxyConfigurationArgs WithCredentials(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceProxyConfigurationArgs @selfRef, global::System.String credentials)
    {
        @selfRef.Credentials = credentials;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceProxyConfigurationArgs WithHost(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceProxyConfigurationArgs @selfRef, global::System.String host)
    {
        @selfRef.Host = host;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceProxyConfigurationArgs WithPort(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceProxyConfigurationArgs @selfRef, global::System.Int32 port)
    {
        @selfRef.Port = port;
        return @selfRef;
    }

}
