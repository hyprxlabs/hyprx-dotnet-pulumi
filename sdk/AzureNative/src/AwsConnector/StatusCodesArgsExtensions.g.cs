// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class StatusCodesArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.StatusCodesArgs WithItems(this global::Pulumi.AzureNative.AwsConnector.Inputs.StatusCodesArgs @selfRef, global::System.Collections.Generic.List<global::System.Int32> items)
    {
        @selfRef.Items = items;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.StatusCodesArgs WithItems(this global::Pulumi.AzureNative.AwsConnector.Inputs.StatusCodesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Int32>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Int32>();
        @configure(@list);
        @selfRef.Items = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.StatusCodesArgs WithItems(this global::Pulumi.AzureNative.AwsConnector.Inputs.StatusCodesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Int32>> @create)
    {
        @selfRef.Items = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.StatusCodesArgs WithQuantity(this global::Pulumi.AzureNative.AwsConnector.Inputs.StatusCodesArgs @selfRef, global::System.Int32 quantity)
    {
        @selfRef.Quantity = quantity;
        return @selfRef;
    }

}
