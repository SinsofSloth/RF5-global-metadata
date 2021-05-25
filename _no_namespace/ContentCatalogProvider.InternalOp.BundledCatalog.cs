internal class ContentCatalogProvider.InternalOp.BundledCatalog // TypeDefIndex: 5723
{
	// Fields
	private readonly string m_BundlePath; // 0x10
	private bool m_OpInProgress; // 0x18
	private AssetBundleCreateRequest m_LoadBundleRequest; // 0x20
	internal AssetBundle m_CatalogAssetBundle; // 0x28
	private AssetBundleRequest m_LoadTextAssetRequest; // 0x30
	private ContentCatalogData m_CatalogData; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x13DDA0 Offset: 0x13DEA1 VA: 0x13DDA0
	private Action<ContentCatalogData> OnLoaded; // 0x40

	// Properties
	public bool OpInProgress { get; }
	public bool OpIsSuccess { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x13E9E0 Offset: 0x13EAE1 VA: 0x13E9E0
	// RVA: 0x15ED550 Offset: 0x15ED651 VA: 0x15ED550
	public void add_OnLoaded(Action<ContentCatalogData> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13E9F0 Offset: 0x13EAF1 VA: 0x13E9F0
	// RVA: 0x15EDA00 Offset: 0x15EDB01 VA: 0x15EDA00
	public void remove_OnLoaded(Action<ContentCatalogData> value) { }

	// RVA: 0x15EDAB0 Offset: 0x15EDBB1 VA: 0x15EDAB0
	public bool get_OpInProgress() { }

	// RVA: 0x15EDAC0 Offset: 0x15EDBC1 VA: 0x15EDAC0
	public bool get_OpIsSuccess() { }

	// RVA: 0x15ED440 Offset: 0x15ED541 VA: 0x15ED440
	public void .ctor(string bundlePath) { }

	// RVA: 0x15EDAE0 Offset: 0x15EDBE1 VA: 0x15EDAE0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x15EDB70 Offset: 0x15EDC71 VA: 0x15EDB70
	private void Unload() { }

	// RVA: 0x15ED600 Offset: 0x15ED701 VA: 0x15ED600
	public void LoadCatalogFromBundleAsync() { }

	[CompilerGeneratedAttribute] // RVA: 0x13EA00 Offset: 0x13EB01 VA: 0x13EA00
	// RVA: 0x15EDBB0 Offset: 0x15EDCB1 VA: 0x15EDBB0
	private void <LoadCatalogFromBundleAsync>b__16_0(AsyncOperation loadOp) { }

	[CompilerGeneratedAttribute] // RVA: 0x13EA10 Offset: 0x13EB11 VA: 0x13EA10
	// RVA: 0x15EDD70 Offset: 0x15EDE71 VA: 0x15EDD70
	private void <LoadCatalogFromBundleAsync>b__16_1(AsyncOperation op) { }
}

