// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class NoneAuthTypeWorkspaceConnectionPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs WithAuthType(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::System.String authType)
    {
        @selfRef.AuthType = authType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs WithCategory(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.ConnectionCategory> category)
    {
        @selfRef.Category = category;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs WithExpiryTime(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::System.String expiryTime)
    {
        @selfRef.ExpiryTime = expiryTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs WithIsSharedToAll(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, bool isSharedToAll = true)
    {
        @selfRef.IsSharedToAll = isSharedToAll;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs WithMetadata(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> metadata)
    {
        @selfRef.Metadata = metadata;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs WithMetadata(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Metadata = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs WithMetadata(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Metadata = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs WithSharedUserList(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> sharedUserList)
    {
        @selfRef.SharedUserList = sharedUserList;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs WithSharedUserList(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SharedUserList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs WithSharedUserList(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SharedUserList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs WithTarget(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::System.String target)
    {
        @selfRef.Target = target;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs WithValue(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs WithValueFormat(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.NoneAuthTypeWorkspaceConnectionPropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.ValueFormat> valueFormat)
    {
        @selfRef.ValueFormat = valueFormat;
        return @selfRef;
    }

}
