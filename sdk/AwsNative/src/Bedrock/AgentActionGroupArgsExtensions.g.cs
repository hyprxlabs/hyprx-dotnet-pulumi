// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class AgentActionGroupArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs WithActionGroupExecutor(this global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs @selfRef, global::Pulumi.Union<global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupExecutor0PropertiesArgs, global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupExecutor1PropertiesArgs> actionGroupExecutor)
    {
        @selfRef.ActionGroupExecutor = actionGroupExecutor;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs WithActionGroupName(this global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs @selfRef, global::System.String actionGroupName)
    {
        @selfRef.ActionGroupName = actionGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs WithActionGroupState(this global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs @selfRef, global::Pulumi.AwsNative.Bedrock.AgentActionGroupState actionGroupState)
    {
        @selfRef.ActionGroupState = actionGroupState;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs WithActionGroupState(this global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.AgentActionGroupState> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Bedrock.AgentActionGroupState>();
        @configure(@item);
        @selfRef.ActionGroupState = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs WithApiSchema(this global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs @selfRef, global::Pulumi.Union<global::Pulumi.AwsNative.Bedrock.Inputs.AgentApiSchema0PropertiesArgs, global::Pulumi.AwsNative.Bedrock.Inputs.AgentApiSchema1PropertiesArgs> apiSchema)
    {
        @selfRef.ApiSchema = apiSchema;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs WithDescription(this global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs WithFunctionSchema(this global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs @selfRef, global::Pulumi.AwsNative.Bedrock.Inputs.AgentFunctionSchemaArgs functionSchema)
    {
        @selfRef.FunctionSchema = functionSchema;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs WithFunctionSchema(this global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.Inputs.AgentFunctionSchemaArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Bedrock.Inputs.AgentFunctionSchemaArgs();
        @configure(@item);
        @selfRef.FunctionSchema = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs WithParentActionGroupSignature(this global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs @selfRef, global::Pulumi.AwsNative.Bedrock.AgentActionGroupSignature parentActionGroupSignature)
    {
        @selfRef.ParentActionGroupSignature = parentActionGroupSignature;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs WithParentActionGroupSignature(this global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.AgentActionGroupSignature> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Bedrock.AgentActionGroupSignature>();
        @configure(@item);
        @selfRef.ParentActionGroupSignature = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs WithSkipResourceInUseCheckOnDelete(this global::Pulumi.AwsNative.Bedrock.Inputs.AgentActionGroupArgs @selfRef, bool skipResourceInUseCheckOnDelete = true)
    {
        @selfRef.SkipResourceInUseCheckOnDelete = skipResourceInUseCheckOnDelete;
        return @selfRef;
    }

}
