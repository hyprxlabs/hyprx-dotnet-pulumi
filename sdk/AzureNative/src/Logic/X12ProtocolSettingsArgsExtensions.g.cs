// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Logic.Inputs;

namespace Pulumi.AzureNative.Logic;

public static partial class X12ProtocolSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithAcknowledgementSettings(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::Pulumi.AzureNative.Logic.Inputs.X12AcknowledgementSettingsArgs acknowledgementSettings)
    {
        @selfRef.AcknowledgementSettings = acknowledgementSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithAcknowledgementSettings(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Logic.Inputs.X12AcknowledgementSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Logic.Inputs.X12AcknowledgementSettingsArgs();
        @configure(@item);
        @selfRef.AcknowledgementSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithEnvelopeOverrides(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Logic.Inputs.X12EnvelopeOverrideArgs> envelopeOverrides)
    {
        @selfRef.EnvelopeOverrides = envelopeOverrides;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithEnvelopeOverrides(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Logic.Inputs.X12EnvelopeOverrideArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Logic.Inputs.X12EnvelopeOverrideArgs>();
        @configure(@list);
        @selfRef.EnvelopeOverrides = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithEnvelopeOverrides(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Logic.Inputs.X12EnvelopeOverrideArgs>> @create)
    {
        @selfRef.EnvelopeOverrides = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithEnvelopeSettings(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::Pulumi.AzureNative.Logic.Inputs.X12EnvelopeSettingsArgs envelopeSettings)
    {
        @selfRef.EnvelopeSettings = envelopeSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithEnvelopeSettings(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Logic.Inputs.X12EnvelopeSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Logic.Inputs.X12EnvelopeSettingsArgs();
        @configure(@item);
        @selfRef.EnvelopeSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithFramingSettings(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::Pulumi.AzureNative.Logic.Inputs.X12FramingSettingsArgs framingSettings)
    {
        @selfRef.FramingSettings = framingSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithFramingSettings(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Logic.Inputs.X12FramingSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Logic.Inputs.X12FramingSettingsArgs();
        @configure(@item);
        @selfRef.FramingSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithMessageFilter(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::Pulumi.AzureNative.Logic.Inputs.X12MessageFilterArgs messageFilter)
    {
        @selfRef.MessageFilter = messageFilter;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithMessageFilter(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Logic.Inputs.X12MessageFilterArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Logic.Inputs.X12MessageFilterArgs();
        @configure(@item);
        @selfRef.MessageFilter = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithMessageFilterList(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Logic.Inputs.X12MessageIdentifierArgs> messageFilterList)
    {
        @selfRef.MessageFilterList = messageFilterList;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithMessageFilterList(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Logic.Inputs.X12MessageIdentifierArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Logic.Inputs.X12MessageIdentifierArgs>();
        @configure(@list);
        @selfRef.MessageFilterList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithMessageFilterList(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Logic.Inputs.X12MessageIdentifierArgs>> @create)
    {
        @selfRef.MessageFilterList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithProcessingSettings(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::Pulumi.AzureNative.Logic.Inputs.X12ProcessingSettingsArgs processingSettings)
    {
        @selfRef.ProcessingSettings = processingSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithProcessingSettings(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Logic.Inputs.X12ProcessingSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Logic.Inputs.X12ProcessingSettingsArgs();
        @configure(@item);
        @selfRef.ProcessingSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithSchemaReferences(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Logic.Inputs.X12SchemaReferenceArgs> schemaReferences)
    {
        @selfRef.SchemaReferences = schemaReferences;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithSchemaReferences(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Logic.Inputs.X12SchemaReferenceArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Logic.Inputs.X12SchemaReferenceArgs>();
        @configure(@list);
        @selfRef.SchemaReferences = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithSchemaReferences(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Logic.Inputs.X12SchemaReferenceArgs>> @create)
    {
        @selfRef.SchemaReferences = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithSecuritySettings(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::Pulumi.AzureNative.Logic.Inputs.X12SecuritySettingsArgs securitySettings)
    {
        @selfRef.SecuritySettings = securitySettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithSecuritySettings(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Logic.Inputs.X12SecuritySettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Logic.Inputs.X12SecuritySettingsArgs();
        @configure(@item);
        @selfRef.SecuritySettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithValidationOverrides(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Logic.Inputs.X12ValidationOverrideArgs> validationOverrides)
    {
        @selfRef.ValidationOverrides = validationOverrides;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithValidationOverrides(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Logic.Inputs.X12ValidationOverrideArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Logic.Inputs.X12ValidationOverrideArgs>();
        @configure(@list);
        @selfRef.ValidationOverrides = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithValidationOverrides(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Logic.Inputs.X12ValidationOverrideArgs>> @create)
    {
        @selfRef.ValidationOverrides = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithValidationSettings(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::Pulumi.AzureNative.Logic.Inputs.X12ValidationSettingsArgs validationSettings)
    {
        @selfRef.ValidationSettings = validationSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithValidationSettings(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Logic.Inputs.X12ValidationSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Logic.Inputs.X12ValidationSettingsArgs();
        @configure(@item);
        @selfRef.ValidationSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithX12DelimiterOverrides(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Logic.Inputs.X12DelimiterOverridesArgs> x12DelimiterOverrides)
    {
        @selfRef.X12DelimiterOverrides = x12DelimiterOverrides;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithX12DelimiterOverrides(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Logic.Inputs.X12DelimiterOverridesArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Logic.Inputs.X12DelimiterOverridesArgs>();
        @configure(@list);
        @selfRef.X12DelimiterOverrides = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs WithX12DelimiterOverrides(this global::Pulumi.AzureNative.Logic.Inputs.X12ProtocolSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Logic.Inputs.X12DelimiterOverridesArgs>> @create)
    {
        @selfRef.X12DelimiterOverrides = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
