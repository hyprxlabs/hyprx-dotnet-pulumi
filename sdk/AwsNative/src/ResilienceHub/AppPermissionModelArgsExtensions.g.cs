// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ResilienceHub.Inputs;

namespace Pulumi.AwsNative.ResilienceHub;

public static partial class AppPermissionModelArgsExtensions
{
    public static global::Pulumi.AwsNative.ResilienceHub.Inputs.AppPermissionModelArgs WithCrossAccountRoleArns(this global::Pulumi.AwsNative.ResilienceHub.Inputs.AppPermissionModelArgs @selfRef, global::System.Collections.Generic.List<global::System.String> crossAccountRoleArns)
    {
        @selfRef.CrossAccountRoleArns = crossAccountRoleArns;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ResilienceHub.Inputs.AppPermissionModelArgs WithCrossAccountRoleArns(this global::Pulumi.AwsNative.ResilienceHub.Inputs.AppPermissionModelArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.CrossAccountRoleArns = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ResilienceHub.Inputs.AppPermissionModelArgs WithCrossAccountRoleArns(this global::Pulumi.AwsNative.ResilienceHub.Inputs.AppPermissionModelArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.CrossAccountRoleArns = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ResilienceHub.Inputs.AppPermissionModelArgs WithInvokerRoleName(this global::Pulumi.AwsNative.ResilienceHub.Inputs.AppPermissionModelArgs @selfRef, global::System.String invokerRoleName)
    {
        @selfRef.InvokerRoleName = invokerRoleName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ResilienceHub.Inputs.AppPermissionModelArgs WithType(this global::Pulumi.AwsNative.ResilienceHub.Inputs.AppPermissionModelArgs @selfRef, global::Pulumi.AwsNative.ResilienceHub.AppPermissionModelType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ResilienceHub.Inputs.AppPermissionModelArgs WithType(this global::Pulumi.AwsNative.ResilienceHub.Inputs.AppPermissionModelArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.ResilienceHub.AppPermissionModelType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.ResilienceHub.AppPermissionModelType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
