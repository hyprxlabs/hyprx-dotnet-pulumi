// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Shield;

public static partial class ProactiveEngagementArgsExtensions
{
    public static global::Pulumi.AwsNative.Shield.ProactiveEngagementArgs WithEmergencyContactList(this global::Pulumi.AwsNative.Shield.ProactiveEngagementArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Shield.Inputs.ProactiveEngagementEmergencyContactArgs> emergencyContactList)
    {
        @selfRef.EmergencyContactList = emergencyContactList;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Shield.ProactiveEngagementArgs WithEmergencyContactList(this global::Pulumi.AwsNative.Shield.ProactiveEngagementArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Shield.Inputs.ProactiveEngagementEmergencyContactArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Shield.Inputs.ProactiveEngagementEmergencyContactArgs>();
        @configure(@list);
        @selfRef.EmergencyContactList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Shield.ProactiveEngagementArgs WithEmergencyContactList(this global::Pulumi.AwsNative.Shield.ProactiveEngagementArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Shield.Inputs.ProactiveEngagementEmergencyContactArgs>> @create)
    {
        @selfRef.EmergencyContactList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Shield.ProactiveEngagementArgs WithProactiveEngagementStatus(this global::Pulumi.AwsNative.Shield.ProactiveEngagementArgs @selfRef, global::Pulumi.AwsNative.Shield.ProactiveEngagementStatus proactiveEngagementStatus)
    {
        @selfRef.ProactiveEngagementStatus = proactiveEngagementStatus;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Shield.ProactiveEngagementArgs WithProactiveEngagementStatus(this global::Pulumi.AwsNative.Shield.ProactiveEngagementArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Shield.ProactiveEngagementStatus> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Shield.ProactiveEngagementStatus>();
        @configure(@item);
        @selfRef.ProactiveEngagementStatus = @item;
        return @selfRef;
    }

}
