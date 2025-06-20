// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class AwsAutoScalingAutoScalingGroupPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithAutoScalingGroupName(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.String autoScalingGroupName)
    {
        @selfRef.AutoScalingGroupName = autoScalingGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithAvailabilityZones(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> availabilityZones)
    {
        @selfRef.AvailabilityZones = availabilityZones;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithAvailabilityZones(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AvailabilityZones = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithAvailabilityZones(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AvailabilityZones = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithCapacityRebalance(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, bool capacityRebalance = true)
    {
        @selfRef.CapacityRebalance = capacityRebalance;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithContext(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.String context)
    {
        @selfRef.Context = context;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithCooldown(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.String cooldown)
    {
        @selfRef.Cooldown = cooldown;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithDefaultInstanceWarmup(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Int32 defaultInstanceWarmup)
    {
        @selfRef.DefaultInstanceWarmup = defaultInstanceWarmup;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithDesiredCapacity(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.String desiredCapacity)
    {
        @selfRef.DesiredCapacity = desiredCapacity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithDesiredCapacityType(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.String desiredCapacityType)
    {
        @selfRef.DesiredCapacityType = desiredCapacityType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithHealthCheckGracePeriod(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Int32 healthCheckGracePeriod)
    {
        @selfRef.HealthCheckGracePeriod = healthCheckGracePeriod;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithHealthCheckType(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.String healthCheckType)
    {
        @selfRef.HealthCheckType = healthCheckType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithInstanceId(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.String instanceId)
    {
        @selfRef.InstanceId = instanceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithInstanceMaintenancePolicy(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.InstanceMaintenancePolicyArgs instanceMaintenancePolicy)
    {
        @selfRef.InstanceMaintenancePolicy = instanceMaintenancePolicy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithInstanceMaintenancePolicy(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.InstanceMaintenancePolicyArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.InstanceMaintenancePolicyArgs();
        @configure(@item);
        @selfRef.InstanceMaintenancePolicy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithLaunchConfigurationName(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.String launchConfigurationName)
    {
        @selfRef.LaunchConfigurationName = launchConfigurationName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithLaunchTemplate(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.LaunchTemplateSpecificationArgs launchTemplate)
    {
        @selfRef.LaunchTemplate = launchTemplate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithLaunchTemplate(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.LaunchTemplateSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.LaunchTemplateSpecificationArgs();
        @configure(@item);
        @selfRef.LaunchTemplate = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithLifecycleHookSpecificationList(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.LifecycleHookSpecificationArgs> lifecycleHookSpecificationList)
    {
        @selfRef.LifecycleHookSpecificationList = lifecycleHookSpecificationList;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithLifecycleHookSpecificationList(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.LifecycleHookSpecificationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.LifecycleHookSpecificationArgs>();
        @configure(@list);
        @selfRef.LifecycleHookSpecificationList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithLifecycleHookSpecificationList(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.LifecycleHookSpecificationArgs>> @create)
    {
        @selfRef.LifecycleHookSpecificationList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithLoadBalancerNames(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> loadBalancerNames)
    {
        @selfRef.LoadBalancerNames = loadBalancerNames;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithLoadBalancerNames(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.LoadBalancerNames = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithLoadBalancerNames(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.LoadBalancerNames = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithMaxInstanceLifetime(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Int32 maxInstanceLifetime)
    {
        @selfRef.MaxInstanceLifetime = maxInstanceLifetime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithMaxSize(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.String maxSize)
    {
        @selfRef.MaxSize = maxSize;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithMetricsCollection(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.MetricsCollectionArgs> metricsCollection)
    {
        @selfRef.MetricsCollection = metricsCollection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithMetricsCollection(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.MetricsCollectionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.MetricsCollectionArgs>();
        @configure(@list);
        @selfRef.MetricsCollection = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithMetricsCollection(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.MetricsCollectionArgs>> @create)
    {
        @selfRef.MetricsCollection = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithMinSize(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.String minSize)
    {
        @selfRef.MinSize = minSize;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithMixedInstancesPolicy(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.MixedInstancesPolicyArgs mixedInstancesPolicy)
    {
        @selfRef.MixedInstancesPolicy = mixedInstancesPolicy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithMixedInstancesPolicy(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.MixedInstancesPolicyArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.MixedInstancesPolicyArgs();
        @configure(@item);
        @selfRef.MixedInstancesPolicy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithNewInstancesProtectedFromScaleIn(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, bool newInstancesProtectedFromScaleIn = true)
    {
        @selfRef.NewInstancesProtectedFromScaleIn = newInstancesProtectedFromScaleIn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithNotificationConfiguration(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.AutoScalingGroupNotificationConfigurationArgs notificationConfiguration)
    {
        @selfRef.NotificationConfiguration = notificationConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithNotificationConfiguration(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.AutoScalingGroupNotificationConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.AutoScalingGroupNotificationConfigurationArgs();
        @configure(@item);
        @selfRef.NotificationConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithNotificationConfigurations(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.AutoScalingGroupNotificationConfigurationArgs> notificationConfigurations)
    {
        @selfRef.NotificationConfigurations = notificationConfigurations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithNotificationConfigurations(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.AutoScalingGroupNotificationConfigurationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.AutoScalingGroupNotificationConfigurationArgs>();
        @configure(@list);
        @selfRef.NotificationConfigurations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithNotificationConfigurations(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.AutoScalingGroupNotificationConfigurationArgs>> @create)
    {
        @selfRef.NotificationConfigurations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithPlacementGroup(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.String placementGroup)
    {
        @selfRef.PlacementGroup = placementGroup;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithServiceLinkedRoleARN(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.String serviceLinkedRoleARN)
    {
        @selfRef.ServiceLinkedRoleARN = serviceLinkedRoleARN;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.TagPropertyArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.TagPropertyArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.TagPropertyArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.TagPropertyArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithTargetGroupARNs(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> targetGroupARNs)
    {
        @selfRef.TargetGroupARNs = targetGroupARNs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithTargetGroupARNs(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.TargetGroupARNs = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithTargetGroupARNs(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.TargetGroupARNs = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithTerminationPolicies(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> terminationPolicies)
    {
        @selfRef.TerminationPolicies = terminationPolicies;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithTerminationPolicies(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.TerminationPolicies = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithTerminationPolicies(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.TerminationPolicies = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithVpcZoneIdentifier(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> vpcZoneIdentifier)
    {
        @selfRef.VpcZoneIdentifier = vpcZoneIdentifier;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithVpcZoneIdentifier(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.VpcZoneIdentifier = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs WithVpcZoneIdentifier(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAutoScalingAutoScalingGroupPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.VpcZoneIdentifier = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
