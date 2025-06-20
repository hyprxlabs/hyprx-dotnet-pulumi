// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AppFlow.Inputs;

namespace Pulumi.AwsNative.AppFlow;

public static partial class FlowSalesforceDestinationPropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceDestinationPropertiesArgs WithDataTransferApi(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceDestinationPropertiesArgs @selfRef, global::Pulumi.AwsNative.AppFlow.FlowDataTransferApi dataTransferApi)
    {
        @selfRef.DataTransferApi = dataTransferApi;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceDestinationPropertiesArgs WithDataTransferApi(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceDestinationPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.AppFlow.FlowDataTransferApi> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.AppFlow.FlowDataTransferApi>();
        @configure(@item);
        @selfRef.DataTransferApi = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceDestinationPropertiesArgs WithErrorHandlingConfig(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceDestinationPropertiesArgs @selfRef, global::Pulumi.AwsNative.AppFlow.Inputs.FlowErrorHandlingConfigArgs errorHandlingConfig)
    {
        @selfRef.ErrorHandlingConfig = errorHandlingConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceDestinationPropertiesArgs WithErrorHandlingConfig(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceDestinationPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.AppFlow.Inputs.FlowErrorHandlingConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.AppFlow.Inputs.FlowErrorHandlingConfigArgs();
        @configure(@item);
        @selfRef.ErrorHandlingConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceDestinationPropertiesArgs WithIdFieldNames(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceDestinationPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> idFieldNames)
    {
        @selfRef.IdFieldNames = idFieldNames;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceDestinationPropertiesArgs WithIdFieldNames(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceDestinationPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.IdFieldNames = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceDestinationPropertiesArgs WithIdFieldNames(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceDestinationPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.IdFieldNames = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceDestinationPropertiesArgs WithObject(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceDestinationPropertiesArgs @selfRef, global::System.String @object)
    {
        @selfRef.Object = @object;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceDestinationPropertiesArgs WithWriteOperationType(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceDestinationPropertiesArgs @selfRef, global::Pulumi.AwsNative.AppFlow.FlowWriteOperationType writeOperationType)
    {
        @selfRef.WriteOperationType = writeOperationType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceDestinationPropertiesArgs WithWriteOperationType(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceDestinationPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.AppFlow.FlowWriteOperationType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.AppFlow.FlowWriteOperationType>();
        @configure(@item);
        @selfRef.WriteOperationType = @item;
        return @selfRef;
    }

}
