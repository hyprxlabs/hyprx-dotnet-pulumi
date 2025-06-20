// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DataFactory;

public static partial class GlobalParameterArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.GlobalParameterArgs WithFactoryName(this global::Pulumi.AzureNative.DataFactory.GlobalParameterArgs @selfRef, global::System.String factoryName)
    {
        @selfRef.FactoryName = factoryName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.GlobalParameterArgs WithGlobalParameterName(this global::Pulumi.AzureNative.DataFactory.GlobalParameterArgs @selfRef, global::System.String globalParameterName)
    {
        @selfRef.GlobalParameterName = globalParameterName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.GlobalParameterArgs WithProperties(this global::Pulumi.AzureNative.DataFactory.GlobalParameterArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.GlobalParameterSpecificationArgs> properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.GlobalParameterArgs WithProperties(this global::Pulumi.AzureNative.DataFactory.GlobalParameterArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.GlobalParameterSpecificationArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.GlobalParameterSpecificationArgs>();
        @configure(@dict);
        @selfRef.Properties = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.GlobalParameterArgs WithProperties(this global::Pulumi.AzureNative.DataFactory.GlobalParameterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.GlobalParameterSpecificationArgs>> @create)
    {
        @selfRef.Properties = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.GlobalParameterArgs WithResourceGroupName(this global::Pulumi.AzureNative.DataFactory.GlobalParameterArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

}
