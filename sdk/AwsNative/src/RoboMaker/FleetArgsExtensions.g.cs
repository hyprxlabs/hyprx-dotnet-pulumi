// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.RoboMaker;

public static partial class FleetArgsExtensions
{
    public static global::Pulumi.AwsNative.RoboMaker.FleetArgs WithName(this global::Pulumi.AwsNative.RoboMaker.FleetArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.RoboMaker.FleetArgs WithTags(this global::Pulumi.AwsNative.RoboMaker.FleetArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.RoboMaker.FleetArgs WithTags(this global::Pulumi.AwsNative.RoboMaker.FleetArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.RoboMaker.FleetArgs WithTags(this global::Pulumi.AwsNative.RoboMaker.FleetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
