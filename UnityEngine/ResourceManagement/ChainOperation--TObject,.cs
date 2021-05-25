internal class ChainOperation<TObject, TObjectDependency> : AsyncOperationBase<TObject> // TypeDefIndex: 4449
{
	// Fields
	private AsyncOperationHandle<TObjectDependency> m_DepOp; // 0x0
	private AsyncOperationHandle<TObject> m_WrappedOp; // 0x0
	private Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> m_Callback; // 0x0
	private Action<AsyncOperationHandle<TObject>> m_CachedOnWrappedCompleted; // 0x0
	private bool m_ReleaseDependenciesOnFailure; // 0x0

	// Properties
	protected override string DebugName { get; }
	protected override float Progress { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA4EC0 Offset: 0x2AA4FC1 VA: 0x2AA4EC0
	|-ChainOperation<object, object>..ctor
	|
	|-RVA: 0x2AA5C30 Offset: 0x2AA5D31 VA: 0x2AA5C30
	|-ChainOperation<SceneInstance, SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA4F60 Offset: 0x2AA5061 VA: 0x2AA4F60
	|-ChainOperation<object, object>.get_DebugName
	|
	|-RVA: 0x2AA5CD0 Offset: 0x2AA5DD1 VA: 0x2AA5CD0
	|-ChainOperation<SceneInstance, SceneInstance>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override void GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA5200 Offset: 0x2AA5301 VA: 0x2AA5200
	|-ChainOperation<object, object>.GetDependencies
	|
	|-RVA: 0x2AA5F70 Offset: 0x2AA6071 VA: 0x2AA5F70
	|-ChainOperation<SceneInstance, SceneInstance>.GetDependencies
	*/

	// RVA: -1 Offset: -1
	public void Init(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA5350 Offset: 0x2AA5451 VA: 0x2AA5350
	|-ChainOperation<object, object>.Init
	|
	|-RVA: 0x2AA60C0 Offset: 0x2AA61C1 VA: 0x2AA60C0
	|-ChainOperation<SceneInstance, SceneInstance>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 27
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA53E0 Offset: 0x2AA54E1 VA: 0x2AA53E0
	|-ChainOperation<object, object>.Execute
	|
	|-RVA: 0x2AA6150 Offset: 0x2AA6251 VA: 0x2AA6150
	|-ChainOperation<SceneInstance, SceneInstance>.Execute
	*/

	// RVA: -1 Offset: -1
	private void OnWrappedCompleted(AsyncOperationHandle<TObject> x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA54B0 Offset: 0x2AA55B1 VA: 0x2AA54B0
	|-ChainOperation<object, object>.OnWrappedCompleted
	|
	|-RVA: 0x2AA6220 Offset: 0x2AA6321 VA: 0x2AA6220
	|-ChainOperation<SceneInstance, SceneInstance>.OnWrappedCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA5640 Offset: 0x2AA5741 VA: 0x2AA5640
	|-ChainOperation<object, object>.Destroy
	|
	|-RVA: 0x2AA63C0 Offset: 0x2AA64C1 VA: 0x2AA63C0
	|-ChainOperation<SceneInstance, SceneInstance>.Destroy
	*/

	// RVA: -1 Offset: -1 Slot: 32
	internal override void ReleaseDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA5790 Offset: 0x2AA5891 VA: 0x2AA5790
	|-ChainOperation<object, object>.ReleaseDependencies
	|
	|-RVA: 0x2AA6510 Offset: 0x2AA6611 VA: 0x2AA6510
	|-ChainOperation<SceneInstance, SceneInstance>.ReleaseDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 33
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA5860 Offset: 0x2AA5961 VA: 0x2AA5860
	|-ChainOperation<object, object>.GetDownloadStatus
	|
	|-RVA: 0x2AA65E0 Offset: 0x2AA66E1 VA: 0x2AA65E0
	|-ChainOperation<SceneInstance, SceneInstance>.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA5A30 Offset: 0x2AA5B31 VA: 0x2AA5A30
	|-ChainOperation<object, object>.get_Progress
	|
	|-RVA: 0x2AA67B0 Offset: 0x2AA68B1 VA: 0x2AA67B0
	|-ChainOperation<SceneInstance, SceneInstance>.get_Progress
	*/
}

