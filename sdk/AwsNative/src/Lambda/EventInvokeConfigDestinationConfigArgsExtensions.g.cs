// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Lambda.Inputs;

namespace Pulumi.AwsNative.Lambda;

public static partial class EventInvokeConfigDestinationConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.Lambda.Inputs.EventInvokeConfigDestinationConfigArgs WithOnFailure(this global::Pulumi.AwsNative.Lambda.Inputs.EventInvokeConfigDestinationConfigArgs @selfRef, global::Pulumi.AwsNative.Lambda.Inputs.EventInvokeConfigOnFailureArgs onFailure)
    {
        @selfRef.OnFailure = onFailure;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lambda.Inputs.EventInvokeConfigDestinationConfigArgs WithOnFailure(this global::Pulumi.AwsNative.Lambda.Inputs.EventInvokeConfigDestinationConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Lambda.Inputs.EventInvokeConfigOnFailureArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Lambda.Inputs.EventInvokeConfigOnFailureArgs();
        @configure(@item);
        @selfRef.OnFailure = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lambda.Inputs.EventInvokeConfigDestinationConfigArgs WithOnSuccess(this global::Pulumi.AwsNative.Lambda.Inputs.EventInvokeConfigDestinationConfigArgs @selfRef, global::Pulumi.AwsNative.Lambda.Inputs.EventInvokeConfigOnSuccessArgs onSuccess)
    {
        @selfRef.OnSuccess = onSuccess;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lambda.Inputs.EventInvokeConfigDestinationConfigArgs WithOnSuccess(this global::Pulumi.AwsNative.Lambda.Inputs.EventInvokeConfigDestinationConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Lambda.Inputs.EventInvokeConfigOnSuccessArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Lambda.Inputs.EventInvokeConfigOnSuccessArgs();
        @configure(@item);
        @selfRef.OnSuccess = @item;
        return @selfRef;
    }

}
