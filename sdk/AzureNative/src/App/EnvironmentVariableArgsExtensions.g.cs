// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.App.Inputs;

namespace Pulumi.AzureNative.App;

public static partial class EnvironmentVariableArgsExtensions
{
    public static global::Pulumi.AzureNative.App.Inputs.EnvironmentVariableArgs WithName(this global::Pulumi.AzureNative.App.Inputs.EnvironmentVariableArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.EnvironmentVariableArgs WithValue(this global::Pulumi.AzureNative.App.Inputs.EnvironmentVariableArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
