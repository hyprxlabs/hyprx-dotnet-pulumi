// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerService.Inputs;

namespace Pulumi.AzureNative.ContainerService;

public static partial class UpdateStageArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerService.Inputs.UpdateStageArgs WithAfterStageWaitInSeconds(this global::Pulumi.AzureNative.ContainerService.Inputs.UpdateStageArgs @selfRef, global::System.Int32 afterStageWaitInSeconds)
    {
        @selfRef.AfterStageWaitInSeconds = afterStageWaitInSeconds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.UpdateStageArgs WithGroups(this global::Pulumi.AzureNative.ContainerService.Inputs.UpdateStageArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerService.Inputs.UpdateGroupArgs> groups)
    {
        @selfRef.Groups = groups;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.UpdateStageArgs WithGroups(this global::Pulumi.AzureNative.ContainerService.Inputs.UpdateStageArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerService.Inputs.UpdateGroupArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerService.Inputs.UpdateGroupArgs>();
        @configure(@list);
        @selfRef.Groups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.UpdateStageArgs WithGroups(this global::Pulumi.AzureNative.ContainerService.Inputs.UpdateStageArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ContainerService.Inputs.UpdateGroupArgs>> @create)
    {
        @selfRef.Groups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.UpdateStageArgs WithName(this global::Pulumi.AzureNative.ContainerService.Inputs.UpdateStageArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

}
