public struct ProvideHandle // TypeDefIndex: 4486
{
	// Fields
	private int m_Version; // 0x0
	private IGenericProviderOperation m_InternalOp; // 0x8
	private ResourceManager m_ResourceManager; // 0x10

	// Properties
	private IGenericProviderOperation InternalOp { get; }
	public ResourceManager ResourceManager { get; }
	public Type Type { get; }
	public IResourceLocation Location { get; }
	public int DependencyCount { get; }

	// Methods

	// RVA: 0x162D0 Offset: 0x163D1 VA: 0x162D0
	internal void .ctor(ResourceManager rm, IGenericProviderOperation op) { }

	// RVA: 0x162E0 Offset: 0x163E1 VA: 0x162E0
	private IGenericProviderOperation get_InternalOp() { }

	// RVA: 0x162F0 Offset: 0x163F1 VA: 0x162F0
	public ResourceManager get_ResourceManager() { }

	// RVA: 0x16300 Offset: 0x16401 VA: 0x16300
	public Type get_Type() { }

	// RVA: 0x16310 Offset: 0x16411 VA: 0x16310
	public IResourceLocation get_Location() { }

	// RVA: 0x16320 Offset: 0x16421 VA: 0x16320
	public int get_DependencyCount() { }

	// RVA: -1 Offset: -1
	public TDepObject GetDependency<TDepObject>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F1E60 Offset: 0x2F1F61 VA: 0x2F1E60
	|-ProvideHandle.GetDependency<object>
	|-ProvideHandle.GetDependency<SpriteAtlas>
	*/

	// RVA: 0x16330 Offset: 0x16431 VA: 0x16330
	public void GetDependencies(IList<object> list) { }

	// RVA: 0x16340 Offset: 0x16441 VA: 0x16340
	public void SetProgressCallback(Func<float> callback) { }

	// RVA: 0x16350 Offset: 0x16451 VA: 0x16350
	public void SetDownloadProgressCallbacks(Func<DownloadStatus> callback) { }

	// RVA: -1 Offset: -1
	public void Complete<T>(T result, bool status, Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302970 Offset: 0x302A71 VA: 0x302970
	|-ProvideHandle.Complete<object>
	|-ProvideHandle.Complete<ContentCatalogData>
	|-ProvideHandle.Complete<AssetBundle>
	|-ProvideHandle.Complete<AssetBundleResource>
	|-ProvideHandle.Complete<Sprite>
	*/
}

