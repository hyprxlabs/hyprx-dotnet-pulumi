// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.QuickSight;

public static partial class TopicArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.TopicArgs WithAwsAccountId(this global::Pulumi.AwsNative.QuickSight.TopicArgs @selfRef, global::System.String awsAccountId)
    {
        @selfRef.AwsAccountId = awsAccountId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.TopicArgs WithConfigOptions(this global::Pulumi.AwsNative.QuickSight.TopicArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TopicConfigOptionsArgs configOptions)
    {
        @selfRef.ConfigOptions = configOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.TopicArgs WithConfigOptions(this global::Pulumi.AwsNative.QuickSight.TopicArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TopicConfigOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TopicConfigOptionsArgs();
        @configure(@item);
        @selfRef.ConfigOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.TopicArgs WithDataSets(this global::Pulumi.AwsNative.QuickSight.TopicArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TopicDatasetMetadataArgs> dataSets)
    {
        @selfRef.DataSets = dataSets;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.TopicArgs WithDataSets(this global::Pulumi.AwsNative.QuickSight.TopicArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TopicDatasetMetadataArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TopicDatasetMetadataArgs>();
        @configure(@list);
        @selfRef.DataSets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.TopicArgs WithDataSets(this global::Pulumi.AwsNative.QuickSight.TopicArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.TopicDatasetMetadataArgs>> @create)
    {
        @selfRef.DataSets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.TopicArgs WithDescription(this global::Pulumi.AwsNative.QuickSight.TopicArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.TopicArgs WithFolderArns(this global::Pulumi.AwsNative.QuickSight.TopicArgs @selfRef, global::System.Collections.Generic.List<global::System.String> folderArns)
    {
        @selfRef.FolderArns = folderArns;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.TopicArgs WithFolderArns(this global::Pulumi.AwsNative.QuickSight.TopicArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.FolderArns = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.TopicArgs WithFolderArns(this global::Pulumi.AwsNative.QuickSight.TopicArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.FolderArns = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.TopicArgs WithName(this global::Pulumi.AwsNative.QuickSight.TopicArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.TopicArgs WithTopicId(this global::Pulumi.AwsNative.QuickSight.TopicArgs @selfRef, global::System.String topicId)
    {
        @selfRef.TopicId = topicId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.TopicArgs WithUserExperienceVersion(this global::Pulumi.AwsNative.QuickSight.TopicArgs @selfRef, global::Pulumi.AwsNative.QuickSight.TopicUserExperienceVersion userExperienceVersion)
    {
        @selfRef.UserExperienceVersion = userExperienceVersion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.TopicArgs WithUserExperienceVersion(this global::Pulumi.AwsNative.QuickSight.TopicArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.TopicUserExperienceVersion> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.TopicUserExperienceVersion>();
        @configure(@item);
        @selfRef.UserExperienceVersion = @item;
        return @selfRef;
    }

}
