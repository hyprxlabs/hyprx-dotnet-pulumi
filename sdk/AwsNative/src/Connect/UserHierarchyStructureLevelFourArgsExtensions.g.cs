// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Connect.Inputs;

namespace Pulumi.AwsNative.Connect;

public static partial class UserHierarchyStructureLevelFourArgsExtensions
{
    public static global::Pulumi.AwsNative.Connect.Inputs.UserHierarchyStructureLevelFourArgs WithHierarchyLevelArn(this global::Pulumi.AwsNative.Connect.Inputs.UserHierarchyStructureLevelFourArgs @selfRef, global::System.String hierarchyLevelArn)
    {
        @selfRef.HierarchyLevelArn = hierarchyLevelArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.Inputs.UserHierarchyStructureLevelFourArgs WithHierarchyLevelId(this global::Pulumi.AwsNative.Connect.Inputs.UserHierarchyStructureLevelFourArgs @selfRef, global::System.String hierarchyLevelId)
    {
        @selfRef.HierarchyLevelId = hierarchyLevelId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.Inputs.UserHierarchyStructureLevelFourArgs WithName(this global::Pulumi.AwsNative.Connect.Inputs.UserHierarchyStructureLevelFourArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

}
