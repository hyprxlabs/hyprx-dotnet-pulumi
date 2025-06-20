// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs WithAuthType(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::System.String authType)
    {
        @selfRef.AuthType = authType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs WithCategory(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.ConnectionCategory> category)
    {
        @selfRef.Category = category;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs WithCredentials(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::Pulumi.AzureNative.MachineLearningServices.Inputs.WorkspaceConnectionManagedIdentityArgs credentials)
    {
        @selfRef.Credentials = credentials;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs WithCredentials(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.Inputs.WorkspaceConnectionManagedIdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MachineLearningServices.Inputs.WorkspaceConnectionManagedIdentityArgs();
        @configure(@item);
        @selfRef.Credentials = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs WithExpiryTime(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::System.String expiryTime)
    {
        @selfRef.ExpiryTime = expiryTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs WithIsSharedToAll(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, bool isSharedToAll = true)
    {
        @selfRef.IsSharedToAll = isSharedToAll;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs WithMetadata(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> metadata)
    {
        @selfRef.Metadata = metadata;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs WithMetadata(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Metadata = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs WithMetadata(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Metadata = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs WithSharedUserList(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> sharedUserList)
    {
        @selfRef.SharedUserList = sharedUserList;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs WithSharedUserList(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SharedUserList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs WithSharedUserList(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SharedUserList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs WithTarget(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::System.String target)
    {
        @selfRef.Target = target;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs WithValue(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs WithValueFormat(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedIdentityAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.ValueFormat> valueFormat)
    {
        @selfRef.ValueFormat = valueFormat;
        return @selfRef;
    }

}
