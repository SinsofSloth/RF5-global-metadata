internal class ManifestBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 495
{
	// Fields
	private ResourceManager.ResourceManagerMediator _mediator; // 0x10

	// Methods

	// RVA: 0x17F4EE0 Offset: 0x17F4FE1 VA: 0x17F4EE0
	public void .ctor(ResourceManager.ResourceManagerMediator mediator) { }

	// RVA: 0x17F4F20 Offset: 0x17F5021 VA: 0x17F4F20 Slot: 4
	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark) { }

	// RVA: 0x17F5210 Offset: 0x17F5311 VA: 0x17F5210
	private CultureInfo UltimateFallbackFixup(CultureInfo lookForCulture) { }

	// RVA: 0x17F69F0 Offset: 0x17F6AF1 VA: 0x17F69F0
	internal static CultureInfo GetNeutralResourcesLanguage(Assembly a, ref UltimateResourceFallbackLocation fallbackLocation) { }

	// RVA: 0x17F5CF0 Offset: 0x17F5DF1 VA: 0x17F5CF0
	internal ResourceSet CreateResourceSet(Stream store, Assembly assembly) { }

	// RVA: 0x17F5B30 Offset: 0x17F5C31 VA: 0x17F5B30
	private Stream GetManifestResourceStream(RuntimeAssembly satellite, string fileName, ref StackCrawlMark stackMark) { }

	// RVA: 0x17F70A0 Offset: 0x17F71A1 VA: 0x17F70A0
	private Stream CaseInsensitiveManifestResourceStreamLookup(RuntimeAssembly satellite, string name) { }

	// RVA: 0x17F53E0 Offset: 0x17F54E1 VA: 0x17F53E0
	private RuntimeAssembly GetSatelliteAssembly(CultureInfo lookForCulture, ref StackCrawlMark stackMark) { }

	// RVA: 0x17F6E10 Offset: 0x17F6F11 VA: 0x17F6E10
	private bool CanUseDefaultResourceClasses(string readerTypeName, string resSetTypeName) { }

	// RVA: 0x17F75E0 Offset: 0x17F76E1 VA: 0x17F75E0
	private string GetSatelliteAssemblyName() { }

	// RVA: 0x17F56E0 Offset: 0x17F57E1 VA: 0x17F56E0
	private void HandleSatelliteMissing() { }

	// RVA: 0x17F6680 Offset: 0x17F6781 VA: 0x17F6680
	private void HandleResourceStreamMissing(string fileName) { }

	// RVA: 0x17F6D80 Offset: 0x17F6E81 VA: 0x17F6D80
	private static bool GetNeutralResourcesLanguageAttribute(Assembly assembly, ref string cultureName, ref short fallbackLocation) { }
}

