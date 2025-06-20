// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Features.Inputs;

namespace Pulumi.AzureNative.Features;

public static partial class SubscriptionFeatureRegistrationPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.Features.Inputs.SubscriptionFeatureRegistrationPropertiesArgs WithDescription(this global::Pulumi.AzureNative.Features.Inputs.SubscriptionFeatureRegistrationPropertiesArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Features.Inputs.SubscriptionFeatureRegistrationPropertiesArgs WithMetadata(this global::Pulumi.AzureNative.Features.Inputs.SubscriptionFeatureRegistrationPropertiesArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> metadata)
    {
        @selfRef.Metadata = metadata;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Features.Inputs.SubscriptionFeatureRegistrationPropertiesArgs WithMetadata(this global::Pulumi.AzureNative.Features.Inputs.SubscriptionFeatureRegistrationPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Metadata = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Features.Inputs.SubscriptionFeatureRegistrationPropertiesArgs WithMetadata(this global::Pulumi.AzureNative.Features.Inputs.SubscriptionFeatureRegistrationPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Metadata = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Features.Inputs.SubscriptionFeatureRegistrationPropertiesArgs WithShouldFeatureDisplayInPortal(this global::Pulumi.AzureNative.Features.Inputs.SubscriptionFeatureRegistrationPropertiesArgs @selfRef, bool shouldFeatureDisplayInPortal = true)
    {
        @selfRef.ShouldFeatureDisplayInPortal = shouldFeatureDisplayInPortal;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Features.Inputs.SubscriptionFeatureRegistrationPropertiesArgs WithState(this global::Pulumi.AzureNative.Features.Inputs.SubscriptionFeatureRegistrationPropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Features.SubscriptionFeatureRegistrationState> state)
    {
        @selfRef.State = state;
        return @selfRef;
    }

}
