// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QBusiness.Inputs;

namespace Pulumi.AwsNative.QBusiness;

public static partial class WebExperienceBrowserExtensionConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QBusiness.Inputs.WebExperienceBrowserExtensionConfigurationArgs WithEnabledBrowserExtensions(this global::Pulumi.AwsNative.QBusiness.Inputs.WebExperienceBrowserExtensionConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QBusiness.WebExperienceBrowserExtension> enabledBrowserExtensions)
    {
        @selfRef.EnabledBrowserExtensions = enabledBrowserExtensions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.WebExperienceBrowserExtensionConfigurationArgs WithEnabledBrowserExtensions(this global::Pulumi.AwsNative.QBusiness.Inputs.WebExperienceBrowserExtensionConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QBusiness.WebExperienceBrowserExtension>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QBusiness.WebExperienceBrowserExtension>();
        @configure(@list);
        @selfRef.EnabledBrowserExtensions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.WebExperienceBrowserExtensionConfigurationArgs WithEnabledBrowserExtensions(this global::Pulumi.AwsNative.QBusiness.Inputs.WebExperienceBrowserExtensionConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QBusiness.WebExperienceBrowserExtension>> @create)
    {
        @selfRef.EnabledBrowserExtensions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
