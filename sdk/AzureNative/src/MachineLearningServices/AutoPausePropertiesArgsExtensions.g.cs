// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class AutoPausePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.AutoPausePropertiesArgs WithDelayInMinutes(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.AutoPausePropertiesArgs @selfRef, global::System.Int32 delayInMinutes)
    {
        @selfRef.DelayInMinutes = delayInMinutes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.AutoPausePropertiesArgs WithEnabled(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.AutoPausePropertiesArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

}
