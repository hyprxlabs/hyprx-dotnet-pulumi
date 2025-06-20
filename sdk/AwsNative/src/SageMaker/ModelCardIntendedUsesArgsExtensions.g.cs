// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class ModelCardIntendedUsesArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardIntendedUsesArgs WithExplanationsForRiskRating(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardIntendedUsesArgs @selfRef, global::System.String explanationsForRiskRating)
    {
        @selfRef.ExplanationsForRiskRating = explanationsForRiskRating;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardIntendedUsesArgs WithFactorsAffectingModelEfficiency(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardIntendedUsesArgs @selfRef, global::System.String factorsAffectingModelEfficiency)
    {
        @selfRef.FactorsAffectingModelEfficiency = factorsAffectingModelEfficiency;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardIntendedUsesArgs WithIntendedUses(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardIntendedUsesArgs @selfRef, global::System.String intendedUses)
    {
        @selfRef.IntendedUses = intendedUses;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardIntendedUsesArgs WithPurposeOfModel(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardIntendedUsesArgs @selfRef, global::System.String purposeOfModel)
    {
        @selfRef.PurposeOfModel = purposeOfModel;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardIntendedUsesArgs WithRiskRating(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardIntendedUsesArgs @selfRef, global::Pulumi.AwsNative.SageMaker.ModelCardRiskRating riskRating)
    {
        @selfRef.RiskRating = riskRating;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardIntendedUsesArgs WithRiskRating(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardIntendedUsesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.ModelCardRiskRating> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.SageMaker.ModelCardRiskRating>();
        @configure(@item);
        @selfRef.RiskRating = @item;
        return @selfRef;
    }

}
