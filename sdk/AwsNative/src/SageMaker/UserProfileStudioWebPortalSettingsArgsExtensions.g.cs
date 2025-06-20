// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class UserProfileStudioWebPortalSettingsArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs WithHiddenAppTypes(this global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.UserProfileAppType> hiddenAppTypes)
    {
        @selfRef.HiddenAppTypes = hiddenAppTypes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs WithHiddenAppTypes(this global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.UserProfileAppType>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.UserProfileAppType>();
        @configure(@list);
        @selfRef.HiddenAppTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs WithHiddenAppTypes(this global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.SageMaker.UserProfileAppType>> @create)
    {
        @selfRef.HiddenAppTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs WithHiddenInstanceTypes(this global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.UserProfileAppInstanceType> hiddenInstanceTypes)
    {
        @selfRef.HiddenInstanceTypes = hiddenInstanceTypes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs WithHiddenInstanceTypes(this global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.UserProfileAppInstanceType>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.UserProfileAppInstanceType>();
        @configure(@list);
        @selfRef.HiddenInstanceTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs WithHiddenInstanceTypes(this global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.SageMaker.UserProfileAppInstanceType>> @create)
    {
        @selfRef.HiddenInstanceTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs WithHiddenMlTools(this global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.UserProfileMlTools> hiddenMlTools)
    {
        @selfRef.HiddenMlTools = hiddenMlTools;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs WithHiddenMlTools(this global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.UserProfileMlTools>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.UserProfileMlTools>();
        @configure(@list);
        @selfRef.HiddenMlTools = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs WithHiddenMlTools(this global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.SageMaker.UserProfileMlTools>> @create)
    {
        @selfRef.HiddenMlTools = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs WithHiddenSageMakerImageVersionAliases(this global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileHiddenSageMakerImageArgs> hiddenSageMakerImageVersionAliases)
    {
        @selfRef.HiddenSageMakerImageVersionAliases = hiddenSageMakerImageVersionAliases;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs WithHiddenSageMakerImageVersionAliases(this global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileHiddenSageMakerImageArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileHiddenSageMakerImageArgs>();
        @configure(@list);
        @selfRef.HiddenSageMakerImageVersionAliases = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs WithHiddenSageMakerImageVersionAliases(this global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileStudioWebPortalSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.SageMaker.Inputs.UserProfileHiddenSageMakerImageArgs>> @create)
    {
        @selfRef.HiddenSageMakerImageVersionAliases = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
