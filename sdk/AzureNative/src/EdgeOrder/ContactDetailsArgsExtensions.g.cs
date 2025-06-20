// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.EdgeOrder.Inputs;

namespace Pulumi.AzureNative.EdgeOrder;

public static partial class ContactDetailsArgsExtensions
{
    public static global::Pulumi.AzureNative.EdgeOrder.Inputs.ContactDetailsArgs WithContactName(this global::Pulumi.AzureNative.EdgeOrder.Inputs.ContactDetailsArgs @selfRef, global::System.String contactName)
    {
        @selfRef.ContactName = contactName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EdgeOrder.Inputs.ContactDetailsArgs WithEmailList(this global::Pulumi.AzureNative.EdgeOrder.Inputs.ContactDetailsArgs @selfRef, global::System.Collections.Generic.List<global::System.String> emailList)
    {
        @selfRef.EmailList = emailList;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EdgeOrder.Inputs.ContactDetailsArgs WithEmailList(this global::Pulumi.AzureNative.EdgeOrder.Inputs.ContactDetailsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.EmailList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EdgeOrder.Inputs.ContactDetailsArgs WithEmailList(this global::Pulumi.AzureNative.EdgeOrder.Inputs.ContactDetailsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.EmailList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EdgeOrder.Inputs.ContactDetailsArgs WithMobile(this global::Pulumi.AzureNative.EdgeOrder.Inputs.ContactDetailsArgs @selfRef, global::System.String mobile)
    {
        @selfRef.Mobile = mobile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EdgeOrder.Inputs.ContactDetailsArgs WithPhone(this global::Pulumi.AzureNative.EdgeOrder.Inputs.ContactDetailsArgs @selfRef, global::System.String phone)
    {
        @selfRef.Phone = phone;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EdgeOrder.Inputs.ContactDetailsArgs WithPhoneExtension(this global::Pulumi.AzureNative.EdgeOrder.Inputs.ContactDetailsArgs @selfRef, global::System.String phoneExtension)
    {
        @selfRef.PhoneExtension = phoneExtension;
        return @selfRef;
    }

}
