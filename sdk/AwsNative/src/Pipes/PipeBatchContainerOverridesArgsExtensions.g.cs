// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Pipes.Inputs;

namespace Pulumi.AwsNative.Pipes;

public static partial class PipeBatchContainerOverridesArgsExtensions
{
    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchContainerOverridesArgs WithCommand(this global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchContainerOverridesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> command)
    {
        @selfRef.Command = command;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchContainerOverridesArgs WithCommand(this global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchContainerOverridesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Command = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchContainerOverridesArgs WithCommand(this global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchContainerOverridesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Command = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchContainerOverridesArgs WithEnvironment(this global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchContainerOverridesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchEnvironmentVariableArgs> environment)
    {
        @selfRef.Environment = environment;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchContainerOverridesArgs WithEnvironment(this global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchContainerOverridesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchEnvironmentVariableArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchEnvironmentVariableArgs>();
        @configure(@list);
        @selfRef.Environment = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchContainerOverridesArgs WithEnvironment(this global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchContainerOverridesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchEnvironmentVariableArgs>> @create)
    {
        @selfRef.Environment = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchContainerOverridesArgs WithInstanceType(this global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchContainerOverridesArgs @selfRef, global::System.String instanceType)
    {
        @selfRef.InstanceType = instanceType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchContainerOverridesArgs WithResourceRequirements(this global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchContainerOverridesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchResourceRequirementArgs> resourceRequirements)
    {
        @selfRef.ResourceRequirements = resourceRequirements;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchContainerOverridesArgs WithResourceRequirements(this global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchContainerOverridesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchResourceRequirementArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchResourceRequirementArgs>();
        @configure(@list);
        @selfRef.ResourceRequirements = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchContainerOverridesArgs WithResourceRequirements(this global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchContainerOverridesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Pipes.Inputs.PipeBatchResourceRequirementArgs>> @create)
    {
        @selfRef.ResourceRequirements = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
