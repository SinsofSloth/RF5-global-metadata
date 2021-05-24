internal class FileBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 492
{
	// Fields
	private ResourceManager.ResourceManagerMediator _mediator; // 0x10

	// Methods

	// RVA: 0x17F4530 Offset: 0x17F4631 VA: 0x17F4530
	public void .ctor(ResourceManager.ResourceManagerMediator mediator) { }

	// RVA: 0x17F4570 Offset: 0x17F4671 VA: 0x17F4570 Slot: 4
	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark) { }

	// RVA: 0x17F4940 Offset: 0x17F4A41 VA: 0x17F4940
	private string FindResourceFile(CultureInfo culture, string fileName) { }

	// RVA: 0x17F4A90 Offset: 0x17F4B91 VA: 0x17F4A90
	private ResourceSet CreateResourceSet(string file) { }
}

