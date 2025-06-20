// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QBusiness.Inputs;

namespace Pulumi.AwsNative.QBusiness;

public static partial class DataAccessorAttributeFilterArgsExtensions
{
    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithAndAllFilters(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs> andAllFilters)
    {
        @selfRef.AndAllFilters = andAllFilters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithAndAllFilters(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs>();
        @configure(@list);
        @selfRef.AndAllFilters = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithAndAllFilters(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs>> @create)
    {
        @selfRef.AndAllFilters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithContainsAll(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorDocumentAttributeArgs containsAll)
    {
        @selfRef.ContainsAll = containsAll;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithContainsAll(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorDocumentAttributeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorDocumentAttributeArgs();
        @configure(@item);
        @selfRef.ContainsAll = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithContainsAny(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorDocumentAttributeArgs containsAny)
    {
        @selfRef.ContainsAny = containsAny;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithContainsAny(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorDocumentAttributeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorDocumentAttributeArgs();
        @configure(@item);
        @selfRef.ContainsAny = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithEqualsTo(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorDocumentAttributeArgs equalsTo)
    {
        @selfRef.EqualsTo = equalsTo;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithEqualsTo(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorDocumentAttributeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorDocumentAttributeArgs();
        @configure(@item);
        @selfRef.EqualsTo = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithGreaterThan(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorDocumentAttributeArgs greaterThan)
    {
        @selfRef.GreaterThan = greaterThan;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithGreaterThan(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorDocumentAttributeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorDocumentAttributeArgs();
        @configure(@item);
        @selfRef.GreaterThan = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithGreaterThanOrEquals(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorDocumentAttributeArgs greaterThanOrEquals)
    {
        @selfRef.GreaterThanOrEquals = greaterThanOrEquals;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithGreaterThanOrEquals(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorDocumentAttributeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorDocumentAttributeArgs();
        @configure(@item);
        @selfRef.GreaterThanOrEquals = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithLessThan(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorDocumentAttributeArgs lessThan)
    {
        @selfRef.LessThan = lessThan;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithLessThan(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorDocumentAttributeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorDocumentAttributeArgs();
        @configure(@item);
        @selfRef.LessThan = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithLessThanOrEquals(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorDocumentAttributeArgs lessThanOrEquals)
    {
        @selfRef.LessThanOrEquals = lessThanOrEquals;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithLessThanOrEquals(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorDocumentAttributeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorDocumentAttributeArgs();
        @configure(@item);
        @selfRef.LessThanOrEquals = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithNotFilter(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs notFilter)
    {
        @selfRef.NotFilter = notFilter;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithNotFilter(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs();
        @configure(@item);
        @selfRef.NotFilter = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithOrAllFilters(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs> orAllFilters)
    {
        @selfRef.OrAllFilters = orAllFilters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithOrAllFilters(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs>();
        @configure(@list);
        @selfRef.OrAllFilters = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs WithOrAllFilters(this global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QBusiness.Inputs.DataAccessorAttributeFilterArgs>> @create)
    {
        @selfRef.OrAllFilters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
