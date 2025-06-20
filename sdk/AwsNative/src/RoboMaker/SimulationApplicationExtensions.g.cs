// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.RoboMaker;

public static partial class SimulationApplicationExtensions
{

    extension(SimulationApplication)
    {
        public static SimulationApplication New(string @id, global::Pulumi.AwsNative.RoboMaker.SimulationApplicationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new SimulationApplication(@id, @args, @options);
        }

        public static SimulationApplication New(string @id, global::System.Action<global::Pulumi.AwsNative.RoboMaker.SimulationApplicationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.RoboMaker.SimulationApplicationArgs @args = new();
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

            return new SimulationApplication(@id, @args, @options);
        }

    }

}
