// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.TestBase;

public static partial class DraftPackageArgsExtensions
{
    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithAppFileName(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.String appFileName)
    {
        @selfRef.AppFileName = appFileName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithApplicationName(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.String applicationName)
    {
        @selfRef.ApplicationName = applicationName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithComments(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.String comments)
    {
        @selfRef.Comments = comments;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithDraftPackageName(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.String draftPackageName)
    {
        @selfRef.DraftPackageName = draftPackageName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithEditPackage(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, bool editPackage = true)
    {
        @selfRef.EditPackage = editPackage;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithExecutableLaunchCommand(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.String executableLaunchCommand)
    {
        @selfRef.ExecutableLaunchCommand = executableLaunchCommand;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithFirstPartyApps(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.TestBase.Inputs.FirstPartyAppDefinitionArgs> firstPartyApps)
    {
        @selfRef.FirstPartyApps = firstPartyApps;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithFirstPartyApps(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.TestBase.Inputs.FirstPartyAppDefinitionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.TestBase.Inputs.FirstPartyAppDefinitionArgs>();
        @configure(@list);
        @selfRef.FirstPartyApps = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithFirstPartyApps(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.TestBase.Inputs.FirstPartyAppDefinitionArgs>> @create)
    {
        @selfRef.FirstPartyApps = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithFlightingRing(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.String flightingRing)
    {
        @selfRef.FlightingRing = flightingRing;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithGalleryApps(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.TestBase.Inputs.GalleryAppDefinitionArgs> galleryApps)
    {
        @selfRef.GalleryApps = galleryApps;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithGalleryApps(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.TestBase.Inputs.GalleryAppDefinitionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.TestBase.Inputs.GalleryAppDefinitionArgs>();
        @configure(@list);
        @selfRef.GalleryApps = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithGalleryApps(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.TestBase.Inputs.GalleryAppDefinitionArgs>> @create)
    {
        @selfRef.GalleryApps = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithHighlightedFiles(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.TestBase.Inputs.HighlightedFileArgs> highlightedFiles)
    {
        @selfRef.HighlightedFiles = highlightedFiles;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithHighlightedFiles(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.TestBase.Inputs.HighlightedFileArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.TestBase.Inputs.HighlightedFileArgs>();
        @configure(@list);
        @selfRef.HighlightedFiles = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithHighlightedFiles(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.TestBase.Inputs.HighlightedFileArgs>> @create)
    {
        @selfRef.HighlightedFiles = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithInplaceUpgradeOSPair(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::Pulumi.AzureNative.TestBase.Inputs.InplaceUpgradeOSInfoArgs inplaceUpgradeOSPair)
    {
        @selfRef.InplaceUpgradeOSPair = inplaceUpgradeOSPair;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithInplaceUpgradeOSPair(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.TestBase.Inputs.InplaceUpgradeOSInfoArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.TestBase.Inputs.InplaceUpgradeOSInfoArgs();
        @configure(@item);
        @selfRef.InplaceUpgradeOSPair = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithIntuneEnrollmentMetadata(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::Pulumi.AzureNative.TestBase.Inputs.IntuneEnrollmentMetadataArgs intuneEnrollmentMetadata)
    {
        @selfRef.IntuneEnrollmentMetadata = intuneEnrollmentMetadata;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithIntuneEnrollmentMetadata(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.TestBase.Inputs.IntuneEnrollmentMetadataArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.TestBase.Inputs.IntuneEnrollmentMetadataArgs();
        @configure(@item);
        @selfRef.IntuneEnrollmentMetadata = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithIntuneMetadata(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::Pulumi.AzureNative.TestBase.Inputs.DraftPackageIntuneAppMetadataArgs intuneMetadata)
    {
        @selfRef.IntuneMetadata = intuneMetadata;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithIntuneMetadata(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.TestBase.Inputs.DraftPackageIntuneAppMetadataArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.TestBase.Inputs.DraftPackageIntuneAppMetadataArgs();
        @configure(@item);
        @selfRef.IntuneMetadata = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithPackageId(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.String packageId)
    {
        @selfRef.PackageId = packageId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithPackageTags(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> packageTags)
    {
        @selfRef.PackageTags = packageTags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithPackageTags(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.PackageTags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithPackageTags(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.PackageTags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithProcessName(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.String processName)
    {
        @selfRef.ProcessName = processName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithResourceGroupName(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithSourceType(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.TestBase.DraftPackageSourceType> sourceType)
    {
        @selfRef.SourceType = sourceType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithTabState(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::Pulumi.AzureNative.TestBase.Inputs.TabStateArgs tabState)
    {
        @selfRef.TabState = tabState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithTabState(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.TestBase.Inputs.TabStateArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.TestBase.Inputs.TabStateArgs();
        @configure(@item);
        @selfRef.TabState = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithTargetOSList(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.TestBase.Inputs.TargetOSInfoArgs> targetOSList)
    {
        @selfRef.TargetOSList = targetOSList;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithTargetOSList(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.TestBase.Inputs.TargetOSInfoArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.TestBase.Inputs.TargetOSInfoArgs>();
        @configure(@list);
        @selfRef.TargetOSList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithTargetOSList(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.TestBase.Inputs.TargetOSInfoArgs>> @create)
    {
        @selfRef.TargetOSList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithTestBaseAccountName(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.String testBaseAccountName)
    {
        @selfRef.TestBaseAccountName = testBaseAccountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithTestTypes(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.TestBase.TestType>> testTypes)
    {
        @selfRef.TestTypes = testTypes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithTestTypes(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.TestBase.TestType>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.TestBase.TestType>>();
        @configure(@list);
        @selfRef.TestTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithTestTypes(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.TestBase.TestType>>> @create)
    {
        @selfRef.TestTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithTests(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.TestBase.Inputs.TestArgs> tests)
    {
        @selfRef.Tests = tests;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithTests(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.TestBase.Inputs.TestArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.TestBase.Inputs.TestArgs>();
        @configure(@list);
        @selfRef.Tests = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithTests(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.TestBase.Inputs.TestArgs>> @create)
    {
        @selfRef.Tests = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithUseAutofill(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, bool useAutofill = true)
    {
        @selfRef.UseAutofill = useAutofill;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithUseSample(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, bool useSample = true)
    {
        @selfRef.UseSample = useSample;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TestBase.DraftPackageArgs WithVersion(this global::Pulumi.AzureNative.TestBase.DraftPackageArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
