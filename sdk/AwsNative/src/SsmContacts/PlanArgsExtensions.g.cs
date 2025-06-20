// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.SsmContacts;

public static partial class PlanArgsExtensions
{
    public static global::Pulumi.AwsNative.SsmContacts.PlanArgs WithContactId(this global::Pulumi.AwsNative.SsmContacts.PlanArgs @selfRef, global::System.String contactId)
    {
        @selfRef.ContactId = contactId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmContacts.PlanArgs WithRotationIds(this global::Pulumi.AwsNative.SsmContacts.PlanArgs @selfRef, global::System.Collections.Generic.List<global::System.String> rotationIds)
    {
        @selfRef.RotationIds = rotationIds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmContacts.PlanArgs WithRotationIds(this global::Pulumi.AwsNative.SsmContacts.PlanArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.RotationIds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmContacts.PlanArgs WithRotationIds(this global::Pulumi.AwsNative.SsmContacts.PlanArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.RotationIds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmContacts.PlanArgs WithStages(this global::Pulumi.AwsNative.SsmContacts.PlanArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.SsmContacts.Inputs.PlanStageArgs> stages)
    {
        @selfRef.Stages = stages;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmContacts.PlanArgs WithStages(this global::Pulumi.AwsNative.SsmContacts.PlanArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.SsmContacts.Inputs.PlanStageArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.SsmContacts.Inputs.PlanStageArgs>();
        @configure(@list);
        @selfRef.Stages = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmContacts.PlanArgs WithStages(this global::Pulumi.AwsNative.SsmContacts.PlanArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.SsmContacts.Inputs.PlanStageArgs>> @create)
    {
        @selfRef.Stages = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
