// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DataSourceOracleParametersArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceOracleParametersArgs WithDatabase(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceOracleParametersArgs @selfRef, global::System.String database)
    {
        @selfRef.Database = database;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceOracleParametersArgs WithHost(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceOracleParametersArgs @selfRef, global::System.String host)
    {
        @selfRef.Host = host;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceOracleParametersArgs WithPort(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceOracleParametersArgs @selfRef, global::System.Double port)
    {
        @selfRef.Port = port;
        return @selfRef;
    }

}
