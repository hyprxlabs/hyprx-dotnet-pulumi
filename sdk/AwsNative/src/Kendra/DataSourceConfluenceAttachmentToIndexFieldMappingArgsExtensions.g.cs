// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Kendra.Inputs;

namespace Pulumi.AwsNative.Kendra;

public static partial class DataSourceConfluenceAttachmentToIndexFieldMappingArgsExtensions
{
    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceAttachmentToIndexFieldMappingArgs WithDataSourceFieldName(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceAttachmentToIndexFieldMappingArgs @selfRef, global::Pulumi.AwsNative.Kendra.DataSourceConfluenceAttachmentFieldName dataSourceFieldName)
    {
        @selfRef.DataSourceFieldName = dataSourceFieldName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceAttachmentToIndexFieldMappingArgs WithDataSourceFieldName(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceAttachmentToIndexFieldMappingArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Kendra.DataSourceConfluenceAttachmentFieldName> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Kendra.DataSourceConfluenceAttachmentFieldName>();
        @configure(@item);
        @selfRef.DataSourceFieldName = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceAttachmentToIndexFieldMappingArgs WithDateFieldFormat(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceAttachmentToIndexFieldMappingArgs @selfRef, global::System.String dateFieldFormat)
    {
        @selfRef.DateFieldFormat = dateFieldFormat;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceAttachmentToIndexFieldMappingArgs WithIndexFieldName(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceAttachmentToIndexFieldMappingArgs @selfRef, global::System.String indexFieldName)
    {
        @selfRef.IndexFieldName = indexFieldName;
        return @selfRef;
    }

}
