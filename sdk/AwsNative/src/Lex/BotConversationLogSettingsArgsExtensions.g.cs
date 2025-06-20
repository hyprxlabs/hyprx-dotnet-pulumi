// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Lex.Inputs;

namespace Pulumi.AwsNative.Lex;

public static partial class BotConversationLogSettingsArgsExtensions
{
    public static global::Pulumi.AwsNative.Lex.Inputs.BotConversationLogSettingsArgs WithAudioLogSettings(this global::Pulumi.AwsNative.Lex.Inputs.BotConversationLogSettingsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Lex.Inputs.BotAudioLogSettingArgs> audioLogSettings)
    {
        @selfRef.AudioLogSettings = audioLogSettings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotConversationLogSettingsArgs WithAudioLogSettings(this global::Pulumi.AwsNative.Lex.Inputs.BotConversationLogSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Lex.Inputs.BotAudioLogSettingArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Lex.Inputs.BotAudioLogSettingArgs>();
        @configure(@list);
        @selfRef.AudioLogSettings = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotConversationLogSettingsArgs WithAudioLogSettings(this global::Pulumi.AwsNative.Lex.Inputs.BotConversationLogSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Lex.Inputs.BotAudioLogSettingArgs>> @create)
    {
        @selfRef.AudioLogSettings = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotConversationLogSettingsArgs WithTextLogSettings(this global::Pulumi.AwsNative.Lex.Inputs.BotConversationLogSettingsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Lex.Inputs.BotTextLogSettingArgs> textLogSettings)
    {
        @selfRef.TextLogSettings = textLogSettings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotConversationLogSettingsArgs WithTextLogSettings(this global::Pulumi.AwsNative.Lex.Inputs.BotConversationLogSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Lex.Inputs.BotTextLogSettingArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Lex.Inputs.BotTextLogSettingArgs>();
        @configure(@list);
        @selfRef.TextLogSettings = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotConversationLogSettingsArgs WithTextLogSettings(this global::Pulumi.AwsNative.Lex.Inputs.BotConversationLogSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Lex.Inputs.BotTextLogSettingArgs>> @create)
    {
        @selfRef.TextLogSettings = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
