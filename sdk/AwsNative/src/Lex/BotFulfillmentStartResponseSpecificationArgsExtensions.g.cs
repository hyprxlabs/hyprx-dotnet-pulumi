// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Lex.Inputs;

namespace Pulumi.AwsNative.Lex;

public static partial class BotFulfillmentStartResponseSpecificationArgsExtensions
{
    public static global::Pulumi.AwsNative.Lex.Inputs.BotFulfillmentStartResponseSpecificationArgs WithAllowInterrupt(this global::Pulumi.AwsNative.Lex.Inputs.BotFulfillmentStartResponseSpecificationArgs @selfRef, bool allowInterrupt = true)
    {
        @selfRef.AllowInterrupt = allowInterrupt;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotFulfillmentStartResponseSpecificationArgs WithDelayInSeconds(this global::Pulumi.AwsNative.Lex.Inputs.BotFulfillmentStartResponseSpecificationArgs @selfRef, global::System.Int32 delayInSeconds)
    {
        @selfRef.DelayInSeconds = delayInSeconds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotFulfillmentStartResponseSpecificationArgs WithMessageGroups(this global::Pulumi.AwsNative.Lex.Inputs.BotFulfillmentStartResponseSpecificationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Lex.Inputs.BotMessageGroupArgs> messageGroups)
    {
        @selfRef.MessageGroups = messageGroups;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotFulfillmentStartResponseSpecificationArgs WithMessageGroups(this global::Pulumi.AwsNative.Lex.Inputs.BotFulfillmentStartResponseSpecificationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Lex.Inputs.BotMessageGroupArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Lex.Inputs.BotMessageGroupArgs>();
        @configure(@list);
        @selfRef.MessageGroups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotFulfillmentStartResponseSpecificationArgs WithMessageGroups(this global::Pulumi.AwsNative.Lex.Inputs.BotFulfillmentStartResponseSpecificationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Lex.Inputs.BotMessageGroupArgs>> @create)
    {
        @selfRef.MessageGroups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
