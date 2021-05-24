public struct TaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 1264
{
	// Fields
	private readonly Task<TResult> m_task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35C350 Offset: 0x35C451 VA: 0x35C350
	|-TaskAwaiter<bool>..ctor
	|
	|-RVA: 0x35C460 Offset: 0x35C561 VA: 0x35C460
	|-TaskAwaiter<int>..ctor
	|
	|-RVA: 0x35C570 Offset: 0x35C671 VA: 0x35C570
	|-TaskAwaiter<long>..ctor
	|
	|-RVA: 0x35C680 Offset: 0x35C781 VA: 0x35C680
	|-TaskAwaiter<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x35C7B0 Offset: 0x35C8B1 VA: 0x35C7B0
	|-TaskAwaiter<Nullable<int>>..ctor
	|
	|-RVA: 0x35C8C0 Offset: 0x35C9C1 VA: 0x35C8C0
	|-TaskAwaiter<object>..ctor
	|
	|-RVA: 0x35C9D0 Offset: 0x35CAD1 VA: 0x35C9D0
	|-TaskAwaiter<VoidTaskResult>..ctor
	|
	|-RVA: 0x35CAD0 Offset: 0x35CBD1 VA: 0x35CAD0
	|-TaskAwaiter<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35C360 Offset: 0x35C461 VA: 0x35C360
	|-TaskAwaiter<bool>.get_IsCompleted
	|
	|-RVA: 0x35C470 Offset: 0x35C571 VA: 0x35C470
	|-TaskAwaiter<int>.get_IsCompleted
	|
	|-RVA: 0x35C580 Offset: 0x35C681 VA: 0x35C580
	|-TaskAwaiter<long>.get_IsCompleted
	|
	|-RVA: 0x35C690 Offset: 0x35C791 VA: 0x35C690
	|-TaskAwaiter<Nullable<ReadOnlySequence<byte>>>.get_IsCompleted
	|
	|-RVA: 0x35C7C0 Offset: 0x35C8C1 VA: 0x35C7C0
	|-TaskAwaiter<Nullable<int>>.get_IsCompleted
	|
	|-RVA: 0x35C8D0 Offset: 0x35C9D1 VA: 0x35C8D0
	|-TaskAwaiter<object>.get_IsCompleted
	|
	|-RVA: 0x35C9E0 Offset: 0x35CAE1 VA: 0x35C9E0
	|-TaskAwaiter<VoidTaskResult>.get_IsCompleted
	|
	|-RVA: 0x35CAE0 Offset: 0x35CBE1 VA: 0x35CAE0
	|-TaskAwaiter<SceneInstance>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35C380 Offset: 0x35C481 VA: 0x35C380
	|-TaskAwaiter<bool>.OnCompleted
	|
	|-RVA: 0x35C490 Offset: 0x35C591 VA: 0x35C490
	|-TaskAwaiter<int>.OnCompleted
	|
	|-RVA: 0x35C5A0 Offset: 0x35C6A1 VA: 0x35C5A0
	|-TaskAwaiter<long>.OnCompleted
	|
	|-RVA: 0x35C6B0 Offset: 0x35C7B1 VA: 0x35C6B0
	|-TaskAwaiter<Nullable<ReadOnlySequence<byte>>>.OnCompleted
	|
	|-RVA: 0x35C7E0 Offset: 0x35C8E1 VA: 0x35C7E0
	|-TaskAwaiter<Nullable<int>>.OnCompleted
	|
	|-RVA: 0x35C8F0 Offset: 0x35C9F1 VA: 0x35C8F0
	|-TaskAwaiter<object>.OnCompleted
	|
	|-RVA: 0x35CA00 Offset: 0x35CB01 VA: 0x35CA00
	|-TaskAwaiter<VoidTaskResult>.OnCompleted
	|
	|-RVA: 0x35CB00 Offset: 0x35CC01 VA: 0x35CB00
	|-TaskAwaiter<SceneInstance>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35C3A0 Offset: 0x35C4A1 VA: 0x35C3A0
	|-TaskAwaiter<bool>.UnsafeOnCompleted
	|
	|-RVA: 0x35C4B0 Offset: 0x35C5B1 VA: 0x35C4B0
	|-TaskAwaiter<int>.UnsafeOnCompleted
	|
	|-RVA: 0x35C5C0 Offset: 0x35C6C1 VA: 0x35C5C0
	|-TaskAwaiter<long>.UnsafeOnCompleted
	|
	|-RVA: 0x35C6D0 Offset: 0x35C7D1 VA: 0x35C6D0
	|-TaskAwaiter<Nullable<ReadOnlySequence<byte>>>.UnsafeOnCompleted
	|
	|-RVA: 0x35C800 Offset: 0x35C901 VA: 0x35C800
	|-TaskAwaiter<Nullable<int>>.UnsafeOnCompleted
	|
	|-RVA: 0x35C910 Offset: 0x35CA11 VA: 0x35C910
	|-TaskAwaiter<object>.UnsafeOnCompleted
	|
	|-RVA: 0x35CA20 Offset: 0x35CB21 VA: 0x35CA20
	|-TaskAwaiter<VoidTaskResult>.UnsafeOnCompleted
	|
	|-RVA: 0x35CB20 Offset: 0x35CC21 VA: 0x35CB20
	|-TaskAwaiter<SceneInstance>.UnsafeOnCompleted
	*/

	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35C3C0 Offset: 0x35C4C1 VA: 0x35C3C0
	|-TaskAwaiter<bool>.GetResult
	|
	|-RVA: 0x35C4D0 Offset: 0x35C5D1 VA: 0x35C4D0
	|-TaskAwaiter<int>.GetResult
	|
	|-RVA: 0x35C5E0 Offset: 0x35C6E1 VA: 0x35C5E0
	|-TaskAwaiter<long>.GetResult
	|
	|-RVA: 0x35C6F0 Offset: 0x35C7F1 VA: 0x35C6F0
	|-TaskAwaiter<Nullable<ReadOnlySequence<byte>>>.GetResult
	|
	|-RVA: 0x35C820 Offset: 0x35C921 VA: 0x35C820
	|-TaskAwaiter<Nullable<int>>.GetResult
	|
	|-RVA: 0x35C930 Offset: 0x35CA31 VA: 0x35C930
	|-TaskAwaiter<object>.GetResult
	|
	|-RVA: 0x35CA40 Offset: 0x35CB41 VA: 0x35CA40
	|-TaskAwaiter<VoidTaskResult>.GetResult
	|
	|-RVA: 0x35CB40 Offset: 0x35CC41 VA: 0x35CB40
	|-TaskAwaiter<SceneInstance>.GetResult
	*/
}

