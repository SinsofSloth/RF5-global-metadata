internal class ChainOperationTypelessDepedency<TObject> : AsyncOperationBase<TObject> // TypeDefIndex: 4450
{
	// Fields
	private AsyncOperationHandle m_DepOp; // 0x0
	private AsyncOperationHandle<TObject> m_WrappedOp; // 0x0
	private Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> m_Callback; // 0x0
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
	|-RVA: 0x2AA2A30 Offset: 0x2AA2B31 VA: 0x2AA2A30
	|-ChainOperationTypelessDepedency<bool>..ctor
	|
	|-RVA: 0x2AA3350 Offset: 0x2AA3451 VA: 0x2AA3350
	|-ChainOperationTypelessDepedency<long>..ctor
	|
	|-RVA: 0x2AA3C70 Offset: 0x2AA3D71 VA: 0x2AA3C70
	|-ChainOperationTypelessDepedency<object>..ctor
	|
	|-RVA: 0x2AA4590 Offset: 0x2AA4691 VA: 0x2AA4590
	|-ChainOperationTypelessDepedency<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA2AD0 Offset: 0x2AA2BD1 VA: 0x2AA2AD0
	|-ChainOperationTypelessDepedency<bool>.get_DebugName
	|
	|-RVA: 0x2AA33F0 Offset: 0x2AA34F1 VA: 0x2AA33F0
	|-ChainOperationTypelessDepedency<long>.get_DebugName
	|
	|-RVA: 0x2AA3D10 Offset: 0x2AA3E11 VA: 0x2AA3D10
	|-ChainOperationTypelessDepedency<object>.get_DebugName
	|
	|-RVA: 0x2AA4630 Offset: 0x2AA4731 VA: 0x2AA4630
	|-ChainOperationTypelessDepedency<SceneInstance>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override void GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA2BA0 Offset: 0x2AA2CA1 VA: 0x2AA2BA0
	|-ChainOperationTypelessDepedency<bool>.GetDependencies
	|
	|-RVA: 0x2AA34C0 Offset: 0x2AA35C1 VA: 0x2AA34C0
	|-ChainOperationTypelessDepedency<long>.GetDependencies
	|
	|-RVA: 0x2AA3DE0 Offset: 0x2AA3EE1 VA: 0x2AA3DE0
	|-ChainOperationTypelessDepedency<object>.GetDependencies
	|
	|-RVA: 0x2AA4700 Offset: 0x2AA4801 VA: 0x2AA4700
	|-ChainOperationTypelessDepedency<SceneInstance>.GetDependencies
	*/

	// RVA: -1 Offset: -1
	public void Init(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA2C50 Offset: 0x2AA2D51 VA: 0x2AA2C50
	|-ChainOperationTypelessDepedency<bool>.Init
	|
	|-RVA: 0x2AA3570 Offset: 0x2AA3671 VA: 0x2AA3570
	|-ChainOperationTypelessDepedency<long>.Init
	|
	|-RVA: 0x2AA3E90 Offset: 0x2AA3F91 VA: 0x2AA3E90
	|-ChainOperationTypelessDepedency<object>.Init
	|
	|-RVA: 0x2AA47B0 Offset: 0x2AA48B1 VA: 0x2AA47B0
	|-ChainOperationTypelessDepedency<SceneInstance>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 27
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA2CD0 Offset: 0x2AA2DD1 VA: 0x2AA2CD0
	|-ChainOperationTypelessDepedency<bool>.Execute
	|
	|-RVA: 0x2AA35F0 Offset: 0x2AA36F1 VA: 0x2AA35F0
	|-ChainOperationTypelessDepedency<long>.Execute
	|
	|-RVA: 0x2AA3F10 Offset: 0x2AA4011 VA: 0x2AA3F10
	|-ChainOperationTypelessDepedency<object>.Execute
	|
	|-RVA: 0x2AA4830 Offset: 0x2AA4931 VA: 0x2AA4830
	|-ChainOperationTypelessDepedency<SceneInstance>.Execute
	*/

	// RVA: -1 Offset: -1
	private void OnWrappedCompleted(AsyncOperationHandle<TObject> x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA2DA0 Offset: 0x2AA2EA1 VA: 0x2AA2DA0
	|-ChainOperationTypelessDepedency<bool>.OnWrappedCompleted
	|
	|-RVA: 0x2AA36C0 Offset: 0x2AA37C1 VA: 0x2AA36C0
	|-ChainOperationTypelessDepedency<long>.OnWrappedCompleted
	|
	|-RVA: 0x2AA3FE0 Offset: 0x2AA40E1 VA: 0x2AA3FE0
	|-ChainOperationTypelessDepedency<object>.OnWrappedCompleted
	|
	|-RVA: 0x2AA4900 Offset: 0x2AA4A01 VA: 0x2AA4900
	|-ChainOperationTypelessDepedency<SceneInstance>.OnWrappedCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA2F30 Offset: 0x2AA3031 VA: 0x2AA2F30
	|-ChainOperationTypelessDepedency<bool>.Destroy
	|
	|-RVA: 0x2AA3850 Offset: 0x2AA3951 VA: 0x2AA3850
	|-ChainOperationTypelessDepedency<long>.Destroy
	|
	|-RVA: 0x2AA4170 Offset: 0x2AA4271 VA: 0x2AA4170
	|-ChainOperationTypelessDepedency<object>.Destroy
	|
	|-RVA: 0x2AA4AA0 Offset: 0x2AA4BA1 VA: 0x2AA4AA0
	|-ChainOperationTypelessDepedency<SceneInstance>.Destroy
	*/

	// RVA: -1 Offset: -1 Slot: 32
	internal override void ReleaseDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA3020 Offset: 0x2AA3121 VA: 0x2AA3020
	|-ChainOperationTypelessDepedency<bool>.ReleaseDependencies
	|
	|-RVA: 0x2AA3940 Offset: 0x2AA3A41 VA: 0x2AA3940
	|-ChainOperationTypelessDepedency<long>.ReleaseDependencies
	|
	|-RVA: 0x2AA4260 Offset: 0x2AA4361 VA: 0x2AA4260
	|-ChainOperationTypelessDepedency<object>.ReleaseDependencies
	|
	|-RVA: 0x2AA4B90 Offset: 0x2AA4C91 VA: 0x2AA4B90
	|-ChainOperationTypelessDepedency<SceneInstance>.ReleaseDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 33
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA3060 Offset: 0x2AA3161 VA: 0x2AA3060
	|-ChainOperationTypelessDepedency<bool>.GetDownloadStatus
	|
	|-RVA: 0x2AA3980 Offset: 0x2AA3A81 VA: 0x2AA3980
	|-ChainOperationTypelessDepedency<long>.GetDownloadStatus
	|
	|-RVA: 0x2AA42A0 Offset: 0x2AA43A1 VA: 0x2AA42A0
	|-ChainOperationTypelessDepedency<object>.GetDownloadStatus
	|
	|-RVA: 0x2AA4BD0 Offset: 0x2AA4CD1 VA: 0x2AA4BD0
	|-ChainOperationTypelessDepedency<SceneInstance>.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA31C0 Offset: 0x2AA32C1 VA: 0x2AA31C0
	|-ChainOperationTypelessDepedency<bool>.get_Progress
	|
	|-RVA: 0x2AA3AE0 Offset: 0x2AA3BE1 VA: 0x2AA3AE0
	|-ChainOperationTypelessDepedency<long>.get_Progress
	|
	|-RVA: 0x2AA4400 Offset: 0x2AA4501 VA: 0x2AA4400
	|-ChainOperationTypelessDepedency<object>.get_Progress
	|
	|-RVA: 0x2AA4D30 Offset: 0x2AA4E31 VA: 0x2AA4D30
	|-ChainOperationTypelessDepedency<SceneInstance>.get_Progress
	*/
}

