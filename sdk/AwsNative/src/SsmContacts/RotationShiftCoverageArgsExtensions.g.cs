// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SsmContacts.Inputs;

namespace Pulumi.AwsNative.SsmContacts;

public static partial class RotationShiftCoverageArgsExtensions
{
    public static global::Pulumi.AwsNative.SsmContacts.Inputs.RotationShiftCoverageArgs WithCoverageTimes(this global::Pulumi.AwsNative.SsmContacts.Inputs.RotationShiftCoverageArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.SsmContacts.Inputs.RotationCoverageTimeArgs> coverageTimes)
    {
        @selfRef.CoverageTimes = coverageTimes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmContacts.Inputs.RotationShiftCoverageArgs WithCoverageTimes(this global::Pulumi.AwsNative.SsmContacts.Inputs.RotationShiftCoverageArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.SsmContacts.Inputs.RotationCoverageTimeArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.SsmContacts.Inputs.RotationCoverageTimeArgs>();
        @configure(@list);
        @selfRef.CoverageTimes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmContacts.Inputs.RotationShiftCoverageArgs WithCoverageTimes(this global::Pulumi.AwsNative.SsmContacts.Inputs.RotationShiftCoverageArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.SsmContacts.Inputs.RotationCoverageTimeArgs>> @create)
    {
        @selfRef.CoverageTimes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmContacts.Inputs.RotationShiftCoverageArgs WithDayOfWeek(this global::Pulumi.AwsNative.SsmContacts.Inputs.RotationShiftCoverageArgs @selfRef, global::Pulumi.AwsNative.SsmContacts.RotationDayOfWeek dayOfWeek)
    {
        @selfRef.DayOfWeek = dayOfWeek;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmContacts.Inputs.RotationShiftCoverageArgs WithDayOfWeek(this global::Pulumi.AwsNative.SsmContacts.Inputs.RotationShiftCoverageArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SsmContacts.RotationDayOfWeek> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.SsmContacts.RotationDayOfWeek>();
        @configure(@item);
        @selfRef.DayOfWeek = @item;
        return @selfRef;
    }

}
