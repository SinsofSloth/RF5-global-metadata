internal class AddressablesImpl : IEqualityComparer<IResourceLocation> // TypeDefIndex: 5672
{
	// Fields
	private ResourceManager m_ResourceManager; // 0x10
	private IInstanceProvider m_InstanceProvider; // 0x18
	internal const string kCacheDataFolder = "{UnityEngine.Application.persistentDataPath}/com.unity.addressables/";
	public ISceneProvider SceneProvider; // 0x20
	internal List<AddressablesImpl.ResourceLocatorInfo> m_ResourceLocators; // 0x28
	private AsyncOperationHandle<IResourceLocator> m_InitializationOperation; // 0x30
	private AsyncOperationHandle<List<string>> m_ActiveCheckUpdateOperation; // 0x48
	private AsyncOperationHandle<List<IResourceLocator>> m_ActiveUpdateOperation; // 0x60
	private Action<AsyncOperationHandle> m_OnHandleCompleteAction; // 0x78
	private Action<AsyncOperationHandle> m_OnSceneHandleCompleteAction; // 0x80
	private Action<AsyncOperationHandle> m_OnHandleDestroyedAction; // 0x88
	private Dictionary<object, AsyncOperationHandle> m_resultToHandle; // 0x90
	internal HashSet<AsyncOperationHandle> m_SceneInstances; // 0x98
	internal bool hasStartedInitialization; // 0xA0

	// Properties
	public IInstanceProvider InstanceProvider { get; set; }
	public ResourceManager ResourceManager { get; }
	internal int SceneOperationCount { get; }
	internal int TrackedHandleCount { get; }
	public Func<IResourceLocation, string> InternalIdTransformFunc { get; set; }
	public AsyncOperationHandle ChainOperation { get; }
	internal bool ShouldChainRequest { get; }
	public string StreamingAssetsSubFolder { get; }
	public string BuildPath { get; }
	public string PlayerBuildDataPath { get; }
	public string RuntimePath { get; }
	public IEnumerable<IResourceLocator> ResourceLocators { get; }
	internal IEnumerable<string> CatalogsWithAvailableUpdates { get; }

	// Methods

	// RVA: 0x15DABD0 Offset: 0x15DACD1 VA: 0x15DABD0
	public IInstanceProvider get_InstanceProvider() { }

	// RVA: 0x15DABE0 Offset: 0x15DACE1 VA: 0x15DABE0
	public void set_InstanceProvider(IInstanceProvider value) { }

	// RVA: 0x15CF880 Offset: 0x15CF981 VA: 0x15CF880
	public ResourceManager get_ResourceManager() { }

	// RVA: 0x15DAC80 Offset: 0x15DAD81 VA: 0x15DAC80
	internal int get_SceneOperationCount() { }

	// RVA: 0x15DACD0 Offset: 0x15DADD1 VA: 0x15DACD0
	internal int get_TrackedHandleCount() { }

	// RVA: 0x15DAA50 Offset: 0x15DAB51 VA: 0x15DAA50
	public void .ctor(IAllocationStrategy alloc) { }

	// RVA: 0x15DAD30 Offset: 0x15DAE31 VA: 0x15DAD30
	internal void ReleaseSceneManagerOperation() { }

	// RVA: 0x15CFDC0 Offset: 0x15CFEC1 VA: 0x15CFDC0
	public Func<IResourceLocation, string> get_InternalIdTransformFunc() { }

	// RVA: 0x15CFF60 Offset: 0x15D0061 VA: 0x15CFF60
	public void set_InternalIdTransformFunc(Func<IResourceLocation, string> value) { }

	// RVA: 0x15DADD0 Offset: 0x15DAED1 VA: 0x15DADD0
	public AsyncOperationHandle get_ChainOperation() { }

	// RVA: 0x15DAF40 Offset: 0x15DB041 VA: 0x15DAF40
	internal bool get_ShouldChainRequest() { }

	// RVA: 0x15DB030 Offset: 0x15DB131 VA: 0x15DB030
	internal void OnSceneUnloaded(Scene scene) { }

	// RVA: 0x15D0130 Offset: 0x15D0231 VA: 0x15D0130
	public string get_StreamingAssetsSubFolder() { }

	// RVA: 0x15D0260 Offset: 0x15D0361 VA: 0x15D0260
	public string get_BuildPath() { }

	// RVA: 0x15D0610 Offset: 0x15D0711 VA: 0x15D0610
	public string get_PlayerBuildDataPath() { }

	// RVA: 0x15D07F0 Offset: 0x15D08F1 VA: 0x15D07F0
	public string get_RuntimePath() { }

	// RVA: 0x15D0D70 Offset: 0x15D0E71 VA: 0x15D0D70
	public void Log(string msg) { }

	// RVA: 0x15D1110 Offset: 0x15D1211 VA: 0x15D1110
	public void LogFormat(string format, object[] args) { }

	// RVA: 0x15D0C90 Offset: 0x15D0D91 VA: 0x15D0C90
	public void LogWarning(string msg) { }

	// RVA: 0x15D1010 Offset: 0x15D1111 VA: 0x15D1010
	public void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x15D0D00 Offset: 0x15D0E01 VA: 0x15D0D00
	public void LogError(string msg) { }

	// RVA: 0x15D18F0 Offset: 0x15D19F1 VA: 0x15D18F0
	public void LogException(AsyncOperationHandle op, Exception ex) { }

	// RVA: 0x15D1090 Offset: 0x15D1191 VA: 0x15D1090
	public void LogErrorFormat(string format, object[] args) { }

	// RVA: 0x15CFBE0 Offset: 0x15CFCE1 VA: 0x15CFBE0
	public string ResolveInternalId(string id) { }

	// RVA: 0x15D0960 Offset: 0x15D0A61 VA: 0x15D0960
	public IEnumerable<IResourceLocator> get_ResourceLocators() { }

	// RVA: 0x15DA580 Offset: 0x15DA681 VA: 0x15DA580
	public void AddResourceLocator(IResourceLocator loc, string localCatalogHash, IResourceLocation remoteCatalogLocation) { }

	// RVA: 0x15DA740 Offset: 0x15DA841 VA: 0x15DA740
	public void RemoveResourceLocator(IResourceLocator loc) { }

	// RVA: 0x15DA930 Offset: 0x15DAA31 VA: 0x15DA930
	public void ClearResourceLocators() { }

	// RVA: 0x15DB5C0 Offset: 0x15DB6C1 VA: 0x15DB5C0
	internal bool GetResourceLocations(object key, Type type, out IList<IResourceLocation> locations) { }

	// RVA: 0x15DBDC0 Offset: 0x15DBEC1 VA: 0x15DBDC0
	internal bool GetResourceLocations(IEnumerable keys, Type type, Addressables.MergeMode merge, out IList<IResourceLocation> locations) { }

	// RVA: 0x15DC3A0 Offset: 0x15DC4A1 VA: 0x15DC3A0
	public AsyncOperationHandle<IResourceLocator> InitializeAsync(string runtimeDataPath, string providerSuffix, bool autoReleaseHandle = True) { }

	// RVA: 0x15D1E00 Offset: 0x15D1F01 VA: 0x15D1E00
	public AsyncOperationHandle<IResourceLocator> InitializeAsync() { }

	// RVA: 0x15DD1E0 Offset: 0x15DD2E1 VA: 0x15DD1E0
	internal ResourceLocationBase CreateCatalogLocationWithHashDependencies(string catalogPath, string hashFilePath) { }

	// RVA: 0x15D2090 Offset: 0x15D2191 VA: 0x15D2090
	public AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle = True, string providerSuffix) { }

	// RVA: 0x15DDF90 Offset: 0x15DE091 VA: 0x15DDF90
	private AsyncOperationHandle<SceneInstance> TrackHandle(AsyncOperationHandle<SceneInstance> handle) { }

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<TObject> TrackHandle<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FC7A0 Offset: 0x34FC8A1 VA: 0x34FC7A0
	|-AddressablesImpl.TrackHandle<IList<IResourceLocation>>
	|-AddressablesImpl.TrackHandle<object>
	|
	|-RVA: 0x34FC750 Offset: 0x34FC851 VA: 0x34FC750
	|-AddressablesImpl.TrackHandle<long>
	*/

	// RVA: 0x15DE040 Offset: 0x15DE141 VA: 0x15DE040
	private AsyncOperationHandle TrackHandle(AsyncOperationHandle handle) { }

	// RVA: 0x15DE080 Offset: 0x15DE181 VA: 0x15DE080
	internal void ClearTrackHandles() { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FC550 Offset: 0x34FC651 VA: 0x34FC550
	|-AddressablesImpl.LoadAssetAsync<object>
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<TObject> LoadAssetWithChain<TObject>(AsyncOperationHandle dep, object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FC600 Offset: 0x34FC701 VA: 0x34FC600
	|-AddressablesImpl.LoadAssetWithChain<object>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FBB40 Offset: 0x34FBC41 VA: 0x34FBB40
	|-AddressablesImpl.LoadAssetAsync<object>
	*/

	// RVA: 0x15DE0E0 Offset: 0x15DE1E1 VA: 0x15DE0E0
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithChain(AsyncOperationHandle dep, IEnumerable keys, Addressables.MergeMode mode, Type type) { }

	// RVA: 0x15D2680 Offset: 0x15D2781 VA: 0x15D2680
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IEnumerable keys, Addressables.MergeMode mode, Type type) { }

	// RVA: 0x15DE360 Offset: 0x15DE461 VA: 0x15DE360
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithChain(AsyncOperationHandle dep, object key, Type type) { }

	// RVA: 0x15D2C10 Offset: 0x15D2D11 VA: 0x15D2C10
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(object key, Type type) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F9C20 Offset: 0x34F9D21 VA: 0x34F9C20
	|-AddressablesImpl.LoadAssetsAsync<object>
	|-AddressablesImpl.LoadAssetsAsync<IAssetBundleResource>
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<IList<TObject>> LoadAssetsWithChain<TObject>(AsyncOperationHandle dep, IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FA180 Offset: 0x34FA281 VA: 0x34FA180
	|-AddressablesImpl.LoadAssetsWithChain<object>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F9CE0 Offset: 0x34F9DE1 VA: 0x34F9CE0
	|-AddressablesImpl.LoadAssetsAsync<object>
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<IList<TObject>> LoadAssetsWithChain<TObject>(AsyncOperationHandle dep, object key, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FA310 Offset: 0x34FA411 VA: 0x34FA310
	|-AddressablesImpl.LoadAssetsWithChain<object>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F9F40 Offset: 0x34FA041 VA: 0x34F9F40
	|-AddressablesImpl.LoadAssetsAsync<object>
	*/

	// RVA: 0x15DE5D0 Offset: 0x15DE6D1 VA: 0x15DE5D0
	private void OnHandleDestroyed(AsyncOperationHandle handle) { }

	// RVA: 0x15DE670 Offset: 0x15DE771 VA: 0x15DE670
	private void OnSceneHandleCompleted(AsyncOperationHandle handle) { }

	// RVA: 0x15DE7B0 Offset: 0x15DE8B1 VA: 0x15DE7B0
	private void OnHandleCompleted(AsyncOperationHandle handle) { }

	// RVA: -1 Offset: -1
	public void Release<TObject>(TObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E2A80 Offset: 0x23E2B81 VA: 0x23E2A80
	|-AddressablesImpl.Release<object>
	*/

	// RVA: -1 Offset: -1
	public void Release<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E29F0 Offset: 0x23E2AF1 VA: 0x23E29F0
	|-AddressablesImpl.Release<bool>
	|
	|-RVA: 0x23E2B70 Offset: 0x23E2C71 VA: 0x23E2B70
	|-AddressablesImpl.Release<IList<AsyncOperationHandle>>
	|-AddressablesImpl.Release<IList<IAssetBundleResource>>
	|-AddressablesImpl.Release<List<string>>
	|-AddressablesImpl.Release<object>
	|-AddressablesImpl.Release<ResourceManagerRuntimeData>
	|-AddressablesImpl.Release<ContentCatalogData>
	|-AddressablesImpl.Release<IResourceLocator>
	|-AddressablesImpl.Release<GameObject>
	|
	|-RVA: 0x23E2C00 Offset: 0x23E2D01 VA: 0x23E2C00
	|-AddressablesImpl.Release<SceneInstance>
	*/

	// RVA: 0x15D3020 Offset: 0x15D3121 VA: 0x15D3020
	public void Release(AsyncOperationHandle handle) { }

	// RVA: 0x15DE8B0 Offset: 0x15DE9B1 VA: 0x15DE8B0
	private AsyncOperationHandle<long> GetDownloadSizeWithChain(AsyncOperationHandle dep, object key) { }

	// RVA: 0x15DEA60 Offset: 0x15DEB61 VA: 0x15DEA60
	private AsyncOperationHandle<long> GetDownloadSizeWithChain(AsyncOperationHandle dep, IEnumerable keys) { }

	// RVA: 0x15D3690 Offset: 0x15D3791 VA: 0x15D3690
	public AsyncOperationHandle<long> GetDownloadSizeAsync(object key) { }

	// RVA: 0x15D3960 Offset: 0x15D3A61 VA: 0x15D3960
	public AsyncOperationHandle<long> GetDownloadSizeAsync(IEnumerable keys) { }

	// RVA: 0x15DECB0 Offset: 0x15DEDB1 VA: 0x15DECB0
	private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, object key, bool autoReleaseHandle) { }

	// RVA: 0x15DEEF0 Offset: 0x15DEFF1 VA: 0x15DEEF0
	private static List<IResourceLocation> GatherDependenciesFromLocations(IList<IResourceLocation> locations) { }

	// RVA: 0x15D4C70 Offset: 0x15D4D71 VA: 0x15D4C70
	public AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle = False) { }

	// RVA: 0x15DF7A0 Offset: 0x15DF8A1 VA: 0x15DF7A0
	private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, IList<IResourceLocation> locations, bool autoReleaseHandle) { }

	// RVA: 0x15D51C0 Offset: 0x15D52C1 VA: 0x15D51C0
	public AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle = False) { }

	// RVA: 0x15DF9E0 Offset: 0x15DFAE1 VA: 0x15DF9E0
	private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle) { }

	// RVA: 0x15D54B0 Offset: 0x15D55B1 VA: 0x15D54B0
	public AsyncOperationHandle DownloadDependenciesAsync(IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle = False) { }

	// RVA: 0x15DFC30 Offset: 0x15DFD31 VA: 0x15DFC30
	internal bool ClearDependencyCacheForKey(object key) { }

	// RVA: 0x15D5B10 Offset: 0x15D5C11 VA: 0x15D5B10
	public AsyncOperationHandle<bool> ClearDependencyCacheAsync(object key, bool autoReleaseHandle) { }

	// RVA: 0x15D5F60 Offset: 0x15D6061 VA: 0x15D5F60
	public AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<IResourceLocation> locations, bool autoReleaseHandle) { }

	// RVA: 0x15D65C0 Offset: 0x15D66C1 VA: 0x15D65C0
	public AsyncOperationHandle<bool> ClearDependencyCacheAsync(IEnumerable keys, bool autoReleaseHandle) { }

	// RVA: 0x15DFC70 Offset: 0x15DFD71 VA: 0x15DFC70
	public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x15D8290 Offset: 0x15D8391 VA: 0x15D8290
	public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x15D8320 Offset: 0x15D8421 VA: 0x15D8320
	public AsyncOperationHandle<GameObject> InstantiateAsync(object key, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x15D83B0 Offset: 0x15D84B1 VA: 0x15D83B0
	public AsyncOperationHandle<GameObject> InstantiateAsync(object key, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x15DFD00 Offset: 0x15DFE01 VA: 0x15DFD00
	private AsyncOperationHandle<GameObject> InstantiateWithChain(AsyncOperationHandle dep, object key, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x15D8440 Offset: 0x15D8541 VA: 0x15D8440
	public AsyncOperationHandle<GameObject> InstantiateAsync(object key, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x15DFF20 Offset: 0x15E0021 VA: 0x15DFF20
	private AsyncOperationHandle<GameObject> InstantiateWithChain(AsyncOperationHandle dep, IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x15D8010 Offset: 0x15D8111 VA: 0x15D8010
	public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x15D3160 Offset: 0x15D3261 VA: 0x15D3160
	public bool ReleaseInstance(GameObject instance) { }

	// RVA: 0x15E0140 Offset: 0x15E0241 VA: 0x15E0140
	internal AsyncOperationHandle<SceneInstance> LoadSceneWithChain(AsyncOperationHandle dep, object key, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x15D8DC0 Offset: 0x15D8EC1 VA: 0x15D8DC0
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100, bool trackHandle = True) { }

	// RVA: 0x15D91B0 Offset: 0x15D92B1 VA: 0x15D91B0
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100, bool trackHandle = True) { }

	// RVA: 0x15D9920 Offset: 0x15D9A21 VA: 0x15D9920
	public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, bool autoReleaseHandle = True) { }

	// RVA: 0x15D9BD0 Offset: 0x15D9CD1 VA: 0x15D9BD0
	public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, bool autoReleaseHandle = True) { }

	// RVA: 0x15D9D80 Offset: 0x15D9E81 VA: 0x15D9D80
	public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = True) { }

	// RVA: 0x15E03B0 Offset: 0x15E04B1 VA: 0x15E03B0
	internal AsyncOperationHandle<SceneInstance> CreateUnloadSceneWithChain(AsyncOperationHandle handle, bool autoReleaseHandle) { }

	// RVA: 0x15E04D0 Offset: 0x15E05D1 VA: 0x15E04D0
	internal AsyncOperationHandle<SceneInstance> CreateUnloadSceneWithChain(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle) { }

	// RVA: 0x15E05F0 Offset: 0x15E06F1 VA: 0x15E05F0
	internal AsyncOperationHandle<SceneInstance> InternalUnloadScene(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle) { }

	// RVA: 0x15DBCD0 Offset: 0x15DBDD1 VA: 0x15DBCD0
	private object EvaluateKey(object obj) { }

	// RVA: 0x15D9F50 Offset: 0x15DA051 VA: 0x15D9F50
	internal AsyncOperationHandle<List<string>> CheckForCatalogUpdates(bool autoReleaseHandle = True) { }

	// RVA: 0x15E0E40 Offset: 0x15E0F41 VA: 0x15E0E40
	internal AddressablesImpl.ResourceLocatorInfo GetLocatorInfo(string c) { }

	// RVA: 0x15E1000 Offset: 0x15E1101 VA: 0x15E1000
	internal IEnumerable<string> get_CatalogsWithAvailableUpdates() { }

	// RVA: 0x15DA200 Offset: 0x15DA301 VA: 0x15DA200
	internal AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(IEnumerable<string> catalogIds, bool autoReleaseHandle = True) { }

	// RVA: 0x15E1A40 Offset: 0x15E1B41 VA: 0x15E1A40 Slot: 4
	public bool Equals(IResourceLocation x, IResourceLocation y) { }

	// RVA: 0x15E1DA0 Offset: 0x15E1EA1 VA: 0x15E1DA0 Slot: 5
	public int GetHashCode(IResourceLocation loc) { }

	[CompilerGeneratedAttribute] // RVA: 0x13E860 Offset: 0x13E961 VA: 0x13E860
	// RVA: 0x15E1F10 Offset: 0x15E2011 VA: 0x15E1F10
	private void <InitializeAsync>b__57_0(AsyncOperationHandle<IResourceLocator> x) { }

	[CompilerGeneratedAttribute] // RVA: 0x13E870 Offset: 0x13E971 VA: 0x13E870
	// RVA: 0x15E2060 Offset: 0x15E2161 VA: 0x15E2060
	private void <TrackHandle>b__61_0(AsyncOperationHandle<SceneInstance> sceneHandle) { }

	[CompilerGeneratedAttribute] // RVA: 0x13E880 Offset: 0x13E981 VA: 0x13E880
	// RVA: 0x15E2120 Offset: 0x15E2221 VA: 0x15E2120
	private void <DownloadDependenciesAsync>b__91_0(AsyncOperationHandle<IList<IAssetBundleResource>> op) { }

	[CompilerGeneratedAttribute] // RVA: 0x13E890 Offset: 0x13E991 VA: 0x13E890
	// RVA: 0x15E21B0 Offset: 0x15E22B1 VA: 0x15E21B0
	private void <DownloadDependenciesAsync>b__91_1(AsyncOperationHandle<IList<IAssetBundleResource>> op) { }

	[CompilerGeneratedAttribute] // RVA: 0x13E8A0 Offset: 0x13E9A1 VA: 0x13E8A0
	// RVA: 0x15E2240 Offset: 0x15E2341 VA: 0x15E2240
	private void <DownloadDependenciesAsync>b__93_0(AsyncOperationHandle<IList<IAssetBundleResource>> op) { }

	[CompilerGeneratedAttribute] // RVA: 0x13E8B0 Offset: 0x13E9B1 VA: 0x13E8B0
	// RVA: 0x15E22D0 Offset: 0x15E23D1 VA: 0x15E22D0
	private void <DownloadDependenciesAsync>b__95_0(AsyncOperationHandle<IList<IAssetBundleResource>> op) { }

	[CompilerGeneratedAttribute] // RVA: 0x13E8C0 Offset: 0x13E9C1 VA: 0x13E8C0
	// RVA: 0x15E2360 Offset: 0x15E2461 VA: 0x15E2360
	private void <DownloadDependenciesAsync>b__95_1(AsyncOperationHandle<IList<IAssetBundleResource>> op) { }

	[CompilerGeneratedAttribute] // RVA: 0x13E8D0 Offset: 0x13E9D1 VA: 0x13E8D0
	// RVA: 0x15E23F0 Offset: 0x15E24F1 VA: 0x15E23F0
	private void <InternalUnloadScene>b__117_0(AsyncOperationHandle<SceneInstance> op) { }

	[CompilerGeneratedAttribute] // RVA: 0x13E8E0 Offset: 0x13E9E1 VA: 0x13E8E0
	// RVA: 0x15E2480 Offset: 0x15E2581 VA: 0x15E2480
	private void <CheckForCatalogUpdates>b__119_0(AsyncOperationHandle o) { }
}

