// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Web.Inputs;

namespace Pulumi.AzureNative.Web;

public static partial class TwitterRegistrationArgsExtensions
{
    public static global::Pulumi.AzureNative.Web.Inputs.TwitterRegistrationArgs WithConsumerKey(this global::Pulumi.AzureNative.Web.Inputs.TwitterRegistrationArgs @selfRef, global::System.String consumerKey)
    {
        @selfRef.ConsumerKey = consumerKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.TwitterRegistrationArgs WithConsumerSecretSettingName(this global::Pulumi.AzureNative.Web.Inputs.TwitterRegistrationArgs @selfRef, global::System.String consumerSecretSettingName)
    {
        @selfRef.ConsumerSecretSettingName = consumerSecretSettingName;
        return @selfRef;
    }

}
