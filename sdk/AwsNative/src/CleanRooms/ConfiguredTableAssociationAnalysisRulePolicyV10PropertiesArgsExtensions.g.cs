// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.CleanRooms.Inputs;

namespace Pulumi.AwsNative.CleanRooms;

public static partial class ConfiguredTableAssociationAnalysisRulePolicyV10PropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.CleanRooms.Inputs.ConfiguredTableAssociationAnalysisRulePolicyV10PropertiesArgs WithList(this global::Pulumi.AwsNative.CleanRooms.Inputs.ConfiguredTableAssociationAnalysisRulePolicyV10PropertiesArgs @selfRef, global::Pulumi.AwsNative.CleanRooms.Inputs.ConfiguredTableAssociationAnalysisRuleListArgs list)
    {
        @selfRef.List = list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CleanRooms.Inputs.ConfiguredTableAssociationAnalysisRulePolicyV10PropertiesArgs WithList(this global::Pulumi.AwsNative.CleanRooms.Inputs.ConfiguredTableAssociationAnalysisRulePolicyV10PropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CleanRooms.Inputs.ConfiguredTableAssociationAnalysisRuleListArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.CleanRooms.Inputs.ConfiguredTableAssociationAnalysisRuleListArgs();
        @configure(@item);
        @selfRef.List = @item;
        return @selfRef;
    }

}
