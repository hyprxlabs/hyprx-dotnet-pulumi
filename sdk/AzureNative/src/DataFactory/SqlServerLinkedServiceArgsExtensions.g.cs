// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class SqlServerLinkedServiceArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithAlwaysEncryptedSettings(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.SqlAlwaysEncryptedPropertiesArgs alwaysEncryptedSettings)
    {
        @selfRef.AlwaysEncryptedSettings = alwaysEncryptedSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithAlwaysEncryptedSettings(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.SqlAlwaysEncryptedPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.SqlAlwaysEncryptedPropertiesArgs();
        @configure(@item);
        @selfRef.AlwaysEncryptedSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Collections.Generic.List<global::System.Object> annotations)
    {
        @selfRef.Annotations = annotations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Object>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Object>();
        @configure(@list);
        @selfRef.Annotations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Object>> @create)
    {
        @selfRef.Annotations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithApplicationIntent(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Object applicationIntent)
    {
        @selfRef.ApplicationIntent = applicationIntent;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithApplicationIntent(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.ApplicationIntent = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithAuthenticationType(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DataFactory.SqlServerAuthenticationType> authenticationType)
    {
        @selfRef.AuthenticationType = authenticationType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithCommandTimeout(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Object commandTimeout)
    {
        @selfRef.CommandTimeout = commandTimeout;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithCommandTimeout(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.CommandTimeout = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithConnectRetryCount(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Object connectRetryCount)
    {
        @selfRef.ConnectRetryCount = connectRetryCount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithConnectRetryCount(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.ConnectRetryCount = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithConnectRetryInterval(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Object connectRetryInterval)
    {
        @selfRef.ConnectRetryInterval = connectRetryInterval;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithConnectRetryInterval(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.ConnectRetryInterval = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithConnectTimeout(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Object connectTimeout)
    {
        @selfRef.ConnectTimeout = connectTimeout;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithConnectTimeout(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.ConnectTimeout = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithConnectVia(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.IntegrationRuntimeReferenceArgs connectVia)
    {
        @selfRef.ConnectVia = connectVia;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithConnectVia(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.IntegrationRuntimeReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.IntegrationRuntimeReferenceArgs();
        @configure(@item);
        @selfRef.ConnectVia = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithConnectionString(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Object connectionString)
    {
        @selfRef.ConnectionString = connectionString;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithConnectionString(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.ConnectionString = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithCredential(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.CredentialReferenceArgs credential)
    {
        @selfRef.Credential = credential;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithCredential(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.CredentialReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.CredentialReferenceArgs();
        @configure(@item);
        @selfRef.Credential = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithDatabase(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Object database)
    {
        @selfRef.Database = database;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithDatabase(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Database = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithDescription(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithEncrypt(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Object encrypt)
    {
        @selfRef.Encrypt = encrypt;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithEncrypt(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Encrypt = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithEncryptedCredential(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.String encryptedCredential)
    {
        @selfRef.EncryptedCredential = encryptedCredential;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithFailoverPartner(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Object failoverPartner)
    {
        @selfRef.FailoverPartner = failoverPartner;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithFailoverPartner(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.FailoverPartner = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithHostNameInCertificate(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Object hostNameInCertificate)
    {
        @selfRef.HostNameInCertificate = hostNameInCertificate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithHostNameInCertificate(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.HostNameInCertificate = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithIntegratedSecurity(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Object integratedSecurity)
    {
        @selfRef.IntegratedSecurity = integratedSecurity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithIntegratedSecurity(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.IntegratedSecurity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithLoadBalanceTimeout(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Object loadBalanceTimeout)
    {
        @selfRef.LoadBalanceTimeout = loadBalanceTimeout;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithLoadBalanceTimeout(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.LoadBalanceTimeout = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithMaxPoolSize(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Object maxPoolSize)
    {
        @selfRef.MaxPoolSize = maxPoolSize;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithMaxPoolSize(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.MaxPoolSize = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithMinPoolSize(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Object minPoolSize)
    {
        @selfRef.MinPoolSize = minPoolSize;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithMinPoolSize(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.MinPoolSize = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithMultiSubnetFailover(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Object multiSubnetFailover)
    {
        @selfRef.MultiSubnetFailover = multiSubnetFailover;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithMultiSubnetFailover(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.MultiSubnetFailover = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithMultipleActiveResultSets(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Object multipleActiveResultSets)
    {
        @selfRef.MultipleActiveResultSets = multipleActiveResultSets;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithMultipleActiveResultSets(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.MultipleActiveResultSets = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithPacketSize(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Object packetSize)
    {
        @selfRef.PacketSize = packetSize;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithPacketSize(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.PacketSize = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs> parameters)
    {
        @selfRef.Parameters = parameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>();
        @configure(@dict);
        @selfRef.Parameters = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>> @create)
    {
        @selfRef.Parameters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithPassword(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::Pulumi.Union<global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs, global::Pulumi.AzureNative.DataFactory.Inputs.SecureStringArgs> password)
    {
        @selfRef.Password = password;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithPooling(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Object pooling)
    {
        @selfRef.Pooling = pooling;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithPooling(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Pooling = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithServer(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Object server)
    {
        @selfRef.Server = server;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithServer(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Server = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithTrustServerCertificate(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Object trustServerCertificate)
    {
        @selfRef.TrustServerCertificate = trustServerCertificate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithTrustServerCertificate(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.TrustServerCertificate = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithUserName(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Object userName)
    {
        @selfRef.UserName = userName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithUserName(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.UserName = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs WithVersion(this global::Pulumi.AzureNative.DataFactory.Inputs.SqlServerLinkedServiceArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
