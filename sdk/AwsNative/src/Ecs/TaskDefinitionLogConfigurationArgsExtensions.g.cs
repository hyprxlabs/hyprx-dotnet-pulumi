// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ecs.Inputs;

namespace Pulumi.AwsNative.Ecs;

public static partial class TaskDefinitionLogConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionLogConfigurationArgs WithLogDriver(this global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionLogConfigurationArgs @selfRef, global::System.String logDriver)
    {
        @selfRef.LogDriver = logDriver;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionLogConfigurationArgs WithOptions(this global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionLogConfigurationArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> options)
    {
        @selfRef.Options = options;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionLogConfigurationArgs WithOptions(this global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionLogConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Options = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionLogConfigurationArgs WithOptions(this global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionLogConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Options = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionLogConfigurationArgs WithSecretOptions(this global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionLogConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionSecretArgs> secretOptions)
    {
        @selfRef.SecretOptions = secretOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionLogConfigurationArgs WithSecretOptions(this global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionLogConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionSecretArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionSecretArgs>();
        @configure(@list);
        @selfRef.SecretOptions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionLogConfigurationArgs WithSecretOptions(this global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionLogConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionSecretArgs>> @create)
    {
        @selfRef.SecretOptions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
