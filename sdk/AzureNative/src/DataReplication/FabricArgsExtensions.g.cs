// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DataReplication;

public static partial class FabricArgsExtensions
{
    public static global::Pulumi.AzureNative.DataReplication.FabricArgs WithFabricName(this global::Pulumi.AzureNative.DataReplication.FabricArgs @selfRef, global::System.String fabricName)
    {
        @selfRef.FabricName = fabricName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataReplication.FabricArgs WithLocation(this global::Pulumi.AzureNative.DataReplication.FabricArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataReplication.FabricArgs WithProperties(this global::Pulumi.AzureNative.DataReplication.FabricArgs @selfRef, global::Pulumi.AzureNative.DataReplication.Inputs.FabricModelPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataReplication.FabricArgs WithProperties(this global::Pulumi.AzureNative.DataReplication.FabricArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataReplication.Inputs.FabricModelPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataReplication.Inputs.FabricModelPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataReplication.FabricArgs WithResourceGroupName(this global::Pulumi.AzureNative.DataReplication.FabricArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataReplication.FabricArgs WithTags(this global::Pulumi.AzureNative.DataReplication.FabricArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataReplication.FabricArgs WithTags(this global::Pulumi.AzureNative.DataReplication.FabricArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataReplication.FabricArgs WithTags(this global::Pulumi.AzureNative.DataReplication.FabricArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
