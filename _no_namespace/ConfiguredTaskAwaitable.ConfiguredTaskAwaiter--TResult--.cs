public struct ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 1268
{
	// Fields
	private readonly Task<TResult> m_task; // 0x0
	private readonly bool m_continueOnCapturedContext; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3698A0 Offset: 0x3699A1 VA: 0x3698A0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>..ctor
	|
	|-RVA: 0x3699E0 Offset: 0x369AE1 VA: 0x3699E0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>..ctor
	|
	|-RVA: 0x369B20 Offset: 0x369C21 VA: 0x369B20
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<long>..ctor
	|
	|-RVA: 0x369C60 Offset: 0x369D61 VA: 0x369C60
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x369DC0 Offset: 0x369EC1 VA: 0x369DC0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>..ctor
	|
	|-RVA: 0x369F00 Offset: 0x36A001 VA: 0x369F00
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>..ctor
	|
	|-RVA: 0x36A040 Offset: 0x36A141 VA: 0x36A040
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>..ctor
	|
	|-RVA: 0x35B8D0 Offset: 0x35B9D1 VA: 0x35B8D0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x369F40 Offset: 0x36A041 VA: 0x369F40
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task>.get_IsCompleted
	|
	|-RVA: 0x3698E0 Offset: 0x3699E1 VA: 0x3698E0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.get_IsCompleted
	|
	|-RVA: 0x369A20 Offset: 0x369B21 VA: 0x369A20
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.get_IsCompleted
	|
	|-RVA: 0x369B60 Offset: 0x369C61 VA: 0x369B60
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<long>.get_IsCompleted
	|
	|-RVA: 0x369CA0 Offset: 0x369DA1 VA: 0x369CA0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ReadOnlySequence<byte>>>.get_IsCompleted
	|
	|-RVA: 0x369E00 Offset: 0x369F01 VA: 0x369E00
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.get_IsCompleted
	|
	|-RVA: 0x36A080 Offset: 0x36A181 VA: 0x36A080
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.get_IsCompleted
	|
	|-RVA: 0x35B910 Offset: 0x35BA11 VA: 0x35B910
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SceneInstance>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x369900 Offset: 0x369A01 VA: 0x369900
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.OnCompleted
	|
	|-RVA: 0x369A40 Offset: 0x369B41 VA: 0x369A40
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.OnCompleted
	|
	|-RVA: 0x369B80 Offset: 0x369C81 VA: 0x369B80
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<long>.OnCompleted
	|
	|-RVA: 0x369CC0 Offset: 0x369DC1 VA: 0x369CC0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ReadOnlySequence<byte>>>.OnCompleted
	|
	|-RVA: 0x369E20 Offset: 0x369F21 VA: 0x369E20
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.OnCompleted
	|
	|-RVA: 0x369F60 Offset: 0x36A061 VA: 0x369F60
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.OnCompleted
	|
	|-RVA: 0x36A0A0 Offset: 0x36A1A1 VA: 0x36A0A0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.OnCompleted
	|
	|-RVA: 0x35B930 Offset: 0x35BA31 VA: 0x35B930
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SceneInstance>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x369920 Offset: 0x369A21 VA: 0x369920
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.UnsafeOnCompleted
	|
	|-RVA: 0x369A60 Offset: 0x369B61 VA: 0x369A60
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.UnsafeOnCompleted
	|
	|-RVA: 0x369BA0 Offset: 0x369CA1 VA: 0x369BA0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<long>.UnsafeOnCompleted
	|
	|-RVA: 0x369CE0 Offset: 0x369DE1 VA: 0x369CE0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ReadOnlySequence<byte>>>.UnsafeOnCompleted
	|
	|-RVA: 0x369E40 Offset: 0x369F41 VA: 0x369E40
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.UnsafeOnCompleted
	|
	|-RVA: 0x369F80 Offset: 0x36A081 VA: 0x369F80
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.UnsafeOnCompleted
	|
	|-RVA: 0x36A0C0 Offset: 0x36A1C1 VA: 0x36A0C0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.UnsafeOnCompleted
	|
	|-RVA: 0x35B950 Offset: 0x35BA51 VA: 0x35B950
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SceneInstance>.UnsafeOnCompleted
	*/

	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x369FA0 Offset: 0x36A0A1 VA: 0x369FA0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task>.GetResult
	|
	|-RVA: 0x369E60 Offset: 0x369F61 VA: 0x369E60
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.GetResult
	|
	|-RVA: 0x369940 Offset: 0x369A41 VA: 0x369940
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.GetResult
	|
	|-RVA: 0x369A80 Offset: 0x369B81 VA: 0x369A80
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.GetResult
	|
	|-RVA: 0x369BC0 Offset: 0x369CC1 VA: 0x369BC0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<long>.GetResult
	|
	|-RVA: 0x369D00 Offset: 0x369E01 VA: 0x369D00
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ReadOnlySequence<byte>>>.GetResult
	|
	|-RVA: 0x36A0E0 Offset: 0x36A1E1 VA: 0x36A0E0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.GetResult
	|
	|-RVA: 0x35B970 Offset: 0x35BA71 VA: 0x35B970
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SceneInstance>.GetResult
	*/
}

