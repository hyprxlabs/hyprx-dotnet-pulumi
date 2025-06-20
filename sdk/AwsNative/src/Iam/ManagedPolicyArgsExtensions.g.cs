// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Iam;

public static partial class ManagedPolicyArgsExtensions
{
    public static global::Pulumi.AwsNative.Iam.ManagedPolicyArgs WithDescription(this global::Pulumi.AwsNative.Iam.ManagedPolicyArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Iam.ManagedPolicyArgs WithGroups(this global::Pulumi.AwsNative.Iam.ManagedPolicyArgs @selfRef, global::System.Collections.Generic.List<global::System.String> groups)
    {
        @selfRef.Groups = groups;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Iam.ManagedPolicyArgs WithGroups(this global::Pulumi.AwsNative.Iam.ManagedPolicyArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Groups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Iam.ManagedPolicyArgs WithGroups(this global::Pulumi.AwsNative.Iam.ManagedPolicyArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Groups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Iam.ManagedPolicyArgs WithManagedPolicyName(this global::Pulumi.AwsNative.Iam.ManagedPolicyArgs @selfRef, global::System.String managedPolicyName)
    {
        @selfRef.ManagedPolicyName = managedPolicyName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Iam.ManagedPolicyArgs WithPath(this global::Pulumi.AwsNative.Iam.ManagedPolicyArgs @selfRef, global::System.String path)
    {
        @selfRef.Path = path;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Iam.ManagedPolicyArgs WithPolicyDocument(this global::Pulumi.AwsNative.Iam.ManagedPolicyArgs @selfRef, global::System.Object policyDocument)
    {
        @selfRef.PolicyDocument = policyDocument;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Iam.ManagedPolicyArgs WithPolicyDocument(this global::Pulumi.AwsNative.Iam.ManagedPolicyArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.PolicyDocument = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Iam.ManagedPolicyArgs WithRoles(this global::Pulumi.AwsNative.Iam.ManagedPolicyArgs @selfRef, global::System.Collections.Generic.List<global::System.String> roles)
    {
        @selfRef.Roles = roles;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Iam.ManagedPolicyArgs WithRoles(this global::Pulumi.AwsNative.Iam.ManagedPolicyArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Roles = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Iam.ManagedPolicyArgs WithRoles(this global::Pulumi.AwsNative.Iam.ManagedPolicyArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Roles = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Iam.ManagedPolicyArgs WithUsers(this global::Pulumi.AwsNative.Iam.ManagedPolicyArgs @selfRef, global::System.Collections.Generic.List<global::System.String> users)
    {
        @selfRef.Users = users;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Iam.ManagedPolicyArgs WithUsers(this global::Pulumi.AwsNative.Iam.ManagedPolicyArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Users = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Iam.ManagedPolicyArgs WithUsers(this global::Pulumi.AwsNative.Iam.ManagedPolicyArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Users = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
