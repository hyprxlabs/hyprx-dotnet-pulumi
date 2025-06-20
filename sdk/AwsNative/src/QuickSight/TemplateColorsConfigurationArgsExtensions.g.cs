// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateColorsConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColorsConfigurationArgs WithCustomColors(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColorsConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateCustomColorArgs> customColors)
    {
        @selfRef.CustomColors = customColors;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColorsConfigurationArgs WithCustomColors(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColorsConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateCustomColorArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateCustomColorArgs>();
        @configure(@list);
        @selfRef.CustomColors = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColorsConfigurationArgs WithCustomColors(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColorsConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateCustomColorArgs>> @create)
    {
        @selfRef.CustomColors = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
