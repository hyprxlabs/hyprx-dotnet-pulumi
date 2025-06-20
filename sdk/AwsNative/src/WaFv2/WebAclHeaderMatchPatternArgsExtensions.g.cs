// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.WaFv2.Inputs;

namespace Pulumi.AwsNative.WaFv2;

public static partial class WebAclHeaderMatchPatternArgsExtensions
{
    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclHeaderMatchPatternArgs WithAll(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclHeaderMatchPatternArgs @selfRef, global::System.Object all)
    {
        @selfRef.All = all;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclHeaderMatchPatternArgs WithAll(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclHeaderMatchPatternArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.All = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclHeaderMatchPatternArgs WithExcludedHeaders(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclHeaderMatchPatternArgs @selfRef, global::System.Collections.Generic.List<global::System.String> excludedHeaders)
    {
        @selfRef.ExcludedHeaders = excludedHeaders;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclHeaderMatchPatternArgs WithExcludedHeaders(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclHeaderMatchPatternArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ExcludedHeaders = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclHeaderMatchPatternArgs WithExcludedHeaders(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclHeaderMatchPatternArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ExcludedHeaders = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclHeaderMatchPatternArgs WithIncludedHeaders(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclHeaderMatchPatternArgs @selfRef, global::System.Collections.Generic.List<global::System.String> includedHeaders)
    {
        @selfRef.IncludedHeaders = includedHeaders;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclHeaderMatchPatternArgs WithIncludedHeaders(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclHeaderMatchPatternArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.IncludedHeaders = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclHeaderMatchPatternArgs WithIncludedHeaders(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclHeaderMatchPatternArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.IncludedHeaders = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
