// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class OriginGroupsArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.OriginGroupsArgs WithItems(this global::Pulumi.AzureNative.AwsConnector.Inputs.OriginGroupsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.OriginGroupArgs> items)
    {
        @selfRef.Items = items;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.OriginGroupsArgs WithItems(this global::Pulumi.AzureNative.AwsConnector.Inputs.OriginGroupsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.OriginGroupArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.OriginGroupArgs>();
        @configure(@list);
        @selfRef.Items = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.OriginGroupsArgs WithItems(this global::Pulumi.AzureNative.AwsConnector.Inputs.OriginGroupsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.OriginGroupArgs>> @create)
    {
        @selfRef.Items = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.OriginGroupsArgs WithQuantity(this global::Pulumi.AzureNative.AwsConnector.Inputs.OriginGroupsArgs @selfRef, global::System.Int32 quantity)
    {
        @selfRef.Quantity = quantity;
        return @selfRef;
    }

}
