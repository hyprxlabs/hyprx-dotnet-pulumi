// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SsmContacts.Inputs;

namespace Pulumi.AwsNative.SsmContacts;

public static partial class ContactTargetInfoArgsExtensions
{
    public static global::Pulumi.AwsNative.SsmContacts.Inputs.ContactTargetInfoArgs WithContactId(this global::Pulumi.AwsNative.SsmContacts.Inputs.ContactTargetInfoArgs @selfRef, global::System.String contactId)
    {
        @selfRef.ContactId = contactId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmContacts.Inputs.ContactTargetInfoArgs WithIsEssential(this global::Pulumi.AwsNative.SsmContacts.Inputs.ContactTargetInfoArgs @selfRef, bool isEssential = true)
    {
        @selfRef.IsEssential = isEssential;
        return @selfRef;
    }

}
