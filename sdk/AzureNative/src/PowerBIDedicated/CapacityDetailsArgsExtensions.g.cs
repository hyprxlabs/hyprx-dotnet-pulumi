// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.PowerBIDedicated;

public static partial class CapacityDetailsArgsExtensions
{
    public static global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs WithAdministration(this global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs @selfRef, global::Pulumi.AzureNative.PowerBIDedicated.Inputs.DedicatedCapacityAdministratorsArgs administration)
    {
        @selfRef.Administration = administration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs WithAdministration(this global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.PowerBIDedicated.Inputs.DedicatedCapacityAdministratorsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.PowerBIDedicated.Inputs.DedicatedCapacityAdministratorsArgs();
        @configure(@item);
        @selfRef.Administration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs WithDedicatedCapacityName(this global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs @selfRef, global::System.String dedicatedCapacityName)
    {
        @selfRef.DedicatedCapacityName = dedicatedCapacityName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs WithLocation(this global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs WithMode(this global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.PowerBIDedicated.Mode> mode)
    {
        @selfRef.Mode = mode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs WithResourceGroupName(this global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs WithSku(this global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs @selfRef, global::Pulumi.AzureNative.PowerBIDedicated.Inputs.CapacitySkuArgs sku)
    {
        @selfRef.Sku = sku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs WithSku(this global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.PowerBIDedicated.Inputs.CapacitySkuArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.PowerBIDedicated.Inputs.CapacitySkuArgs();
        @configure(@item);
        @selfRef.Sku = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs WithSystemData(this global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs @selfRef, global::Pulumi.AzureNative.PowerBIDedicated.Inputs.SystemDataArgs systemData)
    {
        @selfRef.SystemData = systemData;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs WithSystemData(this global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.PowerBIDedicated.Inputs.SystemDataArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.PowerBIDedicated.Inputs.SystemDataArgs();
        @configure(@item);
        @selfRef.SystemData = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs WithTags(this global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs WithTags(this global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs WithTags(this global::Pulumi.AzureNative.PowerBIDedicated.CapacityDetailsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
