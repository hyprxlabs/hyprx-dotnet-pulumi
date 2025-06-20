// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class HealthCheckArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.HealthCheckArgs WithCommand(this global::Pulumi.AzureNative.AwsConnector.Inputs.HealthCheckArgs @selfRef, global::System.Collections.Generic.List<global::System.String> command)
    {
        @selfRef.Command = command;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.HealthCheckArgs WithCommand(this global::Pulumi.AzureNative.AwsConnector.Inputs.HealthCheckArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Command = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.HealthCheckArgs WithCommand(this global::Pulumi.AzureNative.AwsConnector.Inputs.HealthCheckArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Command = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.HealthCheckArgs WithInterval(this global::Pulumi.AzureNative.AwsConnector.Inputs.HealthCheckArgs @selfRef, global::System.Int32 interval)
    {
        @selfRef.Interval = interval;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.HealthCheckArgs WithRetries(this global::Pulumi.AzureNative.AwsConnector.Inputs.HealthCheckArgs @selfRef, global::System.Int32 retries)
    {
        @selfRef.Retries = retries;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.HealthCheckArgs WithStartPeriod(this global::Pulumi.AzureNative.AwsConnector.Inputs.HealthCheckArgs @selfRef, global::System.Int32 startPeriod)
    {
        @selfRef.StartPeriod = startPeriod;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.HealthCheckArgs WithTimeout(this global::Pulumi.AzureNative.AwsConnector.Inputs.HealthCheckArgs @selfRef, global::System.Int32 timeout)
    {
        @selfRef.Timeout = timeout;
        return @selfRef;
    }

}
