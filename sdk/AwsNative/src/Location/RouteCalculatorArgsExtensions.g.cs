// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Location;

public static partial class RouteCalculatorArgsExtensions
{
    public static global::Pulumi.AwsNative.Location.RouteCalculatorArgs WithCalculatorName(this global::Pulumi.AwsNative.Location.RouteCalculatorArgs @selfRef, global::System.String calculatorName)
    {
        @selfRef.CalculatorName = calculatorName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Location.RouteCalculatorArgs WithDataSource(this global::Pulumi.AwsNative.Location.RouteCalculatorArgs @selfRef, global::System.String dataSource)
    {
        @selfRef.DataSource = dataSource;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Location.RouteCalculatorArgs WithDescription(this global::Pulumi.AwsNative.Location.RouteCalculatorArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Location.RouteCalculatorArgs WithPricingPlan(this global::Pulumi.AwsNative.Location.RouteCalculatorArgs @selfRef, global::Pulumi.AwsNative.Location.RouteCalculatorPricingPlan pricingPlan)
    {
        @selfRef.PricingPlan = pricingPlan;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Location.RouteCalculatorArgs WithPricingPlan(this global::Pulumi.AwsNative.Location.RouteCalculatorArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Location.RouteCalculatorPricingPlan> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Location.RouteCalculatorPricingPlan>();
        @configure(@item);
        @selfRef.PricingPlan = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Location.RouteCalculatorArgs WithTags(this global::Pulumi.AwsNative.Location.RouteCalculatorArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Location.RouteCalculatorArgs WithTags(this global::Pulumi.AwsNative.Location.RouteCalculatorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Location.RouteCalculatorArgs WithTags(this global::Pulumi.AwsNative.Location.RouteCalculatorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
