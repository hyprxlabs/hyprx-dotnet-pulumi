// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Logic.Inputs;

namespace Pulumi.AzureNative.Logic;

public static partial class EdifactDelimiterOverrideArgsExtensions
{
    public static global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs WithComponentSeparator(this global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs @selfRef, global::System.Int32 componentSeparator)
    {
        @selfRef.ComponentSeparator = componentSeparator;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs WithDataElementSeparator(this global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs @selfRef, global::System.Int32 dataElementSeparator)
    {
        @selfRef.DataElementSeparator = dataElementSeparator;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs WithDecimalPointIndicator(this global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs @selfRef, global::Pulumi.AzureNative.Logic.EdifactDecimalIndicator decimalPointIndicator)
    {
        @selfRef.DecimalPointIndicator = decimalPointIndicator;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs WithDecimalPointIndicator(this global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Logic.EdifactDecimalIndicator> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.Logic.EdifactDecimalIndicator>();
        @configure(@item);
        @selfRef.DecimalPointIndicator = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs WithMessageAssociationAssignedCode(this global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs @selfRef, global::System.String messageAssociationAssignedCode)
    {
        @selfRef.MessageAssociationAssignedCode = messageAssociationAssignedCode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs WithMessageId(this global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs @selfRef, global::System.String messageId)
    {
        @selfRef.MessageId = messageId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs WithMessageRelease(this global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs @selfRef, global::System.String messageRelease)
    {
        @selfRef.MessageRelease = messageRelease;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs WithMessageVersion(this global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs @selfRef, global::System.String messageVersion)
    {
        @selfRef.MessageVersion = messageVersion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs WithReleaseIndicator(this global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs @selfRef, global::System.Int32 releaseIndicator)
    {
        @selfRef.ReleaseIndicator = releaseIndicator;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs WithRepetitionSeparator(this global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs @selfRef, global::System.Int32 repetitionSeparator)
    {
        @selfRef.RepetitionSeparator = repetitionSeparator;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs WithSegmentTerminator(this global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs @selfRef, global::System.Int32 segmentTerminator)
    {
        @selfRef.SegmentTerminator = segmentTerminator;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs WithSegmentTerminatorSuffix(this global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs @selfRef, global::Pulumi.AzureNative.Logic.SegmentTerminatorSuffix segmentTerminatorSuffix)
    {
        @selfRef.SegmentTerminatorSuffix = segmentTerminatorSuffix;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs WithSegmentTerminatorSuffix(this global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Logic.SegmentTerminatorSuffix> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.Logic.SegmentTerminatorSuffix>();
        @configure(@item);
        @selfRef.SegmentTerminatorSuffix = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs WithTargetNamespace(this global::Pulumi.AzureNative.Logic.Inputs.EdifactDelimiterOverrideArgs @selfRef, global::System.String targetNamespace)
    {
        @selfRef.TargetNamespace = targetNamespace;
        return @selfRef;
    }

}
