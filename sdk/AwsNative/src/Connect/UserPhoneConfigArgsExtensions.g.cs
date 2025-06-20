// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Connect.Inputs;

namespace Pulumi.AwsNative.Connect;

public static partial class UserPhoneConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.Connect.Inputs.UserPhoneConfigArgs WithAfterContactWorkTimeLimit(this global::Pulumi.AwsNative.Connect.Inputs.UserPhoneConfigArgs @selfRef, global::System.Int32 afterContactWorkTimeLimit)
    {
        @selfRef.AfterContactWorkTimeLimit = afterContactWorkTimeLimit;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.Inputs.UserPhoneConfigArgs WithAutoAccept(this global::Pulumi.AwsNative.Connect.Inputs.UserPhoneConfigArgs @selfRef, bool autoAccept = true)
    {
        @selfRef.AutoAccept = autoAccept;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.Inputs.UserPhoneConfigArgs WithDeskPhoneNumber(this global::Pulumi.AwsNative.Connect.Inputs.UserPhoneConfigArgs @selfRef, global::System.String deskPhoneNumber)
    {
        @selfRef.DeskPhoneNumber = deskPhoneNumber;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.Inputs.UserPhoneConfigArgs WithPhoneType(this global::Pulumi.AwsNative.Connect.Inputs.UserPhoneConfigArgs @selfRef, global::Pulumi.AwsNative.Connect.UserPhoneType phoneType)
    {
        @selfRef.PhoneType = phoneType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.Inputs.UserPhoneConfigArgs WithPhoneType(this global::Pulumi.AwsNative.Connect.Inputs.UserPhoneConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Connect.UserPhoneType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Connect.UserPhoneType>();
        @configure(@item);
        @selfRef.PhoneType = @item;
        return @selfRef;
    }

}
