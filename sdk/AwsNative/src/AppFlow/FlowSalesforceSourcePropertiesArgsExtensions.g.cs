// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AppFlow.Inputs;

namespace Pulumi.AwsNative.AppFlow;

public static partial class FlowSalesforceSourcePropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceSourcePropertiesArgs WithDataTransferApi(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceSourcePropertiesArgs @selfRef, global::Pulumi.AwsNative.AppFlow.FlowDataTransferApi dataTransferApi)
    {
        @selfRef.DataTransferApi = dataTransferApi;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceSourcePropertiesArgs WithDataTransferApi(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceSourcePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.AppFlow.FlowDataTransferApi> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.AppFlow.FlowDataTransferApi>();
        @configure(@item);
        @selfRef.DataTransferApi = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceSourcePropertiesArgs WithEnableDynamicFieldUpdate(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceSourcePropertiesArgs @selfRef, bool enableDynamicFieldUpdate = true)
    {
        @selfRef.EnableDynamicFieldUpdate = enableDynamicFieldUpdate;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceSourcePropertiesArgs WithIncludeDeletedRecords(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceSourcePropertiesArgs @selfRef, bool includeDeletedRecords = true)
    {
        @selfRef.IncludeDeletedRecords = includeDeletedRecords;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceSourcePropertiesArgs WithObject(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSalesforceSourcePropertiesArgs @selfRef, global::System.String @object)
    {
        @selfRef.Object = @object;
        return @selfRef;
    }

}
