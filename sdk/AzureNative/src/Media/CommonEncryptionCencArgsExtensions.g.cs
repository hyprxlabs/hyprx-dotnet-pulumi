// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Media.Inputs;

namespace Pulumi.AzureNative.Media;

public static partial class CommonEncryptionCencArgsExtensions
{
    public static global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs WithClearKeyEncryptionConfiguration(this global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs @selfRef, global::Pulumi.AzureNative.Media.Inputs.ClearKeyEncryptionConfigurationArgs clearKeyEncryptionConfiguration)
    {
        @selfRef.ClearKeyEncryptionConfiguration = clearKeyEncryptionConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs WithClearKeyEncryptionConfiguration(this global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Media.Inputs.ClearKeyEncryptionConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Media.Inputs.ClearKeyEncryptionConfigurationArgs();
        @configure(@item);
        @selfRef.ClearKeyEncryptionConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs WithClearTracks(this global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Media.Inputs.TrackSelectionArgs> clearTracks)
    {
        @selfRef.ClearTracks = clearTracks;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs WithClearTracks(this global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Media.Inputs.TrackSelectionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Media.Inputs.TrackSelectionArgs>();
        @configure(@list);
        @selfRef.ClearTracks = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs WithClearTracks(this global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Media.Inputs.TrackSelectionArgs>> @create)
    {
        @selfRef.ClearTracks = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs WithContentKeys(this global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs @selfRef, global::Pulumi.AzureNative.Media.Inputs.StreamingPolicyContentKeysArgs contentKeys)
    {
        @selfRef.ContentKeys = contentKeys;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs WithContentKeys(this global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Media.Inputs.StreamingPolicyContentKeysArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Media.Inputs.StreamingPolicyContentKeysArgs();
        @configure(@item);
        @selfRef.ContentKeys = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs WithDrm(this global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs @selfRef, global::Pulumi.AzureNative.Media.Inputs.CencDrmConfigurationArgs drm)
    {
        @selfRef.Drm = drm;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs WithDrm(this global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Media.Inputs.CencDrmConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Media.Inputs.CencDrmConfigurationArgs();
        @configure(@item);
        @selfRef.Drm = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs WithEnabledProtocols(this global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs @selfRef, global::Pulumi.AzureNative.Media.Inputs.EnabledProtocolsArgs enabledProtocols)
    {
        @selfRef.EnabledProtocols = enabledProtocols;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs WithEnabledProtocols(this global::Pulumi.AzureNative.Media.Inputs.CommonEncryptionCencArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Media.Inputs.EnabledProtocolsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Media.Inputs.EnabledProtocolsArgs();
        @configure(@item);
        @selfRef.EnabledProtocols = @item;
        return @selfRef;
    }

}
