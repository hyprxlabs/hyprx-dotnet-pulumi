// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.IoTOperationsMQ;

public static partial class DataLakeConnectorExtensions
{

    extension(DataLakeConnector)
    {
        public static DataLakeConnector New(string @id, global::Pulumi.AzureNative.IoTOperationsMQ.DataLakeConnectorArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new DataLakeConnector(@id, @args, @options);
        }

        public static DataLakeConnector New(string @id, global::System.Action<global::Pulumi.AzureNative.IoTOperationsMQ.DataLakeConnectorArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.IoTOperationsMQ.DataLakeConnectorArgs @args = new();
            global::Pulumi.CustomResourceOptions? @options = null;
            if (@configureArgs is not null)
            {
                @configureArgs(@args);
            }

            if (@configureOptions is not null)
            {
                @options = new();
                @configureOptions(@options);
            }

            return new DataLakeConnector(@id, @args, @options);
        }

    }

}
