// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class ParameterSpecificationArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs WithDefaultValue(this global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs @selfRef, global::System.Object defaultValue)
    {
        @selfRef.DefaultValue = defaultValue;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs WithDefaultValue(this global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.DefaultValue = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DataFactory.ParameterType> type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
