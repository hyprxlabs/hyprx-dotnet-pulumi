// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.SecurityInsights.Inputs;

namespace Pulumi.AzureNative.SecurityInsights;

public static partial class FieldMappingArgsExtensions
{
    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.FieldMappingArgs WithColumnName(this global::Pulumi.AzureNative.SecurityInsights.Inputs.FieldMappingArgs @selfRef, global::System.String columnName)
    {
        @selfRef.ColumnName = columnName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.FieldMappingArgs WithIdentifier(this global::Pulumi.AzureNative.SecurityInsights.Inputs.FieldMappingArgs @selfRef, global::System.String identifier)
    {
        @selfRef.Identifier = identifier;
        return @selfRef;
    }

}
