// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateDateAxisOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDateAxisOptionsArgs WithMissingDateVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDateAxisOptionsArgs @selfRef, global::System.Object missingDateVisibility)
    {
        @selfRef.MissingDateVisibility = missingDateVisibility;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDateAxisOptionsArgs WithMissingDateVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDateAxisOptionsArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.MissingDateVisibility = @item;
        return @selfRef;
    }

}
