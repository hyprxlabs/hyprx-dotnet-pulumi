// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.CustomerProfiles.Inputs;

namespace Pulumi.AwsNative.CustomerProfiles;

public static partial class SegmentDefinitionExtraLengthValueProfileDimensionArgsExtensions
{
    public static global::Pulumi.AwsNative.CustomerProfiles.Inputs.SegmentDefinitionExtraLengthValueProfileDimensionArgs WithDimensionType(this global::Pulumi.AwsNative.CustomerProfiles.Inputs.SegmentDefinitionExtraLengthValueProfileDimensionArgs @selfRef, global::Pulumi.AwsNative.CustomerProfiles.SegmentDefinitionStringDimensionType dimensionType)
    {
        @selfRef.DimensionType = dimensionType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CustomerProfiles.Inputs.SegmentDefinitionExtraLengthValueProfileDimensionArgs WithDimensionType(this global::Pulumi.AwsNative.CustomerProfiles.Inputs.SegmentDefinitionExtraLengthValueProfileDimensionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CustomerProfiles.SegmentDefinitionStringDimensionType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.CustomerProfiles.SegmentDefinitionStringDimensionType>();
        @configure(@item);
        @selfRef.DimensionType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CustomerProfiles.Inputs.SegmentDefinitionExtraLengthValueProfileDimensionArgs WithValues(this global::Pulumi.AwsNative.CustomerProfiles.Inputs.SegmentDefinitionExtraLengthValueProfileDimensionArgs @selfRef, global::System.Collections.Generic.List<global::System.String> values)
    {
        @selfRef.Values = values;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CustomerProfiles.Inputs.SegmentDefinitionExtraLengthValueProfileDimensionArgs WithValues(this global::Pulumi.AwsNative.CustomerProfiles.Inputs.SegmentDefinitionExtraLengthValueProfileDimensionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Values = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CustomerProfiles.Inputs.SegmentDefinitionExtraLengthValueProfileDimensionArgs WithValues(this global::Pulumi.AwsNative.CustomerProfiles.Inputs.SegmentDefinitionExtraLengthValueProfileDimensionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Values = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
