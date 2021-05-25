public abstract class AsyncOperationBase<TObject> : IAsyncOperation // TypeDefIndex: 4511
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x12A070 Offset: 0x12A171 VA: 0x12A070
	private TObject <Result>k__BackingField; // 0x0
	private int m_referenceCount; // 0x0
	private AsyncOperationStatus m_Status; // 0x0
	private Exception m_Error; // 0x0
	internal ResourceManager m_RM; // 0x0
	internal int m_Version; // 0x0
	private DelegateList<AsyncOperationHandle> m_DestroyedAction; // 0x0
	private DelegateList<AsyncOperationHandle<TObject>> m_CompletedActionT; // 0x0
	private Action<IAsyncOperation> m_OnDestroyAction; // 0x0
	private Action<AsyncOperationHandle> m_dependencyCompleteAction; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x12A080 Offset: 0x12A181 VA: 0x12A080
	private bool <IsRunning>k__BackingField; // 0x0
	private EventWaitHandle m_waitHandle; // 0x0
	private bool m_InDeferredCallbackQueue; // 0x0
	private DelegateList<float> m_UpdateCallbacks; // 0x0
	private Action<float> m_UpdateCallback; // 0x0

	// Properties
	protected virtual float Progress { get; }
	protected virtual string DebugName { get; }
	public TObject Result { get; set; }
	internal int Version { get; }
	internal bool CompletedEventHasListeners { get; }
	internal bool DestroyedEventHasListeners { get; }
	internal Action<IAsyncOperation> OnDestroy { set; }
	internal int ReferenceCount { get; }
	public bool IsRunning { get; set; }
	internal WaitHandle WaitHandle { get; }
	internal Task<TObject> Task { get; }
	private Task<object> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Task { get; }
	internal AsyncOperationStatus Status { get; }
	internal Exception OperationException { get; set; }
	internal object Current { get; }
	internal bool IsDone { get; }
	internal float PercentComplete { get; }
	internal AsyncOperationHandle<TObject> Handle { get; }
	private int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Version { get; }
	private int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.ReferenceCount { get; }
	private float UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.PercentComplete { get; }
	private AsyncOperationStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Status { get; }
	private Exception UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.OperationException { get; }
	private bool UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IsDone { get; }
	private AsyncOperationHandle UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Handle { get; }
	private Action<IAsyncOperation> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.OnDestroy { set; }
	private string UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DebugName { get; }
	private Type UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.ResultType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 27
	protected abstract void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AsyncOperationBase<object>.Execute
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected virtual void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC2480 Offset: 0x2CC2581 VA: 0x2CC2480
	|-AsyncOperationBase<bool>.Destroy
	|
	|-RVA: 0x2CC6F80 Offset: 0x2CC7081 VA: 0x2CC6F80
	|-AsyncOperationBase<IList<IResourceLocation>>.Destroy
	|-AsyncOperationBase<object>.Destroy
	|-AsyncOperationBase<IResourceLocator>.Destroy
	|
	|-RVA: 0x2CC4A00 Offset: 0x2CC4B01 VA: 0x2CC4A00
	|-AsyncOperationBase<long>.Destroy
	|
	|-RVA: 0x2CC9450 Offset: 0x2CC9551 VA: 0x2CC9450
	|-AsyncOperationBase<SceneInstance>.Destroy
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected virtual float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC2490 Offset: 0x2CC2591 VA: 0x2CC2490
	|-AsyncOperationBase<bool>.get_Progress
	|
	|-RVA: 0x2CC6F90 Offset: 0x2CC7091 VA: 0x2CC6F90
	|-AsyncOperationBase<IList<IResourceLocation>>.get_Progress
	|-AsyncOperationBase<List<string>>.get_Progress
	|-AsyncOperationBase<List<IResourceLocator>>.get_Progress
	|-AsyncOperationBase<object>.get_Progress
	|
	|-RVA: 0x2CC4A10 Offset: 0x2CC4B11 VA: 0x2CC4A10
	|-AsyncOperationBase<long>.get_Progress
	|
	|-RVA: 0x2CC9460 Offset: 0x2CC9561 VA: 0x2CC9460
	|-AsyncOperationBase<SceneInstance>.get_Progress
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected virtual string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC24A0 Offset: 0x2CC25A1 VA: 0x2CC24A0
	|-AsyncOperationBase<bool>.get_DebugName
	|
	|-RVA: 0x2CC6FA0 Offset: 0x2CC70A1 VA: 0x2CC6FA0
	|-AsyncOperationBase<List<string>>.get_DebugName
	|-AsyncOperationBase<List<IResourceLocator>>.get_DebugName
	|-AsyncOperationBase<object>.get_DebugName
	|
	|-RVA: 0x2CC4A20 Offset: 0x2CC4B21 VA: 0x2CC4A20
	|-AsyncOperationBase<long>.get_DebugName
	|
	|-RVA: 0x2CC9470 Offset: 0x2CC9571 VA: 0x2CC9470
	|-AsyncOperationBase<SceneInstance>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected virtual void GetDependencies(List<AsyncOperationHandle> dependencies) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC24C0 Offset: 0x2CC25C1 VA: 0x2CC24C0
	|-AsyncOperationBase<bool>.GetDependencies
	|
	|-RVA: 0x2CC6FC0 Offset: 0x2CC70C1 VA: 0x2CC6FC0
	|-AsyncOperationBase<IList<IResourceLocation>>.GetDependencies
	|-AsyncOperationBase<object>.GetDependencies
	|-AsyncOperationBase<IResourceLocator>.GetDependencies
	|
	|-RVA: 0x2CC4A40 Offset: 0x2CC4B41 VA: 0x2CC4A40
	|-AsyncOperationBase<long>.GetDependencies
	|
	|-RVA: 0x2CC9490 Offset: 0x2CC9591 VA: 0x2CC9490
	|-AsyncOperationBase<SceneInstance>.GetDependencies
	*/

	[CompilerGeneratedAttribute] // RVA: 0x12A330 Offset: 0x12A431 VA: 0x12A330
	// RVA: -1 Offset: -1
	public TObject get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC6FD0 Offset: 0x2CC70D1 VA: 0x2CC6FD0
	|-AsyncOperationBase<IResourceLocator>.get_Result
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.get_Result
	|-AsyncOperationBase<object>.get_Result
	|-AsyncOperationBase<GameObject>.get_Result
	|
	|-RVA: 0x2CC24D0 Offset: 0x2CC25D1 VA: 0x2CC24D0
	|-AsyncOperationBase<bool>.get_Result
	|
	|-RVA: 0x2CC4A50 Offset: 0x2CC4B51 VA: 0x2CC4A50
	|-AsyncOperationBase<long>.get_Result
	|
	|-RVA: 0x2CC94A0 Offset: 0x2CC95A1 VA: 0x2CC94A0
	|-AsyncOperationBase<SceneInstance>.get_Result
	*/

	[CompilerGeneratedAttribute] // RVA: 0x12A340 Offset: 0x12A441 VA: 0x12A340
	// RVA: -1 Offset: -1
	public void set_Result(TObject value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC24E0 Offset: 0x2CC25E1 VA: 0x2CC24E0
	|-AsyncOperationBase<bool>.set_Result
	|
	|-RVA: 0x2CC6FE0 Offset: 0x2CC70E1 VA: 0x2CC6FE0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.set_Result
	|-AsyncOperationBase<object>.set_Result
	|-AsyncOperationBase<IResourceLocator>.set_Result
	|
	|-RVA: 0x2CC4A60 Offset: 0x2CC4B61 VA: 0x2CC4A60
	|-AsyncOperationBase<long>.set_Result
	|
	|-RVA: 0x2CC94B0 Offset: 0x2CC95B1 VA: 0x2CC94B0
	|-AsyncOperationBase<SceneInstance>.set_Result
	*/

	// RVA: -1 Offset: -1
	internal int get_Version() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC24F0 Offset: 0x2CC25F1 VA: 0x2CC24F0
	|-AsyncOperationBase<bool>.get_Version
	|
	|-RVA: 0x2CC4A70 Offset: 0x2CC4B71 VA: 0x2CC4A70
	|-AsyncOperationBase<long>.get_Version
	|
	|-RVA: 0x2CC6FF0 Offset: 0x2CC70F1 VA: 0x2CC6FF0
	|-AsyncOperationBase<object>.get_Version
	|
	|-RVA: 0x2CC94C0 Offset: 0x2CC95C1 VA: 0x2CC94C0
	|-AsyncOperationBase<SceneInstance>.get_Version
	*/

	// RVA: -1 Offset: -1
	internal bool get_CompletedEventHasListeners() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC2500 Offset: 0x2CC2601 VA: 0x2CC2500
	|-AsyncOperationBase<bool>.get_CompletedEventHasListeners
	|
	|-RVA: 0x2CC4A80 Offset: 0x2CC4B81 VA: 0x2CC4A80
	|-AsyncOperationBase<long>.get_CompletedEventHasListeners
	|
	|-RVA: 0x2CC7000 Offset: 0x2CC7101 VA: 0x2CC7000
	|-AsyncOperationBase<object>.get_CompletedEventHasListeners
	|
	|-RVA: 0x2CC94D0 Offset: 0x2CC95D1 VA: 0x2CC94D0
	|-AsyncOperationBase<SceneInstance>.get_CompletedEventHasListeners
	*/

	// RVA: -1 Offset: -1
	internal bool get_DestroyedEventHasListeners() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC2540 Offset: 0x2CC2641 VA: 0x2CC2540
	|-AsyncOperationBase<bool>.get_DestroyedEventHasListeners
	|
	|-RVA: 0x2CC4AC0 Offset: 0x2CC4BC1 VA: 0x2CC4AC0
	|-AsyncOperationBase<long>.get_DestroyedEventHasListeners
	|
	|-RVA: 0x2CC7040 Offset: 0x2CC7141 VA: 0x2CC7040
	|-AsyncOperationBase<object>.get_DestroyedEventHasListeners
	|
	|-RVA: 0x2CC9510 Offset: 0x2CC9611 VA: 0x2CC9510
	|-AsyncOperationBase<SceneInstance>.get_DestroyedEventHasListeners
	*/

	// RVA: -1 Offset: -1
	internal void set_OnDestroy(Action<IAsyncOperation> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC25A0 Offset: 0x2CC26A1 VA: 0x2CC25A0
	|-AsyncOperationBase<bool>.set_OnDestroy
	|
	|-RVA: 0x2CC4B20 Offset: 0x2CC4C21 VA: 0x2CC4B20
	|-AsyncOperationBase<long>.set_OnDestroy
	|
	|-RVA: 0x2CC70A0 Offset: 0x2CC71A1 VA: 0x2CC70A0
	|-AsyncOperationBase<object>.set_OnDestroy
	|
	|-RVA: 0x2CC9570 Offset: 0x2CC9671 VA: 0x2CC9570
	|-AsyncOperationBase<SceneInstance>.set_OnDestroy
	*/

	// RVA: -1 Offset: -1
	internal int get_ReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC25B0 Offset: 0x2CC26B1 VA: 0x2CC25B0
	|-AsyncOperationBase<bool>.get_ReferenceCount
	|
	|-RVA: 0x2CC4B30 Offset: 0x2CC4C31 VA: 0x2CC4B30
	|-AsyncOperationBase<long>.get_ReferenceCount
	|
	|-RVA: 0x2CC70B0 Offset: 0x2CC71B1 VA: 0x2CC70B0
	|-AsyncOperationBase<object>.get_ReferenceCount
	|
	|-RVA: 0x2CC9580 Offset: 0x2CC9681 VA: 0x2CC9580
	|-AsyncOperationBase<SceneInstance>.get_ReferenceCount
	*/

	[CompilerGeneratedAttribute] // RVA: 0x12A350 Offset: 0x12A451 VA: 0x12A350
	// RVA: -1 Offset: -1 Slot: 18
	public bool get_IsRunning() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC25C0 Offset: 0x2CC26C1 VA: 0x2CC25C0
	|-AsyncOperationBase<bool>.get_IsRunning
	|
	|-RVA: 0x2CC70C0 Offset: 0x2CC71C1 VA: 0x2CC70C0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.get_IsRunning
	|-AsyncOperationBase<IList<IResourceLocation>>.get_IsRunning
	|-AsyncOperationBase<List<string>>.get_IsRunning
	|-AsyncOperationBase<List<IResourceLocator>>.get_IsRunning
	|-AsyncOperationBase<object>.get_IsRunning
	|-AsyncOperationBase<IResourceLocator>.get_IsRunning
	|-AsyncOperationBase<GameObject>.get_IsRunning
	|
	|-RVA: 0x2CC4B40 Offset: 0x2CC4C41 VA: 0x2CC4B40
	|-AsyncOperationBase<long>.get_IsRunning
	|
	|-RVA: 0x2CC9590 Offset: 0x2CC9691 VA: 0x2CC9590
	|-AsyncOperationBase<SceneInstance>.get_IsRunning
	*/

	[CompilerGeneratedAttribute] // RVA: 0x12A360 Offset: 0x12A461 VA: 0x12A360
	// RVA: -1 Offset: -1
	internal void set_IsRunning(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC25D0 Offset: 0x2CC26D1 VA: 0x2CC25D0
	|-AsyncOperationBase<bool>.set_IsRunning
	|
	|-RVA: 0x2CC4B50 Offset: 0x2CC4C51 VA: 0x2CC4B50
	|-AsyncOperationBase<long>.set_IsRunning
	|
	|-RVA: 0x2CC70D0 Offset: 0x2CC71D1 VA: 0x2CC70D0
	|-AsyncOperationBase<object>.set_IsRunning
	|
	|-RVA: 0x2CC95A0 Offset: 0x2CC96A1 VA: 0x2CC95A0
	|-AsyncOperationBase<SceneInstance>.set_IsRunning
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC25E0 Offset: 0x2CC26E1 VA: 0x2CC25E0
	|-AsyncOperationBase<bool>..ctor
	|
	|-RVA: 0x2CC70E0 Offset: 0x2CC71E1 VA: 0x2CC70E0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>..ctor
	|-AsyncOperationBase<IList<IResourceLocation>>..ctor
	|-AsyncOperationBase<List<string>>..ctor
	|-AsyncOperationBase<List<IResourceLocator>>..ctor
	|-AsyncOperationBase<object>..ctor
	|-AsyncOperationBase<IResourceLocator>..ctor
	|-AsyncOperationBase<GameObject>..ctor
	|
	|-RVA: 0x2CC4B60 Offset: 0x2CC4C61 VA: 0x2CC4B60
	|-AsyncOperationBase<long>..ctor
	|
	|-RVA: 0x2CC95B0 Offset: 0x2CC96B1 VA: 0x2CC95B0
	|-AsyncOperationBase<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static string ShortenPath(string p, bool keepExtension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC26D0 Offset: 0x2CC27D1 VA: 0x2CC26D0
	|-AsyncOperationBase<bool>.ShortenPath
	|
	|-RVA: 0x2CC4C50 Offset: 0x2CC4D51 VA: 0x2CC4C50
	|-AsyncOperationBase<long>.ShortenPath
	|
	|-RVA: 0x2CC71D0 Offset: 0x2CC72D1 VA: 0x2CC71D0
	|-AsyncOperationBase<object>.ShortenPath
	|
	|-RVA: 0x2CC96A0 Offset: 0x2CC97A1 VA: 0x2CC96A0
	|-AsyncOperationBase<SceneInstance>.ShortenPath
	*/

	// RVA: -1 Offset: -1
	internal void IncrementReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC2760 Offset: 0x2CC2861 VA: 0x2CC2760
	|-AsyncOperationBase<bool>.IncrementReferenceCount
	|
	|-RVA: 0x2CC4CE0 Offset: 0x2CC4DE1 VA: 0x2CC4CE0
	|-AsyncOperationBase<long>.IncrementReferenceCount
	|
	|-RVA: 0x2CC7260 Offset: 0x2CC7361 VA: 0x2CC7260
	|-AsyncOperationBase<object>.IncrementReferenceCount
	|
	|-RVA: 0x2CC9730 Offset: 0x2CC9831 VA: 0x2CC9730
	|-AsyncOperationBase<SceneInstance>.IncrementReferenceCount
	*/

	// RVA: -1 Offset: -1
	internal void DecrementReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC28A0 Offset: 0x2CC29A1 VA: 0x2CC28A0
	|-AsyncOperationBase<bool>.DecrementReferenceCount
	|
	|-RVA: 0x2CC4E20 Offset: 0x2CC4F21 VA: 0x2CC4E20
	|-AsyncOperationBase<long>.DecrementReferenceCount
	|
	|-RVA: 0x2CC73A0 Offset: 0x2CC74A1 VA: 0x2CC73A0
	|-AsyncOperationBase<object>.DecrementReferenceCount
	|-AsyncOperationBase<GameObject>.DecrementReferenceCount
	|
	|-RVA: 0x2CC9870 Offset: 0x2CC9971 VA: 0x2CC9870
	|-AsyncOperationBase<SceneInstance>.DecrementReferenceCount
	*/

	// RVA: -1 Offset: -1
	internal WaitHandle get_WaitHandle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC2BD0 Offset: 0x2CC2CD1 VA: 0x2CC2BD0
	|-AsyncOperationBase<bool>.get_WaitHandle
	|
	|-RVA: 0x2CC5150 Offset: 0x2CC5251 VA: 0x2CC5150
	|-AsyncOperationBase<long>.get_WaitHandle
	|
	|-RVA: 0x2CC76D0 Offset: 0x2CC77D1 VA: 0x2CC76D0
	|-AsyncOperationBase<object>.get_WaitHandle
	|
	|-RVA: 0x2CC9BA0 Offset: 0x2CC9CA1 VA: 0x2CC9BA0
	|-AsyncOperationBase<SceneInstance>.get_WaitHandle
	*/

	// RVA: -1 Offset: -1
	internal Task<TObject> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC2C70 Offset: 0x2CC2D71 VA: 0x2CC2C70
	|-AsyncOperationBase<bool>.get_Task
	|
	|-RVA: 0x2CC51F0 Offset: 0x2CC52F1 VA: 0x2CC51F0
	|-AsyncOperationBase<long>.get_Task
	|
	|-RVA: 0x2CC7770 Offset: 0x2CC7871 VA: 0x2CC7770
	|-AsyncOperationBase<object>.get_Task
	|
	|-RVA: 0x2CC9C40 Offset: 0x2CC9D41 VA: 0x2CC9C40
	|-AsyncOperationBase<SceneInstance>.get_Task
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private Task<object> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC2EE0 Offset: 0x2CC2FE1 VA: 0x2CC2EE0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|
	|-RVA: 0x2CC79E0 Offset: 0x2CC7AE1 VA: 0x2CC79E0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|
	|-RVA: 0x2CC5460 Offset: 0x2CC5561 VA: 0x2CC5460
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|
	|-RVA: 0x2CC9EC0 Offset: 0x2CC9FC1 VA: 0x2CC9EC0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC3170 Offset: 0x2CC3271 VA: 0x2CC3170
	|-AsyncOperationBase<bool>.ToString
	|
	|-RVA: 0x2CC7C30 Offset: 0x2CC7D31 VA: 0x2CC7C30
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.ToString
	|-AsyncOperationBase<IList<IResourceLocation>>.ToString
	|-AsyncOperationBase<List<string>>.ToString
	|-AsyncOperationBase<List<IResourceLocator>>.ToString
	|-AsyncOperationBase<object>.ToString
	|-AsyncOperationBase<IResourceLocator>.ToString
	|-AsyncOperationBase<GameObject>.ToString
	|
	|-RVA: 0x2CC56F0 Offset: 0x2CC57F1 VA: 0x2CC56F0
	|-AsyncOperationBase<long>.ToString
	|
	|-RVA: 0x2CCA160 Offset: 0x2CCA261 VA: 0x2CCA160
	|-AsyncOperationBase<SceneInstance>.ToString
	*/

	// RVA: -1 Offset: -1
	private void RegisterForDeferredCallbackEvent(bool incrementReferenceCount = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC3310 Offset: 0x2CC3411 VA: 0x2CC3310
	|-AsyncOperationBase<bool>.RegisterForDeferredCallbackEvent
	|
	|-RVA: 0x2CC5890 Offset: 0x2CC5991 VA: 0x2CC5890
	|-AsyncOperationBase<long>.RegisterForDeferredCallbackEvent
	|
	|-RVA: 0x2CC7DA0 Offset: 0x2CC7EA1 VA: 0x2CC7DA0
	|-AsyncOperationBase<object>.RegisterForDeferredCallbackEvent
	|
	|-RVA: 0x2CCA300 Offset: 0x2CCA401 VA: 0x2CCA300
	|-AsyncOperationBase<SceneInstance>.RegisterForDeferredCallbackEvent
	*/

	// RVA: -1 Offset: -1
	internal void add_Completed(Action<AsyncOperationHandle<TObject>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC3380 Offset: 0x2CC3481 VA: 0x2CC3380
	|-AsyncOperationBase<bool>.add_Completed
	|
	|-RVA: 0x2CC5900 Offset: 0x2CC5A01 VA: 0x2CC5900
	|-AsyncOperationBase<long>.add_Completed
	|
	|-RVA: 0x2CC7E10 Offset: 0x2CC7F11 VA: 0x2CC7E10
	|-AsyncOperationBase<object>.add_Completed
	|
	|-RVA: 0x2CCA370 Offset: 0x2CCA471 VA: 0x2CCA370
	|-AsyncOperationBase<SceneInstance>.add_Completed
	*/

	// RVA: -1 Offset: -1
	internal void remove_Completed(Action<AsyncOperationHandle<TObject>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC3420 Offset: 0x2CC3521 VA: 0x2CC3420
	|-AsyncOperationBase<bool>.remove_Completed
	|
	|-RVA: 0x2CC59A0 Offset: 0x2CC5AA1 VA: 0x2CC59A0
	|-AsyncOperationBase<long>.remove_Completed
	|
	|-RVA: 0x2CC7EB0 Offset: 0x2CC7FB1 VA: 0x2CC7EB0
	|-AsyncOperationBase<object>.remove_Completed
	|
	|-RVA: 0x2CCA410 Offset: 0x2CCA511 VA: 0x2CCA410
	|-AsyncOperationBase<SceneInstance>.remove_Completed
	*/

	// RVA: -1 Offset: -1
	internal void add_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC3440 Offset: 0x2CC3541 VA: 0x2CC3440
	|-AsyncOperationBase<bool>.add_Destroyed
	|
	|-RVA: 0x2CC59C0 Offset: 0x2CC5AC1 VA: 0x2CC59C0
	|-AsyncOperationBase<long>.add_Destroyed
	|
	|-RVA: 0x2CC7ED0 Offset: 0x2CC7FD1 VA: 0x2CC7ED0
	|-AsyncOperationBase<object>.add_Destroyed
	|
	|-RVA: 0x2CCA430 Offset: 0x2CCA531 VA: 0x2CCA430
	|-AsyncOperationBase<SceneInstance>.add_Destroyed
	*/

	// RVA: -1 Offset: -1
	internal void remove_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC34D0 Offset: 0x2CC35D1 VA: 0x2CC34D0
	|-AsyncOperationBase<bool>.remove_Destroyed
	|
	|-RVA: 0x2CC5A50 Offset: 0x2CC5B51 VA: 0x2CC5A50
	|-AsyncOperationBase<long>.remove_Destroyed
	|
	|-RVA: 0x2CC7F60 Offset: 0x2CC8061 VA: 0x2CC7F60
	|-AsyncOperationBase<object>.remove_Destroyed
	|
	|-RVA: 0x2CCA4C0 Offset: 0x2CCA5C1 VA: 0x2CCA4C0
	|-AsyncOperationBase<SceneInstance>.remove_Destroyed
	*/

	// RVA: -1 Offset: -1
	internal void add_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC3550 Offset: 0x2CC3651 VA: 0x2CC3550
	|-AsyncOperationBase<bool>.add_CompletedTypeless
	|
	|-RVA: 0x2CC5AD0 Offset: 0x2CC5BD1 VA: 0x2CC5AD0
	|-AsyncOperationBase<long>.add_CompletedTypeless
	|
	|-RVA: 0x2CC7FE0 Offset: 0x2CC80E1 VA: 0x2CC7FE0
	|-AsyncOperationBase<object>.add_CompletedTypeless
	|
	|-RVA: 0x2CCA540 Offset: 0x2CCA641 VA: 0x2CCA540
	|-AsyncOperationBase<SceneInstance>.add_CompletedTypeless
	*/

	// RVA: -1 Offset: -1
	internal void remove_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC3630 Offset: 0x2CC3731 VA: 0x2CC3630
	|-AsyncOperationBase<bool>.remove_CompletedTypeless
	|
	|-RVA: 0x2CC5BB0 Offset: 0x2CC5CB1 VA: 0x2CC5BB0
	|-AsyncOperationBase<long>.remove_CompletedTypeless
	|
	|-RVA: 0x2CC80C0 Offset: 0x2CC81C1 VA: 0x2CC80C0
	|-AsyncOperationBase<object>.remove_CompletedTypeless
	|
	|-RVA: 0x2CCA620 Offset: 0x2CCA721 VA: 0x2CCA620
	|-AsyncOperationBase<SceneInstance>.remove_CompletedTypeless
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationStatus get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC3710 Offset: 0x2CC3811 VA: 0x2CC3710
	|-AsyncOperationBase<bool>.get_Status
	|
	|-RVA: 0x2CC5C90 Offset: 0x2CC5D91 VA: 0x2CC5C90
	|-AsyncOperationBase<long>.get_Status
	|
	|-RVA: 0x2CC81A0 Offset: 0x2CC82A1 VA: 0x2CC81A0
	|-AsyncOperationBase<object>.get_Status
	|
	|-RVA: 0x2CCA700 Offset: 0x2CCA801 VA: 0x2CCA700
	|-AsyncOperationBase<SceneInstance>.get_Status
	*/

	// RVA: -1 Offset: -1
	internal Exception get_OperationException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC3720 Offset: 0x2CC3821 VA: 0x2CC3720
	|-AsyncOperationBase<bool>.get_OperationException
	|
	|-RVA: 0x2CC5CA0 Offset: 0x2CC5DA1 VA: 0x2CC5CA0
	|-AsyncOperationBase<long>.get_OperationException
	|
	|-RVA: 0x2CC81B0 Offset: 0x2CC82B1 VA: 0x2CC81B0
	|-AsyncOperationBase<object>.get_OperationException
	|
	|-RVA: 0x2CCA710 Offset: 0x2CCA811 VA: 0x2CCA710
	|-AsyncOperationBase<SceneInstance>.get_OperationException
	*/

	// RVA: -1 Offset: -1
	private void set_OperationException(Exception value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC3730 Offset: 0x2CC3831 VA: 0x2CC3730
	|-AsyncOperationBase<bool>.set_OperationException
	|
	|-RVA: 0x2CC5CB0 Offset: 0x2CC5DB1 VA: 0x2CC5CB0
	|-AsyncOperationBase<long>.set_OperationException
	|
	|-RVA: 0x2CC81C0 Offset: 0x2CC82C1 VA: 0x2CC81C0
	|-AsyncOperationBase<object>.set_OperationException
	|
	|-RVA: 0x2CCA720 Offset: 0x2CCA821 VA: 0x2CCA720
	|-AsyncOperationBase<SceneInstance>.set_OperationException
	*/

	// RVA: -1 Offset: -1
	internal bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC3900 Offset: 0x2CC3A01 VA: 0x2CC3900
	|-AsyncOperationBase<bool>.MoveNext
	|
	|-RVA: 0x2CC5E80 Offset: 0x2CC5F81 VA: 0x2CC5E80
	|-AsyncOperationBase<long>.MoveNext
	|
	|-RVA: 0x2CC8390 Offset: 0x2CC8491 VA: 0x2CC8390
	|-AsyncOperationBase<object>.MoveNext
	|
	|-RVA: 0x2CCA8F0 Offset: 0x2CCA9F1 VA: 0x2CCA8F0
	|-AsyncOperationBase<SceneInstance>.MoveNext
	*/

	// RVA: -1 Offset: -1
	internal void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC3940 Offset: 0x2CC3A41 VA: 0x2CC3940
	|-AsyncOperationBase<bool>.Reset
	|
	|-RVA: 0x2CC5EC0 Offset: 0x2CC5FC1 VA: 0x2CC5EC0
	|-AsyncOperationBase<long>.Reset
	|
	|-RVA: 0x2CC83D0 Offset: 0x2CC84D1 VA: 0x2CC83D0
	|-AsyncOperationBase<object>.Reset
	|
	|-RVA: 0x2CCA930 Offset: 0x2CCAA31 VA: 0x2CCA930
	|-AsyncOperationBase<SceneInstance>.Reset
	*/

	// RVA: -1 Offset: -1
	internal object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC3950 Offset: 0x2CC3A51 VA: 0x2CC3950
	|-AsyncOperationBase<bool>.get_Current
	|
	|-RVA: 0x2CC5ED0 Offset: 0x2CC5FD1 VA: 0x2CC5ED0
	|-AsyncOperationBase<long>.get_Current
	|
	|-RVA: 0x2CC83E0 Offset: 0x2CC84E1 VA: 0x2CC83E0
	|-AsyncOperationBase<object>.get_Current
	|
	|-RVA: 0x2CCA940 Offset: 0x2CCAA41 VA: 0x2CCA940
	|-AsyncOperationBase<SceneInstance>.get_Current
	*/

	// RVA: -1 Offset: -1
	internal bool get_IsDone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC3960 Offset: 0x2CC3A61 VA: 0x2CC3960
	|-AsyncOperationBase<bool>.get_IsDone
	|
	|-RVA: 0x2CC83F0 Offset: 0x2CC84F1 VA: 0x2CC83F0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.get_IsDone
	|-AsyncOperationBase<object>.get_IsDone
	|-AsyncOperationBase<GameObject>.get_IsDone
	|
	|-RVA: 0x2CC5EE0 Offset: 0x2CC5FE1 VA: 0x2CC5EE0
	|-AsyncOperationBase<long>.get_IsDone
	|
	|-RVA: 0x2CCA950 Offset: 0x2CCAA51 VA: 0x2CCA950
	|-AsyncOperationBase<SceneInstance>.get_IsDone
	*/

	// RVA: -1 Offset: -1
	internal float get_PercentComplete() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC39E0 Offset: 0x2CC3AE1 VA: 0x2CC39E0
	|-AsyncOperationBase<bool>.get_PercentComplete
	|
	|-RVA: 0x2CC5F60 Offset: 0x2CC6061 VA: 0x2CC5F60
	|-AsyncOperationBase<long>.get_PercentComplete
	|
	|-RVA: 0x2CC8470 Offset: 0x2CC8571 VA: 0x2CC8470
	|-AsyncOperationBase<object>.get_PercentComplete
	|
	|-RVA: 0x2CCA9D0 Offset: 0x2CCAAD1 VA: 0x2CCA9D0
	|-AsyncOperationBase<SceneInstance>.get_PercentComplete
	*/

	// RVA: -1 Offset: -1
	internal void InvokeCompletionEvent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC3AD0 Offset: 0x2CC3BD1 VA: 0x2CC3AD0
	|-AsyncOperationBase<bool>.InvokeCompletionEvent
	|
	|-RVA: 0x2CC6050 Offset: 0x2CC6151 VA: 0x2CC6050
	|-AsyncOperationBase<long>.InvokeCompletionEvent
	|
	|-RVA: 0x2CC8560 Offset: 0x2CC8661 VA: 0x2CC8560
	|-AsyncOperationBase<object>.InvokeCompletionEvent
	|
	|-RVA: 0x2CCAAC0 Offset: 0x2CCABC1 VA: 0x2CCAAC0
	|-AsyncOperationBase<SceneInstance>.InvokeCompletionEvent
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> get_Handle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC3B90 Offset: 0x2CC3C91 VA: 0x2CC3B90
	|-AsyncOperationBase<bool>.get_Handle
	|
	|-RVA: 0x2CC8620 Offset: 0x2CC8721 VA: 0x2CC8620
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.get_Handle
	|-AsyncOperationBase<object>.get_Handle
	|
	|-RVA: 0x2CC6110 Offset: 0x2CC6211 VA: 0x2CC6110
	|-AsyncOperationBase<long>.get_Handle
	|
	|-RVA: 0x2CCAB80 Offset: 0x2CCAC81 VA: 0x2CCAB80
	|-AsyncOperationBase<SceneInstance>.get_Handle
	*/

	// RVA: -1 Offset: -1
	private void UpdateCallback(float unscaledDeltaTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC3BF0 Offset: 0x2CC3CF1 VA: 0x2CC3BF0
	|-AsyncOperationBase<bool>.UpdateCallback
	|
	|-RVA: 0x2CC6170 Offset: 0x2CC6271 VA: 0x2CC6170
	|-AsyncOperationBase<long>.UpdateCallback
	|
	|-RVA: 0x2CC8680 Offset: 0x2CC8781 VA: 0x2CC8680
	|-AsyncOperationBase<object>.UpdateCallback
	|
	|-RVA: 0x2CCABE0 Offset: 0x2CCACE1 VA: 0x2CCABE0
	|-AsyncOperationBase<SceneInstance>.UpdateCallback
	*/

	// RVA: -1 Offset: -1
	public void Complete(TObject result, bool success, string errorMsg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC3CD0 Offset: 0x2CC3DD1 VA: 0x2CC3CD0
	|-AsyncOperationBase<bool>.Complete
	|
	|-RVA: 0x2CC8760 Offset: 0x2CC8861 VA: 0x2CC8760
	|-AsyncOperationBase<IList<IResourceLocation>>.Complete
	|-AsyncOperationBase<List<string>>.Complete
	|-AsyncOperationBase<List<IResourceLocator>>.Complete
	|-AsyncOperationBase<object>.Complete
	|-AsyncOperationBase<IResourceLocator>.Complete
	|-AsyncOperationBase<GameObject>.Complete
	|
	|-RVA: 0x2CC6250 Offset: 0x2CC6351 VA: 0x2CC6250
	|-AsyncOperationBase<long>.Complete
	|
	|-RVA: 0x2CCACC0 Offset: 0x2CCADC1 VA: 0x2CCACC0
	|-AsyncOperationBase<SceneInstance>.Complete
	*/

	// RVA: -1 Offset: -1
	public void Complete(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC3D00 Offset: 0x2CC3E01 VA: 0x2CC3D00
	|-AsyncOperationBase<bool>.Complete
	|
	|-RVA: 0x2CC8790 Offset: 0x2CC8891 VA: 0x2CC8790
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.Complete
	|-AsyncOperationBase<object>.Complete
	|
	|-RVA: 0x2CC6280 Offset: 0x2CC6381 VA: 0x2CC6280
	|-AsyncOperationBase<long>.Complete
	|
	|-RVA: 0x2CCACF0 Offset: 0x2CCADF1 VA: 0x2CCACF0
	|-AsyncOperationBase<SceneInstance>.Complete
	*/

	// RVA: -1 Offset: -1
	internal void Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC4130 Offset: 0x2CC4231 VA: 0x2CC4130
	|-AsyncOperationBase<bool>.Start
	|
	|-RVA: 0x2CC66B0 Offset: 0x2CC67B1 VA: 0x2CC66B0
	|-AsyncOperationBase<long>.Start
	|
	|-RVA: 0x2CC8BC0 Offset: 0x2CC8CC1 VA: 0x2CC8BC0
	|-AsyncOperationBase<object>.Start
	|
	|-RVA: 0x2CCB130 Offset: 0x2CCB231 VA: 0x2CCB130
	|-AsyncOperationBase<SceneInstance>.Start
	*/

	// RVA: -1 Offset: -1
	private void InvokeExecute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC4330 Offset: 0x2CC4431 VA: 0x2CC4330
	|-AsyncOperationBase<bool>.InvokeExecute
	|
	|-RVA: 0x2CC68B0 Offset: 0x2CC69B1 VA: 0x2CC68B0
	|-AsyncOperationBase<long>.InvokeExecute
	|
	|-RVA: 0x2CC8DC0 Offset: 0x2CC8EC1 VA: 0x2CC8DC0
	|-AsyncOperationBase<object>.InvokeExecute
	|
	|-RVA: 0x2CCB330 Offset: 0x2CCB431 VA: 0x2CCB330
	|-AsyncOperationBase<SceneInstance>.InvokeExecute
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC43D0 Offset: 0x2CC44D1 VA: 0x2CC43D0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|
	|-RVA: 0x2CC8E60 Offset: 0x2CC8F61 VA: 0x2CC8E60
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|
	|-RVA: 0x2CC6950 Offset: 0x2CC6A51 VA: 0x2CC6950
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|
	|-RVA: 0x2CCB3D0 Offset: 0x2CCB4D1 VA: 0x2CCB3D0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC4400 Offset: 0x2CC4501 VA: 0x2CC4400
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|
	|-RVA: 0x2CC8E90 Offset: 0x2CC8F91 VA: 0x2CC8E90
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|
	|-RVA: 0x2CC6980 Offset: 0x2CC6A81 VA: 0x2CC6980
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|
	|-RVA: 0x2CCB400 Offset: 0x2CCB501 VA: 0x2CCB400
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC4430 Offset: 0x2CC4531 VA: 0x2CC4430
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|
	|-RVA: 0x2CC8EC0 Offset: 0x2CC8FC1 VA: 0x2CC8EC0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|
	|-RVA: 0x2CC69B0 Offset: 0x2CC6AB1 VA: 0x2CC69B0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|
	|-RVA: 0x2CCB430 Offset: 0x2CCB531 VA: 0x2CCB430
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC4460 Offset: 0x2CC4561 VA: 0x2CC4460
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|
	|-RVA: 0x2CC8EF0 Offset: 0x2CC8FF1 VA: 0x2CC8EF0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|
	|-RVA: 0x2CC69E0 Offset: 0x2CC6AE1 VA: 0x2CC69E0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|
	|-RVA: 0x2CCB460 Offset: 0x2CCB561 VA: 0x2CCB460
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC4490 Offset: 0x2CC4591 VA: 0x2CC4490
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|
	|-RVA: 0x2CC8F20 Offset: 0x2CC9021 VA: 0x2CC8F20
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|
	|-RVA: 0x2CC6A10 Offset: 0x2CC6B11 VA: 0x2CC6A10
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|
	|-RVA: 0x2CCB490 Offset: 0x2CCB591 VA: 0x2CCB490
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC44C0 Offset: 0x2CC45C1 VA: 0x2CC44C0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|
	|-RVA: 0x2CC8F50 Offset: 0x2CC9051 VA: 0x2CC8F50
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|
	|-RVA: 0x2CC6A40 Offset: 0x2CC6B41 VA: 0x2CC6A40
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|
	|-RVA: 0x2CCB4C0 Offset: 0x2CCB5C1 VA: 0x2CCB4C0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private float UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC44F0 Offset: 0x2CC45F1 VA: 0x2CC44F0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|
	|-RVA: 0x2CC8F80 Offset: 0x2CC9081 VA: 0x2CC8F80
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|
	|-RVA: 0x2CC6A70 Offset: 0x2CC6B71 VA: 0x2CC6A70
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|
	|-RVA: 0x2CCB4F0 Offset: 0x2CCB5F1 VA: 0x2CCB4F0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private AsyncOperationStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC4520 Offset: 0x2CC4621 VA: 0x2CC4520
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|
	|-RVA: 0x2CC8FB0 Offset: 0x2CC90B1 VA: 0x2CC8FB0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|
	|-RVA: 0x2CC6AA0 Offset: 0x2CC6BA1 VA: 0x2CC6AA0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|
	|-RVA: 0x2CCB520 Offset: 0x2CCB621 VA: 0x2CCB520
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private Exception UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC4550 Offset: 0x2CC4651 VA: 0x2CC4550
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|
	|-RVA: 0x2CC8FE0 Offset: 0x2CC90E1 VA: 0x2CC8FE0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|
	|-RVA: 0x2CC6AD0 Offset: 0x2CC6BD1 VA: 0x2CC6AD0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|
	|-RVA: 0x2CCB550 Offset: 0x2CCB651 VA: 0x2CCB550
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC4580 Offset: 0x2CC4681 VA: 0x2CC4580
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|
	|-RVA: 0x2CC9010 Offset: 0x2CC9111 VA: 0x2CC9010
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|
	|-RVA: 0x2CC6B00 Offset: 0x2CC6C01 VA: 0x2CC6B00
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|
	|-RVA: 0x2CCB580 Offset: 0x2CCB681 VA: 0x2CCB580
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private AsyncOperationHandle UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC45B0 Offset: 0x2CC46B1 VA: 0x2CC45B0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|
	|-RVA: 0x2CC9040 Offset: 0x2CC9141 VA: 0x2CC9040
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|
	|-RVA: 0x2CC6B30 Offset: 0x2CC6C31 VA: 0x2CC6B30
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|
	|-RVA: 0x2CCB5B0 Offset: 0x2CCB6B1 VA: 0x2CCB5B0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy(Action<IAsyncOperation> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC4640 Offset: 0x2CC4741 VA: 0x2CC4640
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|
	|-RVA: 0x2CC90D0 Offset: 0x2CC91D1 VA: 0x2CC90D0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|
	|-RVA: 0x2CC6BC0 Offset: 0x2CC6CC1 VA: 0x2CC6BC0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|
	|-RVA: 0x2CCB640 Offset: 0x2CCB741 VA: 0x2CCB640
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private string UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC4670 Offset: 0x2CC4771 VA: 0x2CC4670
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|
	|-RVA: 0x2CC9100 Offset: 0x2CC9201 VA: 0x2CC9100
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|
	|-RVA: 0x2CC6BF0 Offset: 0x2CC6CF1 VA: 0x2CC6BF0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|
	|-RVA: 0x2CCB670 Offset: 0x2CCB771 VA: 0x2CCB670
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private object UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC4690 Offset: 0x2CC4791 VA: 0x2CC4690
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|
	|-RVA: 0x2CC9120 Offset: 0x2CC9221 VA: 0x2CC9120
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|
	|-RVA: 0x2CC6C10 Offset: 0x2CC6D11 VA: 0x2CC6C10
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|
	|-RVA: 0x2CCB690 Offset: 0x2CCB791 VA: 0x2CCB690
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private Type UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC4700 Offset: 0x2CC4801 VA: 0x2CC4700
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|
	|-RVA: 0x2CC9150 Offset: 0x2CC9251 VA: 0x2CC9150
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|
	|-RVA: 0x2CC6C80 Offset: 0x2CC6D81 VA: 0x2CC6C80
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|
	|-RVA: 0x2CCB700 Offset: 0x2CCB801 VA: 0x2CCB700
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC4780 Offset: 0x2CC4881 VA: 0x2CC4780
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|
	|-RVA: 0x2CC91D0 Offset: 0x2CC92D1 VA: 0x2CC91D0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|
	|-RVA: 0x2CC6D00 Offset: 0x2CC6E01 VA: 0x2CC6D00
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|
	|-RVA: 0x2CCB780 Offset: 0x2CCB881 VA: 0x2CCB780
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC47A0 Offset: 0x2CC48A1 VA: 0x2CC47A0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|
	|-RVA: 0x2CC91F0 Offset: 0x2CC92F1 VA: 0x2CC91F0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|
	|-RVA: 0x2CC6D20 Offset: 0x2CC6E21 VA: 0x2CC6D20
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|
	|-RVA: 0x2CCB7A0 Offset: 0x2CCB8A1 VA: 0x2CCB7A0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC47D0 Offset: 0x2CC48D1 VA: 0x2CC47D0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|
	|-RVA: 0x2CC9220 Offset: 0x2CC9321 VA: 0x2CC9220
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|
	|-RVA: 0x2CC6D50 Offset: 0x2CC6E51 VA: 0x2CC6D50
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|
	|-RVA: 0x2CCB7D0 Offset: 0x2CCB8D1 VA: 0x2CCB7D0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC4800 Offset: 0x2CC4901 VA: 0x2CC4800
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|
	|-RVA: 0x2CC9250 Offset: 0x2CC9351 VA: 0x2CC9250
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|
	|-RVA: 0x2CC6D80 Offset: 0x2CC6E81 VA: 0x2CC6D80
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|
	|-RVA: 0x2CCB800 Offset: 0x2CCB901 VA: 0x2CCB800
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC4830 Offset: 0x2CC4931 VA: 0x2CC4830
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|
	|-RVA: 0x2CC9280 Offset: 0x2CC9381 VA: 0x2CC9280
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|
	|-RVA: 0x2CC6DB0 Offset: 0x2CC6EB1 VA: 0x2CC6DB0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|
	|-RVA: 0x2CCB830 Offset: 0x2CCB931 VA: 0x2CCB830
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	*/

	// RVA: -1 Offset: -1 Slot: 32
	internal virtual void ReleaseDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC4890 Offset: 0x2CC4991 VA: 0x2CC4890
	|-AsyncOperationBase<bool>.ReleaseDependencies
	|
	|-RVA: 0x2CC92E0 Offset: 0x2CC93E1 VA: 0x2CC92E0
	|-AsyncOperationBase<IList<IResourceLocation>>.ReleaseDependencies
	|-AsyncOperationBase<List<string>>.ReleaseDependencies
	|-AsyncOperationBase<List<IResourceLocator>>.ReleaseDependencies
	|-AsyncOperationBase<object>.ReleaseDependencies
	|-AsyncOperationBase<IResourceLocator>.ReleaseDependencies
	|-AsyncOperationBase<GameObject>.ReleaseDependencies
	|
	|-RVA: 0x2CC6E10 Offset: 0x2CC6F11 VA: 0x2CC6E10
	|-AsyncOperationBase<long>.ReleaseDependencies
	|
	|-RVA: 0x2CCB890 Offset: 0x2CCB991 VA: 0x2CCB890
	|-AsyncOperationBase<SceneInstance>.ReleaseDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private DownloadStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC48A0 Offset: 0x2CC49A1 VA: 0x2CC48A0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|
	|-RVA: 0x2CC92F0 Offset: 0x2CC93F1 VA: 0x2CC92F0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|
	|-RVA: 0x2CC6E20 Offset: 0x2CC6F21 VA: 0x2CC6E20
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|
	|-RVA: 0x2CCB8A0 Offset: 0x2CCB9A1 VA: 0x2CCB8A0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1 Slot: 33
	internal virtual DownloadStatus GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC48F0 Offset: 0x2CC49F1 VA: 0x2CC48F0
	|-AsyncOperationBase<bool>.GetDownloadStatus
	|
	|-RVA: 0x2CC9340 Offset: 0x2CC9441 VA: 0x2CC9340
	|-AsyncOperationBase<IList<IResourceLocation>>.GetDownloadStatus
	|-AsyncOperationBase<List<string>>.GetDownloadStatus
	|-AsyncOperationBase<List<IResourceLocator>>.GetDownloadStatus
	|-AsyncOperationBase<object>.GetDownloadStatus
	|-AsyncOperationBase<IResourceLocator>.GetDownloadStatus
	|
	|-RVA: 0x2CC6E70 Offset: 0x2CC6F71 VA: 0x2CC6E70
	|-AsyncOperationBase<long>.GetDownloadStatus
	|
	|-RVA: 0x2CCB8F0 Offset: 0x2CCB9F1 VA: 0x2CCB8F0
	|-AsyncOperationBase<SceneInstance>.GetDownloadStatus
	*/

	[CompilerGeneratedAttribute] // RVA: 0x12A370 Offset: 0x12A471 VA: 0x12A370
	// RVA: -1 Offset: -1
	private void <.ctor>b__34_0(AsyncOperationHandle o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC49D0 Offset: 0x2CC4AD1 VA: 0x2CC49D0
	|-AsyncOperationBase<bool>.<.ctor>b__34_0
	|
	|-RVA: 0x2CC6F50 Offset: 0x2CC7051 VA: 0x2CC6F50
	|-AsyncOperationBase<long>.<.ctor>b__34_0
	|
	|-RVA: 0x2CC9420 Offset: 0x2CC9521 VA: 0x2CC9420
	|-AsyncOperationBase<object>.<.ctor>b__34_0
	|
	|-RVA: 0x2CCB9D0 Offset: 0x2CCBAD1 VA: 0x2CCB9D0
	|-AsyncOperationBase<SceneInstance>.<.ctor>b__34_0
	*/
}

