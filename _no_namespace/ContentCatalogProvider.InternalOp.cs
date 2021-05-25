internal class ContentCatalogProvider.InternalOp // TypeDefIndex: 5722
{
	// Fields
	private string m_LocalDataPath; // 0x10
	private string m_RemoteHashValue; // 0x18
	private string m_LocalHashValue; // 0x20
	private ProvideHandle m_ProviderInterface; // 0x28
	internal ContentCatalogData m_ContentCatalogData; // 0x40

	// Methods

	// RVA: 0x15EC5A0 Offset: 0x15EC6A1 VA: 0x15EC5A0
	public void Start(ProvideHandle providerInterface, bool disableCatalogUpdateOnStart, bool isLocalCatalogInBundle) { }

	// RVA: 0x15EC440 Offset: 0x15EC541 VA: 0x15EC440
	public void Release() { }

	// RVA: 0x15ECFF0 Offset: 0x15ED0F1 VA: 0x15ECFF0
	internal void LoadCatalog(string idToLoad, bool isLocalCatalogInBundle, bool isLocalCatalog) { }

	// RVA: 0x15ECF10 Offset: 0x15ED011 VA: 0x15ECF10
	private string GetTransformedInternalId(IResourceLocation loc) { }

	// RVA: 0x15EC6E0 Offset: 0x15EC7E1 VA: 0x15EC6E0
	internal string DetermineIdToLoad(IResourceLocation location, IList<object> dependencyObjects, bool disableCatalogUpdateOnStart = False) { }

	// RVA: 0x15ED700 Offset: 0x15ED801 VA: 0x15ED700
	private void OnCatalogLoaded(ContentCatalogData ccd) { }

	// RVA: 0x15EC590 Offset: 0x15EC691 VA: 0x15EC590
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x13E9C0 Offset: 0x13EAC1 VA: 0x13E9C0
	// RVA: 0x15ED8E0 Offset: 0x15ED9E1 VA: 0x15ED8E0
	private void <LoadCatalog>b__7_0(ContentCatalogData ccd) { }

	[CompilerGeneratedAttribute] // RVA: 0x13E9D0 Offset: 0x13EAD1 VA: 0x13E9D0
	// RVA: 0x15ED910 Offset: 0x15EDA11 VA: 0x15ED910
	private void <LoadCatalog>b__7_1(AsyncOperationHandle<ContentCatalogData> op) { }
}

