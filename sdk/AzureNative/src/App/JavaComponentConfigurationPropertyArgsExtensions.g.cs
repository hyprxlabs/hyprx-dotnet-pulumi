// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.App.Inputs;

namespace Pulumi.AzureNative.App;

public static partial class JavaComponentConfigurationPropertyArgsExtensions
{
    public static global::Pulumi.AzureNative.App.Inputs.JavaComponentConfigurationPropertyArgs WithPropertyName(this global::Pulumi.AzureNative.App.Inputs.JavaComponentConfigurationPropertyArgs @selfRef, global::System.String propertyName)
    {
        @selfRef.PropertyName = propertyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.JavaComponentConfigurationPropertyArgs WithValue(this global::Pulumi.AzureNative.App.Inputs.JavaComponentConfigurationPropertyArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
