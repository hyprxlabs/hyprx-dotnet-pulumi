// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.CustomerInsights;

public static partial class PredictionArgsExtensions
{
    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithAutoAnalyze(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, bool autoAnalyze = true)
    {
        @selfRef.AutoAnalyze = autoAnalyze;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithDescription(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithDescription(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Description = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithDescription(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Description = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithDisplayName(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> displayName)
    {
        @selfRef.DisplayName = displayName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithDisplayName(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.DisplayName = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithDisplayName(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.DisplayName = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithGrades(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.CustomerInsights.Inputs.PredictionGradesArgs> grades)
    {
        @selfRef.Grades = grades;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithGrades(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.CustomerInsights.Inputs.PredictionGradesArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.CustomerInsights.Inputs.PredictionGradesArgs>();
        @configure(@list);
        @selfRef.Grades = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithGrades(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.CustomerInsights.Inputs.PredictionGradesArgs>> @create)
    {
        @selfRef.Grades = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithHubName(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.String hubName)
    {
        @selfRef.HubName = hubName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithInvolvedInteractionTypes(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.Collections.Generic.List<global::System.String> involvedInteractionTypes)
    {
        @selfRef.InvolvedInteractionTypes = involvedInteractionTypes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithInvolvedInteractionTypes(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.InvolvedInteractionTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithInvolvedInteractionTypes(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.InvolvedInteractionTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithInvolvedKpiTypes(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.Collections.Generic.List<global::System.String> involvedKpiTypes)
    {
        @selfRef.InvolvedKpiTypes = involvedKpiTypes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithInvolvedKpiTypes(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.InvolvedKpiTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithInvolvedKpiTypes(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.InvolvedKpiTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithInvolvedRelationships(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.Collections.Generic.List<global::System.String> involvedRelationships)
    {
        @selfRef.InvolvedRelationships = involvedRelationships;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithInvolvedRelationships(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.InvolvedRelationships = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithInvolvedRelationships(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.InvolvedRelationships = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithMappings(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::Pulumi.AzureNative.CustomerInsights.Inputs.PredictionMappingsArgs mappings)
    {
        @selfRef.Mappings = mappings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithMappings(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.CustomerInsights.Inputs.PredictionMappingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.CustomerInsights.Inputs.PredictionMappingsArgs();
        @configure(@item);
        @selfRef.Mappings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithNegativeOutcomeExpression(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.String negativeOutcomeExpression)
    {
        @selfRef.NegativeOutcomeExpression = negativeOutcomeExpression;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithPositiveOutcomeExpression(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.String positiveOutcomeExpression)
    {
        @selfRef.PositiveOutcomeExpression = positiveOutcomeExpression;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithPredictionName(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.String predictionName)
    {
        @selfRef.PredictionName = predictionName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithPrimaryProfileType(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.String primaryProfileType)
    {
        @selfRef.PrimaryProfileType = primaryProfileType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithResourceGroupName(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithScopeExpression(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.String scopeExpression)
    {
        @selfRef.ScopeExpression = scopeExpression;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CustomerInsights.PredictionArgs WithScoreLabel(this global::Pulumi.AzureNative.CustomerInsights.PredictionArgs @selfRef, global::System.String scoreLabel)
    {
        @selfRef.ScoreLabel = scoreLabel;
        return @selfRef;
    }

}
