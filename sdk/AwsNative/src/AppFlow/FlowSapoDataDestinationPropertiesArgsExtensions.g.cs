// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AppFlow.Inputs;

namespace Pulumi.AwsNative.AppFlow;

public static partial class FlowSapoDataDestinationPropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSapoDataDestinationPropertiesArgs WithErrorHandlingConfig(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSapoDataDestinationPropertiesArgs @selfRef, global::Pulumi.AwsNative.AppFlow.Inputs.FlowErrorHandlingConfigArgs errorHandlingConfig)
    {
        @selfRef.ErrorHandlingConfig = errorHandlingConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSapoDataDestinationPropertiesArgs WithErrorHandlingConfig(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSapoDataDestinationPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.AppFlow.Inputs.FlowErrorHandlingConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.AppFlow.Inputs.FlowErrorHandlingConfigArgs();
        @configure(@item);
        @selfRef.ErrorHandlingConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSapoDataDestinationPropertiesArgs WithIdFieldNames(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSapoDataDestinationPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> idFieldNames)
    {
        @selfRef.IdFieldNames = idFieldNames;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSapoDataDestinationPropertiesArgs WithIdFieldNames(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSapoDataDestinationPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.IdFieldNames = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSapoDataDestinationPropertiesArgs WithIdFieldNames(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSapoDataDestinationPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.IdFieldNames = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSapoDataDestinationPropertiesArgs WithObjectPath(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSapoDataDestinationPropertiesArgs @selfRef, global::System.String objectPath)
    {
        @selfRef.ObjectPath = objectPath;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSapoDataDestinationPropertiesArgs WithSuccessResponseHandlingConfig(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSapoDataDestinationPropertiesArgs @selfRef, global::Pulumi.AwsNative.AppFlow.Inputs.FlowSuccessResponseHandlingConfigArgs successResponseHandlingConfig)
    {
        @selfRef.SuccessResponseHandlingConfig = successResponseHandlingConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSapoDataDestinationPropertiesArgs WithSuccessResponseHandlingConfig(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSapoDataDestinationPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.AppFlow.Inputs.FlowSuccessResponseHandlingConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.AppFlow.Inputs.FlowSuccessResponseHandlingConfigArgs();
        @configure(@item);
        @selfRef.SuccessResponseHandlingConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSapoDataDestinationPropertiesArgs WithWriteOperationType(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSapoDataDestinationPropertiesArgs @selfRef, global::Pulumi.AwsNative.AppFlow.FlowWriteOperationType writeOperationType)
    {
        @selfRef.WriteOperationType = writeOperationType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowSapoDataDestinationPropertiesArgs WithWriteOperationType(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowSapoDataDestinationPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.AppFlow.FlowWriteOperationType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.AppFlow.FlowWriteOperationType>();
        @configure(@item);
        @selfRef.WriteOperationType = @item;
        return @selfRef;
    }

}
