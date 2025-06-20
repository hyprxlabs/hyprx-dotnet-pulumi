// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.DataBrew;

public static partial class DatasetArgsExtensions
{
    public static global::Pulumi.AwsNative.DataBrew.DatasetArgs WithFormat(this global::Pulumi.AwsNative.DataBrew.DatasetArgs @selfRef, global::Pulumi.AwsNative.DataBrew.DatasetFormat format)
    {
        @selfRef.Format = format;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataBrew.DatasetArgs WithFormat(this global::Pulumi.AwsNative.DataBrew.DatasetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataBrew.DatasetFormat> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.DataBrew.DatasetFormat>();
        @configure(@item);
        @selfRef.Format = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataBrew.DatasetArgs WithFormatOptions(this global::Pulumi.AwsNative.DataBrew.DatasetArgs @selfRef, global::Pulumi.AwsNative.DataBrew.Inputs.DatasetFormatOptionsArgs formatOptions)
    {
        @selfRef.FormatOptions = formatOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataBrew.DatasetArgs WithFormatOptions(this global::Pulumi.AwsNative.DataBrew.DatasetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataBrew.Inputs.DatasetFormatOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DataBrew.Inputs.DatasetFormatOptionsArgs();
        @configure(@item);
        @selfRef.FormatOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataBrew.DatasetArgs WithInput(this global::Pulumi.AwsNative.DataBrew.DatasetArgs @selfRef, global::Pulumi.AwsNative.DataBrew.Inputs.DatasetInputArgs input)
    {
        @selfRef.Input = input;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataBrew.DatasetArgs WithInput(this global::Pulumi.AwsNative.DataBrew.DatasetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataBrew.Inputs.DatasetInputArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DataBrew.Inputs.DatasetInputArgs();
        @configure(@item);
        @selfRef.Input = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataBrew.DatasetArgs WithName(this global::Pulumi.AwsNative.DataBrew.DatasetArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataBrew.DatasetArgs WithPathOptions(this global::Pulumi.AwsNative.DataBrew.DatasetArgs @selfRef, global::Pulumi.AwsNative.DataBrew.Inputs.DatasetPathOptionsArgs pathOptions)
    {
        @selfRef.PathOptions = pathOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataBrew.DatasetArgs WithPathOptions(this global::Pulumi.AwsNative.DataBrew.DatasetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataBrew.Inputs.DatasetPathOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DataBrew.Inputs.DatasetPathOptionsArgs();
        @configure(@item);
        @selfRef.PathOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataBrew.DatasetArgs WithSource(this global::Pulumi.AwsNative.DataBrew.DatasetArgs @selfRef, global::Pulumi.AwsNative.DataBrew.DatasetSource source)
    {
        @selfRef.Source = source;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataBrew.DatasetArgs WithSource(this global::Pulumi.AwsNative.DataBrew.DatasetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataBrew.DatasetSource> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.DataBrew.DatasetSource>();
        @configure(@item);
        @selfRef.Source = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataBrew.DatasetArgs WithTags(this global::Pulumi.AwsNative.DataBrew.DatasetArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataBrew.DatasetArgs WithTags(this global::Pulumi.AwsNative.DataBrew.DatasetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataBrew.DatasetArgs WithTags(this global::Pulumi.AwsNative.DataBrew.DatasetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
