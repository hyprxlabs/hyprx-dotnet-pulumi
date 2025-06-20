// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AppPlatform.Inputs;

namespace Pulumi.AzureNative.AppPlatform;

public static partial class CustomizedAcceleratorPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AppPlatform.Inputs.CustomizedAcceleratorPropertiesArgs WithAcceleratorTags(this global::Pulumi.AzureNative.AppPlatform.Inputs.CustomizedAcceleratorPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> acceleratorTags)
    {
        @selfRef.AcceleratorTags = acceleratorTags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.CustomizedAcceleratorPropertiesArgs WithAcceleratorTags(this global::Pulumi.AzureNative.AppPlatform.Inputs.CustomizedAcceleratorPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AcceleratorTags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.CustomizedAcceleratorPropertiesArgs WithAcceleratorTags(this global::Pulumi.AzureNative.AppPlatform.Inputs.CustomizedAcceleratorPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AcceleratorTags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.CustomizedAcceleratorPropertiesArgs WithAcceleratorType(this global::Pulumi.AzureNative.AppPlatform.Inputs.CustomizedAcceleratorPropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AppPlatform.CustomizedAcceleratorType> acceleratorType)
    {
        @selfRef.AcceleratorType = acceleratorType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.CustomizedAcceleratorPropertiesArgs WithDescription(this global::Pulumi.AzureNative.AppPlatform.Inputs.CustomizedAcceleratorPropertiesArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.CustomizedAcceleratorPropertiesArgs WithDisplayName(this global::Pulumi.AzureNative.AppPlatform.Inputs.CustomizedAcceleratorPropertiesArgs @selfRef, global::System.String displayName)
    {
        @selfRef.DisplayName = displayName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.CustomizedAcceleratorPropertiesArgs WithGitRepository(this global::Pulumi.AzureNative.AppPlatform.Inputs.CustomizedAcceleratorPropertiesArgs @selfRef, global::Pulumi.AzureNative.AppPlatform.Inputs.AcceleratorGitRepositoryArgs gitRepository)
    {
        @selfRef.GitRepository = gitRepository;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.CustomizedAcceleratorPropertiesArgs WithGitRepository(this global::Pulumi.AzureNative.AppPlatform.Inputs.CustomizedAcceleratorPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AppPlatform.Inputs.AcceleratorGitRepositoryArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AppPlatform.Inputs.AcceleratorGitRepositoryArgs();
        @configure(@item);
        @selfRef.GitRepository = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.CustomizedAcceleratorPropertiesArgs WithIconUrl(this global::Pulumi.AzureNative.AppPlatform.Inputs.CustomizedAcceleratorPropertiesArgs @selfRef, global::System.String iconUrl)
    {
        @selfRef.IconUrl = iconUrl;
        return @selfRef;
    }

}
