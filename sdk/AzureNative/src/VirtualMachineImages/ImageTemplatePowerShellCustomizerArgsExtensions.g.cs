// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.VirtualMachineImages.Inputs;

namespace Pulumi.AzureNative.VirtualMachineImages;

public static partial class ImageTemplatePowerShellCustomizerArgsExtensions
{
    public static global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs WithInline(this global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs @selfRef, global::System.Collections.Generic.List<global::System.String> inline)
    {
        @selfRef.Inline = inline;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs WithInline(this global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Inline = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs WithInline(this global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Inline = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs WithName(this global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs WithRunAsSystem(this global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs @selfRef, bool runAsSystem = true)
    {
        @selfRef.RunAsSystem = runAsSystem;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs WithRunElevated(this global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs @selfRef, bool runElevated = true)
    {
        @selfRef.RunElevated = runElevated;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs WithScriptUri(this global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs @selfRef, global::System.String scriptUri)
    {
        @selfRef.ScriptUri = scriptUri;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs WithSha256Checksum(this global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs @selfRef, global::System.String sha256Checksum)
    {
        @selfRef.Sha256Checksum = sha256Checksum;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs WithType(this global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs WithValidExitCodes(this global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs @selfRef, global::System.Collections.Generic.List<global::System.Int32> validExitCodes)
    {
        @selfRef.ValidExitCodes = validExitCodes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs WithValidExitCodes(this global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Int32>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Int32>();
        @configure(@list);
        @selfRef.ValidExitCodes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs WithValidExitCodes(this global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePowerShellCustomizerArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Int32>> @create)
    {
        @selfRef.ValidExitCodes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
