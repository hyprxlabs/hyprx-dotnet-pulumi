// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class BigDataPoolParametrizationReferenceArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.BigDataPoolParametrizationReferenceArgs WithReferenceName(this global::Pulumi.AzureNative.DataFactory.Inputs.BigDataPoolParametrizationReferenceArgs @selfRef, global::System.Object referenceName)
    {
        @selfRef.ReferenceName = referenceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.BigDataPoolParametrizationReferenceArgs WithReferenceName(this global::Pulumi.AzureNative.DataFactory.Inputs.BigDataPoolParametrizationReferenceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.ReferenceName = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.BigDataPoolParametrizationReferenceArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.BigDataPoolParametrizationReferenceArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DataFactory.BigDataPoolReferenceType> type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
