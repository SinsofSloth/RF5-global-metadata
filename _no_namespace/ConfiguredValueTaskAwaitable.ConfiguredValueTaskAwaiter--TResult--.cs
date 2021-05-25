[IsReadOnlyAttribute] // RVA: 0x129600 Offset: 0x129701 VA: 0x129600
public struct ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 4441
{
	// Fields
	private readonly ValueTask<TResult> _value; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ValueTask<TResult> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35BF00 Offset: 0x35C001 VA: 0x35BF00
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>..ctor
	|
	|-RVA: 0x35BFB0 Offset: 0x35C0B1 VA: 0x35BFB0
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x35C0B0 Offset: 0x35C1B1 VA: 0x35C0B0
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35BF10 Offset: 0x35C011 VA: 0x35BF10
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>.get_IsCompleted
	|
	|-RVA: 0x35BFE0 Offset: 0x35C0E1 VA: 0x35BFE0
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<Nullable<ReadOnlySequence<byte>>>.get_IsCompleted
	|
	|-RVA: 0x35C0D0 Offset: 0x35C1D1 VA: 0x35C0D0
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<object>.get_IsCompleted
	*/

	[StackTraceHiddenAttribute] // RVA: 0x1296C0 Offset: 0x1297C1 VA: 0x1296C0
	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35BF50 Offset: 0x35C051 VA: 0x35BF50
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>.GetResult
	|
	|-RVA: 0x35C020 Offset: 0x35C121 VA: 0x35C020
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<Nullable<ReadOnlySequence<byte>>>.GetResult
	|
	|-RVA: 0x35C110 Offset: 0x35C211 VA: 0x35C110
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35BF90 Offset: 0x35C091 VA: 0x35BF90
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>.OnCompleted
	|
	|-RVA: 0x35C090 Offset: 0x35C191 VA: 0x35C090
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<Nullable<ReadOnlySequence<byte>>>.OnCompleted
	|
	|-RVA: 0x35C150 Offset: 0x35C251 VA: 0x35C150
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35BFA0 Offset: 0x35C0A1 VA: 0x35BFA0
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>.UnsafeOnCompleted
	|
	|-RVA: 0x35C0A0 Offset: 0x35C1A1 VA: 0x35C0A0
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<Nullable<ReadOnlySequence<byte>>>.UnsafeOnCompleted
	|
	|-RVA: 0x35C160 Offset: 0x35C261 VA: 0x35C160
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<object>.UnsafeOnCompleted
	*/
}

