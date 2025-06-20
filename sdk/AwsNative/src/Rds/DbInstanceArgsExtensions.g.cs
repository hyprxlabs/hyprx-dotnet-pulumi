// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Rds;

public static partial class DbInstanceArgsExtensions
{
    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithAllocatedStorage(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String allocatedStorage)
    {
        @selfRef.AllocatedStorage = allocatedStorage;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithAllowMajorVersionUpgrade(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, bool allowMajorVersionUpgrade = true)
    {
        @selfRef.AllowMajorVersionUpgrade = allowMajorVersionUpgrade;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithApplyImmediately(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, bool applyImmediately = true)
    {
        @selfRef.ApplyImmediately = applyImmediately;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithAssociatedRoles(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Rds.Inputs.DbInstanceDbInstanceRoleArgs> associatedRoles)
    {
        @selfRef.AssociatedRoles = associatedRoles;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithAssociatedRoles(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Rds.Inputs.DbInstanceDbInstanceRoleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Rds.Inputs.DbInstanceDbInstanceRoleArgs>();
        @configure(@list);
        @selfRef.AssociatedRoles = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithAssociatedRoles(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Rds.Inputs.DbInstanceDbInstanceRoleArgs>> @create)
    {
        @selfRef.AssociatedRoles = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithAutoMinorVersionUpgrade(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, bool autoMinorVersionUpgrade = true)
    {
        @selfRef.AutoMinorVersionUpgrade = autoMinorVersionUpgrade;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithAutomaticBackupReplicationKmsKeyId(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String automaticBackupReplicationKmsKeyId)
    {
        @selfRef.AutomaticBackupReplicationKmsKeyId = automaticBackupReplicationKmsKeyId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithAutomaticBackupReplicationRegion(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String automaticBackupReplicationRegion)
    {
        @selfRef.AutomaticBackupReplicationRegion = automaticBackupReplicationRegion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithAutomaticBackupReplicationRetentionPeriod(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Int32 automaticBackupReplicationRetentionPeriod)
    {
        @selfRef.AutomaticBackupReplicationRetentionPeriod = automaticBackupReplicationRetentionPeriod;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithAvailabilityZone(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String availabilityZone)
    {
        @selfRef.AvailabilityZone = availabilityZone;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithBackupRetentionPeriod(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Int32 backupRetentionPeriod)
    {
        @selfRef.BackupRetentionPeriod = backupRetentionPeriod;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithCaCertificateIdentifier(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String caCertificateIdentifier)
    {
        @selfRef.CaCertificateIdentifier = caCertificateIdentifier;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithCertificateRotationRestart(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, bool certificateRotationRestart = true)
    {
        @selfRef.CertificateRotationRestart = certificateRotationRestart;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithCharacterSetName(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String characterSetName)
    {
        @selfRef.CharacterSetName = characterSetName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithCopyTagsToSnapshot(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, bool copyTagsToSnapshot = true)
    {
        @selfRef.CopyTagsToSnapshot = copyTagsToSnapshot;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithCustomIamInstanceProfile(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String customIamInstanceProfile)
    {
        @selfRef.CustomIamInstanceProfile = customIamInstanceProfile;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDatabaseInsightsMode(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String databaseInsightsMode)
    {
        @selfRef.DatabaseInsightsMode = databaseInsightsMode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDbClusterIdentifier(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String dbClusterIdentifier)
    {
        @selfRef.DbClusterIdentifier = dbClusterIdentifier;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDbClusterSnapshotIdentifier(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String dbClusterSnapshotIdentifier)
    {
        @selfRef.DbClusterSnapshotIdentifier = dbClusterSnapshotIdentifier;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDbInstanceClass(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String dbInstanceClass)
    {
        @selfRef.DbInstanceClass = dbInstanceClass;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDbInstanceIdentifier(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String dbInstanceIdentifier)
    {
        @selfRef.DbInstanceIdentifier = dbInstanceIdentifier;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDbName(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String dbName)
    {
        @selfRef.DbName = dbName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDbParameterGroupName(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String dbParameterGroupName)
    {
        @selfRef.DbParameterGroupName = dbParameterGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDbSecurityGroups(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Collections.Generic.List<global::System.String> dbSecurityGroups)
    {
        @selfRef.DbSecurityGroups = dbSecurityGroups;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDbSecurityGroups(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.DbSecurityGroups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDbSecurityGroups(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.DbSecurityGroups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDbSnapshotIdentifier(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String dbSnapshotIdentifier)
    {
        @selfRef.DbSnapshotIdentifier = dbSnapshotIdentifier;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDbSubnetGroupName(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String dbSubnetGroupName)
    {
        @selfRef.DbSubnetGroupName = dbSubnetGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDbSystemId(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String dbSystemId)
    {
        @selfRef.DbSystemId = dbSystemId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDedicatedLogVolume(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, bool dedicatedLogVolume = true)
    {
        @selfRef.DedicatedLogVolume = dedicatedLogVolume;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDeleteAutomatedBackups(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, bool deleteAutomatedBackups = true)
    {
        @selfRef.DeleteAutomatedBackups = deleteAutomatedBackups;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDeletionProtection(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, bool deletionProtection = true)
    {
        @selfRef.DeletionProtection = deletionProtection;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDomain(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String domain)
    {
        @selfRef.Domain = domain;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDomainAuthSecretArn(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String domainAuthSecretArn)
    {
        @selfRef.DomainAuthSecretArn = domainAuthSecretArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDomainDnsIps(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Collections.Generic.List<global::System.String> domainDnsIps)
    {
        @selfRef.DomainDnsIps = domainDnsIps;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDomainDnsIps(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.DomainDnsIps = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDomainDnsIps(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.DomainDnsIps = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDomainFqdn(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String domainFqdn)
    {
        @selfRef.DomainFqdn = domainFqdn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDomainIamRoleName(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String domainIamRoleName)
    {
        @selfRef.DomainIamRoleName = domainIamRoleName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithDomainOu(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String domainOu)
    {
        @selfRef.DomainOu = domainOu;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithEnableCloudwatchLogsExports(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Collections.Generic.List<global::System.String> enableCloudwatchLogsExports)
    {
        @selfRef.EnableCloudwatchLogsExports = enableCloudwatchLogsExports;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithEnableCloudwatchLogsExports(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.EnableCloudwatchLogsExports = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithEnableCloudwatchLogsExports(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.EnableCloudwatchLogsExports = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithEnableIamDatabaseAuthentication(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, bool enableIamDatabaseAuthentication = true)
    {
        @selfRef.EnableIamDatabaseAuthentication = enableIamDatabaseAuthentication;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithEnablePerformanceInsights(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, bool enablePerformanceInsights = true)
    {
        @selfRef.EnablePerformanceInsights = enablePerformanceInsights;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithEngine(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String engine)
    {
        @selfRef.Engine = engine;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithEngineLifecycleSupport(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String engineLifecycleSupport)
    {
        @selfRef.EngineLifecycleSupport = engineLifecycleSupport;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithEngineVersion(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String engineVersion)
    {
        @selfRef.EngineVersion = engineVersion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithIops(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Int32 iops)
    {
        @selfRef.Iops = iops;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithKmsKeyId(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String kmsKeyId)
    {
        @selfRef.KmsKeyId = kmsKeyId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithLicenseModel(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String licenseModel)
    {
        @selfRef.LicenseModel = licenseModel;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithManageMasterUserPassword(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, bool manageMasterUserPassword = true)
    {
        @selfRef.ManageMasterUserPassword = manageMasterUserPassword;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithMasterUserPassword(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String masterUserPassword)
    {
        @selfRef.MasterUserPassword = masterUserPassword;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithMasterUserSecret(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::Pulumi.AwsNative.Rds.Inputs.DbInstanceMasterUserSecretArgs masterUserSecret)
    {
        @selfRef.MasterUserSecret = masterUserSecret;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithMasterUserSecret(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Rds.Inputs.DbInstanceMasterUserSecretArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Rds.Inputs.DbInstanceMasterUserSecretArgs();
        @configure(@item);
        @selfRef.MasterUserSecret = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithMasterUsername(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String masterUsername)
    {
        @selfRef.MasterUsername = masterUsername;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithMaxAllocatedStorage(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Int32 maxAllocatedStorage)
    {
        @selfRef.MaxAllocatedStorage = maxAllocatedStorage;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithMonitoringInterval(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Int32 monitoringInterval)
    {
        @selfRef.MonitoringInterval = monitoringInterval;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithMonitoringRoleArn(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String monitoringRoleArn)
    {
        @selfRef.MonitoringRoleArn = monitoringRoleArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithMultiAz(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, bool multiAz = true)
    {
        @selfRef.MultiAz = multiAz;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithNcharCharacterSetName(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String ncharCharacterSetName)
    {
        @selfRef.NcharCharacterSetName = ncharCharacterSetName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithNetworkType(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String networkType)
    {
        @selfRef.NetworkType = networkType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithOptionGroupName(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String optionGroupName)
    {
        @selfRef.OptionGroupName = optionGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithPerformanceInsightsKmsKeyId(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String performanceInsightsKmsKeyId)
    {
        @selfRef.PerformanceInsightsKmsKeyId = performanceInsightsKmsKeyId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithPerformanceInsightsRetentionPeriod(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Int32 performanceInsightsRetentionPeriod)
    {
        @selfRef.PerformanceInsightsRetentionPeriod = performanceInsightsRetentionPeriod;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithPort(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String port)
    {
        @selfRef.Port = port;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithPreferredBackupWindow(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String preferredBackupWindow)
    {
        @selfRef.PreferredBackupWindow = preferredBackupWindow;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithPreferredMaintenanceWindow(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String preferredMaintenanceWindow)
    {
        @selfRef.PreferredMaintenanceWindow = preferredMaintenanceWindow;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithProcessorFeatures(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Rds.Inputs.DbInstanceProcessorFeatureArgs> processorFeatures)
    {
        @selfRef.ProcessorFeatures = processorFeatures;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithProcessorFeatures(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Rds.Inputs.DbInstanceProcessorFeatureArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Rds.Inputs.DbInstanceProcessorFeatureArgs>();
        @configure(@list);
        @selfRef.ProcessorFeatures = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithProcessorFeatures(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Rds.Inputs.DbInstanceProcessorFeatureArgs>> @create)
    {
        @selfRef.ProcessorFeatures = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithPromotionTier(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Int32 promotionTier)
    {
        @selfRef.PromotionTier = promotionTier;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithPubliclyAccessible(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, bool publiclyAccessible = true)
    {
        @selfRef.PubliclyAccessible = publiclyAccessible;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithReplicaMode(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String replicaMode)
    {
        @selfRef.ReplicaMode = replicaMode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithRestoreTime(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String restoreTime)
    {
        @selfRef.RestoreTime = restoreTime;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithSourceDbClusterIdentifier(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String sourceDbClusterIdentifier)
    {
        @selfRef.SourceDbClusterIdentifier = sourceDbClusterIdentifier;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithSourceDbInstanceAutomatedBackupsArn(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String sourceDbInstanceAutomatedBackupsArn)
    {
        @selfRef.SourceDbInstanceAutomatedBackupsArn = sourceDbInstanceAutomatedBackupsArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithSourceDbInstanceIdentifier(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String sourceDbInstanceIdentifier)
    {
        @selfRef.SourceDbInstanceIdentifier = sourceDbInstanceIdentifier;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithSourceDbiResourceId(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String sourceDbiResourceId)
    {
        @selfRef.SourceDbiResourceId = sourceDbiResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithSourceRegion(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String sourceRegion)
    {
        @selfRef.SourceRegion = sourceRegion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithStorageEncrypted(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, bool storageEncrypted = true)
    {
        @selfRef.StorageEncrypted = storageEncrypted;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithStorageThroughput(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Int32 storageThroughput)
    {
        @selfRef.StorageThroughput = storageThroughput;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithStorageType(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String storageType)
    {
        @selfRef.StorageType = storageType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithTags(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithTags(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithTags(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithTdeCredentialArn(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String tdeCredentialArn)
    {
        @selfRef.TdeCredentialArn = tdeCredentialArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithTdeCredentialPassword(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String tdeCredentialPassword)
    {
        @selfRef.TdeCredentialPassword = tdeCredentialPassword;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithTimezone(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.String timezone)
    {
        @selfRef.Timezone = timezone;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithUseDefaultProcessorFeatures(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, bool useDefaultProcessorFeatures = true)
    {
        @selfRef.UseDefaultProcessorFeatures = useDefaultProcessorFeatures;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithUseLatestRestorableTime(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, bool useLatestRestorableTime = true)
    {
        @selfRef.UseLatestRestorableTime = useLatestRestorableTime;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithVpcSecurityGroups(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Collections.Generic.List<global::System.String> vpcSecurityGroups)
    {
        @selfRef.VpcSecurityGroups = vpcSecurityGroups;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithVpcSecurityGroups(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.VpcSecurityGroups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rds.DbInstanceArgs WithVpcSecurityGroups(this global::Pulumi.AwsNative.Rds.DbInstanceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.VpcSecurityGroups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
