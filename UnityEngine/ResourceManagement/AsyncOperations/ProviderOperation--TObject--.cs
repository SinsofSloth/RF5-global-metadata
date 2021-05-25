internal class ProviderOperation<TObject> : AsyncOperationBase<TObject>, IGenericProviderOperation, ICachable // TypeDefIndex: 4523
{
	// Fields
	private bool m_ReleaseDependenciesOnFailure; // 0x0
	private Action<int, object, bool, Exception> m_CompletionCallback; // 0x0
	private Action<int, IList<object>> m_GetDepCallback; // 0x0
	private Func<float> m_GetProgressCallback; // 0x0
	private Func<DownloadStatus> m_GetDownloadProgressCallback; // 0x0
	private DownloadStatus m_DownloadStatus; // 0x0
	private IResourceProvider m_Provider; // 0x0
	internal AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0x0
	private IResourceLocation m_Location; // 0x0
	private int m_ProvideHandleVersion; // 0x0
	private bool m_NeedsRelease; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x12A0A0 Offset: 0x12A1A1 VA: 0x12A0A0
	private int <UnityEngine.ResourceManagement.AsyncOperations.ICachable.Hash>k__BackingField; // 0x0
	private ResourceManager m_ResourceManager; // 0x0
	private const float k_OperationWaitingToCompletePercentComplete = 0.99;
	internal const string kInvalidHandleMsg = "The ProvideHandle is invalid. After the handle has been completed, it can no longer be used";

	// Properties
	private int UnityEngine.ResourceManagement.AsyncOperations.ICachable.Hash { get; set; }
	public int ProvideHandleVersion { get; }
	public IResourceLocation Location { get; }
	protected override string DebugName { get; }
	public Type RequestedType { get; }
	public int DependencyCount { get; }
	protected override float Progress { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x12A3A0 Offset: 0x12A4A1 VA: 0x12A3A0
	// RVA: -1 Offset: -1 Slot: 45
	private int UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Hash() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA1210 Offset: 0x2AA1311 VA: 0x2AA1210
	|-ProviderOperation<object>.UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Hash
	*/

	[CompilerGeneratedAttribute] // RVA: 0x12A3B0 Offset: 0x12A4B1 VA: 0x12A3B0
	// RVA: -1 Offset: -1 Slot: 46
	private void UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Hash(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA1220 Offset: 0x2AA1321 VA: 0x2AA1220
	|-ProviderOperation<object>.UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Hash
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public int get_ProvideHandleVersion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA1230 Offset: 0x2AA1331 VA: 0x2AA1230
	|-ProviderOperation<object>.get_ProvideHandleVersion
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public IResourceLocation get_Location() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA1240 Offset: 0x2AA1341 VA: 0x2AA1240
	|-ProviderOperation<object>.get_Location
	*/

	// RVA: -1 Offset: -1 Slot: 44
	public void SetDownloadProgressCallback(Func<DownloadStatus> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA1250 Offset: 0x2AA1351 VA: 0x2AA1250
	|-ProviderOperation<object>.SetDownloadProgressCallback
	*/

	// RVA: -1 Offset: -1 Slot: 33
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA12F0 Offset: 0x2AA13F1 VA: 0x2AA12F0
	|-ProviderOperation<object>.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA14C0 Offset: 0x2AA15C1 VA: 0x2AA14C0
	|-ProviderOperation<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override void GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA14F0 Offset: 0x2AA15F1 VA: 0x2AA14F0
	|-ProviderOperation<object>.GetDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 32
	internal override void ReleaseDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA1620 Offset: 0x2AA1721 VA: 0x2AA1620
	|-ProviderOperation<object>.ReleaseDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA1700 Offset: 0x2AA1801 VA: 0x2AA1700
	|-ProviderOperation<object>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 39
	public void GetDependencies(IList<object> dstList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA1850 Offset: 0x2AA1951 VA: 0x2AA1850
	|-ProviderOperation<object>.GetDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 43
	public Type get_RequestedType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA1B60 Offset: 0x2AA1C61 VA: 0x2AA1B60
	|-ProviderOperation<object>.get_RequestedType
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public int get_DependencyCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA1BE0 Offset: 0x2AA1CE1 VA: 0x2AA1BE0
	|-ProviderOperation<object>.get_DependencyCount
	*/

	// RVA: -1 Offset: -1 Slot: 40
	public TDepObject GetDependency<TDepObject>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22678D0 Offset: 0x22679D1 VA: 0x22678D0
	|-ProviderOperation<object>.GetDependency<object>
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public void SetProgressCallback(Func<float> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA1D50 Offset: 0x2AA1E51 VA: 0x2AA1D50
	|-ProviderOperation<object>.SetProgressCallback
	*/

	// RVA: -1 Offset: -1 Slot: 42
	public void ProviderCompleted<T>(T result, bool status, Exception e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E9660 Offset: 0x23E9761 VA: 0x23E9660
	|-ProviderOperation<object>.ProviderCompleted<object>
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA1D60 Offset: 0x2AA1E61 VA: 0x2AA1D60
	|-ProviderOperation<object>.get_Progress
	*/

	// RVA: -1 Offset: -1 Slot: 27
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA2280 Offset: 0x2AA2381 VA: 0x2AA2280
	|-ProviderOperation<object>.Execute
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA25D0 Offset: 0x2AA26D1 VA: 0x2AA25D0
	|-ProviderOperation<object>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 35
	public void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA2730 Offset: 0x2AA2831 VA: 0x2AA2730
	|-ProviderOperation<object>.Init
	|-ProviderOperation<ContentCatalogData>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA2890 Offset: 0x2AA2991 VA: 0x2AA2890
	|-ProviderOperation<object>.Destroy
	*/
}

