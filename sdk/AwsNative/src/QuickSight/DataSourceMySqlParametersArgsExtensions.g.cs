// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DataSourceMySqlParametersArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceMySqlParametersArgs WithDatabase(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceMySqlParametersArgs @selfRef, global::System.String database)
    {
        @selfRef.Database = database;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceMySqlParametersArgs WithHost(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceMySqlParametersArgs @selfRef, global::System.String host)
    {
        @selfRef.Host = host;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceMySqlParametersArgs WithPort(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceMySqlParametersArgs @selfRef, global::System.Double port)
    {
        @selfRef.Port = port;
        return @selfRef;
    }

}
