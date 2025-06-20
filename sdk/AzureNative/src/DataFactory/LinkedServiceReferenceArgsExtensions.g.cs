// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class LinkedServiceReferenceArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.Object> parameters)
    {
        @selfRef.Parameters = parameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.Object>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.Object>();
        @configure(@dict);
        @selfRef.Parameters = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.Object>> @create)
    {
        @selfRef.Parameters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs WithReferenceName(this global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs @selfRef, global::System.String referenceName)
    {
        @selfRef.ReferenceName = referenceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DataFactory.Type> type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
