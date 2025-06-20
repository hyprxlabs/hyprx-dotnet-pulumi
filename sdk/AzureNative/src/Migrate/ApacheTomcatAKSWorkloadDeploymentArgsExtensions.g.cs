// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Migrate.Inputs;

namespace Pulumi.AzureNative.Migrate;

public static partial class ApacheTomcatAKSWorkloadDeploymentArgsExtensions
{
    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithAutomationArtifactProperties(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::Pulumi.AzureNative.Migrate.Inputs.AutomationArtifactArgs automationArtifactProperties)
    {
        @selfRef.AutomationArtifactProperties = automationArtifactProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithAutomationArtifactProperties(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Migrate.Inputs.AutomationArtifactArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Migrate.Inputs.AutomationArtifactArgs();
        @configure(@item);
        @selfRef.AutomationArtifactProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithBindings(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.BindingArgs> bindings)
    {
        @selfRef.Bindings = bindings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithBindings(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.BindingArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.BindingArgs>();
        @configure(@list);
        @selfRef.Bindings = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithBindings(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Migrate.Inputs.BindingArgs>> @create)
    {
        @selfRef.Bindings = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithBuildContainerImages(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.ContainerImagePropertiesArgs> buildContainerImages)
    {
        @selfRef.BuildContainerImages = buildContainerImages;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithBuildContainerImages(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.ContainerImagePropertiesArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.ContainerImagePropertiesArgs>();
        @configure(@list);
        @selfRef.BuildContainerImages = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithBuildContainerImages(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Migrate.Inputs.ContainerImagePropertiesArgs>> @create)
    {
        @selfRef.BuildContainerImages = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithClusterProperties(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::Pulumi.AzureNative.Migrate.Inputs.AKSDeploymentPropertiesArgs clusterProperties)
    {
        @selfRef.ClusterProperties = clusterProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithClusterProperties(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Migrate.Inputs.AKSDeploymentPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Migrate.Inputs.AKSDeploymentPropertiesArgs();
        @configure(@item);
        @selfRef.ClusterProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithConfigurations(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationConfigurationArgs> configurations)
    {
        @selfRef.Configurations = configurations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithConfigurations(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationConfigurationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationConfigurationArgs>();
        @configure(@list);
        @selfRef.Configurations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithConfigurations(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationConfigurationArgs>> @create)
    {
        @selfRef.Configurations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithContainerImageProperties(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::Pulumi.AzureNative.Migrate.Inputs.ContainerImagePropertiesArgs containerImageProperties)
    {
        @selfRef.ContainerImageProperties = containerImageProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithContainerImageProperties(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Migrate.Inputs.ContainerImagePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Migrate.Inputs.ContainerImagePropertiesArgs();
        @configure(@item);
        @selfRef.ContainerImageProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithDeploymentNamePrefix(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::System.String deploymentNamePrefix)
    {
        @selfRef.DeploymentNamePrefix = deploymentNamePrefix;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithDeploymentSpec(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::Pulumi.AzureNative.Migrate.Inputs.AKSDeploymentSpecificationArgs deploymentSpec)
    {
        @selfRef.DeploymentSpec = deploymentSpec;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithDeploymentSpec(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Migrate.Inputs.AKSDeploymentSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Migrate.Inputs.AKSDeploymentSpecificationArgs();
        @configure(@item);
        @selfRef.DeploymentSpec = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithDirectories(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationDirectoryArgs> directories)
    {
        @selfRef.Directories = directories;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithDirectories(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationDirectoryArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationDirectoryArgs>();
        @configure(@list);
        @selfRef.Directories = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithDirectories(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Migrate.Inputs.WebApplicationDirectoryArgs>> @create)
    {
        @selfRef.Directories = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithLimits(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::Pulumi.AzureNative.Migrate.Inputs.ResourceRequirementsArgs limits)
    {
        @selfRef.Limits = limits;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithLimits(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Migrate.Inputs.ResourceRequirementsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Migrate.Inputs.ResourceRequirementsArgs();
        @configure(@item);
        @selfRef.Limits = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithMonitoringProperties(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::Pulumi.AzureNative.Migrate.Inputs.AppInsightMonitoringPropertiesArgs monitoringProperties)
    {
        @selfRef.MonitoringProperties = monitoringProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithMonitoringProperties(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Migrate.Inputs.AppInsightMonitoringPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Migrate.Inputs.AppInsightMonitoringPropertiesArgs();
        @configure(@item);
        @selfRef.MonitoringProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithRequests(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::Pulumi.AzureNative.Migrate.Inputs.ResourceRequirementsArgs requests)
    {
        @selfRef.Requests = requests;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithRequests(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Migrate.Inputs.ResourceRequirementsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Migrate.Inputs.ResourceRequirementsArgs();
        @configure(@item);
        @selfRef.Requests = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs WithTargetPlatformIdentity(this global::Pulumi.AzureNative.Migrate.Inputs.ApacheTomcatAKSWorkloadDeploymentArgs @selfRef, global::System.String targetPlatformIdentity)
    {
        @selfRef.TargetPlatformIdentity = targetPlatformIdentity;
        return @selfRef;
    }

}
