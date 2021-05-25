internal class GroupOperation : AsyncOperationBase<IList<AsyncOperationHandle>>, ICachable // TypeDefIndex: 4520
{
	// Fields
	private Action<AsyncOperationHandle> m_InternalOnComplete; // 0x80
	private int m_LoadedCount; // 0x88
	private GroupOperation.GroupOperationSettings m_Settings; // 0x8C
	private string debugName; // 0x90
	private const int k_MaxDisplayedLocationLength = 45;
	[CompilerGeneratedAttribute] // RVA: 0x12A090 Offset: 0x12A191 VA: 0x12A090
	private int <UnityEngine.ResourceManagement.AsyncOperations.ICachable.Hash>k__BackingField; // 0x98
	private HashSet<string> m_CachedDependencyLocations; // 0xA0

	// Properties
	private int UnityEngine.ResourceManagement.AsyncOperations.ICachable.Hash { get; set; }
	protected override string DebugName { get; }
	protected override float Progress { get; }

	// Methods

	// RVA: 0x19D54B0 Offset: 0x19D55B1 VA: 0x19D54B0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x12A380 Offset: 0x12A481 VA: 0x12A380
	// RVA: 0x19D55B0 Offset: 0x19D56B1 VA: 0x19D55B0 Slot: 34
	private int UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Hash() { }

	[CompilerGeneratedAttribute] // RVA: 0x12A390 Offset: 0x12A491 VA: 0x12A390
	// RVA: 0x19D55C0 Offset: 0x19D56C1 VA: 0x19D55C0 Slot: 35
	private void UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Hash(int value) { }

	// RVA: 0x19D55D0 Offset: 0x19D56D1 VA: 0x19D55D0
	internal IList<AsyncOperationHandle> GetDependentOps() { }

	// RVA: 0x19D5620 Offset: 0x19D5721 VA: 0x19D5620 Slot: 31
	protected override void GetDependencies(List<AsyncOperationHandle> deps) { }

	// RVA: 0x19D5690 Offset: 0x19D5791 VA: 0x19D5690 Slot: 32
	internal override void ReleaseDependencies() { }

	// RVA: 0x19D59B0 Offset: 0x19D5AB1 VA: 0x19D59B0 Slot: 33
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }

	// RVA: 0x19D5CD0 Offset: 0x19D5DD1 VA: 0x19D5CD0
	private bool DependenciesAreUnchanged(List<AsyncOperationHandle> deps) { }

	// RVA: 0x19D5E50 Offset: 0x19D5F51 VA: 0x19D5E50 Slot: 30
	protected override string get_DebugName() { }

	// RVA: 0x19D60B0 Offset: 0x19D61B1 VA: 0x19D60B0 Slot: 27
	protected override void Execute() { }

	// RVA: 0x19D62F0 Offset: 0x19D63F1 VA: 0x19D62F0
	private void CompleteIfDependenciesComplete() { }

	// RVA: 0x19D6710 Offset: 0x19D6811 VA: 0x19D6710 Slot: 28
	protected override void Destroy() { }

	// RVA: 0x19D6720 Offset: 0x19D6821 VA: 0x19D6720 Slot: 29
	protected override float get_Progress() { }

	// RVA: 0x19D6930 Offset: 0x19D6A31 VA: 0x19D6930
	public void Init(List<AsyncOperationHandle> operations, bool releaseDependenciesOnFailure = True, bool allowFailedDependencies = False) { }

	// RVA: 0x19D69F0 Offset: 0x19D6AF1 VA: 0x19D69F0
	public void Init(List<AsyncOperationHandle> operations, GroupOperation.GroupOperationSettings settings) { }

	// RVA: 0x19D6A80 Offset: 0x19D6B81 VA: 0x19D6A80
	private void OnOperationCompleted(AsyncOperationHandle op) { }
}

