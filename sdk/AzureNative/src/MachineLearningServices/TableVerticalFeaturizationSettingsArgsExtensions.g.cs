// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class TableVerticalFeaturizationSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs WithBlockedTransformers(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.BlockedTransformers>> blockedTransformers)
    {
        @selfRef.BlockedTransformers = blockedTransformers;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs WithBlockedTransformers(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.BlockedTransformers>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.BlockedTransformers>>();
        @configure(@list);
        @selfRef.BlockedTransformers = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs WithBlockedTransformers(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.BlockedTransformers>>> @create)
    {
        @selfRef.BlockedTransformers = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs WithColumnNameAndTypes(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> columnNameAndTypes)
    {
        @selfRef.ColumnNameAndTypes = columnNameAndTypes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs WithColumnNameAndTypes(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.ColumnNameAndTypes = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs WithColumnNameAndTypes(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.ColumnNameAndTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs WithDatasetLanguage(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs @selfRef, global::System.String datasetLanguage)
    {
        @selfRef.DatasetLanguage = datasetLanguage;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs WithEnableDnnFeaturization(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs @selfRef, bool enableDnnFeaturization = true)
    {
        @selfRef.EnableDnnFeaturization = enableDnnFeaturization;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs WithMode(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.FeaturizationMode> mode)
    {
        @selfRef.Mode = mode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs WithTransformerParams(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Immutable.ImmutableArray<global::Pulumi.AzureNative.MachineLearningServices.Inputs.ColumnTransformerArgs>> transformerParams)
    {
        @selfRef.TransformerParams = transformerParams;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs WithTransformerParams(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Immutable.ImmutableArray<global::Pulumi.AzureNative.MachineLearningServices.Inputs.ColumnTransformerArgs>>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Immutable.ImmutableArray<global::Pulumi.AzureNative.MachineLearningServices.Inputs.ColumnTransformerArgs>>();
        @configure(@dict);
        @selfRef.TransformerParams = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs WithTransformerParams(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.TableVerticalFeaturizationSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.Collections.Immutable.ImmutableArray<global::Pulumi.AzureNative.MachineLearningServices.Inputs.ColumnTransformerArgs>>> @create)
    {
        @selfRef.TransformerParams = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
