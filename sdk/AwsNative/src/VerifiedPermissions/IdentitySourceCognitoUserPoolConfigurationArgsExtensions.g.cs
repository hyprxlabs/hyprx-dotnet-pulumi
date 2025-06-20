// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.VerifiedPermissions.Inputs;

namespace Pulumi.AwsNative.VerifiedPermissions;

public static partial class IdentitySourceCognitoUserPoolConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.VerifiedPermissions.Inputs.IdentitySourceCognitoUserPoolConfigurationArgs WithClientIds(this global::Pulumi.AwsNative.VerifiedPermissions.Inputs.IdentitySourceCognitoUserPoolConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::System.String> clientIds)
    {
        @selfRef.ClientIds = clientIds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.VerifiedPermissions.Inputs.IdentitySourceCognitoUserPoolConfigurationArgs WithClientIds(this global::Pulumi.AwsNative.VerifiedPermissions.Inputs.IdentitySourceCognitoUserPoolConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ClientIds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.VerifiedPermissions.Inputs.IdentitySourceCognitoUserPoolConfigurationArgs WithClientIds(this global::Pulumi.AwsNative.VerifiedPermissions.Inputs.IdentitySourceCognitoUserPoolConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ClientIds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.VerifiedPermissions.Inputs.IdentitySourceCognitoUserPoolConfigurationArgs WithGroupConfiguration(this global::Pulumi.AwsNative.VerifiedPermissions.Inputs.IdentitySourceCognitoUserPoolConfigurationArgs @selfRef, global::Pulumi.AwsNative.VerifiedPermissions.Inputs.IdentitySourceCognitoGroupConfigurationArgs groupConfiguration)
    {
        @selfRef.GroupConfiguration = groupConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.VerifiedPermissions.Inputs.IdentitySourceCognitoUserPoolConfigurationArgs WithGroupConfiguration(this global::Pulumi.AwsNative.VerifiedPermissions.Inputs.IdentitySourceCognitoUserPoolConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.VerifiedPermissions.Inputs.IdentitySourceCognitoGroupConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.VerifiedPermissions.Inputs.IdentitySourceCognitoGroupConfigurationArgs();
        @configure(@item);
        @selfRef.GroupConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.VerifiedPermissions.Inputs.IdentitySourceCognitoUserPoolConfigurationArgs WithUserPoolArn(this global::Pulumi.AwsNative.VerifiedPermissions.Inputs.IdentitySourceCognitoUserPoolConfigurationArgs @selfRef, global::System.String userPoolArn)
    {
        @selfRef.UserPoolArn = userPoolArn;
        return @selfRef;
    }

}
