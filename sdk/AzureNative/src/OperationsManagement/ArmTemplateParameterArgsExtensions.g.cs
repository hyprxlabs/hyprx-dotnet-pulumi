// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.OperationsManagement.Inputs;

namespace Pulumi.AzureNative.OperationsManagement;

public static partial class ArmTemplateParameterArgsExtensions
{
    public static global::Pulumi.AzureNative.OperationsManagement.Inputs.ArmTemplateParameterArgs WithName(this global::Pulumi.AzureNative.OperationsManagement.Inputs.ArmTemplateParameterArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.OperationsManagement.Inputs.ArmTemplateParameterArgs WithValue(this global::Pulumi.AzureNative.OperationsManagement.Inputs.ArmTemplateParameterArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
