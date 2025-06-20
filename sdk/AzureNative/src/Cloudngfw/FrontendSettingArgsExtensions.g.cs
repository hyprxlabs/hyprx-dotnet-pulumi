// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Cloudngfw.Inputs;

namespace Pulumi.AzureNative.Cloudngfw;

public static partial class FrontendSettingArgsExtensions
{
    public static global::Pulumi.AzureNative.Cloudngfw.Inputs.FrontendSettingArgs WithBackendConfiguration(this global::Pulumi.AzureNative.Cloudngfw.Inputs.FrontendSettingArgs @selfRef, global::Pulumi.AzureNative.Cloudngfw.Inputs.EndpointConfigurationArgs backendConfiguration)
    {
        @selfRef.BackendConfiguration = backendConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cloudngfw.Inputs.FrontendSettingArgs WithBackendConfiguration(this global::Pulumi.AzureNative.Cloudngfw.Inputs.FrontendSettingArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Cloudngfw.Inputs.EndpointConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Cloudngfw.Inputs.EndpointConfigurationArgs();
        @configure(@item);
        @selfRef.BackendConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cloudngfw.Inputs.FrontendSettingArgs WithFrontendConfiguration(this global::Pulumi.AzureNative.Cloudngfw.Inputs.FrontendSettingArgs @selfRef, global::Pulumi.AzureNative.Cloudngfw.Inputs.EndpointConfigurationArgs frontendConfiguration)
    {
        @selfRef.FrontendConfiguration = frontendConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cloudngfw.Inputs.FrontendSettingArgs WithFrontendConfiguration(this global::Pulumi.AzureNative.Cloudngfw.Inputs.FrontendSettingArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Cloudngfw.Inputs.EndpointConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Cloudngfw.Inputs.EndpointConfigurationArgs();
        @configure(@item);
        @selfRef.FrontendConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cloudngfw.Inputs.FrontendSettingArgs WithName(this global::Pulumi.AzureNative.Cloudngfw.Inputs.FrontendSettingArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cloudngfw.Inputs.FrontendSettingArgs WithProtocol(this global::Pulumi.AzureNative.Cloudngfw.Inputs.FrontendSettingArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Cloudngfw.ProtocolType> protocol)
    {
        @selfRef.Protocol = protocol;
        return @selfRef;
    }

}
