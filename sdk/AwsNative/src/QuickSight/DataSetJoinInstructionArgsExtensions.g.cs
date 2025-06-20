// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DataSetJoinInstructionArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinInstructionArgs WithLeftJoinKeyProperties(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinInstructionArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinKeyPropertiesArgs leftJoinKeyProperties)
    {
        @selfRef.LeftJoinKeyProperties = leftJoinKeyProperties;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinInstructionArgs WithLeftJoinKeyProperties(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinInstructionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinKeyPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinKeyPropertiesArgs();
        @configure(@item);
        @selfRef.LeftJoinKeyProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinInstructionArgs WithLeftOperand(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinInstructionArgs @selfRef, global::System.String leftOperand)
    {
        @selfRef.LeftOperand = leftOperand;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinInstructionArgs WithOnClause(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinInstructionArgs @selfRef, global::System.String onClause)
    {
        @selfRef.OnClause = onClause;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinInstructionArgs WithRightJoinKeyProperties(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinInstructionArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinKeyPropertiesArgs rightJoinKeyProperties)
    {
        @selfRef.RightJoinKeyProperties = rightJoinKeyProperties;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinInstructionArgs WithRightJoinKeyProperties(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinInstructionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinKeyPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinKeyPropertiesArgs();
        @configure(@item);
        @selfRef.RightJoinKeyProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinInstructionArgs WithRightOperand(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinInstructionArgs @selfRef, global::System.String rightOperand)
    {
        @selfRef.RightOperand = rightOperand;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinInstructionArgs WithType(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinInstructionArgs @selfRef, global::Pulumi.AwsNative.QuickSight.DataSetJoinType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinInstructionArgs WithType(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinInstructionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.DataSetJoinType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.DataSetJoinType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
