// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.DataZone.Inputs;

namespace Pulumi.AwsNative.DataZone;

public static partial class ConnectionUsernamePasswordArgsExtensions
{
    public static global::Pulumi.AwsNative.DataZone.Inputs.ConnectionUsernamePasswordArgs WithPassword(this global::Pulumi.AwsNative.DataZone.Inputs.ConnectionUsernamePasswordArgs @selfRef, global::System.String password)
    {
        @selfRef.Password = password;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataZone.Inputs.ConnectionUsernamePasswordArgs WithUsername(this global::Pulumi.AwsNative.DataZone.Inputs.ConnectionUsernamePasswordArgs @selfRef, global::System.String username)
    {
        @selfRef.Username = username;
        return @selfRef;
    }

}
