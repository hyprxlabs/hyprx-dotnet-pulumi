// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.IoT;

public static partial class DimensionArgsExtensions
{
    public static global::Pulumi.AwsNative.IoT.DimensionArgs WithName(this global::Pulumi.AwsNative.IoT.DimensionArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.DimensionArgs WithStringValues(this global::Pulumi.AwsNative.IoT.DimensionArgs @selfRef, global::System.Collections.Generic.List<global::System.String> stringValues)
    {
        @selfRef.StringValues = stringValues;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.DimensionArgs WithStringValues(this global::Pulumi.AwsNative.IoT.DimensionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.StringValues = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.DimensionArgs WithStringValues(this global::Pulumi.AwsNative.IoT.DimensionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.StringValues = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.DimensionArgs WithTags(this global::Pulumi.AwsNative.IoT.DimensionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.DimensionArgs WithTags(this global::Pulumi.AwsNative.IoT.DimensionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.DimensionArgs WithTags(this global::Pulumi.AwsNative.IoT.DimensionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.DimensionArgs WithType(this global::Pulumi.AwsNative.IoT.DimensionArgs @selfRef, global::Pulumi.AwsNative.IoT.DimensionType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.DimensionArgs WithType(this global::Pulumi.AwsNative.IoT.DimensionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoT.DimensionType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.IoT.DimensionType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
