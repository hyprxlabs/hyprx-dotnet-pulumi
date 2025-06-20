// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Compute.Inputs;

namespace Pulumi.AzureNative.Compute;

public static partial class UefiKeySignaturesArgsExtensions
{
    public static global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs WithDb(this global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.UefiKeyArgs> db)
    {
        @selfRef.Db = db;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs WithDb(this global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.UefiKeyArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.UefiKeyArgs>();
        @configure(@list);
        @selfRef.Db = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs WithDb(this global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Compute.Inputs.UefiKeyArgs>> @create)
    {
        @selfRef.Db = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs WithDbx(this global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.UefiKeyArgs> dbx)
    {
        @selfRef.Dbx = dbx;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs WithDbx(this global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.UefiKeyArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.UefiKeyArgs>();
        @configure(@list);
        @selfRef.Dbx = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs WithDbx(this global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Compute.Inputs.UefiKeyArgs>> @create)
    {
        @selfRef.Dbx = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs WithKek(this global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.UefiKeyArgs> kek)
    {
        @selfRef.Kek = kek;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs WithKek(this global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.UefiKeyArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.UefiKeyArgs>();
        @configure(@list);
        @selfRef.Kek = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs WithKek(this global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Compute.Inputs.UefiKeyArgs>> @create)
    {
        @selfRef.Kek = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs WithPk(this global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.UefiKeyArgs pk)
    {
        @selfRef.Pk = pk;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs WithPk(this global::Pulumi.AzureNative.Compute.Inputs.UefiKeySignaturesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.UefiKeyArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.UefiKeyArgs();
        @configure(@item);
        @selfRef.Pk = @item;
        return @selfRef;
    }

}
