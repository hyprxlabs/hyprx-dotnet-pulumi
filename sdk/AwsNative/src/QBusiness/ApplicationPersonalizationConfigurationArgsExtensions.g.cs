// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QBusiness.Inputs;

namespace Pulumi.AwsNative.QBusiness;

public static partial class ApplicationPersonalizationConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QBusiness.Inputs.ApplicationPersonalizationConfigurationArgs WithPersonalizationControlMode(this global::Pulumi.AwsNative.QBusiness.Inputs.ApplicationPersonalizationConfigurationArgs @selfRef, global::Pulumi.AwsNative.QBusiness.ApplicationPersonalizationControlMode personalizationControlMode)
    {
        @selfRef.PersonalizationControlMode = personalizationControlMode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.ApplicationPersonalizationConfigurationArgs WithPersonalizationControlMode(this global::Pulumi.AwsNative.QBusiness.Inputs.ApplicationPersonalizationConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QBusiness.ApplicationPersonalizationControlMode> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QBusiness.ApplicationPersonalizationControlMode>();
        @configure(@item);
        @selfRef.PersonalizationControlMode = @item;
        return @selfRef;
    }

}
