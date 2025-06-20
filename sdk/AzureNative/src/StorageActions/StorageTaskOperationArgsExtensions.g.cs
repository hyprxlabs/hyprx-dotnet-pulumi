// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.StorageActions.Inputs;

namespace Pulumi.AzureNative.StorageActions;

public static partial class StorageTaskOperationArgsExtensions
{
    public static global::Pulumi.AzureNative.StorageActions.Inputs.StorageTaskOperationArgs WithName(this global::Pulumi.AzureNative.StorageActions.Inputs.StorageTaskOperationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.StorageActions.StorageTaskOperationName> name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageActions.Inputs.StorageTaskOperationArgs WithOnFailure(this global::Pulumi.AzureNative.StorageActions.Inputs.StorageTaskOperationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.StorageActions.OnFailure> onFailure)
    {
        @selfRef.OnFailure = onFailure;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageActions.Inputs.StorageTaskOperationArgs WithOnSuccess(this global::Pulumi.AzureNative.StorageActions.Inputs.StorageTaskOperationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.StorageActions.OnSuccess> onSuccess)
    {
        @selfRef.OnSuccess = onSuccess;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageActions.Inputs.StorageTaskOperationArgs WithParameters(this global::Pulumi.AzureNative.StorageActions.Inputs.StorageTaskOperationArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> parameters)
    {
        @selfRef.Parameters = parameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageActions.Inputs.StorageTaskOperationArgs WithParameters(this global::Pulumi.AzureNative.StorageActions.Inputs.StorageTaskOperationArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Parameters = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageActions.Inputs.StorageTaskOperationArgs WithParameters(this global::Pulumi.AzureNative.StorageActions.Inputs.StorageTaskOperationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Parameters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
