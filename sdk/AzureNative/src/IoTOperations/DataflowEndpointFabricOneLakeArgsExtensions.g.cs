// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.IoTOperations.Inputs;

namespace Pulumi.AzureNative.IoTOperations;

public static partial class DataflowEndpointFabricOneLakeArgsExtensions
{
    public static global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeArgs WithAuthentication(this global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeArgs @selfRef, global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeAuthenticationArgs authentication)
    {
        @selfRef.Authentication = authentication;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeArgs WithAuthentication(this global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeAuthenticationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeAuthenticationArgs();
        @configure(@item);
        @selfRef.Authentication = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeArgs WithBatching(this global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeArgs @selfRef, global::Pulumi.AzureNative.IoTOperations.Inputs.BatchingConfigurationArgs batching)
    {
        @selfRef.Batching = batching;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeArgs WithBatching(this global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperations.Inputs.BatchingConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperations.Inputs.BatchingConfigurationArgs();
        @configure(@item);
        @selfRef.Batching = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeArgs WithHost(this global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeArgs @selfRef, global::System.String host)
    {
        @selfRef.Host = host;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeArgs WithNames(this global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeArgs @selfRef, global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeNamesArgs names)
    {
        @selfRef.Names = names;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeArgs WithNames(this global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeNamesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeNamesArgs();
        @configure(@item);
        @selfRef.Names = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeArgs WithOneLakePathType(this global::Pulumi.AzureNative.IoTOperations.Inputs.DataflowEndpointFabricOneLakeArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.IoTOperations.DataflowEndpointFabricPathType> oneLakePathType)
    {
        @selfRef.OneLakePathType = oneLakePathType;
        return @selfRef;
    }

}
