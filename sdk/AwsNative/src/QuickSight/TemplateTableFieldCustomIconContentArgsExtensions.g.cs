// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateTableFieldCustomIconContentArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTableFieldCustomIconContentArgs WithIcon(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTableFieldCustomIconContentArgs @selfRef, global::Pulumi.AwsNative.QuickSight.TemplateTableFieldIconSetType icon)
    {
        @selfRef.Icon = icon;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTableFieldCustomIconContentArgs WithIcon(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTableFieldCustomIconContentArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.TemplateTableFieldIconSetType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.TemplateTableFieldIconSetType>();
        @configure(@item);
        @selfRef.Icon = @item;
        return @selfRef;
    }

}
