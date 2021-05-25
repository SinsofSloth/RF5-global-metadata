internal interface IAsyncOperation // TypeDefIndex: 4510
{
	// Properties
	public abstract Type ResultType { get; }
	public abstract int Version { get; }
	public abstract string DebugName { get; }
	public abstract int ReferenceCount { get; }
	public abstract float PercentComplete { get; }
	public abstract AsyncOperationStatus Status { get; }
	public abstract Exception OperationException { get; }
	public abstract bool IsDone { get; }
	public abstract Action<IAsyncOperation> OnDestroy { set; }
	public abstract bool IsRunning { get; }
	public abstract Task<object> Task { get; }
	public abstract AsyncOperationHandle Handle { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetResultAsObject() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Type get_ResultType() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_Version() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_DebugName() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void DecrementReferenceCount() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void IncrementReferenceCount() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_ReferenceCount() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract float get_PercentComplete() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract DownloadStatus GetDownloadStatus(HashSet<object> visited) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract AsyncOperationStatus get_Status() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Exception get_OperationException() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool get_IsDone() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void set_OnDestroy(Action<IAsyncOperation> value) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void GetDependencies(List<AsyncOperationHandle> deps) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool get_IsRunning() { }

	[CompilerGeneratedAttribute] // RVA: 0x12A2F0 Offset: 0x12A3F1 VA: 0x12A2F0
	// RVA: -1 Offset: -1 Slot: 15
	public abstract void add_CompletedTypeless(Action<AsyncOperationHandle> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x12A300 Offset: 0x12A401 VA: 0x12A300
	// RVA: -1 Offset: -1 Slot: 16
	public abstract void remove_CompletedTypeless(Action<AsyncOperationHandle> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x12A310 Offset: 0x12A411 VA: 0x12A310
	// RVA: -1 Offset: -1 Slot: 17
	public abstract void add_Destroyed(Action<AsyncOperationHandle> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x12A320 Offset: 0x12A421 VA: 0x12A320
	// RVA: -1 Offset: -1 Slot: 18
	public abstract void remove_Destroyed(Action<AsyncOperationHandle> value) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void InvokeCompletionEvent() { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract Task<object> get_Task() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks) { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract AsyncOperationHandle get_Handle() { }
}

