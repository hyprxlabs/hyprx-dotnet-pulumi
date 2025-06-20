// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisDefinitionArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithAnalysisDefaults(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefaultsArgs analysisDefaults)
    {
        @selfRef.AnalysisDefaults = analysisDefaults;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithAnalysisDefaults(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefaultsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefaultsArgs();
        @configure(@item);
        @selfRef.AnalysisDefaults = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithCalculatedFields(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCalculatedFieldArgs> calculatedFields)
    {
        @selfRef.CalculatedFields = calculatedFields;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithCalculatedFields(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCalculatedFieldArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCalculatedFieldArgs>();
        @configure(@list);
        @selfRef.CalculatedFields = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithCalculatedFields(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCalculatedFieldArgs>> @create)
    {
        @selfRef.CalculatedFields = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithColumnConfigurations(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColumnConfigurationArgs> columnConfigurations)
    {
        @selfRef.ColumnConfigurations = columnConfigurations;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithColumnConfigurations(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColumnConfigurationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColumnConfigurationArgs>();
        @configure(@list);
        @selfRef.ColumnConfigurations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithColumnConfigurations(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColumnConfigurationArgs>> @create)
    {
        @selfRef.ColumnConfigurations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithDataSetIdentifierDeclarations(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataSetIdentifierDeclarationArgs> dataSetIdentifierDeclarations)
    {
        @selfRef.DataSetIdentifierDeclarations = dataSetIdentifierDeclarations;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithDataSetIdentifierDeclarations(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataSetIdentifierDeclarationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataSetIdentifierDeclarationArgs>();
        @configure(@list);
        @selfRef.DataSetIdentifierDeclarations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithDataSetIdentifierDeclarations(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataSetIdentifierDeclarationArgs>> @create)
    {
        @selfRef.DataSetIdentifierDeclarations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithFilterGroups(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFilterGroupArgs> filterGroups)
    {
        @selfRef.FilterGroups = filterGroups;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithFilterGroups(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFilterGroupArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFilterGroupArgs>();
        @configure(@list);
        @selfRef.FilterGroups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithFilterGroups(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFilterGroupArgs>> @create)
    {
        @selfRef.FilterGroups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAssetOptionsArgs options)
    {
        @selfRef.Options = options;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAssetOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAssetOptionsArgs();
        @configure(@item);
        @selfRef.Options = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithParameterDeclarations(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisParameterDeclarationArgs> parameterDeclarations)
    {
        @selfRef.ParameterDeclarations = parameterDeclarations;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithParameterDeclarations(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisParameterDeclarationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisParameterDeclarationArgs>();
        @configure(@list);
        @selfRef.ParameterDeclarations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithParameterDeclarations(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisParameterDeclarationArgs>> @create)
    {
        @selfRef.ParameterDeclarations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithQueryExecutionOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisQueryExecutionOptionsArgs queryExecutionOptions)
    {
        @selfRef.QueryExecutionOptions = queryExecutionOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithQueryExecutionOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisQueryExecutionOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisQueryExecutionOptionsArgs();
        @configure(@item);
        @selfRef.QueryExecutionOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithSheets(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSheetDefinitionArgs> sheets)
    {
        @selfRef.Sheets = sheets;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithSheets(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSheetDefinitionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSheetDefinitionArgs>();
        @configure(@list);
        @selfRef.Sheets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithSheets(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSheetDefinitionArgs>> @create)
    {
        @selfRef.Sheets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithStaticFiles(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisStaticFileArgs> staticFiles)
    {
        @selfRef.StaticFiles = staticFiles;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithStaticFiles(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisStaticFileArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisStaticFileArgs>();
        @configure(@list);
        @selfRef.StaticFiles = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs WithStaticFiles(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefinitionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisStaticFileArgs>> @create)
    {
        @selfRef.StaticFiles = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
