// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AppPlatform;

public static partial class CustomizedAcceleratorArgsExtensions
{
    public static global::Pulumi.AzureNative.AppPlatform.CustomizedAcceleratorArgs WithApplicationAcceleratorName(this global::Pulumi.AzureNative.AppPlatform.CustomizedAcceleratorArgs @selfRef, global::System.String applicationAcceleratorName)
    {
        @selfRef.ApplicationAcceleratorName = applicationAcceleratorName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.CustomizedAcceleratorArgs WithCustomizedAcceleratorName(this global::Pulumi.AzureNative.AppPlatform.CustomizedAcceleratorArgs @selfRef, global::System.String customizedAcceleratorName)
    {
        @selfRef.CustomizedAcceleratorName = customizedAcceleratorName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.CustomizedAcceleratorArgs WithProperties(this global::Pulumi.AzureNative.AppPlatform.CustomizedAcceleratorArgs @selfRef, global::Pulumi.AzureNative.AppPlatform.Inputs.CustomizedAcceleratorPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.CustomizedAcceleratorArgs WithProperties(this global::Pulumi.AzureNative.AppPlatform.CustomizedAcceleratorArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AppPlatform.Inputs.CustomizedAcceleratorPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AppPlatform.Inputs.CustomizedAcceleratorPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.CustomizedAcceleratorArgs WithResourceGroupName(this global::Pulumi.AzureNative.AppPlatform.CustomizedAcceleratorArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.CustomizedAcceleratorArgs WithServiceName(this global::Pulumi.AzureNative.AppPlatform.CustomizedAcceleratorArgs @selfRef, global::System.String serviceName)
    {
        @selfRef.ServiceName = serviceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.CustomizedAcceleratorArgs WithSku(this global::Pulumi.AzureNative.AppPlatform.CustomizedAcceleratorArgs @selfRef, global::Pulumi.AzureNative.AppPlatform.Inputs.SkuArgs sku)
    {
        @selfRef.Sku = sku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.CustomizedAcceleratorArgs WithSku(this global::Pulumi.AzureNative.AppPlatform.CustomizedAcceleratorArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AppPlatform.Inputs.SkuArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AppPlatform.Inputs.SkuArgs();
        @configure(@item);
        @selfRef.Sku = @item;
        return @selfRef;
    }

}
