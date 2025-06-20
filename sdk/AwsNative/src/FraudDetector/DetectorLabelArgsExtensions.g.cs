// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.FraudDetector.Inputs;

namespace Pulumi.AwsNative.FraudDetector;

public static partial class DetectorLabelArgsExtensions
{
    public static global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorLabelArgs WithArn(this global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorLabelArgs @selfRef, global::System.String arn)
    {
        @selfRef.Arn = arn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorLabelArgs WithCreatedTime(this global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorLabelArgs @selfRef, global::System.String createdTime)
    {
        @selfRef.CreatedTime = createdTime;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorLabelArgs WithDescription(this global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorLabelArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorLabelArgs WithInline(this global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorLabelArgs @selfRef, bool inline = true)
    {
        @selfRef.Inline = inline;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorLabelArgs WithLastUpdatedTime(this global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorLabelArgs @selfRef, global::System.String lastUpdatedTime)
    {
        @selfRef.LastUpdatedTime = lastUpdatedTime;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorLabelArgs WithName(this global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorLabelArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorLabelArgs WithTags(this global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorLabelArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorTagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorLabelArgs WithTags(this global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorLabelArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorTagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorTagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorLabelArgs WithTags(this global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorLabelArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.FraudDetector.Inputs.DetectorTagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
