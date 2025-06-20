// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Glue.Inputs;

namespace Pulumi.AwsNative.Glue;

public static partial class CrawlerCatalogTargetArgsExtensions
{
    public static global::Pulumi.AwsNative.Glue.Inputs.CrawlerCatalogTargetArgs WithConnectionName(this global::Pulumi.AwsNative.Glue.Inputs.CrawlerCatalogTargetArgs @selfRef, global::System.String connectionName)
    {
        @selfRef.ConnectionName = connectionName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Glue.Inputs.CrawlerCatalogTargetArgs WithDatabaseName(this global::Pulumi.AwsNative.Glue.Inputs.CrawlerCatalogTargetArgs @selfRef, global::System.String databaseName)
    {
        @selfRef.DatabaseName = databaseName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Glue.Inputs.CrawlerCatalogTargetArgs WithDlqEventQueueArn(this global::Pulumi.AwsNative.Glue.Inputs.CrawlerCatalogTargetArgs @selfRef, global::System.String dlqEventQueueArn)
    {
        @selfRef.DlqEventQueueArn = dlqEventQueueArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Glue.Inputs.CrawlerCatalogTargetArgs WithEventQueueArn(this global::Pulumi.AwsNative.Glue.Inputs.CrawlerCatalogTargetArgs @selfRef, global::System.String eventQueueArn)
    {
        @selfRef.EventQueueArn = eventQueueArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Glue.Inputs.CrawlerCatalogTargetArgs WithTables(this global::Pulumi.AwsNative.Glue.Inputs.CrawlerCatalogTargetArgs @selfRef, global::System.Collections.Generic.List<global::System.String> tables)
    {
        @selfRef.Tables = tables;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Glue.Inputs.CrawlerCatalogTargetArgs WithTables(this global::Pulumi.AwsNative.Glue.Inputs.CrawlerCatalogTargetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Tables = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Glue.Inputs.CrawlerCatalogTargetArgs WithTables(this global::Pulumi.AwsNative.Glue.Inputs.CrawlerCatalogTargetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Tables = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
