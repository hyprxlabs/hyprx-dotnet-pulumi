// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Kendra.Inputs;

namespace Pulumi.AwsNative.Kendra;

public static partial class DataSourceSalesforceStandardObjectConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceSalesforceStandardObjectConfigurationArgs WithDocumentDataFieldName(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceSalesforceStandardObjectConfigurationArgs @selfRef, global::System.String documentDataFieldName)
    {
        @selfRef.DocumentDataFieldName = documentDataFieldName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceSalesforceStandardObjectConfigurationArgs WithDocumentTitleFieldName(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceSalesforceStandardObjectConfigurationArgs @selfRef, global::System.String documentTitleFieldName)
    {
        @selfRef.DocumentTitleFieldName = documentTitleFieldName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceSalesforceStandardObjectConfigurationArgs WithFieldMappings(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceSalesforceStandardObjectConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceToIndexFieldMappingArgs> fieldMappings)
    {
        @selfRef.FieldMappings = fieldMappings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceSalesforceStandardObjectConfigurationArgs WithFieldMappings(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceSalesforceStandardObjectConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceToIndexFieldMappingArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceToIndexFieldMappingArgs>();
        @configure(@list);
        @selfRef.FieldMappings = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceSalesforceStandardObjectConfigurationArgs WithFieldMappings(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceSalesforceStandardObjectConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceToIndexFieldMappingArgs>> @create)
    {
        @selfRef.FieldMappings = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceSalesforceStandardObjectConfigurationArgs WithName(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceSalesforceStandardObjectConfigurationArgs @selfRef, global::Pulumi.AwsNative.Kendra.DataSourceSalesforceStandardObjectName name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceSalesforceStandardObjectConfigurationArgs WithName(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceSalesforceStandardObjectConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Kendra.DataSourceSalesforceStandardObjectName> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Kendra.DataSourceSalesforceStandardObjectName>();
        @configure(@item);
        @selfRef.Name = @item;
        return @selfRef;
    }

}
