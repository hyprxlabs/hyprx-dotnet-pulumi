// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.NeptuneGraph;

public static partial class GraphArgsExtensions
{
    public static global::Pulumi.AwsNative.NeptuneGraph.GraphArgs WithDeletionProtection(this global::Pulumi.AwsNative.NeptuneGraph.GraphArgs @selfRef, bool deletionProtection = true)
    {
        @selfRef.DeletionProtection = deletionProtection;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NeptuneGraph.GraphArgs WithGraphName(this global::Pulumi.AwsNative.NeptuneGraph.GraphArgs @selfRef, global::System.String graphName)
    {
        @selfRef.GraphName = graphName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NeptuneGraph.GraphArgs WithProvisionedMemory(this global::Pulumi.AwsNative.NeptuneGraph.GraphArgs @selfRef, global::System.Int32 provisionedMemory)
    {
        @selfRef.ProvisionedMemory = provisionedMemory;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NeptuneGraph.GraphArgs WithPublicConnectivity(this global::Pulumi.AwsNative.NeptuneGraph.GraphArgs @selfRef, bool publicConnectivity = true)
    {
        @selfRef.PublicConnectivity = publicConnectivity;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NeptuneGraph.GraphArgs WithReplicaCount(this global::Pulumi.AwsNative.NeptuneGraph.GraphArgs @selfRef, global::System.Int32 replicaCount)
    {
        @selfRef.ReplicaCount = replicaCount;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NeptuneGraph.GraphArgs WithTags(this global::Pulumi.AwsNative.NeptuneGraph.GraphArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NeptuneGraph.GraphArgs WithTags(this global::Pulumi.AwsNative.NeptuneGraph.GraphArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NeptuneGraph.GraphArgs WithTags(this global::Pulumi.AwsNative.NeptuneGraph.GraphArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NeptuneGraph.GraphArgs WithVectorSearchConfiguration(this global::Pulumi.AwsNative.NeptuneGraph.GraphArgs @selfRef, global::Pulumi.AwsNative.NeptuneGraph.Inputs.GraphVectorSearchConfigurationArgs vectorSearchConfiguration)
    {
        @selfRef.VectorSearchConfiguration = vectorSearchConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NeptuneGraph.GraphArgs WithVectorSearchConfiguration(this global::Pulumi.AwsNative.NeptuneGraph.GraphArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.NeptuneGraph.Inputs.GraphVectorSearchConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.NeptuneGraph.Inputs.GraphVectorSearchConfigurationArgs();
        @configure(@item);
        @selfRef.VectorSearchConfiguration = @item;
        return @selfRef;
    }

}
