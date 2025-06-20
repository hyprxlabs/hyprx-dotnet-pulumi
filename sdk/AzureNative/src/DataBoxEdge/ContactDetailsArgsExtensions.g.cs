// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataBoxEdge.Inputs;

namespace Pulumi.AzureNative.DataBoxEdge;

public static partial class ContactDetailsArgsExtensions
{
    public static global::Pulumi.AzureNative.DataBoxEdge.Inputs.ContactDetailsArgs WithCompanyName(this global::Pulumi.AzureNative.DataBoxEdge.Inputs.ContactDetailsArgs @selfRef, global::System.String companyName)
    {
        @selfRef.CompanyName = companyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataBoxEdge.Inputs.ContactDetailsArgs WithContactPerson(this global::Pulumi.AzureNative.DataBoxEdge.Inputs.ContactDetailsArgs @selfRef, global::System.String contactPerson)
    {
        @selfRef.ContactPerson = contactPerson;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataBoxEdge.Inputs.ContactDetailsArgs WithEmailList(this global::Pulumi.AzureNative.DataBoxEdge.Inputs.ContactDetailsArgs @selfRef, global::System.Collections.Generic.List<global::System.String> emailList)
    {
        @selfRef.EmailList = emailList;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataBoxEdge.Inputs.ContactDetailsArgs WithEmailList(this global::Pulumi.AzureNative.DataBoxEdge.Inputs.ContactDetailsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.EmailList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataBoxEdge.Inputs.ContactDetailsArgs WithEmailList(this global::Pulumi.AzureNative.DataBoxEdge.Inputs.ContactDetailsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.EmailList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataBoxEdge.Inputs.ContactDetailsArgs WithPhone(this global::Pulumi.AzureNative.DataBoxEdge.Inputs.ContactDetailsArgs @selfRef, global::System.String phone)
    {
        @selfRef.Phone = phone;
        return @selfRef;
    }

}
