// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DataSetLogicalTableSourceArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetLogicalTableSourceArgs WithDataSetArn(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetLogicalTableSourceArgs @selfRef, global::System.String dataSetArn)
    {
        @selfRef.DataSetArn = dataSetArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetLogicalTableSourceArgs WithJoinInstruction(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetLogicalTableSourceArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinInstructionArgs joinInstruction)
    {
        @selfRef.JoinInstruction = joinInstruction;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetLogicalTableSourceArgs WithJoinInstruction(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetLogicalTableSourceArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinInstructionArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSetJoinInstructionArgs();
        @configure(@item);
        @selfRef.JoinInstruction = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetLogicalTableSourceArgs WithPhysicalTableId(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetLogicalTableSourceArgs @selfRef, global::System.String physicalTableId)
    {
        @selfRef.PhysicalTableId = physicalTableId;
        return @selfRef;
    }

}
