// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Evidently;

public static partial class ProjectArgsExtensions
{
    public static global::Pulumi.AwsNative.Evidently.ProjectArgs WithAppConfigResource(this global::Pulumi.AwsNative.Evidently.ProjectArgs @selfRef, global::Pulumi.AwsNative.Evidently.Inputs.ProjectAppConfigResourceObjectArgs appConfigResource)
    {
        @selfRef.AppConfigResource = appConfigResource;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Evidently.ProjectArgs WithAppConfigResource(this global::Pulumi.AwsNative.Evidently.ProjectArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Evidently.Inputs.ProjectAppConfigResourceObjectArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Evidently.Inputs.ProjectAppConfigResourceObjectArgs();
        @configure(@item);
        @selfRef.AppConfigResource = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Evidently.ProjectArgs WithDataDelivery(this global::Pulumi.AwsNative.Evidently.ProjectArgs @selfRef, global::Pulumi.AwsNative.Evidently.Inputs.ProjectDataDeliveryObjectArgs dataDelivery)
    {
        @selfRef.DataDelivery = dataDelivery;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Evidently.ProjectArgs WithDataDelivery(this global::Pulumi.AwsNative.Evidently.ProjectArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Evidently.Inputs.ProjectDataDeliveryObjectArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Evidently.Inputs.ProjectDataDeliveryObjectArgs();
        @configure(@item);
        @selfRef.DataDelivery = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Evidently.ProjectArgs WithDescription(this global::Pulumi.AwsNative.Evidently.ProjectArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Evidently.ProjectArgs WithName(this global::Pulumi.AwsNative.Evidently.ProjectArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Evidently.ProjectArgs WithTags(this global::Pulumi.AwsNative.Evidently.ProjectArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Evidently.ProjectArgs WithTags(this global::Pulumi.AwsNative.Evidently.ProjectArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Evidently.ProjectArgs WithTags(this global::Pulumi.AwsNative.Evidently.ProjectArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
