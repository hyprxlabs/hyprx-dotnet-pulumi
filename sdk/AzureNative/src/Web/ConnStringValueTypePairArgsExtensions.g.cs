// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Web.Inputs;

namespace Pulumi.AzureNative.Web;

public static partial class ConnStringValueTypePairArgsExtensions
{
    public static global::Pulumi.AzureNative.Web.Inputs.ConnStringValueTypePairArgs WithType(this global::Pulumi.AzureNative.Web.Inputs.ConnStringValueTypePairArgs @selfRef, global::Pulumi.AzureNative.Web.ConnectionStringType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.ConnStringValueTypePairArgs WithType(this global::Pulumi.AzureNative.Web.Inputs.ConnStringValueTypePairArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Web.ConnectionStringType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.Web.ConnectionStringType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.ConnStringValueTypePairArgs WithValue(this global::Pulumi.AzureNative.Web.Inputs.ConnStringValueTypePairArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
