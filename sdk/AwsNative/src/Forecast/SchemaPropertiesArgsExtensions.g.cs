// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Forecast.Inputs;

namespace Pulumi.AwsNative.Forecast;

public static partial class SchemaPropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.Forecast.Inputs.SchemaPropertiesArgs WithAttributes(this global::Pulumi.AwsNative.Forecast.Inputs.SchemaPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Forecast.Inputs.DatasetAttributesItemPropertiesArgs> attributes)
    {
        @selfRef.Attributes = attributes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Forecast.Inputs.SchemaPropertiesArgs WithAttributes(this global::Pulumi.AwsNative.Forecast.Inputs.SchemaPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Forecast.Inputs.DatasetAttributesItemPropertiesArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Forecast.Inputs.DatasetAttributesItemPropertiesArgs>();
        @configure(@list);
        @selfRef.Attributes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Forecast.Inputs.SchemaPropertiesArgs WithAttributes(this global::Pulumi.AwsNative.Forecast.Inputs.SchemaPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Forecast.Inputs.DatasetAttributesItemPropertiesArgs>> @create)
    {
        @selfRef.Attributes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
