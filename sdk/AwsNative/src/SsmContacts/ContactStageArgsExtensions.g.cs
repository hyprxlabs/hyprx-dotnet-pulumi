// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SsmContacts.Inputs;

namespace Pulumi.AwsNative.SsmContacts;

public static partial class ContactStageArgsExtensions
{
    public static global::Pulumi.AwsNative.SsmContacts.Inputs.ContactStageArgs WithDurationInMinutes(this global::Pulumi.AwsNative.SsmContacts.Inputs.ContactStageArgs @selfRef, global::System.Int32 durationInMinutes)
    {
        @selfRef.DurationInMinutes = durationInMinutes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmContacts.Inputs.ContactStageArgs WithRotationIds(this global::Pulumi.AwsNative.SsmContacts.Inputs.ContactStageArgs @selfRef, global::System.Collections.Generic.List<global::System.String> rotationIds)
    {
        @selfRef.RotationIds = rotationIds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmContacts.Inputs.ContactStageArgs WithRotationIds(this global::Pulumi.AwsNative.SsmContacts.Inputs.ContactStageArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.RotationIds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmContacts.Inputs.ContactStageArgs WithRotationIds(this global::Pulumi.AwsNative.SsmContacts.Inputs.ContactStageArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.RotationIds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmContacts.Inputs.ContactStageArgs WithTargets(this global::Pulumi.AwsNative.SsmContacts.Inputs.ContactStageArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.SsmContacts.Inputs.ContactTargetsArgs> targets)
    {
        @selfRef.Targets = targets;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmContacts.Inputs.ContactStageArgs WithTargets(this global::Pulumi.AwsNative.SsmContacts.Inputs.ContactStageArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.SsmContacts.Inputs.ContactTargetsArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.SsmContacts.Inputs.ContactTargetsArgs>();
        @configure(@list);
        @selfRef.Targets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmContacts.Inputs.ContactStageArgs WithTargets(this global::Pulumi.AwsNative.SsmContacts.Inputs.ContactStageArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.SsmContacts.Inputs.ContactTargetsArgs>> @create)
    {
        @selfRef.Targets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
