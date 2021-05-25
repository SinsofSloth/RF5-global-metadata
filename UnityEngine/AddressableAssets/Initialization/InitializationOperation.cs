internal class InitializationOperation : AsyncOperationBase<IResourceLocator> // TypeDefIndex: 5737
{
	// Fields
	private AsyncOperationHandle<ResourceManagerRuntimeData> m_rtdOp; // 0x80
	private string m_ProviderSuffix; // 0x98
	private AddressablesImpl m_Addressables; // 0xA0
	private ResourceManagerDiagnostics m_Diagnostics; // 0xA8
	private InitalizationObjectsOperation m_InitGroupOps; // 0xB0

	// Properties
	protected override float Progress { get; }
	protected override string DebugName { get; }

	// Methods

	// RVA: 0x15E66B0 Offset: 0x15E67B1 VA: 0x15E66B0
	public void .ctor(AddressablesImpl aa) { }

	// RVA: 0x15E68C0 Offset: 0x15E69C1 VA: 0x15E68C0 Slot: 29
	protected override float get_Progress() { }

	// RVA: 0x15E6940 Offset: 0x15E6A41 VA: 0x15E6940 Slot: 30
	protected override string get_DebugName() { }

	// RVA: 0x15DC8E0 Offset: 0x15DC9E1 VA: 0x15DC8E0
	internal static AsyncOperationHandle<IResourceLocator> CreateInitializationOperation(AddressablesImpl aa, string playerSettingsLocation, string providerSuffix) { }

	// RVA: 0x15E6A40 Offset: 0x15E6B41 VA: 0x15E6A40 Slot: 27
	protected override void Execute() { }

	// RVA: 0x15E8870 Offset: 0x15E8971 VA: 0x15E8870
	private static void LoadProvider(AddressablesImpl addressables, ObjectInitializationData providerData, string providerSuffix) { }

	// RVA: 0x15E8ED0 Offset: 0x15E8FD1 VA: 0x15E8ED0
	private static AsyncOperationHandle<IResourceLocator> OnCatalogDataLoaded(AddressablesImpl addressables, AsyncOperationHandle<ContentCatalogData> op, string providerSuffix) { }

	// RVA: 0x15DD6E0 Offset: 0x15DD7E1 VA: 0x15DD6E0
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalog(AddressablesImpl addressables, IResourceLocation loc, string providerSuffix) { }

	// RVA: 0x15E9450 Offset: 0x15E9551 VA: 0x15E9450
	public AsyncOperationHandle<IResourceLocator> LoadContentCatalog(IResourceLocation loc, string providerSuffix) { }

	// RVA: 0x15E86C0 Offset: 0x15E87C1 VA: 0x15E86C0
	private void LoadContentCatalogInternal(IList<IResourceLocation> catalogs, int index, ResourceLocationMap locMap) { }
}

