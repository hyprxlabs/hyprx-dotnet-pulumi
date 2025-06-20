// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ec2;

public static partial class PrefixListArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.PrefixListArgs WithAddressFamily(this global::Pulumi.AwsNative.Ec2.PrefixListArgs @selfRef, global::Pulumi.AwsNative.Ec2.PrefixListAddressFamily addressFamily)
    {
        @selfRef.AddressFamily = addressFamily;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.PrefixListArgs WithAddressFamily(this global::Pulumi.AwsNative.Ec2.PrefixListArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.PrefixListAddressFamily> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Ec2.PrefixListAddressFamily>();
        @configure(@item);
        @selfRef.AddressFamily = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.PrefixListArgs WithEntries(this global::Pulumi.AwsNative.Ec2.PrefixListArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.PrefixListEntryArgs> entries)
    {
        @selfRef.Entries = entries;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.PrefixListArgs WithEntries(this global::Pulumi.AwsNative.Ec2.PrefixListArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.PrefixListEntryArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.PrefixListEntryArgs>();
        @configure(@list);
        @selfRef.Entries = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.PrefixListArgs WithEntries(this global::Pulumi.AwsNative.Ec2.PrefixListArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Ec2.Inputs.PrefixListEntryArgs>> @create)
    {
        @selfRef.Entries = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.PrefixListArgs WithMaxEntries(this global::Pulumi.AwsNative.Ec2.PrefixListArgs @selfRef, global::System.Int32 maxEntries)
    {
        @selfRef.MaxEntries = maxEntries;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.PrefixListArgs WithPrefixListName(this global::Pulumi.AwsNative.Ec2.PrefixListArgs @selfRef, global::System.String prefixListName)
    {
        @selfRef.PrefixListName = prefixListName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.PrefixListArgs WithTags(this global::Pulumi.AwsNative.Ec2.PrefixListArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.PrefixListArgs WithTags(this global::Pulumi.AwsNative.Ec2.PrefixListArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.PrefixListArgs WithTags(this global::Pulumi.AwsNative.Ec2.PrefixListArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
