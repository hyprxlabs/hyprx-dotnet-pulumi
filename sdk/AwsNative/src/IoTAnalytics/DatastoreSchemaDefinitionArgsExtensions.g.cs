// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoTAnalytics.Inputs;

namespace Pulumi.AwsNative.IoTAnalytics;

public static partial class DatastoreSchemaDefinitionArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastoreSchemaDefinitionArgs WithColumns(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastoreSchemaDefinitionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastoreColumnArgs> columns)
    {
        @selfRef.Columns = columns;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastoreSchemaDefinitionArgs WithColumns(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastoreSchemaDefinitionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastoreColumnArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastoreColumnArgs>();
        @configure(@list);
        @selfRef.Columns = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastoreSchemaDefinitionArgs WithColumns(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastoreSchemaDefinitionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastoreColumnArgs>> @create)
    {
        @selfRef.Columns = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
