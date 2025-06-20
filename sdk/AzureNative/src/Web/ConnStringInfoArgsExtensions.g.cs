// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Web.Inputs;

namespace Pulumi.AzureNative.Web;

public static partial class ConnStringInfoArgsExtensions
{
    public static global::Pulumi.AzureNative.Web.Inputs.ConnStringInfoArgs WithConnectionString(this global::Pulumi.AzureNative.Web.Inputs.ConnStringInfoArgs @selfRef, global::System.String connectionString)
    {
        @selfRef.ConnectionString = connectionString;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.ConnStringInfoArgs WithName(this global::Pulumi.AzureNative.Web.Inputs.ConnStringInfoArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.ConnStringInfoArgs WithType(this global::Pulumi.AzureNative.Web.Inputs.ConnStringInfoArgs @selfRef, global::Pulumi.AzureNative.Web.ConnectionStringType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.ConnStringInfoArgs WithType(this global::Pulumi.AzureNative.Web.Inputs.ConnStringInfoArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Web.ConnectionStringType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.Web.ConnectionStringType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
