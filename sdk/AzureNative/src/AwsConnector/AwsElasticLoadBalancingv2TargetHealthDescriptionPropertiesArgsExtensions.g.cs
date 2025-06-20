// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class AwsElasticLoadBalancingv2TargetHealthDescriptionPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingv2TargetHealthDescriptionPropertiesArgs WithAnomalyDetection(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingv2TargetHealthDescriptionPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.AnomalyDetectionArgs anomalyDetection)
    {
        @selfRef.AnomalyDetection = anomalyDetection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingv2TargetHealthDescriptionPropertiesArgs WithAnomalyDetection(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingv2TargetHealthDescriptionPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.AnomalyDetectionArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.AnomalyDetectionArgs();
        @configure(@item);
        @selfRef.AnomalyDetection = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingv2TargetHealthDescriptionPropertiesArgs WithHealthCheckPort(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingv2TargetHealthDescriptionPropertiesArgs @selfRef, global::System.String healthCheckPort)
    {
        @selfRef.HealthCheckPort = healthCheckPort;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingv2TargetHealthDescriptionPropertiesArgs WithTarget(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingv2TargetHealthDescriptionPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.TargetDescriptionArgs target)
    {
        @selfRef.Target = target;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingv2TargetHealthDescriptionPropertiesArgs WithTarget(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingv2TargetHealthDescriptionPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.TargetDescriptionArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.TargetDescriptionArgs();
        @configure(@item);
        @selfRef.Target = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingv2TargetHealthDescriptionPropertiesArgs WithTargetHealth(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingv2TargetHealthDescriptionPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.TargetHealthArgs targetHealth)
    {
        @selfRef.TargetHealth = targetHealth;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingv2TargetHealthDescriptionPropertiesArgs WithTargetHealth(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingv2TargetHealthDescriptionPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.TargetHealthArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.TargetHealthArgs();
        @configure(@item);
        @selfRef.TargetHealth = @item;
        return @selfRef;
    }

}
