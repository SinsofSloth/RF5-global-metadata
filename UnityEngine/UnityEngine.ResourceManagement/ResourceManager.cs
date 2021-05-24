public class ResourceManager : IDisposable // TypeDefIndex: 4451
{
	// Fields
	internal bool postProfilerEvents; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x129B90 Offset: 0x129C91 VA: 0x129B90
	private static Action<AsyncOperationHandle, Exception> <ExceptionHandler>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x129BA0 Offset: 0x129CA1 VA: 0x129BA0
	private Func<IResourceLocation, string> <InternalIdTransformFunc>k__BackingField; // 0x18
	internal bool CallbackHooksEnabled; // 0x20
	private ListWithEvents<IResourceProvider> m_ResourceProviders; // 0x28
	private IAllocationStrategy m_allocator; // 0x30
	private ListWithEvents<IUpdateReceiver> m_UpdateReceivers; // 0x38
	private List<IUpdateReceiver> m_UpdateReceiversToRemove; // 0x40
	private bool m_UpdatingReceivers; // 0x48
	private Dictionary<int, IResourceProvider> m_providerMap; // 0x50
	private Dictionary<int, IAsyncOperation> m_AssetOperationCache; // 0x58
	private HashSet<ResourceManager.InstanceOperation> m_TrackedInstanceOperations; // 0x60
	private DelegateList<float> m_UpdateCallbacks; // 0x68
	private List<IAsyncOperation> m_DeferredCompleteCallbacks; // 0x70
	private Action<AsyncOperationHandle, ResourceManager.DiagnosticEventType, int, object> m_obsoleteDiagnosticsHandler; // 0x78
	private Action<ResourceManager.DiagnosticEventContext> m_diagnosticsHandler; // 0x80
	private Action<IAsyncOperation> m_ReleaseOpNonCached; // 0x88
	private Action<IAsyncOperation> m_ReleaseOpCached; // 0x90
	private Action<IAsyncOperation> m_ReleaseInstanceOp; // 0x98
	private static int s_GroupOperationTypeHash; // 0x8
	private static int s_InstanceOperationTypeHash; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0x129BB0 Offset: 0x129CB1 VA: 0x129BB0
	private CertificateHandler <CertificateHandlerInstance>k__BackingField; // 0xA0
	private bool m_RegisteredForCallbacks; // 0xA8
	private Dictionary<Type, Type> m_ProviderOperationTypeCache; // 0xB0

	// Properties
	public static Action<AsyncOperationHandle, Exception> ExceptionHandler { get; set; }
	public Func<IResourceLocation, string> InternalIdTransformFunc { get; set; }
	internal int OperationCacheCount { get; }
	internal int InstanceOperationCount { get; }
	public IAllocationStrategy Allocator { get; set; }
	public IList<IResourceProvider> ResourceProviders { get; }
	public CertificateHandler CertificateHandlerInstance { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x12A0F0 Offset: 0x12A1F1 VA: 0x12A0F0
	// RVA: 0x19D8B30 Offset: 0x19D8C31 VA: 0x19D8B30
	public static Action<AsyncOperationHandle, Exception> get_ExceptionHandler() { }

	[CompilerGeneratedAttribute] // RVA: 0x12A100 Offset: 0x12A201 VA: 0x12A100
	// RVA: 0x19D8BA0 Offset: 0x19D8CA1 VA: 0x19D8BA0
	public static void set_ExceptionHandler(Action<AsyncOperationHandle, Exception> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x12A110 Offset: 0x12A211 VA: 0x12A110
	// RVA: 0x19D8C10 Offset: 0x19D8D11 VA: 0x19D8C10
	public Func<IResourceLocation, string> get_InternalIdTransformFunc() { }

	[CompilerGeneratedAttribute] // RVA: 0x12A120 Offset: 0x12A221 VA: 0x12A120
	// RVA: 0x19D8C20 Offset: 0x19D8D21 VA: 0x19D8C20
	public void set_InternalIdTransformFunc(Func<IResourceLocation, string> value) { }

	// RVA: 0x19D8C30 Offset: 0x19D8D31 VA: 0x19D8C30
	public string TransformInternalId(IResourceLocation location) { }

	// RVA: 0x19D8D10 Offset: 0x19D8E11 VA: 0x19D8D10
	internal int get_OperationCacheCount() { }

	// RVA: 0x19D8D70 Offset: 0x19D8E71 VA: 0x19D8D70
	internal int get_InstanceOperationCount() { }

	// RVA: 0x19D8DC0 Offset: 0x19D8EC1 VA: 0x19D8DC0
	public void AddUpdateReceiver(IUpdateReceiver receiver) { }

	// RVA: 0x19D8E40 Offset: 0x19D8F41 VA: 0x19D8E40
	public void RemoveUpdateReciever(IUpdateReceiver receiver) { }

	// RVA: 0x19D8F30 Offset: 0x19D9031 VA: 0x19D8F30
	public IAllocationStrategy get_Allocator() { }

	// RVA: 0x19D8F40 Offset: 0x19D9041 VA: 0x19D8F40
	public void set_Allocator(IAllocationStrategy value) { }

	// RVA: 0x19D8F50 Offset: 0x19D9051 VA: 0x19D8F50
	public IList<IResourceProvider> get_ResourceProviders() { }

	[CompilerGeneratedAttribute] // RVA: 0x12A130 Offset: 0x12A231 VA: 0x12A130
	// RVA: 0x19D8F60 Offset: 0x19D9061 VA: 0x19D8F60
	public CertificateHandler get_CertificateHandlerInstance() { }

	[CompilerGeneratedAttribute] // RVA: 0x12A140 Offset: 0x12A241 VA: 0x12A140
	// RVA: 0x19D8F70 Offset: 0x19D9071 VA: 0x19D8F70
	public void set_CertificateHandlerInstance(CertificateHandler value) { }

	// RVA: 0x19D8F80 Offset: 0x19D9081 VA: 0x19D8F80
	public void .ctor(IAllocationStrategy alloc) { }

	// RVA: 0x19D94D0 Offset: 0x19D95D1 VA: 0x19D94D0
	private void OnObjectAdded(object obj) { }

	// RVA: 0x19D9590 Offset: 0x19D9691 VA: 0x19D9590
	private void OnObjectRemoved(object obj) { }

	// RVA: 0x19D9610 Offset: 0x19D9711 VA: 0x19D9610
	internal void RegisterForCallbacks() { }

	[ObsoleteAttribute] // RVA: 0x12A150 Offset: 0x12A251 VA: 0x12A150
	// RVA: 0x19D9730 Offset: 0x19D9831 VA: 0x19D9730
	public void ClearDiagnosticsCallback() { }

	// RVA: 0x19D9770 Offset: 0x19D9871 VA: 0x19D9770
	public void ClearDiagnosticCallbacks() { }

	// RVA: 0x19D97B0 Offset: 0x19D98B1 VA: 0x19D97B0
	public void UnregisterDiagnosticCallback(Action<ResourceManager.DiagnosticEventContext> func) { }

	[ObsoleteAttribute] // RVA: 0x12A190 Offset: 0x12A291 VA: 0x12A190
	// RVA: 0x19D9890 Offset: 0x19D9991 VA: 0x19D9890
	public void RegisterDiagnosticCallback(Action<AsyncOperationHandle, ResourceManager.DiagnosticEventType, int, object> func) { }

	// RVA: 0x19D98A0 Offset: 0x19D99A1 VA: 0x19D98A0
	public void RegisterDiagnosticCallback(Action<ResourceManager.DiagnosticEventContext> func) { }

	// RVA: 0x19D9930 Offset: 0x19D9A31 VA: 0x19D9930
	internal void PostDiagnosticEvent(ResourceManager.DiagnosticEventContext context) { }

	// RVA: 0x19D9AA0 Offset: 0x19D9BA1 VA: 0x19D9AA0
	public IResourceProvider GetResourceProvider(Type t, IResourceLocation location) { }

	// RVA: 0x19D9F20 Offset: 0x19DA021 VA: 0x19D9F20
	private Type GetDefaultTypeForLocation(IResourceLocation loc) { }

	// RVA: 0x19DA090 Offset: 0x19DA191 VA: 0x19DA090
	private int CalculateLocationsHash(IList<IResourceLocation> locations, Type t) { }

	// RVA: 0x19DA4B0 Offset: 0x19DA5B1 VA: 0x19DA4B0
	private AsyncOperationHandle ProvideResource(IResourceLocation location, Type desiredType, bool releaseDependenciesOnFailure = True) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> ProvideResource<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FDCB0 Offset: 0x34FDDB1 VA: 0x34FDCB0
	|-ResourceManager.ProvideResource<ResourceManagerRuntimeData>
	|-ResourceManager.ProvideResource<ContentCatalogData>
	|-ResourceManager.ProvideResource<object>
	|-ResourceManager.ProvideResource<GameObject>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> StartOperation<TObject>(AsyncOperationBase<TObject> operation, AsyncOperationHandle dependency) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FDF30 Offset: 0x34FE031 VA: 0x34FDF30
	|-ResourceManager.StartOperation<IList<IResourceLocation>>
	|-ResourceManager.StartOperation<List<string>>
	|-ResourceManager.StartOperation<List<IResourceLocator>>
	|-ResourceManager.StartOperation<ContentCatalogData>
	|-ResourceManager.StartOperation<IResourceLocator>
	|-ResourceManager.StartOperation<IList<AsyncOperationHandle>>
	|-ResourceManager.StartOperation<object>
	|-ResourceManager.StartOperation<GameObject>
	|
	|-RVA: 0x34FDDD0 Offset: 0x34FDED1 VA: 0x34FDDD0
	|-ResourceManager.StartOperation<bool>
	|
	|-RVA: 0x34FDE80 Offset: 0x34FDF81 VA: 0x34FDE80
	|-ResourceManager.StartOperation<long>
	|
	|-RVA: 0x34FDFE0 Offset: 0x34FE0E1 VA: 0x34FDFE0
	|-ResourceManager.StartOperation<SceneInstance>
	*/

	// RVA: 0x19DB4A0 Offset: 0x19DB5A1 VA: 0x19DB4A0
	internal AsyncOperationHandle StartOperation(IAsyncOperation operation, AsyncOperationHandle dependency) { }

	// RVA: 0x19DB630 Offset: 0x19DB731 VA: 0x19DB630
	private void OnInstanceOperationDestroy(IAsyncOperation o) { }

	// RVA: 0x19DB780 Offset: 0x19DB881 VA: 0x19DB780
	private void OnOperationDestroyNonCached(IAsyncOperation o) { }

	// RVA: 0x19DB870 Offset: 0x19DB971 VA: 0x19DB870
	private void OnOperationDestroyCached(IAsyncOperation o) { }

	// RVA: -1 Offset: -1
	internal T CreateOperation<T>(Type actualType, int typeHash, int operationHash, Action<IAsyncOperation> onDestroyAction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2266AD0 Offset: 0x2266BD1 VA: 0x2266AD0
	|-ResourceManager.CreateOperation<ProviderOperation<ContentCatalogData>>
	|-ResourceManager.CreateOperation<object>
	|-ResourceManager.CreateOperation<GroupOperation>
	|-ResourceManager.CreateOperation<IAsyncOperation>
	|-ResourceManager.CreateOperation<ResourceManager.InstanceOperation>
	*/

	// RVA: 0x19DBAE0 Offset: 0x19DBBE1 VA: 0x19DBAE0
	internal void AddOperationToCache(int hash, IAsyncOperation operation) { }

	// RVA: 0x19DBA00 Offset: 0x19DBB01 VA: 0x19DBA00
	internal bool RemoveOperationFromCache(int hash) { }

	// RVA: 0x19DBBC0 Offset: 0x19DBCC1 VA: 0x19DBBC0
	internal bool IsOperationCached(int hash) { }

	// RVA: 0x19DBC30 Offset: 0x19DBD31 VA: 0x19DBC30
	internal int CachedOperationCount() { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateCompletedOperation<TObject>(TObject result, string errorMsg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FD4D0 Offset: 0x34FD5D1 VA: 0x34FD4D0
	|-ResourceManager.CreateCompletedOperation<bool>
	|
	|-RVA: 0x34FD5F0 Offset: 0x34FD6F1 VA: 0x34FD5F0
	|-ResourceManager.CreateCompletedOperation<IList<IAssetBundleResource>>
	|-ResourceManager.CreateCompletedOperation<List<IResourceLocator>>
	|-ResourceManager.CreateCompletedOperation<IResourceLocator>
	|-ResourceManager.CreateCompletedOperation<GameObject>
	|-ResourceManager.CreateCompletedOperation<object>
	|
	|-RVA: 0x34FD560 Offset: 0x34FD661 VA: 0x34FD560
	|-ResourceManager.CreateCompletedOperation<long>
	|
	|-RVA: 0x34FD680 Offset: 0x34FD781 VA: 0x34FD680
	|-ResourceManager.CreateCompletedOperation<SceneInstance>
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> CreateCompletedOperationInternal<TObject>(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FD720 Offset: 0x34FD821 VA: 0x34FD720
	|-ResourceManager.CreateCompletedOperationInternal<bool>
	|
	|-RVA: 0x34FD880 Offset: 0x34FD981 VA: 0x34FD880
	|-ResourceManager.CreateCompletedOperationInternal<long>
	|
	|-RVA: 0x34FD9E0 Offset: 0x34FDAE1 VA: 0x34FD9E0
	|-ResourceManager.CreateCompletedOperationInternal<object>
	|
	|-RVA: 0x34FDB40 Offset: 0x34FDC41 VA: 0x34FDB40
	|-ResourceManager.CreateCompletedOperationInternal<SceneInstance>
	*/

	// RVA: 0x19DBC90 Offset: 0x19DBD91 VA: 0x19DBC90
	public void Release(AsyncOperationHandle handle) { }

	// RVA: 0x19DBCA0 Offset: 0x19DBDA1 VA: 0x19DBCA0
	public void Acquire(AsyncOperationHandle handle) { }

	// RVA: 0x19DBCD0 Offset: 0x19DBDD1 VA: 0x19DBCD0
	private GroupOperation AcquireGroupOpFromCache(int hash) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGroupOperation<T>(IList<IResourceLocation> locations) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FA7A0 Offset: 0x34FA8A1 VA: 0x34FA7A0
	|-ResourceManager.CreateGroupOperation<object>
	|-ResourceManager.CreateGroupOperation<string>
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGroupOperation<T>(IList<IResourceLocation> locations, bool allowFailedDependencies) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FAE00 Offset: 0x34FAF01 VA: 0x34FAE00
	|-ResourceManager.CreateGroupOperation<object>
	|-ResourceManager.CreateGroupOperation<string>
	*/

	// RVA: 0x19DBE10 Offset: 0x19DBF11 VA: 0x19DBE10
	public AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGenericGroupOperation(List<AsyncOperationHandle> operations, bool releasedCachedOpOnComplete = False) { }

	// RVA: 0x19DAD20 Offset: 0x19DAE21 VA: 0x19DAD20
	internal AsyncOperationHandle<IList<AsyncOperationHandle>> ProvideResourceGroupCached(IList<IResourceLocation> locations, int groupHash, Type desiredType, Action<AsyncOperationHandle> callback, bool releaseDependenciesOnFailure = True) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> ProvideResources<TObject>(IList<IResourceLocation> locations, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FA490 Offset: 0x34FA591 VA: 0x34FA490
	|-ResourceManager.ProvideResources<object>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> ProvideResources<TObject>(IList<IResourceLocation> locations, bool releaseDependenciesOnFailure, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FA4F0 Offset: 0x34FA5F1 VA: 0x34FA4F0
	|-ResourceManager.ProvideResources<object>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateChainOperation<TObject, TObjectDependency>(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FCC20 Offset: 0x34FCD21 VA: 0x34FCC20
	|-ResourceManager.CreateChainOperation<List<IResourceLocator>, List<string>>
	|-ResourceManager.CreateChainOperation<IResourceLocator, ContentCatalogData>
	|-ResourceManager.CreateChainOperation<object, object>
	|
	|-RVA: 0x34FCF00 Offset: 0x34FD001 VA: 0x34FCF00
	|-ResourceManager.CreateChainOperation<SceneInstance, SceneInstance>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateChainOperation<TObject>(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FC9E0 Offset: 0x34FCAE1 VA: 0x34FC9E0
	|-ResourceManager.CreateChainOperation<bool>
	|
	|-RVA: 0x34FCDE0 Offset: 0x34FCEE1 VA: 0x34FCDE0
	|-ResourceManager.CreateChainOperation<IList<IResourceLocation>>
	|-ResourceManager.CreateChainOperation<IList<IAssetBundleResource>>
	|-ResourceManager.CreateChainOperation<IResourceLocator>
	|-ResourceManager.CreateChainOperation<GameObject>
	|-ResourceManager.CreateChainOperation<object>
	|
	|-RVA: 0x34FCB00 Offset: 0x34FCC01 VA: 0x34FCB00
	|-ResourceManager.CreateChainOperation<long>
	|
	|-RVA: 0x34FD0C0 Offset: 0x34FD1C1 VA: 0x34FD0C0
	|-ResourceManager.CreateChainOperation<SceneInstance>
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> CreateChainOperationInternal<TObject, TObjectDependency>(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FD1E0 Offset: 0x34FD2E1 VA: 0x34FD1E0
	|-ResourceManager.CreateChainOperationInternal<object, object>
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> CreateChainOperationInternal<TObject>(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FD3A0 Offset: 0x34FD4A1 VA: 0x34FD3A0
	|-ResourceManager.CreateChainOperationInternal<object>
	*/

	// RVA: 0x19DBFC0 Offset: 0x19DC0C1 VA: 0x19DBFC0
	public AsyncOperationHandle<SceneInstance> ProvideScene(ISceneProvider sceneProvider, IResourceLocation location, LoadSceneMode loadMode, bool activateOnLoad, int priority) { }

	// RVA: 0x19DC0F0 Offset: 0x19DC1F1 VA: 0x19DC0F0
	public AsyncOperationHandle<SceneInstance> ReleaseScene(ISceneProvider sceneProvider, AsyncOperationHandle<SceneInstance> sceneLoadHandle) { }

	// RVA: 0x19DC230 Offset: 0x19DC331 VA: 0x19DC230
	public AsyncOperationHandle<GameObject> ProvideInstance(IInstanceProvider provider, IResourceLocation location, InstantiationParameters instantiateParameters) { }

	// RVA: 0x19DC550 Offset: 0x19DC651 VA: 0x19DC550
	public void CleanupSceneInstances(Scene scene) { }

	// RVA: 0x19DC860 Offset: 0x19DC961 VA: 0x19DC860
	private void ExecuteDeferredCallbacks() { }

	// RVA: 0x19DCA10 Offset: 0x19DCB11 VA: 0x19DCA10
	internal void RegisterForDeferredCallback(IAsyncOperation op, bool incrementRefCount = True) { }

	// RVA: 0x19DCB00 Offset: 0x19DCC01 VA: 0x19DCB00
	internal void Update(float unscaledDeltaTime) { }

	// RVA: 0x19DCD40 Offset: 0x19DCE41 VA: 0x19DCD40 Slot: 4
	public void Dispose() { }

	// RVA: 0x19DCE70 Offset: 0x19DCF71 VA: 0x19DCE70
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x12A1A0 Offset: 0x12A2A1 VA: 0x12A1A0
	// RVA: 0x19DCF40 Offset: 0x19DD041 VA: 0x19DCF40
	private void <.ctor>b__45_0(IUpdateReceiver x) { }
}

