[DisplayNameAttribute] // RVA: 0x13DBF0 Offset: 0x13DCF1 VA: 0x13DBF0
public class ContentCatalogProvider : ResourceProviderBase // TypeDefIndex: 5720
{
	// Fields
	public bool DisableCatalogUpdateOnStart; // 0x1C
	public bool IsLocalCatalogInBundle; // 0x1D
	internal Dictionary<IResourceLocation, ContentCatalogProvider.InternalOp> m_LocationToCatalogLoadOpMap; // 0x20
	private ResourceManager m_RM; // 0x28

	// Methods

	// RVA: 0x15E6990 Offset: 0x15E6A91 VA: 0x15E6990
	public void .ctor(ResourceManager resourceManagerInstance) { }

	// RVA: 0x15EC370 Offset: 0x15EC471 VA: 0x15EC370 Slot: 15
	public override void Release(IResourceLocation location, object obj) { }

	// RVA: 0x15EC450 Offset: 0x15EC551 VA: 0x15EC450 Slot: 17
	public override void Provide(ProvideHandle providerInterface) { }
}

