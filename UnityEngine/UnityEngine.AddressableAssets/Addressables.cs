public static class Addressables // TypeDefIndex: 5670
{
	// Fields
	internal static bool reinitializeAddressables; // 0x0
	internal static AddressablesImpl m_AddressablesInstance; // 0x8
	public const string kAddressablesRuntimeDataPath = "AddressablesRuntimeDataPath";
	private const string k_AddressablesLogConditional = "ADDRESSABLES_LOG_ALL";
	public const string kAddressablesRuntimeBuildLogPath = "AddressablesRuntimeBuildLog";

	// Properties
	private static AddressablesImpl m_Addressables { get; }
	public static ResourceManager ResourceManager { get; }
	internal static AddressablesImpl Instance { get; }
	public static IInstanceProvider InstanceProvider { get; }
	public static Func<IResourceLocation, string> InternalIdTransformFunc { get; set; }
	public static string StreamingAssetsSubFolder { get; }
	public static string BuildPath { get; }
	public static string PlayerBuildDataPath { get; }
	public static string RuntimePath { get; }
	public static IEnumerable<IResourceLocator> ResourceLocators { get; }
	[ObsoleteAttribute] // RVA: 0x13EBA0 Offset: 0x13ECA1 VA: 0x13EBA0
	public static AsyncOperationHandle<IResourceLocator> InitializationOperation { get; }

	// Methods

	// RVA: 0x15CF690 Offset: 0x15CF791 VA: 0x15CF690
	private static AddressablesImpl get_m_Addressables() { }

	// RVA: 0x15CF700 Offset: 0x15CF801 VA: 0x15CF700
	public static ResourceManager get_ResourceManager() { }

	// RVA: 0x15CF940 Offset: 0x15CFA41 VA: 0x15CF940
	internal static AddressablesImpl get_Instance() { }

	// RVA: 0x15CFA10 Offset: 0x15CFB11 VA: 0x15CFA10
	public static IInstanceProvider get_InstanceProvider() { }

	// RVA: 0x15CFAF0 Offset: 0x15CFBF1 VA: 0x15CFAF0
	public static string ResolveInternalId(string id) { }

	// RVA: 0x15CFCE0 Offset: 0x15CFDE1 VA: 0x15CFCE0
	public static Func<IResourceLocation, string> get_InternalIdTransformFunc() { }

	// RVA: 0x15CFE70 Offset: 0x15CFF71 VA: 0x15CFE70
	public static void set_InternalIdTransformFunc(Func<IResourceLocation, string> value) { }

	// RVA: 0x15D0020 Offset: 0x15D0121 VA: 0x15D0020
	public static string get_StreamingAssetsSubFolder() { }

	// RVA: 0x15D0180 Offset: 0x15D0281 VA: 0x15D0180
	public static string get_BuildPath() { }

	// RVA: 0x15D04C0 Offset: 0x15D05C1 VA: 0x15D04C0
	public static string get_PlayerBuildDataPath() { }

	// RVA: 0x15D06A0 Offset: 0x15D07A1 VA: 0x15D06A0
	public static string get_RuntimePath() { }

	// RVA: 0x15D0880 Offset: 0x15D0981 VA: 0x15D0880
	public static IEnumerable<IResourceLocator> get_ResourceLocators() { }

	[ConditionalAttribute] // RVA: 0x13E590 Offset: 0x13E691 VA: 0x13E590
	// RVA: 0x15D0A70 Offset: 0x15D0B71 VA: 0x15D0A70
	internal static void InternalSafeSerializationLog(string msg, LogType logType = 3) { }

	[ConditionalAttribute] // RVA: 0x13E5D0 Offset: 0x13E6D1 VA: 0x13E5D0
	// RVA: 0x15D0DE0 Offset: 0x15D0EE1 VA: 0x15D0DE0
	internal static void InternalSafeSerializationLogFormat(string format, LogType logType = 3, object[] args) { }

	[ConditionalAttribute] // RVA: 0x13E610 Offset: 0x13E711 VA: 0x13E610
	// RVA: 0x15D1190 Offset: 0x15D1291 VA: 0x15D1190
	public static void Log(string msg) { }

	[ConditionalAttribute] // RVA: 0x13E650 Offset: 0x13E751 VA: 0x13E650
	// RVA: 0x15D12D0 Offset: 0x15D13D1 VA: 0x15D12D0
	public static void LogFormat(string format, object[] args) { }

	// RVA: 0x15D1410 Offset: 0x15D1511 VA: 0x15D1410
	public static void LogWarning(string msg) { }

	// RVA: 0x15D1550 Offset: 0x15D1651 VA: 0x15D1550
	public static void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x15D1690 Offset: 0x15D1791 VA: 0x15D1690
	public static void LogError(string msg) { }

	// RVA: 0x15D17D0 Offset: 0x15D18D1 VA: 0x15D17D0
	public static void LogException(AsyncOperationHandle op, Exception ex) { }

	// RVA: 0x15D1B50 Offset: 0x15D1C51 VA: 0x15D1B50
	public static void LogErrorFormat(string format, object[] args) { }

	[ObsoleteAttribute] // RVA: 0x13E690 Offset: 0x13E791 VA: 0x13E690
	// RVA: 0x15D1C90 Offset: 0x15D1D91 VA: 0x15D1C90
	public static AsyncOperationHandle<IResourceLocator> Initialize() { }

	// RVA: 0x15D1D10 Offset: 0x15D1E11 VA: 0x15D1D10
	public static AsyncOperationHandle<IResourceLocator> InitializeAsync() { }

	[ObsoleteAttribute] // RVA: 0x13E6A0 Offset: 0x13E7A1 VA: 0x13E6A0
	// RVA: 0x15D1F00 Offset: 0x15D2001 VA: 0x15D1F00
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalog(string catalogPath, string providerSuffix) { }

	// RVA: 0x15D1F80 Offset: 0x15D2081 VA: 0x15D1F80
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, string providerSuffix) { }

	// RVA: 0x15D23C0 Offset: 0x15D24C1 VA: 0x15D23C0
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle, string providerSuffix) { }

	// RVA: 0x15D24D0 Offset: 0x15D25D1 VA: 0x15D24D0
	public static AsyncOperationHandle<IResourceLocator> get_InitializationOperation() { }

	[ObsoleteAttribute] // RVA: 0x13E6B0 Offset: 0x13E7B1 VA: 0x13E6B0
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAsset<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FB840 Offset: 0x34FB941 VA: 0x34FB840
	|-Addressables.LoadAsset<object>
	*/

	[ObsoleteAttribute] // RVA: 0x13E6C0 Offset: 0x13E7C1 VA: 0x13E6C0
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAsset<TObject>(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FB7A0 Offset: 0x34FB8A1 VA: 0x34FB7A0
	|-Addressables.LoadAsset<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FBA10 Offset: 0x34FBB11 VA: 0x34FBA10
	|-Addressables.LoadAssetAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FB8E0 Offset: 0x34FB9E1 VA: 0x34FB8E0
	|-Addressables.LoadAssetAsync<AssetDataTable>
	|-Addressables.LoadAssetAsync<object>
	*/

	[ObsoleteAttribute] // RVA: 0x13E6D0 Offset: 0x13E7D1 VA: 0x13E6D0
	// RVA: 0x15D24E0 Offset: 0x15D25E1 VA: 0x15D24E0
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocations(IList<object> keys, Addressables.MergeMode mode, Type type) { }

	[ObsoleteAttribute] // RVA: 0x13E6E0 Offset: 0x13E7E1 VA: 0x13E6E0
	// RVA: 0x15D2570 Offset: 0x15D2671 VA: 0x15D2570
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IList<object> keys, Addressables.MergeMode mode, Type type) { }

	// RVA: 0x15D2970 Offset: 0x15D2A71 VA: 0x15D2970
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IEnumerable keys, Addressables.MergeMode mode, Type type) { }

	[ObsoleteAttribute] // RVA: 0x13E6F0 Offset: 0x13E7F1 VA: 0x13E6F0
	// RVA: 0x15D2A80 Offset: 0x15D2B81 VA: 0x15D2A80
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocations(object key, Type type) { }

	// RVA: 0x15D2B00 Offset: 0x15D2C01 VA: 0x15D2B00
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(object key, Type type) { }

	[ObsoleteAttribute] // RVA: 0x13E700 Offset: 0x13E801 VA: 0x13E700
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(IList<IResourceLocation> locations, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F9080 Offset: 0x34F9181 VA: 0x34F9080
	|-Addressables.LoadAssets<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F9480 Offset: 0x34F9581 VA: 0x34F9480
	|-Addressables.LoadAssetsAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F95C0 Offset: 0x34F96C1 VA: 0x34F95C0
	|-Addressables.LoadAssetsAsync<object>
	*/

	[ObsoleteAttribute] // RVA: 0x13E710 Offset: 0x13E811 VA: 0x13E710
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(IList<object> keys, Action<TObject> callback, Addressables.MergeMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F8FC0 Offset: 0x34F90C1 VA: 0x34F8FC0
	|-Addressables.LoadAssets<object>
	*/

	[ObsoleteAttribute] // RVA: 0x13E720 Offset: 0x13E821 VA: 0x13E720
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<object> keys, Action<TObject> callback, Addressables.MergeMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F91E0 Offset: 0x34F92E1 VA: 0x34F91E0
	|-Addressables.LoadAssetsAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F9700 Offset: 0x34F9801 VA: 0x34F9700
	|-Addressables.LoadAssetsAsync<object>
	*/

	[ObsoleteAttribute] // RVA: 0x13E730 Offset: 0x13E831 VA: 0x13E730
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<object> keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F9330 Offset: 0x34F9431 VA: 0x34F9330
	|-Addressables.LoadAssetsAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F9850 Offset: 0x34F9951 VA: 0x34F9850
	|-Addressables.LoadAssetsAsync<object>
	*/

	[ObsoleteAttribute] // RVA: 0x13E740 Offset: 0x13E841 VA: 0x13E740
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(object key, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F9130 Offset: 0x34F9231 VA: 0x34F9130
	|-Addressables.LoadAssets<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F99A0 Offset: 0x34F9AA1 VA: 0x34F99A0
	|-Addressables.LoadAssetsAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F9AE0 Offset: 0x34F9BE1 VA: 0x34F9AE0
	|-Addressables.LoadAssetsAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static void Release<TObject>(TObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E27D0 Offset: 0x23E28D1 VA: 0x23E27D0
	|-Addressables.Release<object>
	*/

	// RVA: -1 Offset: -1
	public static void Release<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E28D0 Offset: 0x23E29D1 VA: 0x23E28D0
	|-Addressables.Release<object>
	*/

	// RVA: 0x15D2EF0 Offset: 0x15D2FF1 VA: 0x15D2EF0
	public static void Release(AsyncOperationHandle handle) { }

	// RVA: 0x15D3070 Offset: 0x15D3171 VA: 0x15D3070
	public static bool ReleaseInstance(GameObject instance) { }

	// RVA: 0x15D32C0 Offset: 0x15D33C1 VA: 0x15D32C0
	public static bool ReleaseInstance(AsyncOperationHandle handle) { }

	// RVA: 0x15D33F0 Offset: 0x15D34F1 VA: 0x15D33F0
	public static bool ReleaseInstance(AsyncOperationHandle<GameObject> handle) { }

	[ObsoleteAttribute] // RVA: 0x13E750 Offset: 0x13E851 VA: 0x13E750
	// RVA: 0x15D3510 Offset: 0x15D3611 VA: 0x15D3510
	public static AsyncOperationHandle<long> GetDownloadSize(object key) { }

	// RVA: 0x15D3590 Offset: 0x15D3691 VA: 0x15D3590
	public static AsyncOperationHandle<long> GetDownloadSizeAsync(object key) { }

	// RVA: 0x15D3760 Offset: 0x15D3861 VA: 0x15D3760
	public static AsyncOperationHandle<long> GetDownloadSizeAsync(string key) { }

	[ObsoleteAttribute] // RVA: 0x13E760 Offset: 0x13E861 VA: 0x13E760
	// RVA: 0x15D3860 Offset: 0x15D3961 VA: 0x15D3860
	public static AsyncOperationHandle<long> GetDownloadSizeAsync(IList<object> keys) { }

	// RVA: 0x15D49E0 Offset: 0x15D4AE1 VA: 0x15D49E0
	public static AsyncOperationHandle<long> GetDownloadSizeAsync(IEnumerable keys) { }

	[ObsoleteAttribute] // RVA: 0x13E770 Offset: 0x13E871 VA: 0x13E770
	// RVA: 0x15D4AE0 Offset: 0x15D4BE1 VA: 0x15D4AE0
	public static AsyncOperationHandle DownloadDependencies(object key) { }

	// RVA: 0x15D4B60 Offset: 0x15D4C61 VA: 0x15D4B60
	public static AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle = False) { }

	// RVA: 0x15D50B0 Offset: 0x15D51B1 VA: 0x15D50B0
	public static AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle = False) { }

	[ObsoleteAttribute] // RVA: 0x13E780 Offset: 0x13E881 VA: 0x13E780
	// RVA: 0x15D53A0 Offset: 0x15D54A1 VA: 0x15D53A0
	public static AsyncOperationHandle DownloadDependenciesAsync(IList<object> keys, Addressables.MergeMode mode, bool autoReleaseHandle = False) { }

	// RVA: 0x15D5900 Offset: 0x15D5A01 VA: 0x15D5900
	public static AsyncOperationHandle DownloadDependenciesAsync(IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle = False) { }

	// RVA: 0x15D5A10 Offset: 0x15D5B11 VA: 0x15D5A10
	public static void ClearDependencyCacheAsync(object key) { }

	// RVA: 0x15D5E60 Offset: 0x15D5F61 VA: 0x15D5E60
	public static void ClearDependencyCacheAsync(IList<IResourceLocation> locations) { }

	[ObsoleteAttribute] // RVA: 0x13E790 Offset: 0x13E891 VA: 0x13E790
	// RVA: 0x15D64C0 Offset: 0x15D65C1 VA: 0x15D64C0
	public static void ClearDependencyCacheAsync(IList<object> keys) { }

	// RVA: 0x15D6B20 Offset: 0x15D6C21 VA: 0x15D6B20
	public static void ClearDependencyCacheAsync(IEnumerable keys) { }

	// RVA: 0x15D6C20 Offset: 0x15D6D21 VA: 0x15D6C20
	public static void ClearDependencyCacheAsync(string key) { }

	// RVA: 0x15D6D20 Offset: 0x15D6E21 VA: 0x15D6D20
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(object key, bool autoReleaseHandle) { }

	// RVA: 0x15D6E30 Offset: 0x15D6F31 VA: 0x15D6E30
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<IResourceLocation> locations, bool autoReleaseHandle) { }

	[ObsoleteAttribute] // RVA: 0x13E7A0 Offset: 0x13E8A1 VA: 0x13E7A0
	// RVA: 0x15D6F40 Offset: 0x15D7041 VA: 0x15D6F40
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<object> keys, bool autoReleaseHandle) { }

	// RVA: 0x15D7050 Offset: 0x15D7151 VA: 0x15D7050
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IEnumerable keys, bool autoReleaseHandle) { }

	// RVA: 0x15D7160 Offset: 0x15D7261 VA: 0x15D7160
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(string key, bool autoReleaseHandle) { }

	[ObsoleteAttribute] // RVA: 0x13E7B0 Offset: 0x13E8B1 VA: 0x13E7B0
	// RVA: 0x15D7270 Offset: 0x15D7371 VA: 0x15D7270
	public static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	[ObsoleteAttribute] // RVA: 0x13E7C0 Offset: 0x13E8C1 VA: 0x13E7C0
	// RVA: 0x15D7490 Offset: 0x15D7591 VA: 0x15D7490
	public static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	[ObsoleteAttribute] // RVA: 0x13E7D0 Offset: 0x13E8D1 VA: 0x13E7D0
	// RVA: 0x15D7730 Offset: 0x15D7831 VA: 0x15D7730
	public static AsyncOperationHandle<GameObject> Instantiate(object key, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	[ObsoleteAttribute] // RVA: 0x13E7E0 Offset: 0x13E8E1 VA: 0x13E7E0
	// RVA: 0x15D7930 Offset: 0x15D7A31 VA: 0x15D7930
	public static AsyncOperationHandle<GameObject> Instantiate(object key, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	[ObsoleteAttribute] // RVA: 0x13E7F0 Offset: 0x13E8F1 VA: 0x13E7F0
	// RVA: 0x15D7BD0 Offset: 0x15D7CD1 VA: 0x15D7BD0
	public static AsyncOperationHandle<GameObject> Instantiate(object key, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	[ObsoleteAttribute] // RVA: 0x13E800 Offset: 0x13E901 VA: 0x13E800
	// RVA: 0x15D7DE0 Offset: 0x15D7EE1 VA: 0x15D7DE0
	public static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x15D7EB0 Offset: 0x15D7FB1 VA: 0x15D7EB0
	public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x15D7580 Offset: 0x15D7681 VA: 0x15D7580
	public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x15D77D0 Offset: 0x15D78D1 VA: 0x15D77D0
	public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x15D7A20 Offset: 0x15D7B21 VA: 0x15D7A20
	public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x15D7CA0 Offset: 0x15D7DA1 VA: 0x15D7CA0
	public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x15D7350 Offset: 0x15D7451 VA: 0x15D7350
	public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	[ObsoleteAttribute] // RVA: 0x13E810 Offset: 0x13E911 VA: 0x13E810
	// RVA: 0x15D8A40 Offset: 0x15D8B41 VA: 0x15D8A40
	public static AsyncOperationHandle<SceneInstance> LoadScene(object key, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	[ObsoleteAttribute] // RVA: 0x13E820 Offset: 0x13E921 VA: 0x13E820
	// RVA: 0x15D8C00 Offset: 0x15D8D01 VA: 0x15D8C00
	public static AsyncOperationHandle<SceneInstance> LoadScene(IResourceLocation location, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x15D8AE0 Offset: 0x15D8BE1 VA: 0x15D8AE0
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x15D8CA0 Offset: 0x15D8DA1 VA: 0x15D8CA0
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	[ObsoleteAttribute] // RVA: 0x13E830 Offset: 0x13E931 VA: 0x13E830
	// RVA: 0x15D9370 Offset: 0x15D9471 VA: 0x15D9370
	public static AsyncOperationHandle<SceneInstance> UnloadScene(SceneInstance scene, bool autoReleaseHandle = True) { }

	[ObsoleteAttribute] // RVA: 0x13E840 Offset: 0x13E941 VA: 0x13E840
	// RVA: 0x15D9510 Offset: 0x15D9611 VA: 0x15D9510
	public static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle handle, bool autoReleaseHandle = True) { }

	[ObsoleteAttribute] // RVA: 0x13E850 Offset: 0x13E951 VA: 0x13E850
	// RVA: 0x15D96F0 Offset: 0x15D97F1 VA: 0x15D96F0
	public static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = True) { }

	// RVA: 0x15D9400 Offset: 0x15D9501 VA: 0x15D9400
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, bool autoReleaseHandle = True) { }

	// RVA: 0x15D95C0 Offset: 0x15D96C1 VA: 0x15D95C0
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, bool autoReleaseHandle = True) { }

	// RVA: 0x15D97A0 Offset: 0x15D98A1 VA: 0x15D97A0
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = True) { }

	// RVA: 0x15D9E50 Offset: 0x15D9F51 VA: 0x15D9E50
	public static AsyncOperationHandle<List<string>> CheckForCatalogUpdates(bool autoReleaseHandle = True) { }

	// RVA: 0x15DA0F0 Offset: 0x15DA1F1 VA: 0x15DA0F0
	public static AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(IEnumerable<string> catalogs, bool autoReleaseHandle = True) { }

	// RVA: 0x15DA470 Offset: 0x15DA571 VA: 0x15DA470
	public static void AddResourceLocator(IResourceLocator locator, string localCatalogHash, IResourceLocation remoteCatalogLocation) { }

	// RVA: 0x15DA650 Offset: 0x15DA751 VA: 0x15DA650
	public static void RemoveResourceLocator(IResourceLocator locator) { }

	// RVA: 0x15DA810 Offset: 0x15DA911 VA: 0x15DA810
	public static void ClearResourceLocators() { }

	// RVA: 0x15DA990 Offset: 0x15DAA91 VA: 0x15DA990
	private static void .cctor() { }
}

