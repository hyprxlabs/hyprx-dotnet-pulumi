// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DataSourceParametersArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithAmazonElasticsearchParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceAmazonElasticsearchParametersArgs amazonElasticsearchParameters)
    {
        @selfRef.AmazonElasticsearchParameters = amazonElasticsearchParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithAmazonElasticsearchParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceAmazonElasticsearchParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceAmazonElasticsearchParametersArgs();
        @configure(@item);
        @selfRef.AmazonElasticsearchParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithAmazonOpenSearchParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceAmazonOpenSearchParametersArgs amazonOpenSearchParameters)
    {
        @selfRef.AmazonOpenSearchParameters = amazonOpenSearchParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithAmazonOpenSearchParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceAmazonOpenSearchParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceAmazonOpenSearchParametersArgs();
        @configure(@item);
        @selfRef.AmazonOpenSearchParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithAthenaParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceAthenaParametersArgs athenaParameters)
    {
        @selfRef.AthenaParameters = athenaParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithAthenaParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceAthenaParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceAthenaParametersArgs();
        @configure(@item);
        @selfRef.AthenaParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithAuroraParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceAuroraParametersArgs auroraParameters)
    {
        @selfRef.AuroraParameters = auroraParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithAuroraParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceAuroraParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceAuroraParametersArgs();
        @configure(@item);
        @selfRef.AuroraParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithAuroraPostgreSqlParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceAuroraPostgreSqlParametersArgs auroraPostgreSqlParameters)
    {
        @selfRef.AuroraPostgreSqlParameters = auroraPostgreSqlParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithAuroraPostgreSqlParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceAuroraPostgreSqlParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceAuroraPostgreSqlParametersArgs();
        @configure(@item);
        @selfRef.AuroraPostgreSqlParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithDatabricksParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceDatabricksParametersArgs databricksParameters)
    {
        @selfRef.DatabricksParameters = databricksParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithDatabricksParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceDatabricksParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceDatabricksParametersArgs();
        @configure(@item);
        @selfRef.DatabricksParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithMariaDbParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceMariaDbParametersArgs mariaDbParameters)
    {
        @selfRef.MariaDbParameters = mariaDbParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithMariaDbParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceMariaDbParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceMariaDbParametersArgs();
        @configure(@item);
        @selfRef.MariaDbParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithMySqlParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceMySqlParametersArgs mySqlParameters)
    {
        @selfRef.MySqlParameters = mySqlParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithMySqlParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceMySqlParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceMySqlParametersArgs();
        @configure(@item);
        @selfRef.MySqlParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithOracleParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceOracleParametersArgs oracleParameters)
    {
        @selfRef.OracleParameters = oracleParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithOracleParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceOracleParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceOracleParametersArgs();
        @configure(@item);
        @selfRef.OracleParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithPostgreSqlParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSourcePostgreSqlParametersArgs postgreSqlParameters)
    {
        @selfRef.PostgreSqlParameters = postgreSqlParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithPostgreSqlParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSourcePostgreSqlParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSourcePostgreSqlParametersArgs();
        @configure(@item);
        @selfRef.PostgreSqlParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithPrestoParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSourcePrestoParametersArgs prestoParameters)
    {
        @selfRef.PrestoParameters = prestoParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithPrestoParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSourcePrestoParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSourcePrestoParametersArgs();
        @configure(@item);
        @selfRef.PrestoParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithRdsParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceRdsParametersArgs rdsParameters)
    {
        @selfRef.RdsParameters = rdsParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithRdsParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceRdsParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceRdsParametersArgs();
        @configure(@item);
        @selfRef.RdsParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithRedshiftParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceRedshiftParametersArgs redshiftParameters)
    {
        @selfRef.RedshiftParameters = redshiftParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithRedshiftParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceRedshiftParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceRedshiftParametersArgs();
        @configure(@item);
        @selfRef.RedshiftParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithS3Parameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceS3ParametersArgs s3Parameters)
    {
        @selfRef.S3Parameters = s3Parameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithS3Parameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceS3ParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceS3ParametersArgs();
        @configure(@item);
        @selfRef.S3Parameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithSnowflakeParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceSnowflakeParametersArgs snowflakeParameters)
    {
        @selfRef.SnowflakeParameters = snowflakeParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithSnowflakeParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceSnowflakeParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceSnowflakeParametersArgs();
        @configure(@item);
        @selfRef.SnowflakeParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithSparkParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceSparkParametersArgs sparkParameters)
    {
        @selfRef.SparkParameters = sparkParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithSparkParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceSparkParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceSparkParametersArgs();
        @configure(@item);
        @selfRef.SparkParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithSqlServerParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceSqlServerParametersArgs sqlServerParameters)
    {
        @selfRef.SqlServerParameters = sqlServerParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithSqlServerParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceSqlServerParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceSqlServerParametersArgs();
        @configure(@item);
        @selfRef.SqlServerParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithStarburstParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceStarburstParametersArgs starburstParameters)
    {
        @selfRef.StarburstParameters = starburstParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithStarburstParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceStarburstParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceStarburstParametersArgs();
        @configure(@item);
        @selfRef.StarburstParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithTeradataParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceTeradataParametersArgs teradataParameters)
    {
        @selfRef.TeradataParameters = teradataParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithTeradataParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceTeradataParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceTeradataParametersArgs();
        @configure(@item);
        @selfRef.TeradataParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithTrinoParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceTrinoParametersArgs trinoParameters)
    {
        @selfRef.TrinoParameters = trinoParameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs WithTrinoParameters(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceParametersArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceTrinoParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSourceTrinoParametersArgs();
        @configure(@item);
        @selfRef.TrinoParameters = @item;
        return @selfRef;
    }

}
