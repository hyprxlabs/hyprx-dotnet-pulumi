// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.FinSpace.Inputs;

namespace Pulumi.AwsNative.FinSpace;

public static partial class EnvironmentSuperuserParametersArgsExtensions
{
    public static global::Pulumi.AwsNative.FinSpace.Inputs.EnvironmentSuperuserParametersArgs WithEmailAddress(this global::Pulumi.AwsNative.FinSpace.Inputs.EnvironmentSuperuserParametersArgs @selfRef, global::System.String emailAddress)
    {
        @selfRef.EmailAddress = emailAddress;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.FinSpace.Inputs.EnvironmentSuperuserParametersArgs WithFirstName(this global::Pulumi.AwsNative.FinSpace.Inputs.EnvironmentSuperuserParametersArgs @selfRef, global::System.String firstName)
    {
        @selfRef.FirstName = firstName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.FinSpace.Inputs.EnvironmentSuperuserParametersArgs WithLastName(this global::Pulumi.AwsNative.FinSpace.Inputs.EnvironmentSuperuserParametersArgs @selfRef, global::System.String lastName)
    {
        @selfRef.LastName = lastName;
        return @selfRef;
    }

}
