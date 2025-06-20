// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class MapperAttributeMappingsArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.MapperAttributeMappingsArgs WithAttributeMappings(this global::Pulumi.AzureNative.DataFactory.Inputs.MapperAttributeMappingsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.MapperAttributeMappingArgs> attributeMappings)
    {
        @selfRef.AttributeMappings = attributeMappings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.MapperAttributeMappingsArgs WithAttributeMappings(this global::Pulumi.AzureNative.DataFactory.Inputs.MapperAttributeMappingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.MapperAttributeMappingArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.MapperAttributeMappingArgs>();
        @configure(@list);
        @selfRef.AttributeMappings = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.MapperAttributeMappingsArgs WithAttributeMappings(this global::Pulumi.AzureNative.DataFactory.Inputs.MapperAttributeMappingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DataFactory.Inputs.MapperAttributeMappingArgs>> @create)
    {
        @selfRef.AttributeMappings = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
